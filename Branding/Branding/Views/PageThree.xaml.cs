using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Branding.Views {

    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PageThree : ContentPage {

        public PageThree () {
			InitializeComponent ();
            this.Title = "Page Three";
        }
	}
}