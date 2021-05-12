﻿using animalPairs.Common;
using animalPairs.Views.Chat;
using animalPairs.Views.Forms;
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

        private string password;

        private string confirmPassword;

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

        /// <summary>
        /// Gets or sets the property that bounds with an entry that gets the name from user in the Sign Up page.
        /// </summary>
        public string ConfirmPassword
        {
            get
            {
                return this.confirmPassword;
            }

            set
            {
                if (this.confirmPassword == value)
                {
                    return;
                }

                this.confirmPassword = value;
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
            var authService = DependencyService.Resolve<IAuthenticationService>();
            if(validatePassword(Password, ConfirmPassword))
            {
                if(await authService.CreateUser(Email, Password))
                {
                    await Shell.Current.GoToAsync(nameof(ChatMessagePage));
                }
                else
                {
                    Console.WriteLine("Something was grong");
                }
            }
            else
            {
                Console.WriteLine("Password is not correct");
            }
        }

        private bool validatePassword(string password, string confirmPassword)
        {
            bool result = true;

            return result;
        }
        #endregion
    }
}