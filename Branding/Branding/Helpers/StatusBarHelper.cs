﻿using Xamarin.Forms;

namespace Branding.Helpers {

    public class StatusBarHelper {

        public const string TranslucentStatusChangeMessage = "TranslucentStatusChange";

        public static StatusBarHelper Instance { get; } = new StatusBarHelper();

        protected StatusBarHelper() {}

        public void MakeTranslucentStatusBar(bool translucent) {
            MessagingCenter.Send(this, TranslucentStatusChangeMessage, translucent);
        }
    }
}