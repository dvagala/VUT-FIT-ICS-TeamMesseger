using System;
using System.Globalization;
using System.Windows.Data;
using ICS.Project.BL.Models;

namespace ICS.Project.App.Converters
{
    internal class UserToLastActivityConvertor : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is UserModel user)
                return user.IsLoggedIn
                    ? "now"
                    : user.LastLogoutTime.ToString("HH:mm d.M.yyyy", CultureInfo.InvariantCulture);
            throw new ArgumentException();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}