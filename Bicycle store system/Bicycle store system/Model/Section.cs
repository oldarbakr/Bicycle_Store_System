using Bicycle_store_system.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bicycle_store_system.Model
{
    public class Section
    {
        private int sectionID;
        private string sectionName;
        private string sectionType;

        public Section()
        {
        }

        public Section(int sectionID, string sectionName, string sectionType)
        {
            this.SectionID = sectionID;
            this.SectionName = sectionName;
            this.SectionType = sectionType;
        }

        public int SectionID { get => sectionID; set => sectionID = value; }
        public string SectionName { get => sectionName; set => sectionName = value; }
        public string SectionType { get => sectionType; set => sectionType = value; }

        public int AddSection(Section section) 
        {
            try
            {
                string query = $"INSERT INTO Section(SectionName,SectionType) VALUES ('{section.SectionName}','{section.SectionType}')";
                return dbHelper.ExecuteNonQuery(query);
            }
            catch (Exception)
            {
                throw new Exception("Not able to add Section") ;
            }
        }
        public int DeleteSection(int section)
        {
            try
            {
                string query = $"delete Section where SectionID = {section}";
                return dbHelper.ExecuteNonQuery(query);
            }
            catch (Exception)
            {
                throw new Exception("Not able to delete Section");
            }

        }
        public int UpdateSection(int sectionID,string sectionName,string sectionType)
        {
            try
            {
                string query = $"update Section set SectionName = '{sectionName}',SectionType = '{sectionType}' where SectionID ={sectionID}";
                return dbHelper.ExecuteNonQuery(query);
            }
            catch (Exception)
            {
                throw new Exception("Not able to Update Section");
            }

        }
        public DataTable SearchSection(string section)
        {
            try
            {
                string query = $"SELECT * FROM Section WHERE SectionName LIKE '%{section}%'";
                return dbHelper.ExecuteQuery(query);
            }
            catch (Exception)
            {
                throw new Exception("Not able to Search Section data");
            }
        }
        public DataTable ViewSection()
        {
            try
            {
                string query = $"select * from Section";
                return dbHelper.ExecuteQuery(query);
            }
            catch (Exception)
            {
                throw new Exception("Not able to View Section data");
            }
        }



    }
}
