using System;
using System.Windows.Forms;
using DownloadNodesSample;
using Newtonsoft.Json;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void buttonCheckTheWeather_Click(object sender, EventArgs e)
        {
            Json json = new Json(textBoxNameCity.Text);
               
            richTextBox.Text= string.Format("{0}\n", json.description);
            pictureBox.ImageLocation = json.image;

        }
    }
}
