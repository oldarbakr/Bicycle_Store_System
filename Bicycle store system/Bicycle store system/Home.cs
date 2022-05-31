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
        public partial class Home : Form

        {
        public Client Client { get; set; }

        public Home(Client client)
        {
            InitializeComponent();
            Client = client;
        }
        public Home()
        {
            
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {
            try
            {
                if (Client != null)
                {
                    lblWellcome.Text = Client.ClientFullName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Bicycle bicycle = new Bicycle();
            dataGridView1.DataSource = bicycle.ViewBicycle();
            Tool tool = new Tool();
            dataGridView2.DataSource = tool.ViewTool();
            SpecialOffer specialOffer = new SpecialOffer();
            dataGridView3.DataSource = specialOffer.ViewSpecialOffer();
        }
        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void specialOffersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewSpecial form = new ViewSpecial();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }
    }
}
