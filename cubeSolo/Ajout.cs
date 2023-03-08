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

namespace cubeSolo
{
    public partial class Ajout : Form
    {
        public Ajout()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ajout ajout = new Ajout();
            ajout.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && comboBox1.Text != "")
            {
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
                APIMethods1.PostUser(user);


                MessageBox.Show("Utilisateur Ajouté");
            }
            else
            {
                MessageBox.Show("Veuillez rentrer tous les champs");
            }
        }
    }
}
