using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace ICS.Project.App.Converters
{
    class ToggleButtonToChangeTextToSaveConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is bool)
            {
                bool isEditButtonChecked = (bool) value;

                if (isEditButtonChecked)
                {
                    return "Save";
                }
                else
                {
                    return "Edit";
                }
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