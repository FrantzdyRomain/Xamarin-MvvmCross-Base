
using System.Reflection;
using MvvmCross.Core.ViewModels;
using BaseProject.Core.Services.Interfaces;
using MvvmCross.Platform.IoC;
using MvvmCross.Platform;
using MvvmCross.Localization;
using MvvmCross.Plugins.ResxLocalization;
using Base.Localization;
using BaseProject.Core.ViewModels;
namespace BaseProject.Core
{
    public class App : MvxApplication
    {
        public App()
        {
            //Register your services

        }
        public override void Initialize(){
            //Register your services. Any classes used for API services ending with Service will be registered
            typeof(ISampleCalculationService).GetTypeInfo().Assembly.CreatableTypes().EndingWith("Service").AsInterfaces().RegisterAsLazySingleton();

			//Register your Repositories. Any repository classes used for caching results from API services ending with Repositoty will be registered
			typeof(ISampleCalculationService).GetTypeInfo().Assembly.CreatableTypes().EndingWith("Repositoty").AsInterfaces().RegisterAsLazySingleton();

			//Mvx.RegisterSingleton<IMvxTextProvider>(new MvxResxTextProvider(Strings.ResourceManager));
			 
			Mvx.RegisterSingleton<IMvxAppStart>(new MvxAppStart<SampleCalculationViewModel>());
            //RegisterAppStart(new AppStart());
		}
    }
}
