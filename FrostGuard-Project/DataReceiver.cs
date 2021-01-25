using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrostGuard_Project
{
    class DataReceiver
    {
        public void receiveData()
        {
            string connectionString = @"Data Source=WIN-50GP30FGO75;Initial Catalog=Demodb;User ID=sa;Password=demol23";
            DatabaseConnection databaseConnection = new DatabaseConnection(connectionString);
        }
    }
}
