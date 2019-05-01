using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using ICS.Project.BL.Models;

namespace ICS.Project.App.Converters
{
    class UserToFullNameConvertor : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is UserModel userModelValue)
            {
                return $"{userModelValue.Name} {userModelValue.Surname}";
            }
            else
            {
                throw new ArgumentException();               
            }

        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

}