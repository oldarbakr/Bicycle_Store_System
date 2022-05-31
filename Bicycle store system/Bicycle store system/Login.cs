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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Email != string.Empty) 
            {
                tbEmail.Text = Properties.Settings.Default.Email;
                tbPassword.Text = Properties.Settings.Default.Password;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SingUp form = new SingUp();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        public void btLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string email = tbEmail.Text.Trim();
                string password = tbPassword.Text.Trim();
                lblMassage.Text = "";
                lblMassage.ForeColor = Color.Black;

                if (string.IsNullOrWhiteSpace(email))
                {
                    lblMassage.Text = "Please enter your email.";
                    lblMassage.ForeColor = Color.Red;
                    tbEmail.Focus();
                    return;
                }
                else if (!(email.EndsWith("@bss.employee")||email.EndsWith("@bss.client")))
                {
                    lblMassage.Text = "The Email most ends with @bss.client or @bss.employee.";
                    lblMassage.ForeColor = Color.Red;
                    tbEmail.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(password))
                {
                    lblMassage.Text = "Please enter your password.";
                    lblMassage.ForeColor = Color.Red;
                    tbPassword.Focus();
                    return;
                }
                if (cbRememberMe.Checked == true) 
                {
                    Properties.Settings.Default.Email = tbEmail.Text;
                    Properties.Settings.Default.Password = tbPassword.Text;
                    Properties.Settings.Default.Save();
                }
                else if (cbRememberMe.Checked == false) 
                {
                    Properties.Settings.Default.Email = "";
                    Properties.Settings.Default.Password = "";
                    Properties.Settings.Default.Save();
                }
                if (email.Contains("@bss.employee"))
                {
                    Employee employee = new Employee();
                    var result = employee.EmployeeLogin(email, password);
                    if (result != null)
                    {
                        Manage Employee = new Manage(result);
                        this.Hide();
                        Employee.ShowDialog();
                        this.Show();
                    }
                    else
                    {
                        lblMassage.Text = "Incorrect Email or password";
                        lblMassage.ForeColor = Color.Red;
                    }
                    return;
                }
                else if(email.Contains("@bss.client")) 
                {
                    Client client = new Client();
                    var result = client.ClientLogin(email, password);
                    if (result != null)
                    {
                        Home home = new Home(result);
                        this.Hide();
                        home.ShowDialog();
                        this.Show();
                    }
                    else
                    {
                        lblMassage.Text = "Incorrect Email or password";
                        lblMassage.ForeColor = Color.Red;
                    }
                    return;
                }
            }
            catch (Exception)
            {
                lblMassage.Text = "An error occured in login.";
                lblMassage.ForeColor = Color.Red;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btClear_Click(object sender, EventArgs e)
        {
            lblMassage.Text = "";
            tbEmail.Text = "";
            tbPassword.Text = "";
            cbRememberMe.Checked = false;
        }

        private void tbEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
