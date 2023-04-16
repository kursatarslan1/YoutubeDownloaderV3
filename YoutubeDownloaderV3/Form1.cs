using MediaToolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideoLibrary;
using YoutubeSearch;

namespace YoutubeDownloaderV3
{
    public partial class Form1 : Form
    {
        private Button currentButton;
        private Form activeForm;
        public Form1()
        {
            InitializeComponent();
            videoDgv.RowTemplate.Height = 200;
            changeLocation.Visible = false;
            mp3Cb.Checked = true;
            if (Properties.Settings.Default.mediaPath != "")
            {
                locationTxt.Text = Properties.Settings.Default.mediaPath;
            }
        }

        void downloadSucces()
        {
            progressBar1.Value = 100;
            lblStatus.Text = "İndirme Başarılı.";
            listCounter = 0;
            if (mp3Cb.Enabled == false)
            {
                mp3Cb.Enabled = true;
            }
            if (mp4Cb.Enabled == false)
            {
                mp4Cb.Enabled = true;
            }
            downloadingNow = false;
        }

        void downloadFailed()
        {
            progressBar1.Value = 100;
            progressBar1.ForeColor = Color.Red;
            lblStatus.Text = "İndirme Başarısız.";
            downloadingNow = false;
        }

        void downloading()
        {
            progressBar1.Value = progressBarValue + 20;
            lblStatus.Text = "İndirme başladı";
            listCounter += 1;
            lblInfo.Text = mediaList[listCounter];
            downloadingNow = true;
        }

        bool mp3 = true;
        int progressBarValue = 10;
        int counter = 0;
        int listCounter = 0;
        List<string> mediaList = new List<string>();
        bool check = true;
        bool downloadingNow;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if(downloadingNow == true)
            {
                DialogResult result = MessageBox.Show("İndirme devam ediyor çıkmak istiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(result == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
            else
            {
                Application.Exit();
            }
        }

        private void btnMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            VideoSearch items = new VideoSearch();
            List<Video> list = new List<Video>();

            foreach (var item in items.SearchQuery(searchBoxTxt.Text, 1))
            {
                Video video = new Video
                {
                    Title = item.Title,
                    Author = item.Author,
                    Url = item.Url,
                };
                byte[] imageBytes = new WebClient().DownloadData(item.Thumbnail);
                using (MemoryStream ms = new MemoryStream(imageBytes))
                {
                    video.Thumbnail = Image.FromStream(ms);
                }
                list.Add(video);

            }
            videoBindingSource.DataSource = list;
            videoDgv.CurrentCell = null;
        }
        void GetMedia()
        {
            WebRequest req = WebRequest.Create(mediaLinkTxt.Text);
            WebResponse res = req.GetResponse();
            StreamReader sr = new StreamReader(res.GetResponseStream());
            string inf = sr.ReadToEnd();
            int strt = inf.IndexOf("<title>") + 7;
            int stp = inf.Substring(strt).IndexOf("</title>");
            string gelenbilgi = inf.Substring(strt, stp);
            if (check == true)
            {
                lblInfo.Text = gelenbilgi;
                check = false;
            }
            mediaList.Add(gelenbilgi);
            downladedMedia.Items.Add(gelenbilgi);
        }

        private async void mediaDownlad_Click(object sender, EventArgs e)
        {
            if (mp3Cb.Checked == true)
            {
                mp4Cb.Enabled = false;
            }
            else if (mp4Cb.Checked == true)
            {
                mp3Cb.Checked = false;
            }
            counter += 1;
            lblQueu.Text = "Sırada olan şarkı sayısı: " + counter.ToString();
            progressBar1.Value = 0;
            if (mediaLinkTxt.Text == "" || locationTxt.Text == "")
            {
                MessageBox.Show("Lütfen boş bırakmayın.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    downloadingNow = true;
                    GetMedia();
                    progressBar1.Value += progressBarValue;
                    lblStatus.Text = "İndirme başladı.";
                    var yt = YouTube.Default;
                    var media = await yt.GetVideoAsync(mediaLinkTxt.Text);
                    progressBar1.Value += progressBarValue;
                    File.WriteAllBytes(locationTxt.Text + @"\" + media.FullName, await media.GetBytesAsync());
                    progressBar1.Value += progressBarValue;

                    var inputfile = new MediaToolkit.Model.MediaFile { Filename = locationTxt.Text + @"\" + media.FullName };
                    var outputfile = new MediaToolkit.Model.MediaFile { Filename = $"{locationTxt.Text + @"\" + media.FullName}.mp3" };
                    progressBar1.Value += progressBarValue;


                    using (var eng = new Engine())
                    {
                        eng.GetMetadata(inputfile);
                        eng.Convert(inputfile, outputfile);
                    }
                    progressBar1.Value += progressBarValue + 10;

                    if (mp3 == true)
                    {
                        File.Delete(locationTxt.Text + @"\" + media.FullName);
                    }
                    else
                    {
                        File.Delete($"{locationTxt.Text + @"\" + media.FullName}.mp3");
                    }
                    progressBar1.Value += progressBarValue;

                    progressBar1.Value = 0;
                    counter -= 1;
                    if (counter != 0)
                    {
                        downloading();
                    }
                    else
                    {
                        downloadSucces();
                    }


                    lblQueu.Text = "Sırada olan şarkı sayısı: " + counter.ToString();
                }
                catch (UriFormatException)
                {
                    MessageBox.Show("Hatalı link girişi.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "HATA", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    downloadFailed();
                }
            }
        }

        private void mp3Cb_CheckedChanged(object sender, EventArgs e)
        {
            mp3 = true;
        }

        private void mp4Cb_CheckedChanged(object sender, EventArgs e)
        {
            mp3 = false;
        }
        void SetLocation()
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog() { Description = "Nereye İndirmek İstiyorsun ?" })
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    locationTxt.Text = fbd.SelectedPath;
                    locationTxt.Enabled = false;
                    changeLocation.Visible = true;
                }
            }
            Properties.Settings.Default.mediaPath = locationTxt.Text;
            Properties.Settings.Default.Save();
        }

        private void locationTxt_Click(object sender, EventArgs e)
        {
            SetLocation();
        }

        private void changeLocation_Click(object sender, EventArgs e)
        {
            SetLocation();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (locationTxt.Text != "")
            {
                locationTxt.Enabled = false;
                changeLocation.Visible = true;
            }
        }

        private void videoDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(videoDgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                mediaLinkTxt.Text = videoDgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            }
        }
    }
}
