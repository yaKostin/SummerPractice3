using System;
using System.Windows.Data;
using System.Globalization;
using Investment.ViewModel.Wrappers.ObjectWrappers;

namespace Investment.ViewModel.Converters
{
    [ValueConversion(typeof(string), typeof(string))]
    public class RatingConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null) throw new ArgumentNullException("value");
            var ratingVM = value as RatingVM;
            var rating = ratingVM.DomainObject;
            var result = rating.Name;
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
