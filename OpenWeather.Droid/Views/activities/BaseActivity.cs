using Android.OS;
using Android.Support.V7.Widget;
using MvvmCross.ViewModels;
using MvvmCross.Droid.Support.V7.AppCompat;

namespace OpenWeather.Droid.Views.activities
{
    public abstract class BaseActivity<TViewModel>:MvxAppCompatActivity<TViewModel>
        where TViewModel:class, IMvxViewModel
    {
        //Layout For The Activity
        public abstract int ActivityLayoutId { get; }

      //  protected Toolbar Toolbar => FindViewById<Toolbar>(Resource.Layout.toolbar);

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(ActivityLayoutId);
         //   SetSupportActionBar(Toolbar);
        }
    }

}
