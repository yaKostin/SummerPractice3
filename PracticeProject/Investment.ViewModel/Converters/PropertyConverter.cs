using System;
using System.Globalization;
using System.Windows.Data;
using Investment.ViewModel.Wrappers.ObjectWrappers;
namespace Investment.ViewModel.Converters
{
    [ValueConversion(typeof(string), typeof(string))]
    public class PropertyConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null) throw new ArgumentNullException("value");
            var propVM = value as PropertyVM;
            var prop = propVM.DomainObject;
//            var result = ((PropertyVM)(value)).DomainObject.Name;
            var result = prop.Name;
            return result;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null) throw new ArgumentNullException("value");
            var result = value.ToString().Trim();
            return result;
        }
    }
}
