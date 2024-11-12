using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DAO
{
    public class SqlConnectionData
    {
        public static SqlConnection Connect()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["YourConnectionStringName"].ConnectionString;
            SqlConnection conn = new SqlConnection(connectionString);
            return conn;
        }
    }
    public class DatabaseAccess
    {
    }
}
