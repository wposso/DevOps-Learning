using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DevOps_Learning.Class
{
    internal class _DataBaseConnectionControl
    {
        private static string connectionString = "server=mydatabase.c9kgs2ucojqe.us-east-2.rds.amazonaws.com; database=Learning_C#; user=admin; password=masterkey";
        private static SqlConnection connectionSQL;

        public static SqlConnection GetConnection() 
        {
            connectionSQL = new SqlConnection(connectionString);
            return connectionSQL;
        }

        public static void OpenConnection() 
        {
            if(connectionSQL.State == System.Data.ConnectionState.Closed) 
            {
                connectionSQL.Open();
            }
        }
        public static void CloseConnection() 
        {
            if(connectionSQL.State == System.Data.ConnectionState.Open) 
            {
                connectionSQL.Close();
            }
        }
    }
}
