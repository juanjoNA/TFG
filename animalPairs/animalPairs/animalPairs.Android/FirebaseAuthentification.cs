using Android.Gms.Extensions;
using animalPairs.Common;
using animalPairs.Droid;
using Firebase.Auth;
using System;
using System.Threading.Tasks;

[assembly: Xamarin.Forms.Dependency(typeof(FirebaseAuthentication))]

namespace animalPairs.Droid
{
    class FirebaseAuthentication : IAuthenticationService
    {
        public static int REQ_AUTH = 9999;
        public static String KEY_AUTH = "auth";

        public async Task<bool> CreateUser(string email, string password)
        {
            try
            {
                await FirebaseAuth.Instance.CreateUserWithEmailAndPasswordAsync(email, password);

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public string getAuthKey()
        {
            return KEY_AUTH;
        }

        public string GetUserId()
        {
            var user = FirebaseAuth.Instance.CurrentUser;
            return user.Uid;
        }

        public bool IsSignIn()
        {
            var currentUser = FirebaseAuth.Instance.CurrentUser;
            return currentUser != null;
        }

        public async Task<string> LoginWithEmailAndPassword(string email, string password)
        {
            try
            {
                var user = await Firebase.Auth.FirebaseAuth.Instance.SignInWithEmailAndPasswordAsync(email, password);
                var token = await user.User.GetIdToken(false);
                return (string)token;
            }
            catch (FirebaseAuthInvalidUserException e)
            {
                e.PrintStackTrace();
                return string.Empty;
            }
            catch (FirebaseAuthInvalidCredentialsException e)
            {
                e.PrintStackTrace();
                return string.Empty;
            }
        }

        public bool LogOut()
        {
            try
            {
                Firebase.Auth.FirebaseAuth.Instance.SignOut();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}