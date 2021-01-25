using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = @"Data Source=WIN-50GP30FGO75;Initial Catalog=Demodb;User ID=sa;Password=demol23";
            DatabaseConnection databaseConnection = new DatabaseConnection(connectionString);


            //Get DATA

            //Process DATA

            //Calculate things

            //Send Email
            MailSystem mailSystem = new MailSystem();

        }
    }
}
