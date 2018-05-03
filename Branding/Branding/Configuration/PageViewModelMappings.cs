using System;
using System.Collections.Generic;
using Branding.ViewModels;
using Branding.Views;

namespace Branding.Configuration {
    internal static class PageViewModelMappings {


        static PageViewModelMappings() {
        }


        public static Dictionary<Type, Type> GetMapping() {

            var mappings = new Dictionary<Type, Type>();

            mappings.Add(typeof(ExtendedSplashViewModel), typeof(ExtendedSplashView));
            mappings.Add(typeof(MainViewModel), typeof(MainView));
            mappings.Add(typeof(HomeViewModel), typeof(HomeView));

            return mappings;
        }
    }
}