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
    public partial class frmUser : Form
    {
        public frmUser()
        {
            InitializeComponent();
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            frmCreateUser createUser = new frmCreateUser();
            createUser.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            byte[] data = System.Text.Encoding.ASCII.GetBytes(txtPassward.Text);
            data = new System.Security.Cryptography.SHA256Managed().ComputeHash(data);
            string hash = System.Text.Encoding.ASCII.GetString(data);
            List<Customer> customers = DBConnection.getCustomer(txtUserName.Text , hash);

            if(customers.Count() != 0)
            {
                
                foreach (var item in customers)
                {
                    Customer customer = new Customer(item.CustomerID,item.LastName, item.FirstName, item.Address, item.City, item.State,
                        item.Zip, item.Email, item.UserName, item.Passward );
                    UserBookForm userBook = new UserBookForm(customer);
                    userBook.Show();
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Please try again");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
