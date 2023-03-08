using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cubeSolo.Models;
using cubeSolo.API;

namespace cubeSolo.API
{
    internal class APIMethods1
    {
        public static bool PostUser(Users user)
        {
            return ApiClient.PostItem<Users>(user, "/Utilisateur");
        }

    }
}
