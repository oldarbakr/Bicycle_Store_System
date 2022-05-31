using Bicycle_store_system.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bicycle_store_system
{
    public partial class Employees : Form
    {
        public Employees()
        {
            InitializeComponent();
        }
        private void Employees_Load(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            dgvEmployee.DataSource = employee.ViewEmployee();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                Employee employee = new Employee();
                int a = employee.UpdateEmployee(int.Parse(tbEmployeeIDUpdate.Text), tbEmployeeFNUpdate.Text,dtpEBirhtDayU.Text, cbEGanderU.SelectedItem.ToString(), tbCellU.Text, tbEEmailU.Text,tbEPU.Text);
                if (a == 1)
                {
                    dgvEmployee.DataSource = employee.ViewEmployee();
                    lblError.ForeColor = Color.Green;
                    lblError.Text = "Employee updated.";
                }

                else
                {
                    dgvEmployee.DataSource = employee.ViewEmployee();
                    lblError.Text = "Employee not founded.";
                    lblError.ForeColor = Color.Red;
                }
            }
            catch (Exception ex)
            {
                lblError.ForeColor = Color.Red;
                lblError.Text = ex.Message;
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Employee employee = new Employee();
                dgvEmployee.DataSource = employee.SearchEmployee(tbSearchE.Text);
            }
            catch (Exception ex)
            {
                lblError.ForeColor = Color.Red;
                lblError.Text = ex.Message;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Employee employee = new Employee();
                int a = employee.DeleteEmployee(int.Parse(tbDeleteE.Text.Trim().ToString()));
                if (a == 1)
                {
                    lblError.ForeColor = Color.Red;
                    dgvEmployee.DataSource = employee.ViewEmployee();
                    throw new Exception("Employee deleted.");
                }
                else
                {
                    lblError.ForeColor = Color.Red;
                    dgvEmployee.DataSource = employee.ViewEmployee();
                    throw new Exception("Employee not founded.");
                }
            }
            catch (Exception ex)
            {
                lblError.ForeColor = Color.Red;
                lblError.Text = ex.Message;
            }
        }

        private void tbBicycleIDUpdate_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbEmployeeIDUpdate_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chr = e.KeyChar;
            if (!char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
            }
        }

        private void tbCellU_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chr = e.KeyChar;
            if (!char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
            }
        }
    }
}
