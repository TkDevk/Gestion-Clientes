using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gestion.dao;
using Gestion.models;
using MySqlX.XDevAPI;
using Org.BouncyCastle.Asn1.Ocsp;

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
            updateList();
        }

        private void updateList()
        {
            ClienteDao dataBase = new ClienteDao();
            // bind to a list

            List<Cliente> listDb = dataBase.ClientList();

            listClients.Items.Clear();

            for (int i = 0; i < listDb.Count; i++)
            {
                Cliente cliente = listDb[i];
                listClients.Items.Add(cliente);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Name = textName.Text;
            cliente.LastName = textLastName.Text;
            cliente.Email = textEmail.Text;
            cliente.NumCel = textPhone.Text;

            if (labelId.Text != "")
            {
                cliente.Id = Convert.ToInt32(labelId.Text);
            }


            ClienteDao db = new ClienteDao();
            db.Save(cliente);
            updateList();

            labelId.Text = "";
            textName.Text = "";
            textLastName.Text = "";
            textEmail.Text = "";
            textPhone.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Casting to indicate that it's a client
            Cliente cliente = (Cliente)listClients.SelectedItem;
            ClienteDao db = new ClienteDao();

            db.Delete(cliente);
            updateList();

            //listClients.Items.RemoveAt(indice);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Cliente cliente = (Cliente)listClients.SelectedItem;
            textName.Text = cliente.Name;
            textLastName.Text = cliente.LastName;
            textEmail.Text = cliente.Email;
            textPhone.Text = cliente.NumCel;

            labelId.Text = $"{cliente.Id}";
        }
    }
}
