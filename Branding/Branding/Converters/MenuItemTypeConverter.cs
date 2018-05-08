using System;
using System.Globalization;
using Branding.Models;
using Xamarin.Forms;

namespace Branding.Converters {

    public class MenuItemTypeConverter : IValueConverter {

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture) {
            var menuItemType = (MenuItemType)value;

            switch (menuItemType) {
                case MenuItemType.Home:
                    return "ic_home.png";

                case MenuItemType.BookRoom:
                    return  "ic_bed.png";

                case MenuItemType.MyRoom:
                    return "ic_key.png";

                case MenuItemType.Suggestions:
                    return "ic_beach.png";

                case MenuItemType.Concierge:
                    return "ic_bot.png";

                case MenuItemType.Logout:
                    return "ic_logout.png";

                default:
                    return string.Empty;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) {
            return null;
        }
    }
}