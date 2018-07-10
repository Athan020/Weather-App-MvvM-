using System;
using MvvmCross.Platforms.Ios.Presenters.Attributes;
using MvvmCross.Platforms.Ios.Views;
using MvvmCross.Binding.BindingContext;
using OpenWeather.Core;
using UIKit;
using OpenWeather.core.ViewModels;
namespace OpenWeather.iOS.Views
{
    [MvxModalPresentation]
    public class WeatherView:MvxViewController<WeatherDetailsViewModel>
    {
        public WeatherView():base(nameof(WeatherView),null)
        {
            
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
        }
    }
}
