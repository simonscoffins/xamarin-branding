using System.Threading.Tasks;
using Branding.Core;
using Branding.Services;

namespace Branding.ViewModels {
    public class ExtendedSplashViewModel : ViewModelBase {

        private string _message = "This is a Splash Screen";
        private readonly INavigationService _navigationService;

        public ExtendedSplashViewModel(INavigationService navigationService) {
            _navigationService = navigationService;
        }

        public string Message {
            get => _message;
        }


        public override async Task InitializeAsync(object navigationData) {

            IsBusy = true;

            await _navigationService.InitializeAsync();


            IsBusy = false;
        }

    }
}