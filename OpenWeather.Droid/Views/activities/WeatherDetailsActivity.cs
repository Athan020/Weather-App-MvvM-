using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MvvmCross;
using MvvmCross.Binding.BindingContext;
using Android.App;
using MvvmCross.Droid.Support.V7.AppCompat;
using OpenWeather.core.ViewModels;
using Android.OS;

namespace OpenWeather.Droid.Views.activities
{
    [Activity(Label = "WeatherDetailsActivity")]
    public class WeatherDetailsActivity : MvxAppCompatActivity<WeatherDetailsViewModel>
    {
 
    

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.activity_weather_details);

            var listview = FindViewById(Resource.Id.listView);

            var set = this.CreateBindingSet<WeatherDetailsActivity, WeatherDetailsViewModel>();

            set.Bind(listview).For("ItemSource").To(vm => vm.WeatherDetails);
            set.Bind(FindViewById(Resource.Id.weather_location)).For("Text").To(vm => vm.WeatherLocation);
            set.Bind(FindViewById(Resource.Id.temp)).For("Text").To(vm => vm.WeatherTemprature);
            set.Bind(FindViewById(Resource.Id.forecast)).For("Text").To(vm => vm.WeatherForecast);
            set.Bind(FindViewById(Resource.Id.weather_icon)).For("ImageSource").To(vm => vm.WeatherIconUrl);
            set.Apply();
        }
    }
}