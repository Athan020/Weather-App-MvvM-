using Android.App;
using System;
using Android.Runtime;
using MvvmCross.Platforms.Android.Core;
using MvvmCross.Platforms.Android.Views;
using OpenWeather.core;

namespace OpenWeather.Droid
{
    [Application]
    public class Setup : MvxAndroidApplication<MvxAndroidSetup<App>,App>
    {
        public Setup(IntPtr javaReference,JniHandleOwnership transfer)
               : base(javaReference,transfer)
        {
        }
    }
}
