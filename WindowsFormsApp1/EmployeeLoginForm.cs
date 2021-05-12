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
    public partial class EmployeeLoginForm : Form
    {
        public EmployeeLoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            List<Employee> employees = DBConnection.getEmployee(Int32.Parse(txtEmployeeCode.Text));

            if (employees.Count() != 0)
            {

                foreach (var item in employees)
                {
                    Employee employee = new Employee(item.EmployeeCode, item.FullName, item.Address);
                    AlterBooksForm bookForm = new AlterBooksForm(employee);
                    bookForm.Show();
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("User name or password is wrong please try again");
            }
        }

        private void btnCreateEmployee_Click(object sender, EventArgs e)
        {
            CreateNewEmployeeForm newEmployee = new CreateNewEmployeeForm();
            newEmployee.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
