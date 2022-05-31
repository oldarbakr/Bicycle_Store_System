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
    public partial class Tools : Form
    {
        public Tools()
        {
            InitializeComponent();
        }
        private void Tools_Load(object sender, EventArgs e)
        {
            Tool tool = new Tool();
            DataTable dataTable = new DataTable();

            dataTable = tool.cdSectionID();
            cbSectionID.DisplayMember = "SectionID";
            cbSectionID.ValueMember = "SectionID";
            cbSectionID.DataSource = dataTable;
            cbSectionIDUpdate.DisplayMember = "SectionID";
            cbSectionIDUpdate.ValueMember = "SectionID";
            cbSectionIDUpdate.DataSource = dataTable;

            dataTable = tool.cdSpecialOfferID();
            cbSpecialOfferID.DisplayMember = "SpecialOfferID";
            cbSpecialOfferID.ValueMember = "SpecialOfferID";
            cbSpecialOfferID.DataSource = dataTable;
            cbSpecialOfferIDUpdate.DisplayMember = "SpecialOfferID";
            cbSpecialOfferIDUpdate.ValueMember = "SpecialOfferID";
            cbSpecialOfferIDUpdate.DataSource = dataTable;

            dgvTool.DataSource = tool.ViewTool();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Tool tool = new Tool();
                tool.ToolModel = tbToolModel.Text;
                tool.ToolColor = cbToolColor.SelectedItem.ToString();
                tool.ToolPrice = float.Parse(tbToolPrice.Text);
                tool.SectionID = int.Parse(cbSectionID.SelectedValue.ToString());
                tool.SpecialOfferID = int.Parse(cbSpecialOfferID.SelectedValue.ToString());
                int a = tool.AddTool(tool);
                if (a == 1)
                {
                    lblError.ForeColor = Color.Green;
                    lblError.Text = "Bicycle Added.";
                }
                dgvTool.DataSource = tool.ViewTool();
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
                Tool tool = new Tool();
                int a = tool.DeleteTool(int.Parse(tbDeleteTool.Text.Trim().ToString()));
                if (a == 1)
                {
                    lblError.ForeColor = Color.Red;
                    dgvTool.DataSource = tool.ViewTool();
                    throw new Exception("Tool deleted.");
                }
                else
                {
                    lblError.ForeColor = Color.Red;
                    dgvTool.DataSource = tool.ViewTool();
                    throw new Exception("Tool not founded.");
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
                Tool tool = new Tool();
                int a = tool.UpdateTool(int.Parse(tbToolIDUpdate.Text), tbToolModelUpdate.Text, cbToolColorUpdate.SelectedItem.ToString(), tbToolPriceUpdate.Text, int.Parse(cbSectionIDUpdate.Text), int.Parse(cbSpecialOfferIDUpdate.Text));
                if (a == 1)
                {
                    dgvTool.DataSource = tool.ViewTool();
                    lblError.ForeColor = Color.Green;
                    lblError.Text="Tool updated.";
                }

                else
                {
                    dgvTool.DataSource = tool.ViewTool();
                    lblError.ForeColor = Color.Red;
                    throw new Exception("Tool not founded.");
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
                Tool tool = new Tool();
                dgvTool.DataSource = tool.SearchTool(tbToolSeaech.Text);
            }
            catch (Exception ex)
            {
                lblError.ForeColor = Color.Red;
                lblError.Text = ex.Message;
            }
        }
        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
