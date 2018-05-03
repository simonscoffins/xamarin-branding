using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Branding.Configuration;
using Branding.Services;
using Branding.ViewModels;
using Branding.Views;
using Xamarin.Forms;

namespace Branding {

	public partial class App : Application {

	    static App() {
	        Locator.Bootstrap();
        }

        public App () {
			InitializeComponent();


            //var menu = new MenuView() {
            //    Title = "Side Menu"
            //};

            //var tp = new TypographicScales();
            //tp.Title = "Typographic Scales";

            //tp.Children.Add(new ScaleBlackText());
            //tp.Children.Add(new PageOne());
            //tp.Children.Add(new PageTwo());
            //tp.Children.Add(new PageThree());


            //var navPage = new CustomNavigationPage(tp) {Title = "Typographic Scales"};

            //var md = new MainView {
            //    Master = menu,
            //    Detail = navPage,
            //    MasterBehavior = MasterBehavior.Popover
            //};


            //MainPage = md;

            InitializeNavigation();
        }


	    private Task InitializeNavigation() {
	        var navSvc = Locator.Instance.Resolve<INavigationService>();
	        return navSvc.NavigateToAsync<ExtendedSplashViewModel>();
	    }

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
