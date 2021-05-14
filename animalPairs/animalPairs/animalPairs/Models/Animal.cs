using animalPairs.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace animalPairs.Models
{
    class Animal : BaseViewModel
    {
        #region Fields

        /// Gets or sets a value indicating whether the article is favourite.
        private bool isLiked;

        #endregion

        #region Public Properties


        /// Gets or sets the animal image path.
        public Gender Gender { get; set; }

        /// Gets or sets the animal image path.
        public string ImagePath { get; set; }

        /// Gets or sets the animal name.
        public string Name { get; set; }

        /// Gets or sets the animal author name.
        public string Type { get; set; }

        /// Gets or sets the animal description
        public string Description { get; set; }

        /// Gets or sets a value indicating whether the article is favourite.
        public bool IsLiked
        {
            get
            {
                return this.isLiked;
            }

            set
            {
                this.isLiked = value;
                this.NotifyPropertyChanged();
            }
        }

        /// Gets or sets the favourite count.
        public int FavouritesCount { get; set; }

        /// Gets or sets the animal age.
        public int Age { get; internal set; }

        /// Gets animal Name and age with specific format.
        public string NameAndAge
        {
            get
            {
                return string.Format("{0} , {1}", Name, Age);
            }
        }

        #endregion
    }

    public enum Gender
    {
        Hembra,
        Macho
    }
}