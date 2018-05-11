using System.Collections.ObjectModel;
using System.Windows.Input;
using Branding.Core;
using Branding.Models;
using Branding.Services;
using Xamarin.Forms;
using MenuItem = Branding.Models.MenuItem;

namespace Branding.ViewModels {
    public class MenuViewModel : ViewModelBase {



        private readonly INavigationService _navigationService;
        
        private ObservableCollection<Models.MenuItem> _menuItems;


        public MenuViewModel(INavigationService navigationService) {
            _navigationService = navigationService;

            MenuItems = new ObservableCollection<MenuItem>();
            InitializeMenuItems();
        }


        public string Message { get; } = "Branding";


        public ObservableCollection<Models.MenuItem> MenuItems {
            get => _menuItems;

            set {
                _menuItems = value;
                RaisePropertyChanged();
            }
        }

        public ICommand MenuItemSelectedCommand => new Command<MenuItem>(OnSelectMenuItem);

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
                Title = "Place holder 1",
                MenuItemType = MenuItemType.PlaceHolder1,
                ViewModelType = typeof(PlaceHolder1ViewModel),
                IsEnabled = true
            });

            MenuItems.Add(new MenuItem {
                Icon = "ic_key.png",
                Title = "Place holder2",
                MenuItemType = MenuItemType.PlaceHolder2,
                ViewModelType = typeof(PlaceHolder2ViewModel),
                IsEnabled = true
            });

            MenuItems.Add(new MenuItem {
                Icon = "ic_beach.png",
                Title = "Place holder 3",
                MenuItemType = MenuItemType.PlaceHolder3,
                ViewModelType = typeof(PlaceHolder3ViewModel),
                IsEnabled = true
            });

            MenuItems.Add(new MenuItem {
                Icon= "ic_bot.png",
                Title = "Settings",
                MenuItemType = MenuItemType.Settings,
                ViewModelType = typeof(SettingsViewModel),
                IsEnabled = true
            });
        }


        private async void OnSelectMenuItem(MenuItem item) {

           if (item.IsEnabled && item.ViewModelType != null) {

                //item.AfterNavigationAction?.Invoke();
                await _navigationService.NavigateToAsync(item.ViewModelType, item);
            }

        }



    }
}