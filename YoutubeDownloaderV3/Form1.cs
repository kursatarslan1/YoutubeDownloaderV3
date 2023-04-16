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
            videoDgv.RowTemplate.Height = 200; // set default row height 200, it's for doesn't look small images when search
            changeLocation.Visible = false;
            mp3Cb.Checked = true;
            if (Properties.Settings.Default.mediaPath != "") // add the location to the textbox if there is a location saved in the properties.
            {
                locationTxt.Text = Properties.Settings.Default.mediaPath;
            }
        }

        void downloadSucces() // Download Success
        {
            progressBar1.Value = 100; // Hard-coding not necessary. For looking good.
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

        void downloadFailed() // Download Failed
        {
            progressBar1.Value = 100; // Hard-coding not necessary. For looking good.
            progressBar1.ForeColor = Color.Red;
            lblStatus.Text = "İndirme Başarısız.";
            downloadingNow = false;
        }

        void downloading() // Downlading
        {
            progressBar1.Value = progressBarValue + 20; // Hard-coding not necessary. For looking good.
            lblStatus.Text = "İndirme başladı";
            listCounter += 1; // Add music count 
            lblInfo.Text = mediaList[listCounter]; // Works in the order of the media to be downloaded
            downloadingNow = true;
        }

        bool mp3 = true;
        int progressBarValue = 10;
        int counter = 0;
        int listCounter = 0;
        List<string> mediaList = new List<string>(); // When it searches, it transfers the search results here.
        bool check = true; // Since the default title value is 3 dots, it is a one-time check so that 3 dots are not added to the list when the download button is pressed.
        bool downloadingNow;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]                                          //
        private extern static void ReleaseCapture();                                                      //  This code block is written to assign the added panel 
                                                                                                          //  to act as a topbar and to be dragged with the form 
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]                                             //  has no borders.
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);     //

        private void panelTitleBar_MouseDown_1(object sender, MouseEventArgs e)                           // 
        {                                                                                                 //
            ReleaseCapture();                                                                             //  Mouse movement is captured and location change is provided with response.
            SendMessage(this.Handle, 0x112, 0xf012, 0);                                                   //
        }                                                                                                 //

        private void btnExit_Click(object sender, EventArgs e)
        {
            if(downloadingNow == true) // Show messagebox if there is any downloaded media to make sure the user wants to close the program.
            {
                DialogResult result = MessageBox.Show("İndirme devam ediyor çıkmak istiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(result == DialogResult.Yes)
                {
                    Application.Exit(); // Exit anyway
                }
            }
            else
            {
                Application.Exit(); // Exit if there is no media to download.
            }
        }

        private void btnMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnSearch_Click(object sender, EventArgs e)  // Found search results and add list
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
            videoBindingSource.DataSource = list; // datagridview 
            videoDgv.CurrentCell = null;
        }
        void GetMedia()  // Media Informations
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
            counter += 1; // Downloading media counter
            lblQueu.Text = "Sırada olan şarkı sayısı: " + counter.ToString(); // Queu label
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
                    // Downloading part
                    var yt = YouTube.Default;
                    var media = await yt.GetVideoAsync(mediaLinkTxt.Text);
                    progressBar1.Value += progressBarValue;
                    File.WriteAllBytes(locationTxt.Text + @"\" + media.FullName, await media.GetBytesAsync());
                    progressBar1.Value += progressBarValue;

                    var inputfile = new MediaToolkit.Model.MediaFile { Filename = locationTxt.Text + @"\" + media.FullName };
                    var outputfile = new MediaToolkit.Model.MediaFile { Filename = $"{locationTxt.Text + @"\" + media.FullName}.mp3" };
                    // Downloading part
                    progressBar1.Value += progressBarValue;

                    using (var eng = new Engine())
                    {
                        eng.GetMetadata(inputfile);
                        eng.Convert(inputfile, outputfile);
                    }
                    progressBar1.Value += progressBarValue + 10;

                    // Program downloads mp3 and mp4 but it deletes the one we did not choose after the download is complete.
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
                catch (UriFormatException) // Link Error
                {
                    MessageBox.Show("Hatalı link girişi.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                }
                catch (Exception ex) // Unexpected Error
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
            if(videoDgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null) // Add link to mediaLinkTxt when click on the link.
            {
                mediaLinkTxt.Text = videoDgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            }
        }
    }
}
