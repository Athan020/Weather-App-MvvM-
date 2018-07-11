using Android.OS;
using MvvmCross.ViewModels;
using MvvmCross.Droid.Support.V7.AppCompat;
using Acr.UserDialogs;

namespace OpenWeather.Droid.Views.activities
{
    public abstract class BaseActivity<TViewModel>:MvxAppCompatActivity<TViewModel>
        where TViewModel:class, IMvxViewModel
    {
        //Layout For The Activity
        public abstract int ActivityLayoutId { get; }
        public abstract Android.App.Activity Activity { get; }
      //  protected Toolbar Toolbar => FindViewById<Toolbar>(Resource.Layout.toolbar);

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(ActivityLayoutId);

            UserDialogs.Init(() => Activity);
           //UserDialogs.Init(this);
         //   SetSupportActionBar(Toolbar);
        }
    }

}
