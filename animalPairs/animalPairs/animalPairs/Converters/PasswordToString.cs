using animalPairs.Controls;
using animalPairs.ViewModels.Forms;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace animalPairs.Converters
{
    class PasswordToString : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null || !(parameter is BorderlessEntry password))
            {
                return false;
            }

            var isFocused = (bool)value;
            var isInvalidpassword = !isFocused && !Utils.Utils.isValidPassword(password.Text);

            return isInvalidpassword;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return true;
        }
    }
}
