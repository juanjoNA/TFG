using animalPairs.Views.Forms;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace animalPairs.ViewModels.Forms
{
    /// <summary>
    /// ViewModel for login page.
    /// </summary>
    [Preserve(AllMembers = true)]
    public class LoginViewModel : BaseViewModel
    {
        private string email;
        private bool isInvalidEmail;
        private string password;

        #region Property

        /// <summary>
        /// Gets or sets the property that bounds with an entry that gets the email ID from user in the login page.
        /// </summary>
        public string Email
        {
            get
            {
                return this.email;
            }

            set
            {
                if (this.email == value)
                {
                    return;
                }

                this.email = value;
                this.NotifyPropertyChanged(nameof(email));
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the entered email is valid or invalid.
        /// </summary>
        public bool IsInvalidEmail
        {
            get
            {
                return this.isInvalidEmail;
            }

            set
            {
                if (this.isInvalidEmail == value)
                {
                    return;
                }

                this.isInvalidEmail = value;
                this.NotifyPropertyChanged(nameof(isInvalidEmail));
            }
        }

        /// <summary>
        /// Gets or sets the property that bounds with an entry that gets the email ID from user in the login page.
        /// </summary>
        public string Password
        {
            get
            {
                return this.password;
            }

            set
            {
                if (this.password == value)
                {
                    return;
                }

                this.password = value;
                this.NotifyPropertyChanged(nameof(password));
            }
        }

        #endregion

        public LoginViewModel()
        {
            SignUpCommand = new Command(OnSignUp);
        }

        private async void OnSignUp()
        {
            await Shell.Current.GoToAsync(nameof(SignUpPage));
        }


        #region Commands

        public ICommand SignUpCommand { get; }

        #endregion

    }
}
