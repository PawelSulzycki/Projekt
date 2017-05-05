using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class TaskDbContext : DbContext
    {
        public TaskDbContext() : base("Tasks")
        {
            Database.SetInitializer(new TaskDbInitializer());
        }
        public DbSet<Task> Task { get; set; }
        public DbSet<ImageCheck> ImageCheck { get; set; }
        public DbSet<WeatherCheck> WeatherCheck { get; set; }
        public void LoadData()
        {
            foreach (var task in Task)
            {
                foreach (var image in ImageCheck)
                {
                    if (task.Id == image.Id)
                    {
                        var imageMail = new ImageCheck(image.Site, image.Keyword);
                        imageMail.emailAdress = image.emailAdress;
                        Program.Tasks.Add(imageMail);
                    }
                }
                foreach (var weather in WeatherCheck)
                {
                    if (task.Id == weather.Id)
                    {
                        var weatherCheck = new WeatherCheck(weather.City, weather.Temperature);
                        weatherCheck.emailAdress = weather.emailAdress;
                        Program.Tasks.Add(weatherCheck);
                    }
                }

            }
        }
    }
}
