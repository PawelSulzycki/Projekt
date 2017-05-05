using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DownloadNodesSample;
namespace WindowsFormsApplication1
{
    static class Program
    {
        public static BindingList<Task> Tasks = new BindingList<Task>();
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var ctt = new TaskDbContext();
            ctt.LoadData();
            Application.Run(new Form1());

            
        }
    }
}
