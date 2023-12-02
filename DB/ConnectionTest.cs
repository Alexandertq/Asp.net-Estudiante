using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
    public class ConnectionTest
    {
        public static void Main(string[] args)
        {
            using (SqlConnection sqlConn = new SqlConnection(ConnectionDB.SQLServer()))
            {
                sqlConn.Open();
                Console.WriteLine("Conexión... OK");
                sqlConn.Close();
            }
            Console.ReadLine();
        }
    }
}
