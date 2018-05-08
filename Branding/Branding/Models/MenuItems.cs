using System.Collections.Generic;
using System.Linq;
using Branding.ViewModels;

namespace Branding.Models {
    public static class MenuItems {

        public static MenuItem Home = new MenuItem {
            Title = "Home",
            MenuItemType = MenuItemType.Home,
            ViewModelType = typeof(MainViewModel),
            IsEnabled = true
        };

        public static MenuItem PlaceHolder1View = new MenuItem {
            Title = "PlaceHolder1View",
            MenuItemType = MenuItemType.PlaceHolder1,
            ViewModelType = typeof(MainViewModel),
            IsEnabled = true
        };

        public static MenuItem PlaceHolder2View = new MenuItem {
            Title = "PlaceHolder2View",
            MenuItemType = MenuItemType.PlaceHolder2,
            ViewModelType = typeof(MainViewModel),
            IsEnabled = true
        };

        public static MenuItem PlaceHolder3View = new MenuItem {
            Title = "PlaceHolder2View",
            MenuItemType = MenuItemType.PlaceHolder3,
            ViewModelType = typeof(MainViewModel),
            IsEnabled = true
        };

        public static MenuItem Settings = new MenuItem {
            Title = "Settings",
            MenuItemType = MenuItemType.Settings,
            ViewModelType = typeof(MainViewModel),
            IsEnabled = true
        };


        public static MenuItem GetByMenuType(MenuItemType menuType) {

            return All().First(m => m.MenuItemType == menuType);
        }

        public static IEnumerable<MenuItem> All() {

            yield return Home;
            yield return PlaceHolder1View;
            yield return PlaceHolder2View;
            yield return PlaceHolder3View;
            yield return Settings;
        }
    }
}