using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YoutubeDownloaderV3
{
    internal class Video
    {
        public string Author { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public Image Thumbnail { get; set; }
    }
}
