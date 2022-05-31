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
    public partial class Bicycles : Form
    {
        public Bicycles()
        {
            InitializeComponent();
        }
        private void Bicycles_Load(object sender, EventArgs e)
        {
            Bicycle bicycle = new Bicycle();
            DataTable dataTable = new DataTable();

            dataTable = bicycle.cdSectionID();
            cbSectionID.DisplayMember = "SectionID";
            cbSectionID.ValueMember = "SectionID";
            cbSectionID.DataSource = dataTable;
            cbSectionIDUpdate.DisplayMember = "SectionID";
            cbSectionIDUpdate.ValueMember = "SectionID";
            cbSectionIDUpdate.DataSource = dataTable;
            
            dataTable = bicycle.cdSpecialOfferID();
            cbSpecialOfferID.DisplayMember = "SpecialOfferID";
            cbSpecialOfferID.ValueMember = "SpecialOfferID";
            cbSpecialOfferID.DataSource = dataTable;
            cbSpecialOfferIDUpdate.DisplayMember = "SpecialOfferID";
            cbSpecialOfferIDUpdate.ValueMember = "SpecialOfferID";
            cbSpecialOfferIDUpdate.DataSource = dataTable;

            dgvBicycle.DataSource = bicycle.ViewBicycle();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Bicycle bicycle = new Bicycle();
                bicycle.BicycleModel = tbBicycleModel.Text;
                bicycle.BicycleColor = cbBicycleColor.SelectedItem.ToString();
                bicycle.BicyclePrice = tbBicyclePrice.Text;

                bicycle.SectionID = int.Parse(cbSectionID.SelectedValue.ToString());
                bicycle.SpecialOfferID = int.Parse(cbSpecialOfferID.SelectedValue.ToString());
                int a = bicycle.AddBicycle(bicycle);
                if (a == 1)
                {
                    lblError.ForeColor = Color.Green;
                    lblError.Text = "Bicycle Added.";
                }
                dgvBicycle.DataSource = bicycle.ViewBicycle();
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
                Bicycle bicycle = new Bicycle();
                int a = bicycle.DeleteBicycle(int.Parse(tbDeleteBicycle.Text.Trim().ToString()));
                if (a == 1)
                {
                    lblError.ForeColor = Color.Red;
                    dgvBicycle.DataSource = bicycle.ViewBicycle();
                    throw new Exception("Bicycle deleted.");
                }
                else
                {
                    lblError.ForeColor = Color.Red;
                    dgvBicycle.DataSource = bicycle.ViewBicycle();
                    throw new Exception("Bicycle not founded.");
                }
            }
            catch (Exception ex)
            {
                lblError.ForeColor = Color.Red;
                lblError.Text = ex.Message;
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                Bicycle bicycle = new Bicycle();
                int a = bicycle.UpdateBicycle(int.Parse(tbBicycleIDUpdate.Text), tbBicycleModelUpdate.Text, cbBicycleColorUpdate.SelectedItem.ToString(), tbBicyclePriceUpdate.Text, int.Parse(cbSectionIDUpdate.Text), int.Parse(cbSpecialOfferIDUpdate.Text));
                if (a == 1)
                {
                    dgvBicycle.DataSource = bicycle.ViewBicycle();
                    lblError.ForeColor = Color.Green;
                    lblError.Text="Bicycle updated.";
                }

                else
                {
                    dgvBicycle.DataSource = bicycle.ViewBicycle();
                    lblError.Text = "Bicycle not founded.";
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
                Bicycle bicycle = new Bicycle();
                dgvBicycle.DataSource = bicycle.SearchBicycle(tbSearchBicycle.Text);
            }
            catch (Exception ex)
            {
                lblError.ForeColor = Color.Red;
                lblError.Text = ex.Message;
            }
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void cbSepcialOfferID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbSectionID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
