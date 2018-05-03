using System.Threading.Tasks;
using Branding.Core;
using Branding.Services;

namespace Branding.ViewModels {

    public class MainViewModel : ViewModelBase {

        private MenuViewModel _menuViewModel;
        private INavigationService _navigationService;

        public MainViewModel(MenuViewModel menuViewModel, INavigationService navigationService) {
            _menuViewModel = menuViewModel;
            _navigationService = navigationService;
        }


        public MenuViewModel MenuViewModel {
            get {
                return _menuViewModel;
            }

            set {
                _menuViewModel = value;
                RaisePropertyChanged();
            }
        }


        public override Task InitializeAsync(object navigationData) {
            return Task.WhenAll (
                _menuViewModel.InitializeAsync(navigationData),
                _navigationService.NavigateToAsync<HomeViewModel>()
            );
        }
    }
}