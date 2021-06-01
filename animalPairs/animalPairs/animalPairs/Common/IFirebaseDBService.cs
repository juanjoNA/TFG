using animalPairs.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace animalPairs.Common
{
    public interface IFirebaseDBService
    {
        UserProfile GetProfile(String id);
        
        String SetProfile(UserProfile profile);
        String SetAnimal(Mascota animal);
        void GetMessage();
        void SetMessage(String message);
        String GetMessageKey();
        Mascota GetMascota(String id);
    }
}
