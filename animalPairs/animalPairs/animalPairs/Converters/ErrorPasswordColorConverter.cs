using animalPairs.Controls;
using animalPairs.ViewModels.Forms;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace animalPairs.Converters
{
    class ErrorPasswordColorConverter : IValueConverter
    {
        /// <summary>
        /// Identifies the simple and gradient login pages.
        /// </summary>
        public string PageVariantParameter { get; set; }

        /// <summary>
        /// This method is used to convert the bool to color.
        /// </summary>
        /// <param name="value">Gets the value.</param>
        /// <param name="targetType">Gets the target type.</param>
        /// <param name="parameter">Gets the parameter.</param>
        /// <param name="culture">Gets the culture.</param>
        /// <returns>Returns the color.</returns>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // For Gradient login page 
            if (PageVariantParameter == "0")
            {
                var passwordEntry = parameter as BorderlessEntry;

                if (!(passwordEntry?.BindingContext is SignUpPageViewModel bindingContext))
                {
                    return Color.Transparent;
                }

                var isFocused = (bool)value;

                if (isFocused)
                {
                    return Color.FromRgba(255, 255, 255, 0.6);
                }

                return !Utils.Utils.isValidPassword(passwordEntry.Text) ? Color.FromHex("#FF4A4A") : Color.Transparent;

            }

            // For Simple login page
            else
            {
                var passwordEntry = parameter as BorderlessEntry;

                if (!(passwordEntry?.BindingContext is SignUpPageViewModel bindingContext)) return Color.FromHex("#ced2d9");

                var isFocused = (bool)value;

                if (isFocused)
                {
                    return Color.FromHex("#959eac");
                }

                return Utils.Utils.isValidPassword(passwordEntry.Text) ? Color.FromHex("#FF4A4A") : Color.FromHex("#ced2d9");

            }
        }

        /// <summary>
        /// This method is used to convert the color to bool.
        /// </summary>
        /// <param name="value">Gets the value.</param>
        /// <param name="targetType">Gets the target type.</param>
        /// <param name="parameter">Gets the parameter.</param>
        /// <param name="culture">Gets the culture.</param>
        /// <returns>Returns the string.</returns>        
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}