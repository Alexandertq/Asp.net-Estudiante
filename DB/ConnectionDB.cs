using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
    public class ConnectionDB
    {
        public static string SQLServer()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();

            //servidor
            builder.DataSource = "DESKTOP-HJBN8HQ";

            //Base de datos
            builder.InitialCatalog = "Db_Family";

            //Username
            builder.UserID = "sa";

            //password
            builder.Password = "12345678";

            return builder.ToString();
        }
    }
}
