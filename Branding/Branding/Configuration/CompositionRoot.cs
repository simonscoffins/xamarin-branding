using Branding.Services;
using Branding.ViewModels;
using SimpleInjector;

namespace Branding.Configuration {
    internal static class CompositionRoot {

        internal static void Register(Container container) {

            container.RegisterSingleton<INavigationService, NavigationService>();

            container.Register<ExtendedSplashViewModel, ExtendedSplashViewModel>();
            container.Register<MainViewModel, MainViewModel>();
            container.Register<MenuViewModel, MenuViewModel>();
            container.Register<HomeViewModel, HomeViewModel>();

            container.Register<PlaceHolder1ViewModel, PlaceHolder1ViewModel>();
            container.Register<PlaceHolder2ViewModel, PlaceHolder2ViewModel>();
            container.Register<PlaceHolder3ViewModel, PlaceHolder3ViewModel>();
            container.Register<SettingsViewModel, SettingsViewModel>();
        }
    }
}