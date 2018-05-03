using Branding.Core;

namespace Branding.ViewModels {

    public class HomeViewModel : ViewModelBase {

        private string _message = "This is the Home View";

        public HomeViewModel() {         
        }

        public string Message {
            get => _message;
        }

    }
}