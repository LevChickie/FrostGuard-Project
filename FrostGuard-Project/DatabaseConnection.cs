using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrostGuard_Project
{
    class DatabaseConnection
    {
        private string connectionString;
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataReader dataReader;

        public DatabaseConnection(string connectionString)
        {
            this.connectionString = connectionString;

        }

        public void Connect()
        {
            this.connection = new SqlConnection(this.connectionString);
            this.connection.Open();
            //MessageBox.Show("Connection opened");
        }

        public void Disconnect()
        {
            this.connection.Close();
        }

        public void ExecuteCommand(string command)
        {
            this.command = new SqlCommand(command, connection);
            this.dataReader = this.command.ExecuteReader();
        }


    }
}
