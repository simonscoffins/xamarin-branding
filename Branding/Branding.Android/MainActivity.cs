using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Util;
using Branding.Helpers;
using Xamarin.Forms;

namespace Branding.Droid {

    [Activity(Label = "Branding", Icon = "@drawable/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity {

        protected override void OnCreate(Bundle bundle) {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);
            
            //InitMessageCenterSubscriptions();

            //Window.AddFlags(WindowManagerFlags.TranslucentNavigation);
            Window.AddFlags(WindowManagerFlags.TranslucentStatus);

            LoadApplication(new App());
        }

        private void InitMessageCenterSubscriptions() {
            MessagingCenter.Instance.Subscribe<StatusBarHelper, bool>(this, StatusBarHelper.TranslucentStatusChangeMessage, OnTranslucentStatusRequest);
        }



        private void OnTranslucentStatusRequest(StatusBarHelper helper, bool makeTranslucent) {
            MakeStatusBarTranslucent(makeTranslucent);
        }


        private void MakeStatusBarTranslucent(bool makeTranslucent) {

            if (makeTranslucent) {
                SetStatusBarColor(Android.Graphics.Color.Transparent);

                if (Build.VERSION.SdkInt >= BuildVersionCodes.Lollipop) {
                    Window.DecorView.SystemUiVisibility = (StatusBarVisibility)(SystemUiFlags.LayoutFullscreen | SystemUiFlags.LayoutStable);
                }
            } else {
                using (var value = new TypedValue()) {
                    if (Theme.ResolveAttribute(Resource.Attribute.colorPrimaryDark, value, true)) {
                        var color = new Android.Graphics.Color(value.Data);
                        SetStatusBarColor(color);
                    }
                }

                if (Build.VERSION.SdkInt >= BuildVersionCodes.Lollipop) {
                    Window.DecorView.SystemUiVisibility = StatusBarVisibility.Visible;
                }
            }
        }
    }
}

