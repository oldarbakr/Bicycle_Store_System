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
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }
        private void Reports_Load(object sender, EventArgs e)
        {
            Report report = new Report();
            DataTable dataTable = new DataTable();

            dataTable = report.cdClientID();
            cbClientID.DisplayMember = "ClientID";
            cbClientID.ValueMember = "ClientID";
            cbClientID.DataSource = dataTable;
            cbClientIDUpdate.DisplayMember = "ClientID";
            cbClientIDUpdate.ValueMember = "ClientID";
            cbClientIDUpdate.DataSource = dataTable;

            dataTable = report.cdSpecialOfferID();
            cbSpecialOfferID.DisplayMember = "SpecialOfferID";
            cbSpecialOfferID.ValueMember = "SpecialOfferID";
            cbSpecialOfferID.DataSource = dataTable;
            cbSpecialOfferIDUpdate.DisplayMember = "SpecialOfferID";
            cbSpecialOfferIDUpdate.ValueMember = "SpecialOfferID";
            cbSpecialOfferIDUpdate.DataSource = dataTable;

            dgvReport.DataSource = report.ViewReport();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Report report = new Report();
                report.ReportDate = dtpReportDate.Text;
                report.ReportText = tbReportText.Text;
                report.SpecialOfferID = int.Parse(cbSpecialOfferID.SelectedValue.ToString());
                report.ClientID = int.Parse(cbClientID.SelectedValue.ToString());
                int a=report.AddReport(report);
                if (a == 1)
                {
                    lblError.ForeColor = Color.Green;
                    lblError.Text = "Report Added.";
                }
                dgvReport.DataSource = report.ViewReport();

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
                Report report = new Report();
                int a = report.DeleteReport(int.Parse(tbDeleteReport.Text.Trim().ToString()));
                if (a == 1)
                {
                    lblError.ForeColor = Color.Red;
                    dgvReport.DataSource = report.ViewReport();
                    throw new Exception("Report deleted.");
                }
                else
                {
                    lblError.ForeColor = Color.Red;
                    dgvReport.DataSource = report.ViewReport();
                    throw new Exception("Report not founded.");
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
                Report report = new Report();
                int a = report.UpdateReport(int.Parse(tbReportIDUpdate.Text), dtpReportDateUpdate.Text, tbReportTextUpdate.Text, int.Parse(cbSpecialOfferIDUpdate.Text), int.Parse(cbClientIDUpdate.Text));
                if (a == 1)
                {
                    dgvReport.DataSource = report.ViewReport();
                    lblError.ForeColor = Color.Green;
                    lblError.Text = "Report updated.";
                }

                else
                {
                    dgvReport.DataSource = report.ViewReport();
                    lblError.ForeColor = Color.Red;
                    throw new Exception("Report not founded.");
                }
            }
            catch (Exception ex)
            {
                lblError.ForeColor = Color.Red;
                lblError.Text = ex.Message;
            }
        }
        private void Search_Click(object sender, EventArgs e)
        {
            try
            {
                Report report = new Report();
                dgvReport.DataSource = report.SearchReport(int.Parse(tbReportSeaech.Text));
            }
            catch (Exception ex)
            {
                lblError.ForeColor = Color.Red;
                lblError.Text = ex.Message;
            }
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
