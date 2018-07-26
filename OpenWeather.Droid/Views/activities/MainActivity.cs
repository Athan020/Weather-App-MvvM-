using OpenWeather.core.ViewModels;
using Android.App;
using MvvmCross;
using MvvmCross.ViewModels;
using MvvmCross.Droid.Support.V7.AppCompat;
using Android.OS;

namespace OpenWeather.Droid.Views.activities
{
    [Activity(Label = "Open Weather",MainLauncher =true)]
    public class MainActivity : MvxAppCompatActivity<MainViewModel>
    {
       // public override int ActivityLayoutId => Resource.Layout.activity_main;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.activity_main);
        }

    }
}