using MvvmCross.ViewModels;
using MvvmCross.Navigation;
using MvvmCross.Commands;
using OpenWeather.core.Services;
using System.Threading.Tasks;
using System;
using OpenWeather.Core.Models;
//using Acr.UserDialogs;


namespace OpenWeather.core.ViewModels
{
    public class MainViewModel:MvxViewModel
    {
        private readonly IMvxNavigationService _navigationService;
        private readonly IWeatherService _weatherService;
        //private readonly IUserDialogs _userDialog;


        public MainViewModel(IMvxNavigationService navigationService, IWeatherService weatherService)
        {
            _navigationService = navigationService;
            _weatherService = weatherService;
            //_userDialog = userDialogs;
          //  GetweatherCommand = new MvxAsyncCommand(FetchWeather);

        }

        public override Task Initialize()
        {
            return base.Initialize();
        }


        public MvxAsyncCommand getWeatherCommand;

        public IMvxAsyncCommand GetweatherCommand {
            get
            {
                return getWeatherCommand ?? (getWeatherCommand = new MvxAsyncCommand(async () => await FetchWeather()));
            }
        }

       

        private async Task FetchWeather()
        {

            var forecast = new Forecast();
            Console.WriteLine("Got here ", CityName," yah");

            try
            {
                forecast = await _weatherService.FetchWeather(CityName);
           }
            catch (Exception ex)
            {
           //     var alert = _userDialog.AlertAsync(new AlertConfig
            //    {
             //       Title = "Oops.. ",
              //      Message = "There was a problem trying to fetch your weather",
               //     OkText = "Ok"
              // });
               Console.WriteLine(ex.Message);
            }
            Console.WriteLine(forecast.Base.ToString());
           if (forecast != null) await _navigationService.Navigate<WeatherDetailsViewModel, Forecast>(forecast);

        }

        public string _cityName = string.Empty;
        public string CityName
        {
            get {
                return _cityName;
            }
            set
            {
                _cityName = value;
                RaisePropertyChanged(() => CityName);
            }
        }


    }
}
