using OpenWeather.core.ViewModels;
using Android.App;

namespace OpenWeather.Droid.Views.activities
{
    [Activity(Label = "Open Weather",MainLauncher =true)]
    public class MainActivity : BaseActivity<MainViewModel>
    {
        public override int ActivityLayoutId => Resource.Layout.activity_main;
    }
}