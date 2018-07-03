using MvvmCross.ViewModels;
using MvvmCross.Navigation;
using MvvmCross.Commands;
using OpenWeather.core.Services;
using OpenWeather.Core.Models;

namespace OpenWeather.core.ViewModels
{
    public class MainViewModel : MvxViewModel
    {
        private readonly IMvxNavigationService _navigationService;
        private IWeatherService _weatherService;
        public MainViewModel(IMvxNavigationService navigationService, WeatherService weatherService)
        {
            _navigationService = navigationService;
            _weatherService = weatherService;
            ShowWeatherDetailsCommand = new MvxAsyncCommand(async () => await _navigationService.Navigate<WeatherDetailsViewModel>());
            GetweatherCommand = new MvxAsyncCommand(async () => await _weatherService.FetchWeather("Cape Town"));
        }

        // Init and Start are important parts of MvvmCross' CIRS ViewModel lifecycle
        // Learn how to use Init and Start at https://github.com/MvvmCross/MvvmCross/wiki/view-model-lifecycle
        public void Init()
        {
        }

        public override void Start()
        {
        }
        public IMvxAsyncCommand ShowWeatherDetailsCommand { get; private set; }
        public IMvxAsyncCommand GetweatherCommand { get; private set; }

        #region Properties
        public string _cityName = string.Empty;
        public string cityName
        {
            get => _cityName;
            set
            {
                SetProperty(ref _cityName, value);
            }
        }
        #endregion
    }
}
