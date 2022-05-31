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
    public partial class Shifts : Form
    {
        public Shifts()
        {
            InitializeComponent();
        }

        private void Shifts_Load(object sender, EventArgs e)
        {
            Shift shifts = new Shift();
            DataTable dataTable = new DataTable();

            dataTable = shifts.cdSectionID();
            cbS.DisplayMember = "SectionID";
            cbS.ValueMember = "SectionID";
            cbS.DataSource = dataTable;
            cbSU.DisplayMember = "SectionID";
            cbSU.ValueMember = "SectionID";
            cbSU.DataSource = dataTable;

            dataTable = shifts.cdEmployeeID();
            cbE.DisplayMember = "EmployeeID";
            cbE.ValueMember = "EmployeeID";
            cbE.DataSource = dataTable;
            cbEU.DisplayMember = "EmployeeID";
            cbEU.ValueMember = "EmployeeID";
            cbEU.DataSource = dataTable;

            dgvShifts.DataSource = shifts.ViewShifts();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Shift shift = new Shift();
                shift.SectionID = int.Parse(cbS.SelectedValue.ToString());
                shift.EmployeeID = int.Parse(cbE.SelectedValue.ToString());
                shift.ShiftStartTime = dateTimePicker1.Text;
                shift.ShiftEndTime = dateTimePicker2.Text;
                int a = shift.AddShifts(shift);
                if (a == 1)
                {
                    lblError.ForeColor = Color.Green;
                    lblError.Text = "Shift Added.";
                }
                dgvShifts.DataSource = shift.ViewShifts();
            }

            catch (Exception ex)
            {
                lblError.ForeColor = Color.Red;
                lblError.Text = ex.Message;
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                Shift shift = new Shift();
                int a = shift.DeleteShifts(int.Parse(tbDeleteShift.Text.Trim().ToString()));
                if (a == 1)
                {
                    lblError.ForeColor = Color.Red;
                    dgvShifts.DataSource = shift.ViewShifts();
                    throw new Exception("Shift deleted.");
                }
                else
                {
                    lblError.ForeColor = Color.Red;
                    dgvShifts.DataSource = shift.ViewShifts();
                    throw new Exception("Shift not founded.");
                }
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
                Shift shift = new Shift();
                int a = shift.UpdateShifts(int.Parse(cbSU.SelectedValue.ToString()), int.Parse(cbEU.SelectedValue.ToString()), dateTimePicker3.Text, dateTimePicker4.Text);
                if (a == 1)
                {
                    dgvShifts.DataSource = shift.ViewShifts();
                    lblError.ForeColor = Color.Green;
                    lblError.Text = "Shift updated.";
                }

                else
                {
                    dgvShifts.DataSource = shift.ViewShifts();
                    lblError.ForeColor = Color.Red;
                    throw new Exception("Shift not founded.");
                }
            }
            catch (Exception ex)
            {
                lblError.ForeColor = Color.Red;
                lblError.Text = ex.Message;
            }
        }
    }
}
