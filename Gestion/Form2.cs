using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Name = textName.Text;
            cliente.LastName = textLastName.Text;
            cliente.Email = textEmail.Text;
            cliente.NumCel = textPhone.Text;

            listClients.Items.Add(cliente);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            int indice = listClients.SelectedIndex;
            listClients.Items.RemoveAt(indice);
        }
    }
}
