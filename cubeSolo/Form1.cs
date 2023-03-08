namespace cubeSolo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Connexion connexion = new Connexion();
            connexion.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ConnectModifier connexion = new ConnectModifier();
            connexion.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ConnectSupprimer connexion = new ConnectSupprimer();
            connexion.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}