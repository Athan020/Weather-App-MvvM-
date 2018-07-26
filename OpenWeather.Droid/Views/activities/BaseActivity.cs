using Android.OS;
using System;
using MvvmCross.ViewModels;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Droid.Support.V7.AppCompat;
using Acr.UserDialogs;

namespace OpenWeather.Droid.Views.activities
{
    public abstract class BaseActivity<TViewModel>:MvxAppCompatActivity<TViewModel>
        where TViewModel:class, IMvxViewModel
    {
        //Layout For The Activity
       // public abstract int ActivityLayoutId { get; }
        public abstract Android.App.Activity Activity { get; }
        public abstract String TAG { get; }

      //  protected Toolbar Toolbar => FindViewById<Toolbar>(Resource.Layout.toolbar);

         
       
          
    }

}
