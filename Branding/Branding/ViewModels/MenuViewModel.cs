using System.Collections.ObjectModel;
using Branding.Core;
using Branding.Models;

namespace Branding.ViewModels {
    public class MenuViewModel : ViewModelBase {


        public string Message { get; } = "Branding";

        private ObservableCollection<Models.MenuItem> _menuItems;


        public MenuViewModel() {
            
            MenuItems = new ObservableCollection<MenuItem>();
            InitializeMenuItems();
        }


        public ObservableCollection<Models.MenuItem> MenuItems {
            get => _menuItems;

            set {
                _menuItems = value;
                RaisePropertyChanged();
            }
        }

        private void InitializeMenuItems() {

            MenuItems.Add(new MenuItem {
                Icon = "ic_home.png",
                Title = "Home",
                MenuItemType = MenuItemType.Home,
                ViewModelType = typeof(MainViewModel),
                IsEnabled = true
            });

            MenuItems.Add(new MenuItem {
                Icon = "ic_bed.png",
                Title = "PlaceHolder1",
                MenuItemType = MenuItemType.PlaceHolder1,
                ViewModelType = typeof(MainViewModel),
                IsEnabled = true
            });

            MenuItems.Add(new MenuItem {
                Icon = "ic_key.png",
                Title = "PlaceHolder2",
                MenuItemType = MenuItemType.PlaceHolder2,
                ViewModelType = typeof(MainViewModel),
                IsEnabled = true
            });

            MenuItems.Add(new MenuItem {
                Icon = "ic_beach.png",
                Title = "PlaceHolder3",
                MenuItemType = MenuItemType.PlaceHolder3,
                ViewModelType = typeof(MainViewModel),
                IsEnabled = true
            });

            MenuItems.Add(new MenuItem {
                Icon= "ic_bot.png",
                Title = "Settings",
                MenuItemType = MenuItemType.Settings,
                ViewModelType = typeof(MainViewModel),
                IsEnabled = true
            });
        }


    }
}