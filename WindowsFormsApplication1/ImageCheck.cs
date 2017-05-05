using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace WindowsFormsApplication1
{
    [Table("ImageCheck")]
    public class ImageCheck : Task 
    {
        public string Site { get; set; }
        public string Keyword { get; set; }
        public ImageCheck(string site, string keyword)
        {
            Site = site;
            Keyword = keyword;
        }

        public ImageCheck()
        {
            
        }

        public override string ToString()
        {

            return "Twój obrazek z portalu " + Site + " dla słowa: " + Keyword;

        }
        public override void initialize()
        {
            var site = new DownloadNodesSample.HtmlSample("http://" + Site);
            var image = site.FindImage(Keyword);
            if (image != null && image != "BRAK SZUKANEGO OBRAZKA")
            {
                string body = "<html><body><br/><br/><img src=" + image +
                  " /></body></html></body></html>";
                string subject = "Twój obrazek z " + Site;
                if (this.emailAdress != null)
                {


                    var email = new Email(emailAdress, subject, body);
                    email.SendEmail();


                }
                else
                {
                    var window = new PopOut(image, subject);
                    window.initialize();

                }
            }
        }

    }
}
