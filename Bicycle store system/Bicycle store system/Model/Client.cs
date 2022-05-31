using Bicycle_store_system.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bicycle_store_system.Model
{
    public class Client
    {
        private int clientID;
        private string clientFullName;
        private string clientBirthDay;
        private string clientGander;
        private string clientCellphone;
        private string clientEmail;
        private string clientPassword;

        public Client()
        {
        }

        public Client(int clientID, string clientFullName, string clientBirthDay, string clientGander,
          string clientCellphone, string clientEmail, string clientPassword)
        {
            this.clientID = clientID;
            this.clientFullName = clientFullName;
            this.clientBirthDay = clientBirthDay;
            this.clientGander = clientGander;
            this.clientCellphone = clientCellphone;
            this.clientEmail = clientEmail;
            this.clientPassword = clientPassword;
        }

        public int ClientID { get => clientID; set => clientID = value; }
        public string ClientFullName { get => clientFullName; set => clientFullName = value; }
        public string ClientBirthDay { get => clientBirthDay; set => clientBirthDay = value; }
        public string ClientGander { get => clientGander; set => clientGander = value; }
        public string ClientCellphone { get => clientCellphone; set => clientCellphone = value; }
        public string ClientEmail { get => clientEmail; set => clientEmail = value; }
        public string ClientPassword { get => clientPassword; set => clientPassword = value; }

        public int AddClient(Client client)
        {
            try
            {
                string query = $"INSERT INTO Client(ClientFullName,ClientBirthDay,ClientGander,ClientCellphone,ClientEmail,ClientPassword) VALUES ('{client.clientFullName}','{client.ClientBirthDay}','{client.ClientGander}','{client.clientCellphone}','{client.ClientEmail}','{client.ClientPassword}')";
                return dbHelper.ExecuteNonQuery(query);
            }
            catch (Exception)
            {

                throw new Exception("Not able to add Client");
            }

        }
        public int UpdateClient(int clientID, string clientFullName, string clientBirthDay, string clientGander, string clientCellphone, string clientEmail, string clientPassword)
        {
            try
            {
                string query = $"update Client set ClientFullName = '{clientFullName}',ClientBirthDay = '{clientBirthDay}',ClientGander = '{clientGander}',ClientCellphone = '{clientCellphone}',ClientEmail = '{clientEmail}',ClientPassword = '{clientPassword}' where ClientID ={clientID}";
                return dbHelper.ExecuteNonQuery(query);
            }
            catch (Exception)
            {
                throw new Exception("Not able to Update Client");
            }

        }
        public int DeleteClient(int client)
        {
            try
            {
                string query = $"delete Client where ClientID = {client}";
                return dbHelper.ExecuteNonQuery(query);
            }
            catch (Exception)
            {
                throw new Exception("Not able to delete Client");
            }

        }
        public DataTable SearchClient(string client)
        {
            try
            {
                string query = $"SELECT * FROM Client WHERE ClientID LIKE '%{client}%'";
                return dbHelper.ExecuteQuery(query);
            }
            catch (Exception)
            {
                throw new Exception("Not able to Search Client data");
            }
        }
        public DataTable ViewClient()
        {
            try
            {
                string query = $"select * from Client";
                return dbHelper.ExecuteQuery(query);
            }
            catch (Exception)
            {
                throw new Exception("Not able to View Client data");
            }
        }
        public Client ClientLogin(string email, string password)
        {
            try
            {
                string query = $"select * from Client where ClientEmail ='{email}' AND ClientPassword='{password}'";
                DataTable dt = dbHelper.ExecuteQuery(query);

                if (dt.Rows.Count > 0)
                {
                    Client client = new Client();
                    client.ClientID = int.Parse(dt.Rows[0]["ClientID"].ToString());
                    client.ClientFullName = dt.Rows[0]["ClientFullName"].ToString();
                    client.ClientEmail = dt.Rows[0]["ClientEmail"].ToString();
                    return client;
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception("Error in Login:"+ex);
            }
        }
    }
}
