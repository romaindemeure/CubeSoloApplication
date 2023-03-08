using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cubeSolo.Models
{
    // classe Users utilisée pour représenter des utilisateurs
    public class Users
    {
        // nom est décorée avec [JsonProperty("nom")] donc l'objet nom est sérialisé en JSON
        [JsonProperty("nom")]

        // définition de propriété C# pour la classe Users. Cette propriété représente le nom de l'utilisateur
        public string? nom { get; set; }

        [JsonProperty("prenom")]
        public string? prenom { get; set; }

        [JsonProperty("telephone_Fix_Utilisateur")]
        public string? telephone_Fix_Utilisateur { get; set; }

        [JsonProperty("telephone_Portable_Utilisateur")]
        public string? telephone_Portable_Utilisateur { get; set; }

        [JsonProperty("email")]
        public string? email { get; set; }

        [JsonProperty("service")]
        public string? service { get; set; }

        [JsonProperty("site")]
        public string? site { get; set; }

    }
}
