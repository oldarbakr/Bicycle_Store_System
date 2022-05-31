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
    public partial class SpecialOffers : Form
    {
        public SpecialOffers()
        {
            InitializeComponent();
        }
        private void SpecialOffers_Load(object sender, EventArgs e)
        {
            SpecialOffer specialOffer = new SpecialOffer();
            dgvSpecialOffer.DataSource = specialOffer.ViewSpecialOffer();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SpecialOffer specialOffer = new SpecialOffer();
                specialOffer.DiscountPercentage = cb1.SelectedItem.ToString();
                specialOffer.OfferExpirationDate = dtp1.Text;
                int a = specialOffer.AddSpecialOffer(specialOffer);
                if (a == 1)
                {
                    lblError.ForeColor = Color.Green;
                    lblError.Text = "Special offer Added.";
                }
                dgvSpecialOffer.DataSource = specialOffer.ViewSpecialOffer();
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
                SpecialOffer specialOffer = new SpecialOffer();
                int a = specialOffer.DeleteSpecialOffer(int.Parse(tbDeleteSpecialOffer.Text.Trim().ToString()));
                if (a == 1)
                {
                    lblError.ForeColor = Color.Red;
                    dgvSpecialOffer.DataSource = specialOffer.ViewSpecialOffer();
                    throw new Exception("Special offer deleted.");
                }
                else
                {
                    lblError.ForeColor = Color.Red;
                    dgvSpecialOffer.DataSource = specialOffer.ViewSpecialOffer();
                    throw new Exception("Special offer not founded.");
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
                SpecialOffer specialOffer = new SpecialOffer();
                int a = specialOffer.UpdateSpecialOffer(int.Parse(tbSpecialOfferIDUpdate.Text), cb1Update.SelectedItem.ToString(), dtp1Update.Text);
                if (a == 1)
                {
                    dgvSpecialOffer.DataSource = specialOffer.ViewSpecialOffer();
                    lblError.ForeColor = Color.Green;
                    lblError.Text = "Special offer updated.";
                }

                else
                {
                    dgvSpecialOffer.DataSource = specialOffer.ViewSpecialOffer();
                    lblError.ForeColor = Color.Red;
                    throw new Exception("Special offer not founded.");
                }
            }
            catch (Exception ex)
            {
                lblError.ForeColor = Color.Red;
                lblError.Text = ex.Message;
            }
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

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
