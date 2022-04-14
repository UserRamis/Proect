using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Project
{
    class Database
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-AJR95T9\SQLEXPRESS; Initial Catalog=Hospital;Integrated Security=true ");

        public void openconnection()
        {
            if(sqlConnection.State==System.Data.ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
        }

        public void closeconnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }

        public SqlConnection getconnection()
        {
            return sqlConnection;
        }

    }
}
