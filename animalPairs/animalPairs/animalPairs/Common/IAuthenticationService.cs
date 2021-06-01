using animalPairs.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace animalPairs.Common
{
    public interface IAuthenticationService
    {

        Task<string> LoginWithEmailAndPassword(string email, string password);
        Task<bool> CreateUser(string email, string password);
        bool LogOut();
        bool IsSignIn();
        String getAuthKey();
        String GetUserId();
    }
}
