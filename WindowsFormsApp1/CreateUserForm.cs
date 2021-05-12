using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmCreateUser : Form
    {
        public frmCreateUser()
        {
            InitializeComponent();
        }

        private void frmCreateUser_Load(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (txtAddress.Text =="" || txtCity.Text=="" || txtEmail.Text=="" || txtFirstName.Text =="" || txtLastName.Text == "" ||
                txtPassward.Text =="" || txtState.Text == "" || txtUserName.Text == "" || txtZip.Text == "")
            {
                MessageBox.Show("They are required field please fill them");
            }
            else
            {
                byte[] data = System.Text.Encoding.ASCII.GetBytes(txtPassward.Text);
                data = new System.Security.Cryptography.SHA256Managed().ComputeHash(data);
                string hash = System.Text.Encoding.ASCII.GetString(data);
                Customer customer = new Customer(txtLastName.Text, txtFirstName.Text, txtAddress.Text, txtCity.Text, txtState.Text,
                    txtZip.Text, txtEmail.Text, txtUserName.Text, hash);
                DBConnection.insertCustomer(customer);
                MessageBox.Show("User created succesfully");
                this.Close();
            }
          
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
