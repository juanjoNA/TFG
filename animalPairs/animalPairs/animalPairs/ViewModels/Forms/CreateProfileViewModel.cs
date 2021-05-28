using animalPairs.Common;
using animalPairs.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace animalPairs.ViewModels.Forms
{
    [Preserve(AllMembers = true)]
    public class CreateProfileViewModel : BaseViewModel
    {

        #region Fields
        private string ;

        #endregion

        #region Property

        /// <summary>
        /// Gets or sets the property that bounds with an entry that gets the name from user in the Sign Up page.
        /// </summary>
        public UserProfile Profile
        {
            get
            {
                return this.profile;
            }

            set
            {
                if (this.profile == value)
                {
                    return;
                }

                this.profile = value;
                this.NotifyPropertyChanged();
            }
        }
        public Mascota Animal
        {
            get
            {
                return this.animal;
            }

            set
            {
                if (this.animal == value)
                {
                    return;
                }

                this.animal = value;
                this.NotifyPropertyChanged();
            }
        }
        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance for the <see cref="CreateProfileViewModel" /> class.
        /// </summary>
        public CreateProfileViewModel()
        {
            this.ContinueCommand = new Command(this.ContinueClicked);
            animal = new Mascota();
        }
        #endregion

        #region Command

        /// <summary>
        /// Gets or sets the command that is executed when the Continue button is clicked.
        /// </summary>
        public Command ContinueCommand { get; set; }

        #endregion

        #region methods
        private async void ContinueClicked(object obj)
        {
            var firebaseDB = DependencyService.Resolve<IFirebaseDBService>();
            var errores = isValidToContinue();
            if (errores.Count > 0) 
            {
                string error = "Por favor introduzca los campos siguientes para continuar:\n\n";
                foreach (string item in errores)
                {
                    error += "\t- " + item + ".\n";
                }
                await App.Current.MainPage.DisplayAlert("Error", error, "OK");
                return;
            }
            firebaseDB.SetProfile(Profile);
            Animal.ProfileId = Profile.Email;
            firebaseDB.SetAnimal(Animal);
        }

        private List<string> isValidToContinue()
        {
            List<string> errores = new List<string>();
            if (Profile.Name == null) errores.Add("Nombre del usuario");
            if (Profile.Surname == null) errores.Add("Apellido del usuario");
            if (Animal.Name == null) errores.Add("Nombre del Animal");
            if (Animal.Age == 0) errores.Add("Edad de la mascota");
            if (Animal.Type == null) errores.Add("Tipo de mascota");
            if (Animal.Description == null) errores.Add("Descripción de la mascota");
            if (Animal.AnimalRace == null) errores.Add("Raza de la mascota");
            if (Animal.Gender == null) errores.Add("Género de la mascota");

            return errores;
        }
        #endregion
    }
}
