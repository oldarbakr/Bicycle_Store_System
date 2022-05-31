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
    public partial class ViewSpecial : Form
    {
        public ViewSpecial()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                SpecialOffer specialOffer = new SpecialOffer();
                dgvSpecialOffer.DataSource = specialOffer.SearchSpecialOffer(int.Parse(tbSpecialOfferSeaech.Text));
            }
            catch (Exception ex)
            {
                lblError.ForeColor = Color.Red;
                lblError.Text = ex.Message;
            }
        }

        private void ViewSpecial_Load(object sender, EventArgs e)
        {
            SpecialOffer specialOffer = new SpecialOffer();
            dgvSpecialOffer.DataSource = specialOffer.ViewSpecialOffer();
        }
    }
}
