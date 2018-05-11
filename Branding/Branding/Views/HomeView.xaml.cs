using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Branding.Helpers;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Branding.Views {

    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HomeView : ContentPage {

        public HomeView () {
			InitializeComponent ();
		}


        protected override async void OnAppearing() {

            base.OnAppearing();

            StatusBarHelper.Instance.MakeTranslucentStatusBar(true);

        }

    }
}