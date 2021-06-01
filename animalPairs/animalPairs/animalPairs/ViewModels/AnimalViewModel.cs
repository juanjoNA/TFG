using Syncfusion.XForms.Buttons;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Model = animalPairs.Models.Mascota;

namespace animalPairs.ViewModels
{
    [Preserve(AllMembers = true)]
    class AnimalViewModel : BaseViewModel
    {

        #region Fields

        private Command<object> itemTappedCommand;

        #endregion

        #region Properties

        /// Gets or sets a collction of value to be displayed in animals card page.
        public ObservableCollection<Model> Animals { get; set; }

        /// Gets the command that will be executed when an item is selected.
        public Command<object> ItemTappedCommand
        {
            get
            {
                return this.itemTappedCommand ?? (this.itemTappedCommand = new Command<object>(this.NavigateToAnimalPage));
            }
        }

        #endregion

        #region Constructor

        public AnimalViewModel()
        {

            this.AddLikeCommand = new Command(this.LikeButtonClicked);

            this.Animals = new ObservableCollection<Model>()
            {
                new Model
                {
                    Name = "Zoe",
                    Age = 5,
                    IsLiked = false,
                    Gender = "Macho",
                    Description = "Perro muy sencillo y sociable",
                    Type = "perro",
                    AnimalRace = "labrador",
                    ImagePath= App.BaseImageUrl + "ArticleParallaxHeaderImage.png",
                    FavouritesCount= 0
                },
                new Model
                {
                    Name = "Bobby",
                    Age = 1,
                    IsLiked = false,
                    Gender = "Macho",
                    Description = "Perro pequeño muy cariñoso y bastante inquieto. Es muy obediente.",
                    Type = "perro",
                    AnimalRace = "labrador",
                    ImagePath= App.BaseImageUrl + "ArticleParallaxHeaderImage.png",
                    FavouritesCount= 0
                },
                new Model
                {
                    Name = "Reina",
                    Age = 12,
                    IsLiked = false,
                    Gender = "Hembra",
                    Description = "Yegua rapida de pura sangre perfecta para poder montar y para competiciones.",
                    Type = "caballo",
                    AnimalRace = "arabe",
                    ImagePath= App.BaseImageUrl + "ArticleParallaxHeaderImage.png",
                    FavouritesCount= 0
                },
                new Model
                {
                    Name = "Misifu",
                    Age = 8,
                    IsLiked = false,
                    Gender = "Macho",
                    Description = "Gato pequines joven. Muy bien cuidado, alimentado y con revisiones de todo recien pasadas.",
                    Type = "gato",
                    AnimalRace = "persa",
                    ImagePath= App.BaseImageUrl + "ArticleParallaxHeaderImage.png",
                    FavouritesCount= 0
                },
                new Model
                {
                    Name = "Red",
                    Age = 16,
                    IsLiked = false,
                    Gender = "Hembra",
                    Description = "Loro gris de cola roja. Habla mucho y es capaz de imitar cualquier tipo de ruido. Es poco sociable con las mujeres pero muy cariñoso con todos los hombres. Muy inteligente y con un poco de dedicacion puede aprender cualquier cosa.",
                    Type = "pajaro",
                    AnimalRace = "yaco",
                    ImagePath= App.BaseImageUrl + "ArticleParallaxHeaderImage.png",
                    FavouritesCount= 0
                },
            };
        }

        #endregion

        #region Methods

        /// <summary>
        /// Invoked when an item is selected from the articles card list page.
        /// </summary>
        /// <param name="selectedItem">Selected item from the list view.</param>
        private void NavigateToAnimalPage(object obj)
        {
            // Do something
        }

        /// <summary>
        /// Invoked when the favourite button clicked
        /// </summary>
        /// <param name="obj">The object</param>
        private void LikeButtonClicked(object obj)
        {
            if (obj != null && (obj is Model))
            {
                (obj as Model).IsLiked = (obj as Model).IsLiked ? false : true;
            }
            else
            {
                var button = obj as SfButton;
                if (button != null)
                {
                    button.Text = (button.Text == "\ue701") ? "\ue732" : "\ue701";
                }
            }
        }

        #endregion

        #region commands

        /// <summary>
        /// Gets or sets the command is executed when the favourite button is clicked.
        /// </summary>
        public Command AddLikeCommand { get; set; }

        #endregion
    }
}
