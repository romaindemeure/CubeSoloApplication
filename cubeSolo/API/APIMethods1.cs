using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cubeSolo.Models;
using cubeSolo.API;

// Nom du namespace est cubeSolo.API
namespace cubeSolo.API
{
    // Class APIMethods1
    internal class APIMethods1
    {
        // Création de PostUser avec comme paramètre user qui est défini dans Models.Users.cs
        public static bool PostUser(Users user)
        {
            // Utilisation de PostItem que nous avons crée dans cubeSolo.Models avec comme paramètre l'utisateur et l'endpoint de l'API
            return ApiClient.PostItem<Users>(user, "/Utilisateur");
        }

    }
}
