using Bicycle_store_system.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bicycle_store_system.Model
{
    class Bicycle
    {
        private int bicycleID;
        private string bicycleModel;
        private string bicycleColor;
        private string bicyclePrice;
        private int sectionID;
        private int specialOfferID;

        public Bicycle()
        {
        }

        public Bicycle(int bicycleID, string bicycleModel, string bicycleColor,
            string bicyclePrice, int sectionID, int specialOfferID)
        {
            this.BicycleID = bicycleID;
            this.BicycleModel = bicycleModel;
            this.BicycleColor = bicycleColor;
            this.BicyclePrice = bicyclePrice;
            this.SectionID = sectionID;
            this.SpecialOfferID = specialOfferID;
        }

        public int BicycleID { get => bicycleID; set => bicycleID = value; }
        public string BicycleModel { get => bicycleModel; set => bicycleModel = value; }
        public string BicycleColor { get => bicycleColor; set => bicycleColor = value; }
        public string BicyclePrice { get => bicyclePrice; set => bicyclePrice = value; }
        public int SectionID { get => sectionID; set => sectionID = value; }
        public int SpecialOfferID { get => specialOfferID; set => specialOfferID = value; }

        public int AddBicycle(Bicycle bicycle)
        {
            try
            {
                string query = $"INSERT INTO Bicycle(BicycleModel,BicycleColor,BicyclePrice,SectionID,SpecialOfferID) VALUES ('{bicycle.bicycleModel}','{bicycle.bicycleColor}','{bicycle.bicyclePrice}','{bicycle.sectionID}','{bicycle.specialOfferID}')";
                return dbHelper.ExecuteNonQuery(query);
            }
            catch (Exception)
            {
                throw new Exception("Not able to add Bicycle");
            }

        }
        public int DeleteBicycle(int bicycle)
        {
            try
            {
                string query = $"delete Bicycle where BicycleID = {bicycle}";
                return dbHelper.ExecuteNonQuery(query);
            }
            catch (Exception)
            {
                throw new Exception("Not able to delete Bicycle");
            }

        }
        public int UpdateBicycle(int bicycleID, string bicycleModel, string bicycleColor, string bicyclePrice, int sectionID, int specialOfferID)
        {
            try
            {
                string query = $"update Bicycle set BicycleModel = '{bicycleModel}',BicycleColor = '{bicycleColor}',BicyclePrice = '{bicyclePrice}',SectionID = '{sectionID}',SpecialOfferID = '{specialOfferID}' where BicycleID ={bicycleID}";
                return dbHelper.ExecuteNonQuery(query);
            }
            catch (Exception)
            {
                throw new Exception("Not able to Update Bicycle");
            }

        }
        public DataTable SearchBicycle(string bicycle)
        {
            try
            {
                string query = $"SELECT * FROM Bicycle WHERE BicycleModel LIKE '%{bicycle}%'";
                return dbHelper.ExecuteQuery(query);
            }
            catch (Exception)
            {
                throw new Exception("Not able to Search Bicycle data");
            }
        }
        public DataTable ViewBicycle()
        {
            try
            {
                string query = $"select * from Bicycle";
                return dbHelper.ExecuteQuery(query);
            }
            catch (Exception)
            {
                throw new Exception("Not able to View Bicycle data");
            }
        }
        public DataTable cdSectionID() {
            try
            {
                string query = $"SELECT [SectionID] From Section";
                return dbHelper.ExecuteQuery(query);
            }
            catch (Exception)
            {

                throw new Exception("Not able to load SectionID informations");
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
    }
    
}
