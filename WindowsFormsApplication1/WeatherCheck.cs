using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    [Table("WeatherCheck")]
    public class WeatherCheck : Task
    {
        public string City { get; set; }
        public decimal Temperature { get; set; }
        public WeatherCheck(string city, decimal temperature)
        {
            City = city;
            Temperature = temperature;
        }
        
        public WeatherCheck()
        {

        }
        public override string ToString()
        {

            return "Twoja pogoda dla miasta: " + City;

        }
        public override void initialize()
        {
            Json json = new Json(City);

            string subject = "Twój obrazek z pogoda";

            if (Convert.ToDecimal(json.temperature) >= Temperature)
            {
                if (emailAdress != null && emailAdress.Length > 2)
                {

                    string body = "<html><body><p>" + json.description + "</p><br/><br/><img src=" + json.image +
                              " /></body></html></body></html>";
                    var email = new Email(emailAdress, subject, body);
                    email.SendEmail();


                }
                else
                {
                    var window = new PopOut(json.image, json.description);
                    window.initialize();

                }
            }
        }
     }
}
