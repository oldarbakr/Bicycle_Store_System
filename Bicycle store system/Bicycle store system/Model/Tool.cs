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
    public class Tool
    {
        private int toolID;
        private string toolModel;
        private string toolColor;
        private double toolPrice;
        private int sectionID;
        private int specialOfferID;

        public Tool()
        {
        }

        public Tool(int toolID, string toolModel, string toolColor,
    double toolPrice, int sectionID, int specialOfferID)
        {
            this.toolID = toolID;
            this.toolModel = toolModel;
            this.toolColor = toolColor;
            this.toolPrice = toolPrice;
            this.sectionID = sectionID;
            this.specialOfferID = specialOfferID;
        }

        public int ToolID { get => toolID; set => toolID = value; }
        public string ToolModel { get => toolModel; set => toolModel = value; }
        public string ToolColor { get => toolColor; set => toolColor = value; }
        public double ToolPrice { get => toolPrice; set => toolPrice = value; }
        public int SectionID { get => sectionID; set => sectionID = value; }
        public int SpecialOfferID { get => specialOfferID; set => specialOfferID = value; }

        public int AddTool(Tool tool)
        {
            try
            {
                string query = $"INSERT INTO Tool(ToolModel,ToolColor,ToolPrice,SectionID,SpecialOfferID) VALUES ('{tool.ToolModel}','{tool.ToolColor}','{tool.toolPrice}','{tool.SectionID}','{tool.SpecialOfferID}')";
                return dbHelper.ExecuteNonQuery(query);
            }
            catch (Exception)
            {
                throw new Exception("Not able to add Tool");
            }

        }
        public int DeleteTool(int tool)
        {
            try
            {
                string query = $"delete Tool where ToolID = {tool}";
                return dbHelper.ExecuteNonQuery(query);
            }
            catch (Exception)
            {
                throw new Exception("Not able to delete Tool");
            }

        }
        public int UpdateTool(int toolID, string toolModel, string toolColor, string toolPrice, int sectionID, int specialOfferID)
        {
            try
            {
                string query = $"update Tool set ToolModel = '{toolModel}',ToolColor = '{toolColor}',ToolPrice = '{toolPrice}',SectionID = '{sectionID}',SpecialOfferID = '{specialOfferID}' where ToolID ={toolID}";
                return dbHelper.ExecuteNonQuery(query);
            }
            catch (Exception)
            {
                throw new Exception("Not able to Update Tool");
            }

        }
        public DataTable SearchTool(string tool)
        {
            try
            {
                string query = $"SELECT * FROM Tool WHERE ToolModel LIKE '%{tool}%'";
                return dbHelper.ExecuteQuery(query);
            }
            catch (Exception)
            {
                throw new Exception("Not able to Search Tool data");
            }
        }
        public DataTable ViewTool()
        {
            try
            {
                string query = $"select * from Tool";
                return dbHelper.ExecuteQuery(query);
            }
            catch (Exception)
            {
                throw new Exception("Not able to View Tool data");
            }
        }
        public DataTable cdSectionID()
        {
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
