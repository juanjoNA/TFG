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
        private string name;
        private int age;
        private string raza;
        private string description;
        private string type;
        private string gender;
        private string imagePath;
        private string profileId;

        #endregion

        #region Properties


        /// Gets or sets the animal image path.
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

        /// Gets or sets the animal image path.
        public string ImagePath
        {
            get
            {
                return this.imagePath;
            }
            set
            {
                this.imagePath = value;
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

        public string ProfileId
        {
            get
            {
                return this.profileId;
            }
            set
            {
                this.profileId = value;
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

        #region Constructor
        public Mascota() { }

        public Mascota(string name, string raza, string gender, int age, string type, string description, string profileId)
        {
            Name = name;
            Raza = raza;
            Gender = gender;
            Age = age;
            Type = type;
            Description = description;
            ProfileId = profileId;
        }
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