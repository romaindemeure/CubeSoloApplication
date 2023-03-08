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
    public partial class ConnectSupprimer : Form
    {
        public ConnectSupprimer()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string correctMdp = "123";
            string mdp = this.tbmdp.Text;

            if (correctMdp == mdp)
            {
                this.Hide();
                MessageBox.Show("Utilisateur supprimé");
            }
            else
            {
                MessageBox.Show("Mot de passe incorrect");
            }
        }
    }
}
