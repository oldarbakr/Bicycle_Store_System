using Bicycle_store_system.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bicycle_store_system.Model
{
    class Report
    {
        private int reportID;
        private string reportDate;
        private string reportText;
        private int specialOfferID;
        private int clientID;

        public Report() 
        {
        }

        public Report(int reportID, string reportDate, string reportText, int specialOfferID, int clientID)
        {
            this.reportID = reportID;
            this.reportDate = reportDate;
            this.reportText = reportText;
            this.specialOfferID = specialOfferID;
            this.clientID = clientID;
        }

        public int ReportID { get => reportID; set => reportID = value; }
        public string ReportDate { get => reportDate; set => reportDate = value; }
        public string ReportText { get => reportText; set => reportText = value; }
        public int SpecialOfferID { get => specialOfferID; set => specialOfferID = value; }
        public int ClientID { get => clientID; set => clientID = value; }

        public int AddReport(Report report)
        {
            try
            {
                string query = $"INSERT INTO Report(ReportDate,ReportText,SpecialOfferID,ClientID) VALUES ('{report.ReportDate}','{report.ReportText}','{report.SpecialOfferID}','{report.ClientID}')";
                return dbHelper.ExecuteNonQuery(query);
            }
            catch (Exception)
            {
                throw new Exception("Not able to add Report");
            }

        }
        public int DeleteReport(int report)
        {
            try
            {
                string query = $"delete Report where ReportID = {report}";
                return dbHelper.ExecuteNonQuery(query);
            }
            catch (Exception)
            {
                throw new Exception("Not able to delete Report");
            }

        }
        public int UpdateReport(int reportID, string reportDate, string reportText, int specialOfferID, int clientID)
        {
            try
            {
                string query = $"update Report set ReportDate = '{reportDate}',ReportText = '{reportText}',SpecialOfferID = '{specialOfferID}',ClientID = '{clientID}' where ReportID ={reportID}";
                return dbHelper.ExecuteNonQuery(query);
            }
            catch (Exception)
            {
                throw new Exception("Not able to Update Report");
            }

        }
        public DataTable SearchReport(int report)
        {
            try
            {
                string query = $"SELECT * FROM Report WHERE ReportID LIKE '%{report}%'";
                return dbHelper.ExecuteQuery(query);
            }
            catch (Exception)
            {
                throw new Exception("Not able to Search Report data");
            }
        }
        public DataTable ViewReport()
        {
            try
            {
                string query = $"select * from Report";
                return dbHelper.ExecuteQuery(query);
            }
            catch (Exception)
            {
                throw new Exception("Not able to View Report data");
            }
        }
        public DataTable cdSpecialOfferID()
        {
            try
            {
                string query = $"SELECT [SpecialOfferID] From [Special offer]";
                return dbHelper.ExecuteQuery(query);
            }
            catch (Exception)
            {
                throw new Exception("Not able to load SpecialOfferID informations");
            }
        }
        public DataTable cdClientID()
        {
            try
            {
                string query = $"SELECT [ClientID] From [Client]";
                return dbHelper.ExecuteQuery(query);
            }
            catch (Exception)
            {
                throw new Exception("Not able to load Client informations");
            }
        }
    }
}
