using System;

namespace LegacyApplication
{
    public class WeatherForecast
    {
        public WeatherForecast(string callType)
        {
            Type += callType;
        }

        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }

        public string Type { get; private set; } = "NEW_";


    }
}
