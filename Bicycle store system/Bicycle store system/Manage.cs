using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bicycle_store_system.Model;

namespace Bicycle_store_system
{
    public partial class Manage : Form
    {
        public Employee Employee { get; set; }

        public Manage(Employee employee)
        {
            InitializeComponent();
            Employee = employee;
        }

        private void menuItem6_Click(object sender, EventArgs e)
        {

        }

        private void menuItem7_Click(object sender, EventArgs e)
        {

        }

        private void menuItem8_Click(object sender, EventArgs e)
        {

        }

        private void menuItem9_Click(object sender, EventArgs e)
        {

        }

        private void menuItem10_Click(object sender, EventArgs e)
        {

        }

        private void menuItem11_Click(object sender, EventArgs e)
        {

        }

        private void Manage_Load(object sender, EventArgs e)
        {
            try
            {
                if (Employee != null)
                {
                    lblWellcome.Text = Employee.EmployeeFullName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Shift shift = new Shift();
            dataGridView1.DataSource = shift.ViewShifts();
            Report report = new Report();
            dataGridView2.DataSource = report.ViewReport();
            Section section = new Section();
            dataGridView3.DataSource = section.ViewSection();
        }

        private void vxcToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuItem1_Click(object sender, EventArgs e)
        {

        }

        private void menuItem4_Click(object sender, EventArgs e)
        {

        }

        private void menuItem5_Click(object sender, EventArgs e)
        {

        }

        private void menuItem2_Click(object sender, EventArgs e)
        {

        }

        private void menuItem3_Click(object sender, EventArgs e)
        {

        }

        private void sectionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sections form = new Sections();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void bToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bicycles form = new Bicycles();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void manageStoreToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tools form = new Tools();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports form = new Reports();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void specialOffersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SpecialOffers form = new SpecialOffers();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void manageWorkShiftsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Shifts form = new Shifts();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void lblWellcome_Click(object sender, EventArgs e)
        {

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employees form = new Employees();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void clientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clients form = new Clients();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void xvToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ViewSpecial form = new ViewSpecial();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }
    }
}
