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
    public partial class Clients : Form
    {
        public Clients()
        {
            InitializeComponent();
        }

        private void Clients_Load(object sender, EventArgs e)
        {
            Client client = new Client();
            dgvClient.DataSource = client.ViewClient();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                Client client = new Client();
                int a = client.UpdateClient(int.Parse(tbEmployeeIDUpdate.Text), tbEmployeeFNUpdate.Text, dtpEBirhtDayU.Text, cbEGanderU.SelectedItem.ToString(), tbCellU.Text, tbEEmailU.Text, tbEPU.Text);
                if (a == 1)
                {
                    dgvClient.DataSource = client.ViewClient();
                    lblError.ForeColor = Color.Green;
                    lblError.Text = "Client updated.";
                }

                else
                {
                    dgvClient.DataSource = client.ViewClient();
                    lblError.Text = "Client not founded.";
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
                Client client = new Client();
                dgvClient.DataSource = client.SearchClient(tbSearchE.Text);
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
                Client client = new Client();
                int a = client.DeleteClient(int.Parse(tbDeleteE.Text.Trim().ToString()));
                if (a == 1)
                {
                    lblError.ForeColor = Color.Red;
                    dgvClient.DataSource = client.ViewClient();
                    throw new Exception("Client deleted.");
                }
                else
                {
                    lblError.ForeColor = Color.Red;
                    dgvClient.DataSource = client.ViewClient();
                    throw new Exception("Client not founded.");
                }
            }
            catch (Exception ex)
            {
                lblError.ForeColor = Color.Red;
                lblError.Text = ex.Message;
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

        private void tbEmployeeIDUpdate_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chr = e.KeyChar;
            if (!char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
            }
        }
    }
}
