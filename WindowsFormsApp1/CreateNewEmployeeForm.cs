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
    public partial class CreateNewEmployeeForm : Form
    {
        public CreateNewEmployeeForm()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if(txtAddress.Text == "" || txtCode.Text == "" || txtFullName.Text == "")
            {
                MessageBox.Show("Required fields");
            }
            else
            {
                Employee employee = new Employee(Int32.Parse(txtCode.Text), txtFullName.Text, txtAddress.Text);
                if (DBConnection.insertEmployee(employee))
                {
                    MessageBox.Show("Employee created succesfully");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("This employee code is used");
                }
            }
               
           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
