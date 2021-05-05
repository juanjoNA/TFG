using Foundation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UIKit;
using animalPairs.Common;
using Firebase.Auth;
using System.Threading.Tasks;
using System.Threading;
using animalPairs.iOS;

[assembly: Xamarin.Forms.Dependency(typeof(FirebaseAuthentication))]

namespace animalPairs.iOS
{
    class FirebaseAuthentication : IAuthenticationService
    {
        public static String KEY_AUTH = "auth";

        public async Task<bool> CreateUser(string email, string password)
        {
            try
            {
                var authResult = Auth.DefaultInstance.CreateUserAsync(email, password);
                return await Task.FromResult(true);
            } 
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return await Task.FromResult(false);
            }
        }

        public string getAuthKey()
        {
            return KEY_AUTH;
        }

        public string GetUserId()
        {
            throw new NotImplementedException();
        }

        public bool IsSignIn()
        {
            var user = Auth.DefaultInstance.CurrentUser;
            return user != null;
        }

        public async Task<string> LoginWithEmailAndPassword(string email, string password)
        {
            var user = await Auth.DefaultInstance.SignInWithPasswordAsync(email, password);
            return await user.User.GetIdTokenAsync();
        }

        public bool LogOut()
        {
            try
            {
                _ = Auth.DefaultInstance.SignOut(out NSError error);
                return error == null;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}