using System;
using System.Globalization;
using System.Windows.Data;

namespace ICS.Project.App.Converters
{
    internal class DateTimeFormatConvertor : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is DateTime dateTimeValue)
                return dateTimeValue.ToString("HH:mm d.M.yyyy", CultureInfo.InvariantCulture);
            throw new ArgumentException();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}