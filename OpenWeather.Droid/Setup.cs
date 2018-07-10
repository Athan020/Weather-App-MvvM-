using Android.App;
using System;
using Android.Runtime;
using MvvmCross.Platforms.Android.Core;
using MvvmCross.Platforms.Android.Views;
using OpenWeather.core;
using Plugin.CurrentActivity;

namespace OpenWeather.Droid
{
    [Application]
    public class Setup : MvxAndroidApplication<MvxAndroidSetup<App>,App>
    {
        public Setup(IntPtr javaReference,JniHandleOwnership transfer)
               : base(javaReference,transfer)
        {
        }

        public override void OnCreate()
        {
            base.OnCreate();
            CrossCurrentActivity.Current.Init(this);
        }
    }
}
