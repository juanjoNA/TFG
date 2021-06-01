using animalPairs.Common;
using animalPairs.Models;
using animalPairs.Utils;
using animalPairs.Views.Chat;
using animalPairs.Views.Forms;
using animalPairs.Views.Navigation;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace animalPairs.ViewModels.Forms
{
    /// <summary>
    /// ViewModel for sign-up page.
    /// </summary>
    [Preserve(AllMembers = true)]
    public class SignUpPageViewModel : LoginViewModel
    {
        #region Fields

        private string name;
        private string surname;

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance for the <see cref="SignUpPageViewModel" /> class.
        /// </summary>
        public SignUpPageViewModel()
        {
            this.LoginCommand = new Command(this.LoginClicked);
            this.SignUpCommand = new Command(this.SignUpClickedAsync);
        }

        #endregion

        #region Property

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (this.name == value)
                {
                    return;
                }

                this.name = value;
                this.NotifyPropertyChanged();
            }
        }

        public string Surname
        {
            get
            {
                return this.surname;
            }

            set
            {
                if (this.surname == value)
                {
                    return;
                }

                this.surname = value;
                this.NotifyPropertyChanged();
            }
        }

        #endregion

        #region Command

        /// <summary>
        /// Gets or sets the command that is executed when the Log In button is clicked.
        /// </summary>
        public Command LoginCommand { get; set; }

        /// <summary>
        /// Gets or sets the command that is executed when the Sign Up button is clicked.
        /// </summary>
        public Command SignUpCommand { get; set; }

        #endregion

        #region Methods

        /// <summary>
        /// Invoked when the Log in button is clicked.
        /// </summary>
        /// <param name="obj">The Object</param>
        private async void LoginClicked(object obj)
        {
            await Shell.Current.GoToAsync(nameof(LoginPage));
        }

        /// <summary>
        /// Invoked when the Sign Up button is clicked.
        /// </summary>
        /// <param name="obj">The Object</param>
        private async void SignUpClickedAsync(object obj)
        {
            var authservice = DependencyService.Resolve<IAuthenticationService>();
            var firestoreDB = DependencyService.Resolve<IFirebaseDBService>();
            UserProfile user;

            if(Name.Equals(null) || Surname.Equals(null) || Email.Equals(null) || Password.Equals(null))
            {
                await App.Current.MainPage.DisplayAlert("Error", "Introduce todos los campos", "OK");
            }
            else
            {
                if (!Utils.Utils.isValidPassword(Password))
                {
                    await App.Current.MainPage.DisplayAlert("Error", "introduce una contraseña válida", "OK");
                    return;
                }
                if (!Utils.Utils.isValidEmail(Email))
                {
                    await App.Current.MainPage.DisplayAlert("Error", "Introduce un email válido", "OK");
                    return;
                }

                var result = await authservice.CreateUser(Email, Password);
                if (result)
                {
                    user = new UserProfile(authservice.GetUserId(), Name, Surname, Email);
                    firestoreDB.SetProfile(user);
                    Application.Current.MainPage = new NavigationPage(new CreateProfilePage());
                }
                else
                {
                    await App.Current.MainPage.DisplayAlert("Error", "Ha ocurrido un problema, intentalo más tarde", "OK");
                }
                
            }
            
            
        }
        #endregion
    }
}