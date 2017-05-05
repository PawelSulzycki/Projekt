using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using DownloadNodesSample;
using System.Net;
using System.Net.Mail;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using Newtonsoft.Json;



namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        
        Email email = new Email();
        public Form1()
        {
            InitializeComponent();
            listBoxWorks.DataSource = Program.Tasks;
        }
        

        private void buttonDo_Click(object sender, EventArgs e)
        {
            foreach (Task inTask in Program.Tasks)
            {
                inTask.initialize();
            }
            System.Windows.Forms.MessageBox.Show("Wykonano wszystkie zadania", "Sent");

        }

        private void buttonAddToList_Click(object sender, EventArgs e)
        {
            if ((tabControl1.SelectedTab == tabPage1) && (tabControl2.SelectedTab == tabPage3))
            {
                using (var ctx = new TaskDbContext())
                {
                    var imageMail = new ImageCheck(textBoxNamePortal.Text, textBoxKeyWord.Text);
                    imageMail.emailAdress = textBoxEmail.Text;
                    Program.Tasks.Add(imageMail);
                    ctx.Task.Add(imageMail);
                    ctx.SaveChanges();
                }
            }
            else if ((tabControl1.SelectedTab == tabPage2) && (tabControl2.SelectedTab == tabPage4))
            {
                using (var ctx = new TaskDbContext())
                {
                    Json json = new Json(textBoxNameCity.Text);
                    var weatherWindow = new WeatherCheck(textBoxNameCity.Text, numericUpDown1.Value);
                    Program.Tasks.Add(weatherWindow);
                    ctx.Task.Add(weatherWindow);
                    ctx.SaveChanges();
                }


            }
            else if ((tabControl1.SelectedTab == tabPage1) && (tabControl2.SelectedTab == tabPage4))
            {
                using (var ctx = new TaskDbContext())
                {
                    var imageWindow = new ImageCheck(textBoxNamePortal.Text, textBoxKeyWord.Text);
                    Program.Tasks.Add(imageWindow);
                    ctx.Task.Add(imageWindow);
                    ctx.SaveChanges();
                }

            }
            else if((tabControl1.SelectedTab == tabPage2) && (tabControl2.SelectedTab == tabPage3))
            {
                using (var ctx = new TaskDbContext())
                {
                    var weatherCheck = new WeatherCheck(textBoxNameCity.Text, numericUpDown1.Value);
                    weatherCheck.emailAdress = textBoxEmail.Text;
                    Program.Tasks.Add(weatherCheck);
                    ctx.Task.Add(weatherCheck);
                    ctx.SaveChanges();
                }

            }

        
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            Program.Tasks.Clear();
            using (var ctt = new TaskDbContext())
            {

                foreach (var s in ctt.Task)
                {
                    ctt.Task.Remove(s);

                }
                ctt.SaveChanges();

            }
        }

        private void buttonCheckTheWeather_Click(object sender, EventArgs e)
        {
            var f2 = new Form2();
            f2.Show();
        }

    }
}
