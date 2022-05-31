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
    public partial class Sections : Form    
    {
        public Sections()
        {
            InitializeComponent();
        }
        private void Sections_Load(object sender, EventArgs e)
        {
            Section section = new Section();
            dgvSection.DataSource = section.ViewSection();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Section section = new Section();
                section.SectionName = tbSectionName.Text;
                section.SectionType = cbSectionType.SelectedItem.ToString();
                int a = section.AddSection(section);
                if (a == 1)
                {
                    lblError.ForeColor = Color.Green;
                    lblError.Text = "Section Added.";
                }
                else
                {
                    lblError.ForeColor = Color.Red;
                    dgvSection.DataSource = section.ViewSection();
                    throw new Exception("Section not Added.");
                }
                dgvSection.DataSource = section.ViewSection();
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
                Section section = new Section();
                int a=section.DeleteSection(int.Parse(tbDeleteSection.Text.Trim().ToString()));
                if (a == 1)
                {
                    lblError.ForeColor = Color.Red;
                    dgvSection.DataSource = section.ViewSection();
                    throw new Exception("Section deleted.");
                }
                else 
                {
                    lblError.ForeColor = Color.Red;
                    dgvSection.DataSource = section.ViewSection();
                    throw new Exception("Section not founded.");
                }
            }
            catch (Exception ex)
            {
                lblError.ForeColor = Color.Red;
                lblError.Text = ex.Message;
            }

        }
        private void Update_Click(object sender, EventArgs e)
        {
            try
            {
                Section section = new Section();
                int a = section.UpdateSection(int.Parse(tbID.Text),tbName.Text,cbType.SelectedItem.ToString());
                if (a == 1)
                {
                    lblError.ForeColor = Color.Green;
                    dgvSection.DataSource = section.ViewSection();
                    throw new Exception("Section updated.");
                }

                else
                {
                    lblError.ForeColor = Color.Red;
                    dgvSection.DataSource = section.ViewSection();
                    throw new Exception("Section not founded.");
                }
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Section section = new Section();
            dgvSection.DataSource = section.SearchSection(tbSearchSection.Text);
        }
    }
}
