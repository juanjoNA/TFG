using animalPairs.Common;
using animalPairs.Views.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace animalPairs.ViewModels
{
    /// <summary>
    /// This viewmodel extends in another viewmodels.
    /// </summary>
    [Preserve(AllMembers = true)]
    [DataContract]
    public class BaseViewModel : INotifyPropertyChanged
    {
        #region Event handler

        /// <summary>
        /// Occurs when the property is changed.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        #region Methods

        /// <summary>
        /// The PropertyChanged event occurs when changing the value of property.
        /// </summary>
        /// <param name="propertyName">The PropertyName</param>
        protected void NotifyPropertyChanged([CallerMemberName] string propertyName = null)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected async void checkWetherTheUserIsSignIn()
        {
            var authenticationService = DependencyService.Resolve<IAuthenticationService>();
            if (!authenticationService.IsSignIn())
            {
                await Xamarin.Forms.Shell.Current.GoToAsync(nameof(LoginPage));
            }
            else
            {
                await Xamarin.Forms.Shell.Current.GoToAsync(nameof(SignUpPage));
            }
        }

        #endregion
    }
}
