using MediaToolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideoLibrary;
using YoutubeSearch;

namespace YoutubeDownloaderV3.Forms
{
    public partial class GetVideoForms : Form
    {
        public GetVideoForms()
        {
            InitializeComponent();
            videoDgv.RowTemplate.Height = 200;
            changeLocation.Visible = false;
            checkBox1.Checked = true;
            if (Properties.Settings.Default.mediaPath != "")
            {
                locationTxt.Text = Properties.Settings.Default.mediaPath;
            }
        }
        Boolean mp3 = true;
        int progressBarValue = 10;
        int counter = 0;
        int listCounter = 0;
        List<string> mediaList = new List<string>();
        bool check = true;
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
            if (checkBox1.Checked == true)
            {
                checkBox2.Enabled = false;
            }
            else if (checkBox2.Checked == true)
            {
                checkBox1.Checked = false;
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
                        progressBar1.Value = progressBarValue + 20;
                        lblStatus.Text = "İndirme başladı";
                        listCounter += 1;
                        lblInfo.Text = mediaList[listCounter];
                    }
                    else
                    {
                        lblStatus.Text = "İndirme başarılı";
                        listCounter = 0;
                        if (checkBox1.Enabled == false)
                        {
                            checkBox1.Enabled = true;
                        }
                        if (checkBox2.Enabled == false)
                        {
                            checkBox2.Enabled = true;
                        }
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
                    lblStatus.Text = "İndirme başarısız";
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            mp3 = true;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
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

        private void GetVideoForms_Load(object sender, EventArgs e)
        {
            if (locationTxt.Text != "")
            {
                locationTxt.Enabled = false;
                changeLocation.Visible = true;
            }
        }
    }
}
