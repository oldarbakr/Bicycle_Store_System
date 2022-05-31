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
    public class Employee
    {
        private int employeeID;
        private string employeeFullName;
        private string employeeBirthDay;
        private string employeeGander;
        private string employeeCellphone;
        private string employeeEmail;
        private string employeePassword;

        public Employee()
         {
         }

         public Employee(int employeeID, string employeeFullName, string employeeBirthDay, string employeeGander,
             string employeeCellphone, string employeeEmail, string employeePassword)
         {
             this.employeeID = employeeID;
             this.employeeFullName = employeeFullName;
             this.employeeBirthDay = employeeBirthDay;
             this.employeeGander = employeeGander;
             this.employeeCellphone = employeeCellphone;
             this.employeeEmail = employeeEmail;
             this.employeePassword = employeePassword;
         }
         public int EmployeeID { get => employeeID; set => employeeID = value; }
         public string EmployeeFullName { get => employeeFullName; set => employeeFullName = value; }
         public string EmployeeBirthDay { get => employeeBirthDay; set => employeeBirthDay = value; }
         public string EmployeeGander { get => employeeGander; set => employeeGander = value; }
         public string EmployeeCellphone { get => employeeCellphone; set => employeeCellphone = value; }
         public string EmployeeEmail { get => employeeEmail; set => employeeEmail = value; }
         public string EmployeePassword { get => employeePassword; set => employeePassword = value; }

        public int UpdateEmployee(int employeeID, string employeeFullName, string employeeBirthDay, string employeeGander, string employeeCellphone, string employeeEmail, string employeePassword)
        {
            try
            {
                string query = $"update Employee set EmployeeFullName = '{employeeFullName}',EmployeeBirthDay = '{employeeBirthDay}',EmployeeGander = '{employeeGander}',EmployeeCellphone = '{employeeCellphone}',EmployeeEmail = '{employeeEmail}',EmployeePassword = '{employeePassword}' where EmployeeID ={employeeID}";
                return dbHelper.ExecuteNonQuery(query);
            }
            catch (Exception)
            {
                throw new Exception("Not able to Update Employee");
            }

        }
        public int AddEmployee(Employee employee)
        {
            try
            {
                string query = $"INSERT INTO Employee(EmployeeFullName,EmployeeBirthDay,EmployeeGander,EmployeeCellphone,EmployeeEmail,EmployeePassword) VALUES ('{employee.EmployeeFullName}','{employee.EmployeeBirthDay}','{employee.EmployeeGander}','{employee.EmployeeCellphone}','{employee.EmployeeEmail}','{employee.EmployeePassword}')";
                return dbHelper.ExecuteNonQuery(query);
            }
            catch (Exception)
            {
                throw new Exception("Not able to add Employee");
            }

        }
        public int DeleteEmployee(int employee)
        {
            try
            {
                string query = $"delete Employee where EmployeeID = {employee}";
                return dbHelper.ExecuteNonQuery(query);
            }
            catch (Exception)
            {
                throw new Exception("Not able to delete Employee");
            }

        }
        public DataTable SearchEmployee(string employee)
        {
            try
            {
                string query = $"SELECT * FROM Employee WHERE EmployeeID LIKE '%{employee}%'";
                return dbHelper.ExecuteQuery(query);
            }
            catch (Exception)
            {
                throw new Exception("Not able to Search Employee data");
            }
        }
        public DataTable ViewEmployee()
        {
            try
            {
                string query = $"select * from Employee";
                return dbHelper.ExecuteQuery(query);
            }
            catch (Exception)
            {
                throw new Exception("Not able to View Employee data");
            }
        }
        public Employee EmployeeLogin(string email, string password)
         {
             try
             { 
                     string query = $"select * from Employee where EmployeeEmail ='{email}' AND EmployeePassword='{password}'";
                     DataTable dt = dbHelper.ExecuteQuery(query);

                     if (dt.Rows.Count > 0)
                     {
                         Employee employee = new Employee();
                         employee.EmployeeID = int.Parse(dt.Rows[0]["EmployeeID"].ToString());
                         employee.EmployeeFullName = dt.Rows[0]["EmployeeFullName"].ToString();
                         employee.EmployeeBirthDay = dt.Rows[0]["EmployeeBirthDay"].ToString();
                         employee.EmployeeGander = dt.Rows[0]["EmployeeGander"].ToString();
                         employee.EmployeeCellphone = dt.Rows[0]["EmployeeCellphone"].ToString();
                         employee.EmployeeEmail = dt.Rows[0]["EmployeeEmail"].ToString();
                         employee.EmployeePassword = dt.Rows[0]["EmployeePassword"].ToString();
                    return employee;
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
