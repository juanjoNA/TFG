using animalPairs.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace animalPairs.Models
{
    public class Mascota : BaseViewModel
    {
        #region Fields

        /// Gets or sets a value indicating whether the article is favourite.
        private bool isLiked;
        private List<string> likes;

        #endregion

        #region Public Properties


        /// Gets or sets the animal image path.
        public string Gender { get; set; }

        /// Gets or sets the animal image path.
        public string ImagePath { get; set; }

        /// Gets or sets the animal name.
        public string Name { get; set; }

        /// Gets or sets the animal author name.
        public string Type { get; set; }

        /// Gets or sets the animal description
        public string Description { get; set; }

        /// Gets or sets the profileId asociate to animal
        public string ProfileId { get; set; }

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
        public int Age { get; set; }

        /// Gets animal Name and age with specific format.
        public string NameAndAge
        {
            get
            {
                return string.Format("{0} , {1}", Name, Age);
            }
        }

        public string AnimalRace { get; set; }
        #endregion

        #region Methods
        public List<string> GetLikes()
        {
            return this.likes;
        }

        public void AddLike(string id)
        {
            this.likes.Add(id);
            this.NotifyPropertyChanged();
        }

        public void RemoveLike(string id)
        {
            this.likes.Remove(id);
            this.NotifyPropertyChanged();
        }

        #endregion

    }
}