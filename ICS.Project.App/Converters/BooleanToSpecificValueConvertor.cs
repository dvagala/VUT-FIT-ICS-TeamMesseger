using System;
using System.Globalization;
using System.Windows.Data;

namespace ICS.Project.App.Converters
{
    internal class BooleanToSpecificValueConvertor : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is bool boolValue && parameter is string stringParameter &&
                int.TryParse(stringParameter, out var intParameter))
                return boolValue ? intParameter : 0;
            throw new ArgumentException();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}