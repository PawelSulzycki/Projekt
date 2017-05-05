using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{

    public class PopOut
    {
        public string Image;
        public string Body;
       public PopOut(string image, string body)
        {
            Image = image;
            Body = body;
        }
        public void initialize()
        {
            Form3 form3 = new Form3(Body, Image);
            form3.Show();
        }

    }
}
