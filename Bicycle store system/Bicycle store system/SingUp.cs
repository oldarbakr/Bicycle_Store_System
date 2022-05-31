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
    public partial class SingUp : Form
    {
        public SingUp()
        {
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void dtpEmployeeBirhtDay_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblEMassage_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblCMassage.Text = "";
            string employeeFullName = tbEmployeeFullName.Text.Trim();
            string employeeBirthDay = dtpEmployeeBirhtDay.Text.Trim();
            string employeeGander = cbEmployeeGander.Text.Trim();
            string employeeCellphone = tbEmployeeCellphone.Text.Trim();
            string employeeEmail = tbEmployeeEmail.Text.Trim();
            string employeePassword = tbEmployeePassword.Text.Trim();

            if (string.IsNullOrEmpty(employeeFullName))
            {
                lblEMassage.Text = "Please enter your full name.";
                lblEMassage.ForeColor = Color.Red;
                tbEmployeeFullName.Focus();
                return;
            }
            if (string.IsNullOrEmpty(employeeGander))
            {
                lblEMassage.Text = "Please choose your gander.";
                lblEMassage.ForeColor = Color.Red;
                cbEmployeeGander.Focus();
                return;
            }
            if (string.IsNullOrEmpty(employeeCellphone))
            {
                lblEMassage.Text = "Please enter your cellphone number.";
                lblEMassage.ForeColor = Color.Red;
                tbEmployeeCellphone.Focus();
                return;
            }
            if (string.IsNullOrEmpty(employeeEmail))
            {
                lblEMassage.Text = "Please enter a valid Email.";
                lblEMassage.ForeColor = Color.Red;
                tbEmployeeEmail.Focus();
                return;
            }
            else if (!employeeEmail.EndsWith("@bss.employee"))
            {
                lblEMassage.Text = "Email most ends with @bss.employee.";
                lblEMassage.ForeColor = Color.Red;
                tbEmployeeEmail.Focus();
                return;
            }
            if (string.IsNullOrEmpty(employeePassword))
            {
                lblEMassage.Text = "Please enter a password.";
                lblEMassage.ForeColor = Color.Red;
                tbEmployeePassword.Focus();
                return;
            }
            try
            {
                Employee employee = new Employee();
                employee.EmployeeFullName = employeeFullName;
                employee.EmployeeBirthDay = employeeBirthDay;
                employee.EmployeeGander = employeeGander;
                employee.EmployeeCellphone = employeeCellphone;
                employee.EmployeeEmail = employeeEmail;
                employee.EmployeePassword = employeePassword;
                int Result = employee.AddEmployee(employee);
                if (Result > 0)
                {
                    lblEMassage.Text = "Client Employee.";
                    lblEMassage.ForeColor = Color.Green;

                    string message = "Sign up successfully done.";
                    string title = "Done";
                    MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                    DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button2);
                    if (result == DialogResult.OK)
                    {
                        Employee employee2 = new Employee();
                        var result2 = employee2.EmployeeLogin(employeeEmail, employeePassword);
                        if (result2 != null)
                        {
                            Manage manage = new Manage(result2);
                            this.Hide();
                            manage.ShowDialog();
                            this.Show();
                        }
                    }
                    else if (result == DialogResult.Cancel)
                    {
                        lblEMassage.Text = "";
                        tbEmployeeFullName.Text = "";
                        cbEmployeeGander.Text = "";
                        tbEmployeeCellphone.Text = "";
                        tbEmployeeEmail.Text = "";
                        tbEmployeePassword.Text = "";
                    }
                    else
                    {
                        // Do something  
                    }
                }
                else
                {
                    lblEMassage.Text = "Employee not added.";
                    lblEMassage.ForeColor = Color.Red;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblCMassage.Text = "";
            string ClientFullName = tbClientFullName.Text.Trim();
            string ClientBirthDay = dtpClientBirhtDay.Text.Trim();
            string ClientGander = cbClientGander.Text.Trim();
            string ClientCellphone = tbClientCellphone.Text.Trim();
            string ClientEmail = tbClientEmail.Text.Trim();
            string ClientPassword = tbClientPassword.Text.Trim();

            if (string.IsNullOrEmpty(ClientFullName))
            {
                lblCMassage.Text = "Please enter your full name.";
                lblCMassage.ForeColor = Color.Red;
                tbClientFullName.Focus();
                return;
            }
            if (string.IsNullOrEmpty(ClientGander))
            {
                lblCMassage.Text = "Please choose your gander.";
                lblCMassage.ForeColor = Color.Red;
                cbClientGander.Focus();
                return;
            }
            if (string.IsNullOrEmpty(ClientCellphone))
            {
                lblCMassage.Text = "Please enter your cellphone number.";
                lblCMassage.ForeColor = Color.Red;
                tbClientCellphone.Focus();
                return;
            }
            if (string.IsNullOrEmpty(ClientEmail))
            {
                lblCMassage.Text = "Please enter a valid Email.";
                lblCMassage.ForeColor = Color.Red;
                tbClientEmail.Focus();
                return;
            }
            else if (!ClientEmail.EndsWith("@bss.client")) 
            {
                lblCMassage.Text = "Email most ends with @bss.client.";
                lblCMassage.ForeColor = Color.Red;
                tbClientEmail.Focus();
                return;
            }
            if (string.IsNullOrEmpty(ClientPassword))
            {
                lblCMassage.Text = "Please enter a password.";
                lblCMassage.ForeColor = Color.Red;
                tbClientPassword.Focus();
                return;
            }
            try
            {
                Client client = new Client();
                client.ClientFullName = ClientFullName;
                client.ClientBirthDay = ClientBirthDay;
                client.ClientGander = ClientGander;
                client.ClientCellphone = ClientCellphone;
                client.ClientEmail = ClientEmail;
                client.ClientPassword = ClientPassword;
                int Result = client.AddClient(client);
                if (Result > 0)
                {
                    lblCMassage.Text = "Client added.";
                    lblCMassage.ForeColor = Color.Green;

                    string message = "Sign up successfully done.";
                    string title = "Done";
                    MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                    DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button2);
                    if (result == DialogResult.OK)
                    {
                        Client Client = new Client();
                        var result2 = Client.ClientLogin(ClientEmail, ClientPassword);
                        if (result2 != null)
                        {
                            Home home = new Home(result2);
                            this.Hide();
                            home.ShowDialog();
                            this.Show();
                        }
                    }
                    else if (result == DialogResult.Cancel)
                    {
                        lblCMassage.Text = "";
                        tbClientFullName.Text = "";
                        cbClientGander.Text = "";
                        tbClientCellphone.Text = "";
                        tbClientEmail.Text = "";
                        tbClientPassword.Text = "";
                    }
                    else
                    {
                        // Do something  
                    }
                }
                else
                {
                    lblCMassage.Text = "Client not added.";
                    lblCMassage.ForeColor = Color.Red;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tbClientFullName_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbClientCellphone_TextChanged(object sender, EventArgs e)
        {

        }

        private void SingUp_Load(object sender, EventArgs e)
        {
           
        }

        private void ClientPage_Click(object sender, EventArgs e)
        {
            this.AcceptButton = button2;
        }

        private void EmployeePage_Click(object sender, EventArgs e)
        {
            this.AcceptButton = button1;
        }

        private void tbClientCellphone_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chr = e.KeyChar;
            if (!char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
            }
        }

        private void tbEmployeeCellphone_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chr = e.KeyChar;
            if (!char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
            }
        }
    }
}
