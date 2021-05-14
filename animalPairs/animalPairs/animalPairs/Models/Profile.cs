using System.Runtime.Serialization;
using Xamarin.Forms.Internals;

namespace animalPairs.Models
{
    /// <summary>
    /// Model for SocialProfile
    /// </summary>
    [Preserve(AllMembers = true)]
    public class Profile
    {
        #region Fields

        private string userId;
        private string email;
        private string name;
        private string surname;
        private string imagePath;

        #endregion

        #region Properties

        public string UserID
        {
            get { return userId; }
            set { this.userId = value; }
        }
        public string Email
        {
            get { return email; }
            set { this.email = value; }
        }
        public string Name
        {
            get { return name; }
            set { this.name = value; }
        }
        public string Surname
        {
            get { return surname; }
            set { this.surname = value; }
        }

        public string ImagePath
        {
            get { return App.BaseImageUrl + this.imagePath; }
            set { this.imagePath = value; }
        }

        #endregion

        #region Methods

        #endregion
    }
}