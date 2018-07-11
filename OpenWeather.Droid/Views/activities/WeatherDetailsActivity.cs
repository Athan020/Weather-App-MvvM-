using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MvvmCross;
using Android.App;

using OpenWeather.core.ViewModels;

namespace OpenWeather.Droid.Views.activities
{
    [Activity(Label = "WeatherDetailsActivity")]
    public class WeatherDetailsActivity : BaseActivity<WeatherDetailsViewModel>
    {
        public override int ActivityLayoutId => Resource.Layout.activity_weather_details;
        public override Activity Activity => this;
    }
}