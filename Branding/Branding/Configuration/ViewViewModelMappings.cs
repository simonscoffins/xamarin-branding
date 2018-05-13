using System;
using System.Collections.Generic;
using Branding.ViewModels;
using Branding.Views;

namespace Branding.Configuration {
    internal static class ViewViewModelMappings {

        static ViewViewModelMappings() { }

        public static Dictionary<Type, Type> GetMapping() {

            var mappings = new Dictionary<Type, Type>();

            mappings.Add(typeof(ExtendedSplashViewModel), typeof(ExtendedSplashView));
            mappings.Add(typeof(MainViewModel), typeof(MainView));
            mappings.Add(typeof(HomeViewModel), typeof(HomeView));

            mappings.Add(typeof(PlaceHolder1ViewModel), typeof(PlaceHolder1View));
            mappings.Add(typeof(PlaceHolder2ViewModel), typeof(PlaceHolder2View));
            mappings.Add(typeof(PlaceHolder3ViewModel), typeof(PlaceHolder3View));
            mappings.Add(typeof(SettingsViewModel), typeof(SettingsView));

            mappings.Add(typeof(TypeSystemViewModel), typeof(TypeSystemTabbedPage));

            return mappings;
        }
    }
}