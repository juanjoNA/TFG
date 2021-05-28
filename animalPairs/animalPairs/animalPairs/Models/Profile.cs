using System.Runtime.Serialization;
using Xamarin.Forms.Internals;

namespace animalPairs.Models
{
    /// <summary>
    /// Model for SocialProfile
    /// </summary>
    [Preserve(AllMembers = true)]
    public class UserProfile
    {
        #region Fields

        private string id;
        private string email;
        private string name;
        private string surname;
        private string imagePath;
        private string animalId;

        #endregion

        #region Properties

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
        public string AnimalId
        {
            get { return animalId; }
            set { this.animalId = value; }
        }

        public string ImagePath
        {
            get { return App.BaseImageUrl + this.imagePath; }
            set { this.imagePath = value; }
        }
        public string Id
        {
            get { return id; }
            set { this.id = value; }
        }

        #endregion

        #region Constructors
        public UserProfile(string id, string name, string surname, string email)
        {
            Id = id;
            Name = name;
            Surname = surname;
            Email = email;
        }

        public UserProfile()
        {

        }
        #endregion
        #region Methods

        #endregion
    }
}