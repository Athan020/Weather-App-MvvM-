using OpenWeather.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OpenWeather.core.Services
{
   public interface IWeatherService
    {

         Task<Forecast> FetchWeather(String query);
       // string GetWindRating(double windspeed);

//        string GetWindDirection(double windDeg);
    }
}
