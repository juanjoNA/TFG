using animalPairs.Common;
using animalPairs.Models;
using animalPairs.Views.Navigation;
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
        private string name;
        private int age;
        private string raza;
        private string description;
        private string type;
        private string gender;

        #endregion

        #region Property

        /// <summary>
        /// Gets or sets the property that bounds with an entry that gets the name from user in the Sign Up page.
        /// </summary>
        public string Gender
        {
            get
            {
                return this.gender;
            }
            set
            {
                this.gender = value;
                this.NotifyPropertyChanged();
            }
        }

        public string Raza
        {
            get
            {
                return this.raza;
            }
            set
            {
                this.raza = value;
                this.NotifyPropertyChanged();
            }
        }

        /// Gets or sets the animal name.
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
                this.NotifyPropertyChanged();
            }
        }

        /// Gets or sets the animal author name.
        public string Type
        {
            get
            {
                return this.type;
            }
            set
            {
                this.type = value;
                this.NotifyPropertyChanged();
            }
        }

        /// Gets or sets the animal description
        public string Description
        {
            get
            {
                return this.description;
            }
            set
            {
                this.description = value;
                this.NotifyPropertyChanged();
            }
        }

        /// Gets or sets the animal age.
        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                this.age = value;
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
            var authentication = DependencyService.Resolve<IAuthenticationService>(); 
            var errores = isValidToContinue();
            Mascota animal;
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
            animal = new Mascota(Name, Raza, Gender, Age, Type, Description, authentication.GetUserId());
            firebaseDB.SetAnimal(animal);
            Application.Current.MainPage = new NavigationPage(new BottomNavigationPage());
        }

        private List<string> isValidToContinue()
        {
            List<string> errores = new List<string>();
            if (Name == null) errores.Add("Nombre del Animal");
            if (Age == 0) errores.Add("Edad de la mascota");
            if (Type == null) errores.Add("Tipo de mascota");
            if (Description == null) errores.Add("Descripción de la mascota");
            if (Raza == null) errores.Add("Raza de la mascota");
            if (Gender == null) errores.Add("Género de la mascota");

            return errores;
        }
        #endregion
    }
}
