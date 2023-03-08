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
    public partial class ConnectModifier : Form
    {
        public ConnectModifier()
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
                Modifier modifier = new Modifier();
                modifier.Show();
            }
            else
            {
                MessageBox.Show("Mot de passe incorrect");
            }
        }
    }
}
