using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
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