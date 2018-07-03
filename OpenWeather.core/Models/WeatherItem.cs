using System;
using System.Collections.Generic;
using System.Text;

namespace OpenWeather.core.Models
{
    public class WeatherItem
    {
        public WeatherItem(string weatherTitle, string weatherData)
        {
            WeatherTitle = weatherTitle;
            WeatherData = weatherData;
        }

        public string WeatherTitle { get; set; }
        public string WeatherData { get; set; }


    }
}
