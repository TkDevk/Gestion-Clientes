namespace Gestion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 popUp = new Form2();
            popUp.ShowDialog();
        }
    }
}
