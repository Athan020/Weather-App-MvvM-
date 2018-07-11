using OpenWeather.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace OpenWeather.core.Services
{
    public class WeatherService : IWeatherService
    {
        public async Task<Forecast> FetchWeather(string query)
        {
            var http = new HttpClient();

            var uri = new Uri(Constants.baseUrl + query + Constants.key);
            Forecast forecast = new Forecast();

            using (var httpClient = new HttpClient())
            {
                var response = await http.GetAsync(uri).ConfigureAwait(false);
                if (response.IsSuccessStatusCode)
                {
                    var JsonResponse = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    if (!string.IsNullOrWhiteSpace(JsonResponse))
                    {
                        forecast = JsonConvert.DeserializeObject<Forecast>(JsonResponse);

                        Console.WriteLine(JsonResponse);

                    }
                }
                return forecast;
            }    
        }


    }
    static class Constants
    {
        public const string baseUrl = "http://api.openweathermap.org/data/2.5/weather?q=";
        public const string key = "&units=metric&type=accurate&appid=460cc8bee30660deca0296e2f3ffef24";
    }
}
