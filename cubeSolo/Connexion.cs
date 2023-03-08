using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace cubeSolo
{
    public partial class Connexion : Form
    {
        Hashtable tablemdp = new Hashtable();
        public Connexion()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string correctMdp = "123";
            string mdp = this.tbmdp.Text;

            if (correctMdp == mdp)
            {
                this.Hide();
                Ajout ajout = new Ajout();
                ajout.Show();
            }
            else
            {
                MessageBox.Show("Mot de passe incorrect");
            }
        }
    }
}
