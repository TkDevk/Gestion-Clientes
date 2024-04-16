using Gestion.models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion.dao
{
    internal class ClienteDao
    {
        public MySqlConnection Connect()
        {
            //server
            string server = "localhost";
            string user = "root";
            string password = "";
            string dataBase = "clientes";
            //String that allows connection
            string stringConection = "Database=" + dataBase + "; Data Source="
                + server + "; User Id=" + user + "; Password=" + password + "";

            //Connect to Database

            //Pass the required values through the param to enable the connection to the db
            MySqlConnection connectionDb = new MySqlConnection(stringConection);
            //Open connection
            connectionDb.Open();

            return connectionDb;


        }
        // return list's client
        public List<Cliente> ClientList()
        {
            List<Cliente> list = new List<Cliente>();

            //Test with a request
            // Also, i will create a new command for db and i need to pass the string request to this command

            string request = "SELECT * FROM `clientes`";
            MySqlCommand command = new MySqlCommand(request);

            //Finally, i pass the connection to my db (Connection is diff, is a word's library)
            command.Connection = Connect();

            // A new instance's class to read the data

            MySqlDataReader readerDb = command.ExecuteReader();

            //command.ExecuteReader() returns a sql object

            //Handle the incoming data

        
            while (readerDb.Read())
            {
                Cliente cliente = new Cliente();
                //GetInt32 and GetString retrieve values from the data reader
                cliente.Id = readerDb.GetInt32(0);
                cliente.Name = readerDb.GetString("name");
                cliente.LastName = readerDb.GetString("last_name");
                cliente.Email = readerDb.GetString("email");
                cliente.NumCel = readerDb.GetString("phone");
                list.Add(cliente);
            }
            command.Connection.Close();

            return list;
        }


        public void Save(Cliente cliente)
        {
            if (cliente.Id==null)
            {
                insert(cliente);
            }
            else
            {
                update(cliente);
            }
        }

        private void insert(Cliente cliente)
        {
            string request = "INSERT INTO `clientes` (`id`, `name`, `last_name`, `email`, `phone`) VALUES (NULL, '" + cliente.Name + "', '" + cliente.LastName + "', '" + cliente.Email + "', '" + cliente.NumCel + "');";
            MySqlCommand command = new MySqlCommand(request);
            command.Connection = Connect();
            command.ExecuteNonQuery();

            command.Connection.Close();
        }

        private void update(Cliente cliente)
        {
            string request = "UPDATE `clientes` SET `name` = '" + cliente.Name + "', `last_name` = '" + cliente.LastName + "', `email` = '" + cliente.Email + "', `phone` = '" + cliente.NumCel + "' WHERE `clientes`.`id` = "+cliente.Id+";";
            MySqlCommand command = new MySqlCommand(request);
            command.Connection = Connect();
            command.ExecuteNonQuery();

            command.Connection.Close();
        }

        public void Delete(Cliente? cliente)
        {
            string request = "DELETE FROM `clientes` WHERE `clientes`.`id` = "+cliente.Id+";";
            MySqlCommand command = new MySqlCommand(request);
            command.Connection = Connect();
            command.ExecuteNonQuery();

            command.Connection.Close();
        }
    }
}
