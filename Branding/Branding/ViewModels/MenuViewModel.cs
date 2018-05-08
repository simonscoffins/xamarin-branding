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
                Title = "Home",
                MenuItemType = MenuItemType.Home,
                ViewModelType = typeof(MainViewModel),
                IsEnabled = true
            });

            MenuItems.Add(new MenuItem {
                Title = "PlaceHolder1View",
                MenuItemType = MenuItemType.PlaceHolder1,
                ViewModelType = typeof(MainViewModel),
                IsEnabled = true
            });



    }


}
}