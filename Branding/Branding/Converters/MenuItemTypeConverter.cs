using System;
using System.Globalization;
using Branding.Models;
using Xamarin.Forms;

namespace Branding.Converters {

    public class MenuItemTypeConverter : IValueConverter {

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture) {
            var icon = value as string;
            return icon;            
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) {
            return null;
        }
    }
}