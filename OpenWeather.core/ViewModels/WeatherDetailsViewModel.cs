using System.Threading.Tasks;
using MvvmCross.ViewModels;
using MvvmCross.Commands;
using OpenWeather.Core.Models;
using OpenWeather.core.Services;
using OpenWeather.core.Models;
using System.Collections.Generic;
using System;

namespace OpenWeather.core.ViewModels
{
    public class WeatherDetailsViewModel : MvxViewModel<Forecast>
    {
       
        

       // private String WeatherCondition;

        public WeatherDetailsViewModel()
        {
        }

        // Init and Start are important parts of MvvmCross' CIRS ViewModel lifecycle
        // Learn how to use Init and Start at https://github.com/MvvmCross/MvvmCross/wiki/view-model-lifecycle
        public void Init()
        {
        }

        public override Task Initialize()
        {
            return base.Initialize();
        }

        public override void Prepare(Forecast parameter)
        {
            Console.WriteLine(parameter.ToString());
            WeatherDetails = PrepareWeatherList(parameter);
        }
        public override void Start()
        {
        }

        public List<WeatherItem> PrepareWeatherList(Forecast result)
        {
            
            List<WeatherItem> ItemList = new List<WeatherItem>();
            WeatherIconUrl = "http://openweathermap.org/img/w/" + result.Weather[0].Icon + ".png";

            WeatherTemprature = result.Main.Temp.ToString();
           
            WeatherForecast = result.Weather[0].Description;

            WeatherLocation = "Weather in " + result.Name + "," +result.Sys.Country.ToUpper();
            ItemList.Add(new WeatherItem("Wind", GetWindRating(result.Wind.Speed) + " " + result.Wind.Speed + " m/s \n " + GetWindDirection(result.Wind.Deg) + " " + result.Wind.Deg + " deg"));
            ItemList.Add(new WeatherItem("Cloudiness", result.Weather[0].Description));
            ItemList.Add(new WeatherItem("Presure", result.Main.Pressure.ToString() + " hpa"));
            ItemList.Add(new WeatherItem("Humidty", result.Main.Humidity.ToString() + " %"));
            ItemList.Add(new WeatherItem("Sunrise", LocallizeTime(result.Sys.Sunrise)));
            ItemList.Add(new WeatherItem("Sunset", LocallizeTime(result.Sys.Sunset)));
            ItemList.Add(new WeatherItem("Geo Coords", "[" + result.Coord?.Lat.ToString() + "," + result?.Coord?.Lon.ToString() + "]"));

            return ItemList;
        }
        public string LocallizeTime(long value)
        {
            var date = new DateTime(value * 1000L).ToLocalTime().ToString();

            return date;
        }
        public List<WeatherItem> _weatherDetails;
        public List<WeatherItem> WeatherDetails
        {
            get => _weatherDetails;
            set
            {
                _weatherDetails = value;
                RaisePropertyChanged(() => WeatherDetails);
            }
        }
        private String _weatherIconUrl;
        public String WeatherIconUrl
        {
            get => _weatherIconUrl;
            set
            {
                _weatherIconUrl = value;
                RaisePropertyChanged(() => WeatherIconUrl);
            }
        }

        public String _weatherTemprature;
        public String WeatherTemprature
        {
            get =>_weatherTemprature;
            set
            {
                _weatherTemprature = value;
                RaisePropertyChanged(() => WeatherTemprature);
            }     
        }

        public String _weatherLocation;
        public String WeatherLocation
        {
            get => _weatherLocation;
            set
            {
                _weatherTemprature = value;
                RaisePropertyChanged(() => WeatherLocation);
            }
        }

        public String _weatherForecast;
        public String WeatherForecast
        {
            get => _weatherForecast;
            set
            {
                _weatherForecast = value;
                RaisePropertyChanged(() => WeatherForecast);
            }
        }

        private IMvxAsyncCommand Getweather { get; set; }

        public string GetWindDirection(double windDeg)
        {
            string windDirection = " ";
            if (windDeg == 0 || windDeg == 360)
            {
                windDirection = "North";
            }
            else if (windDeg > 0 && windDeg < 45)
            {
                windDirection = "North North-East";
            }
            else if (windDeg == 45)
            {
                windDirection = "North-East";
            }
            else if (windDeg > 45 && windDeg < 90)
            {
                windDirection = "East North-East";
            }
            else if (windDeg == 90)
            {
                windDirection = "East";
            }
            else if (windDeg > 90 && windDeg < 135)
            {
                windDirection = "East South-East";
            }
            else if (windDeg == 135)
            {
                windDirection = "South-East";
            }
            else if (windDeg > 135 && windDeg < 180)
            {
                windDirection = "South South-East";
            }
            else if (windDeg == 180)
            {
                windDirection = "South";
            }
            else if (windDeg > 180 && windDeg < 225)
            {
                windDirection = "South South-West";
            }
            else if (windDeg == 225)
            {
                windDirection = "South-West";
            }
            else if (windDeg > 225 && windDeg < 270)
            {
                windDirection = "West South-West";
            }
            else if (windDeg == 270)
            {
                windDirection = "West";
            }
            else if (windDeg > 270 && windDeg < 315)
            {
                windDirection = "West North-West";
            }
            else if (windDeg == 315)
            {
                windDirection = "North-West";
            }
            else if (windDeg > 315 && windDeg < 360)
            {
                windDirection = "West North-West";
            }
            return windDirection;
        }

        public string GetWindRating(double windspeed)
        {
            string windRating = " ";
            if (windspeed < 1)
            {
                windRating = "Calm";
            }
            else if (windspeed >= 1 && windspeed < 6)
            {
                windRating = "Light Air";
            }
            else if (windspeed >= 6 && windspeed < 12)
            {
                windRating = "Light Breeze";
            }
            else if (windspeed >= 12 && windspeed < 20)
            {
                windRating = "Gentle Breeze";
            }
            else if (windspeed >= 20 && windspeed < 29)
            {
                windRating = "Moderate Breeze";
            }
            else if (windspeed >= 29 && windspeed < 39)
            {
                windRating = "Fresh Breeze";
            }
            else if (windspeed >= 39 && windspeed < 50)
            {
                windRating = "Strong Breeze";
            }
            else if (windspeed >= 50 && windspeed < 62)
            {
                windRating = "High Wind";
            }
            else if (windspeed >= 62 && windspeed < 75)
            {
                windRating = "Gale";
            }
            else if (windspeed >= 75 && windspeed < 89)
            {
                windRating = "Severe Gale";
            }
            else if (windspeed >= 89 && windspeed < 103)
            {
                windRating = "Storm";
            }
            else if (windspeed >= 103 && windspeed < 118)
            {
                windRating = "Violent Storm";
            }
            else if (windspeed >= 118)
            {
                windRating = "Hurricane Force";
            }
            return windRating;
        }

     
    }
}
