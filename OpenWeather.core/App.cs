using System;
using MvvmCross.IoC;
using MvvmCross.ViewModels;
using OpenWeather.core.ViewModels;

namespace OpenWeather.core
{
    public class App:MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Services")
                .AsInterfaces()
                .RegisterAsLazySingleton();

           RegisterAppStart<MainViewModel>();
        }
    }
}
