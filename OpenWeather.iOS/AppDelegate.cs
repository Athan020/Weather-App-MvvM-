using Foundation;
using UIKit;
using MvvmCross.ViewModels;
using MvvmCross.Platforms.Ios;
using MvvmCross.Platforms.Ios.Presenters;
using MvvmCross.Platforms.Ios.Core;

namespace OpenWeather.iOS
{
	// The UIApplicationDelegate for the application. This class is responsible for launching the
	// User Interface of the application, as well as listening (and optionally responding) to application events from iOS.
	[Register("AppDelegate")]
    public class AppDelegate : MvxApplicationDelegate<MvxIosSetup<core.App>, core.App>
	{
        
	}
}

