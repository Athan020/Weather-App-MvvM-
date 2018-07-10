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
            GetweatherCommand = new MvxAsyncCommand(FetchWeather);

        }

        public override Task Initialize()
        {
            return base.Initialize();
        }


        public IMvxAsyncCommand GetweatherCommand { get; private set; }

       

        private async Task FetchWeather()
        {

            Forecast forecast = new Forecast();
            try
            {
                forecast = await _weatherService.FetchWeather(_cityName);
            }
            catch (Exception ex)
            {
                //var alert = _userDialog.AlertAsync(new AlertConfig
                //{
                //    Title = "Oops.. ",
                //    Message = "There was a problem trying to fetch your weather",
                //    OkText = "Ok"
                //});
                Console.WriteLine(ex.Message);
            }
            if (forecast != null) await _navigationService.Navigate<WeatherDetailsViewModel, Forecast>(forecast);

        }

        public string _cityName = string.Empty;
        public string CityName
        {
            get => _cityName;
            set
            {
                SetProperty(ref _cityName, value);
            }
        }


    }
}
