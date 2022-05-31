using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bicycle_store_system.Models
{
    public static class dbHelper
    {
        public static DataTable ExecuteQuery(string query)
        {
            SqlConnection connection = null;
            try
            {
                string conString = "Server=DESKTOP-L5UNA6D;Database=DbDemo;Trusted_Connection=True;";
                connection = new SqlConnection(conString);
                connection.Open();
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataAdapter sqlCommand = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    sqlCommand.Fill(dt);
                    return dt;
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public static int ExecuteNonQuery(string query)
        {
            SqlConnection connection = null;
            try
            {
                string conString = "Server=DESKTOP-L5UNA6D;Database=DbDemo;Trusted_Connection=True;";
                connection = new SqlConnection(conString);
                connection.Open();
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    SqlCommand sqlCommand = new SqlCommand(query, connection);
                    return sqlCommand.ExecuteNonQuery();
                }
                else
                {
                    throw new Exception("Error");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error:"+ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }


    }
}





