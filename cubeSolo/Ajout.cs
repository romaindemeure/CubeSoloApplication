// Importation de cubeSolo.API et cubeSolo.Models pour pouvoir être utilisé
using cubeSolo.API;
using cubeSolo.Models;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Nom du namespace est cubeSolo
namespace cubeSolo
{
    // Class Ajout qui hérite de Form
    public partial class Ajout : Form
    {
        // Method constructeur Nomé Ajout
        public Ajout()
        {
            InitializeComponent();
        }

        // Vérification de la saisi utilisateur et Utilisation de l'API pour faire un POST
        private void button1_Click(object sender, EventArgs e)
        {
            // Vérification de la saisi utilisateur
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && comboBox1.Text != "")
            {
                // Utilisation du Models Users et création d'un objet pour envoyer a l'API
                Users user = new Users
                {
                    nom = textBox1.Text,
                    prenom = textBox2.Text,
                    telephone_Fix_Utilisateur = textBox3.Text,
                    telephone_Portable_Utilisateur = textBox4.Text,
                    email = textBox5.Text,
                    service = textBox6.Text,
                    site = comboBox1.Text,
                };
                // Utilisation de APIMethods1 pour Post un Utilisateur. Envoyer l'object en paramètre
                APIMethods1.PostUser(user);

                // Affichier un message si l'Ajout a fonctionné
                MessageBox.Show("Utilisateur Ajouté");
            }
            else
            {
                // Afficher un message si l'ajout n'a pas fonctionné
                MessageBox.Show("Veuillez rentrer tous les champs");
            }
        }
    }
}
