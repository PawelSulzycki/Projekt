using System;
using DownloadNodesSample;
using Newtonsoft.Json;

namespace WindowsFormsApplication1
{
    public class Json
    {
        public string image;
        public string description;
        public double temperature;
        public Json(string city)
        {
            var site = new HtmlSample("http://api.openweathermap.org/data/2.5/weather?q=" + city + ",pl&APPID=5a2583f8a76134addaffb0299912a39a");
            var api = site.GetPageHtml();
            var output = JsonConvert.DeserializeObject(api);

            WeatherForecast deserializedWeather = JsonConvert.DeserializeObject<WeatherForecast>(output.ToString());
            temperature = Math.Round((deserializedWeather.Main.temp - 273), 1);
            description = "Dzisiaj jest " +temperature + " stopni Celcjusza. Ciśnienie " + deserializedWeather.Main.pressure + " hPa. " +
                                                     "A co na niebie? " + deserializedWeather.Weather[0].description;
            image = "http://openweathermap.org/img/w/" + deserializedWeather.Weather[0].icon + ".png";
        }
    }
}