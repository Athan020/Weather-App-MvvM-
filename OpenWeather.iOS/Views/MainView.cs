using System;
using MvvmCross.Platforms.Ios.Presenters.Attributes;
using MvvmCross.Platforms.Ios.Views;
using MvvmCross;
using MvvmCross.Binding.BindingContext;
using OpenWeather.Core;
using UIKit;
using OpenWeather.core.ViewModels;

namespace OpenWeather.iOS.Views
{
    [MvxRootPresentation]
    public class MainView:MvxViewController<MainViewModel>
    {
        public MainView():base(nameof(MainView),null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
          

             
           
        }
    }
}
