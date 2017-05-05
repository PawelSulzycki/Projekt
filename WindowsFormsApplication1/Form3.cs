using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DownloadNodesSample;
using Newtonsoft.Json;

namespace WindowsFormsApplication1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

        }

        public Form3(string city)
        {
            InitializeComponent();

            Json json = new Json(city);

            richTextBox1.Text = string.Format("{0}\n", json.description);
            pictureBox1.ImageLocation = json.image;
        }

        public Form3(string body, string image)
        {
            InitializeComponent();
            richTextBox1.Text = string.Format("{0}\n", body);
            pictureBox1.ImageLocation = image;
            if(image.StartsWith("http://openweathermap.org/"))
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            }

        }
    }
}
