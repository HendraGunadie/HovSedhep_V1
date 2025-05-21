using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HovSedhep_V1
{
    internal class connection
    {

        string connString = "Server=MSI; Database=HovSedhepDatabase; Integrated Security=True";
        SqlConnection conn;

        public SqlConnection getConnection()
        {
            return conn;
        }

        public void openConnection()
        {
            conn = new SqlConnection(connString);
            conn.Open();
        }

        public void closeConnection()
        {
            conn.Close();
        }
    }
}
