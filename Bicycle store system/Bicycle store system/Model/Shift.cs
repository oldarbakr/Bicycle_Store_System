using Bicycle_store_system.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bicycle_store_system.Model
{
    public partial class Shift
    {
        private int sectionID;
        private int employeeID;
        private string shiftStartTime;
        private string shiftEndTime;

        public Shift() 
        {
        }

        public Shift(int sectionID, int employeeID,
            string shiftStartTime, string shiftEndTime)
        {
            this.sectionID = sectionID;
            this.employeeID = employeeID;
            this.shiftStartTime = shiftStartTime;
            this.shiftEndTime = shiftEndTime;
        }
        public int SectionID { get => sectionID; set => sectionID = value; }
        public int EmployeeID { get => employeeID; set => employeeID = value; }
        public string ShiftStartTime { get => shiftStartTime; set => shiftStartTime = value; }
        public string ShiftEndTime { get => shiftEndTime; set => shiftEndTime = value; }

        public int AddShifts(Shift shifts)
        {
            try
            {
                string query = $"INSERT INTO Shifts(SectionID,EmployeeID,ShiftStartTime,ShiftEndTime) VALUES ('{shifts.SectionID}','{shifts.EmployeeID}','{shifts.ShiftStartTime}','{shifts.ShiftEndTime}')";
                return dbHelper.ExecuteNonQuery(query);
            }
            catch (Exception)
            {
                throw new Exception("Not able to add Shifts");
            }
        }
        public int DeleteShifts(int shifts)
        {
            try
            {
                string query = $"delete Shifts where SectionID = {shifts}";
                return dbHelper.ExecuteNonQuery(query);
            }
            catch (Exception)
            {
                throw new Exception("Not able to delete Shift");
            }

        }
        public int UpdateShifts(int sectionID, int employeeID, string shiftStartTime, string shiftEndTime)
        {
            try
            {
                string query = $"update Shifts set SectionID = '{sectionID}',EmployeeID = '{employeeID}',ShiftStartTime = '{shiftStartTime}',ShiftEndTime = '{shiftEndTime}' where SectionID ={sectionID}";
                return dbHelper.ExecuteNonQuery(query);
            }
            catch (Exception)
            {
                throw new Exception("Not able to Update Shifts");
            }
        }
        public DataTable ViewShifts()
        {
            try
            {
                string query = $"select * from Shifts";
                return dbHelper.ExecuteQuery(query);
            }
            catch (Exception)
            {
                throw new Exception("Not able to View Shifts data");
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
        public DataTable cdEmployeeID()
        {
            try
            {
                string query = $"SELECT [EmployeeID] From Employee";
                return dbHelper.ExecuteQuery(query);
            }
            catch (Exception)
            {
                throw new Exception("Not able to load EmployeeID informations");
            }

        }
    }
}
