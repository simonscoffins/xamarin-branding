using System;
using System.Threading.Tasks;
using Branding.Core;

namespace Branding.Models {
    public class MenuItem : ObservableObject {

        private string _icon;
        private string _title;
        private MenuItemType _menuItemType;
        private Type _viewModelType;
        private bool _isEnabled;

        public string Icon {
            get => _icon;

            set {
                _icon = value;
                RaisePropertyChanged();
            }
        }

        public string Title {
            get => _title;

            set {
                _title = value;
                RaisePropertyChanged();
            }
        }

        public MenuItemType MenuItemType {
            get => _menuItemType;

            set {
                _menuItemType = value;
                RaisePropertyChanged();
            }
        }

        public Type ViewModelType {
            get => _viewModelType;

            set {
                _viewModelType = value;
                RaisePropertyChanged();
            }
        }

        public bool IsEnabled {
            get => _isEnabled;

            set {
                _isEnabled = value;
                RaisePropertyChanged();
            }
        }

        public Func<Task> AfterNavigationAction { get; set; }

    }
}