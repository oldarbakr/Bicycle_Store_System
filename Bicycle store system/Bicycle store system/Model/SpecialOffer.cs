using Bicycle_store_system.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bicycle_store_system.Model
{
    class SpecialOffer
    {
        private int specialOfferID;
        private string discountPercentage;
        private string offerExpirationDate;

        public SpecialOffer() 
        {
        }

        public SpecialOffer(int specialOfferID, string discountPercentage,string offerExpirationDate)
        {
            this.specialOfferID = specialOfferID;
            this.discountPercentage = discountPercentage;
            this.offerExpirationDate = offerExpirationDate;
        }

        public int SpecialOfferID { get => specialOfferID; set => specialOfferID = value; }
        public string DiscountPercentage { get => discountPercentage; set => discountPercentage = value; }
        public string OfferExpirationDate { get => offerExpirationDate; set => offerExpirationDate = value; }

        public int AddSpecialOffer(SpecialOffer specialOffer)
        {
            try
            {
                string query = $"INSERT INTO [Special offer](DiscountPercentage,OfferExpirationDate) VALUES ('{specialOffer.discountPercentage}','{specialOffer.offerExpirationDate}')";
                return dbHelper.ExecuteNonQuery(query);
            }
            catch (Exception)
            {
                throw new Exception("Not able to add SpecialOffer");
            }

        }
        public int DeleteSpecialOffer(int specialOffer)
        {
            try
            {
                string query = $"delete [Special offer] where SpecialOfferID = {specialOffer}";
                return dbHelper.ExecuteNonQuery(query);
            }
            catch (Exception)
            {
                throw new Exception("Not able to delete SpecialOffer");
            }

        }
        public int UpdateSpecialOffer(int specialOfferID, string discountPercentage, string offerExpirationDate)
        {
            try
            {
                string query = $"update [Special offer] set DiscountPercentage = '{discountPercentage}',OfferExpirationDate = '{offerExpirationDate}' where SpecialOfferID ={specialOfferID}";
                return dbHelper.ExecuteNonQuery(query);
            }
            catch (Exception)
            {
                throw new Exception("Not able to Update SpecialOffer");
            }

        }
        public DataTable SearchSpecialOffer(int specialOffer)
        {
            try
            {
                string query = $"SELECT * FROM [Special offer] WHERE SpecialOfferID LIKE '%{specialOffer}%'";
                return dbHelper.ExecuteQuery(query);
            }
            catch (Exception)
            {
                throw new Exception("Not able to Search SpecialOffer data");
            }
        }
        public DataTable ViewSpecialOffer()
        {
            try
            {
                string query = $"select * from [Special offer]";
                return dbHelper.ExecuteQuery(query);
            }
            catch (Exception)
            {
                throw new Exception("Not able to View Special offer data");
            }
        }
    }
}
