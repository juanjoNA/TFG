using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using animalPairs.Common;
using animalPairs.Droid;
using animalPairs.Models;
using Firebase.Firestore;
using Java.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

[assembly: Xamarin.Forms.Dependency(typeof(FirebaseDBService))]

namespace animalPairs.Droid
{
    class FirebaseDBService : IFirebaseDBService
    {
        public Mascota GetMascota(string id)
        {
            throw new NotImplementedException();
        }

        public void GetMessage()
        {
            throw new NotImplementedException();
        }

        public string GetMessageKey()
        {
            throw new NotImplementedException();
        }

        public UserProfile GetProfile(String id)
        {
            UserProfile p = new UserProfile();
            DocumentReference docRef = FirebaseFirestore.Instance.Collection("profiles").Document(id);

            return p;
        }

        public string SetAnimal(Mascota animal)
        {
            HashMap animalInfo = new HashMap();
            animalInfo.Put("name", animal.Name);
            animalInfo.Put("type", animal.Type);

            animal.Raza = animal.Raza.ToLower();
            animalInfo.Put("raza", animal.Raza);

            animalInfo.Put("age", animal.Age);
            animalInfo.Put("description", animal.Description);
            animalInfo.Put("profileId", animal.ProfileId);
            animalInfo.Put("likes", new ArrayList());

            DocumentReference docRef = FirebaseFirestore.Instance.Collection("animals").Document();
            docRef.Set(animalInfo);
            return docRef.Id;
        }

        public void SetMessage(string message)
        {
            throw new NotImplementedException();
        }

        public string SetProfile(UserProfile profile)
        {
            HashMap profileInfo = new HashMap();
            profileInfo.Put("name", profile.Name);
            profileInfo.Put("surname", profile.Surname);
            profileInfo.Put("email", profile.Email);

            DocumentReference docRef = MainActivity.database.Collection("profiles").Document(profile.Id);
            docRef.Set(profileInfo);
            return docRef.Id;
        }
    }
}