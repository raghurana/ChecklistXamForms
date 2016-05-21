using System;
using System.Globalization;
using Xamarin.Forms;

namespace ChecklistTest.ValueConverters
{
    public class NullToDefaultPlaceholderConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value ?? "Select...";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }
    }
}