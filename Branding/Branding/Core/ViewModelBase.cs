using System.Threading.Tasks;

namespace Branding.Core {
    public abstract class ViewModelBase : ObservableObject {

        private string _title = string.Empty;
        private string _icon = string.Empty;
        private bool _isBusy;


        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>The title.</value>
        public string Title {
            get => _title;
            set => SetProperty(ref _title, value);
        }


        /// <summary>
        /// Gets or sets the icon.
        /// </summary>
        /// <value>The icon.</value>
        public string Icon {
            get => _icon;
            set => SetProperty(ref _icon, value);
        }


        /// <summary>
        /// Gets or sets a value indicating whether this instance is busy.
        /// </summary>
        /// <value><c>true</c> if this instance is busy; otherwise, <c>false</c>.</value>
        public bool IsBusy {
            get => _isBusy;
            set => SetProperty(ref _isBusy, value);
        }

        public virtual Task InitializeAsync(object navigationData) {
            return Task.FromResult(false);
        }

    }
}