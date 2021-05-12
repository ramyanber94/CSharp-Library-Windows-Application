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
    public partial class UserBookForm : Form
    {
        Customer customer;
        public UserBookForm(Customer customer)
        {
            InitializeComponent();
            this.customer = customer;
           
        }

        private void UserBook_Load(object sender, EventArgs e)
        {
            listDisplayBooks.HorizontalScrollbar = true;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFirstName.Text = customer.FirstName;
            txtLastName.Text = customer.LastName;
            txtEmail.Text = customer.Email;
            txtState.Text = customer.State;
            txtCity.Text = customer.City;
            txtUserName.Text = customer.UserName;
            txtZip.Text = customer.Zip;
            txtAddress.Text = customer.Address;
            txtOrderQty.Text = DBConnection.orderQty(customer.CustomerID).ToString();
        }

        private void btnFindBook_Click(object sender, EventArgs e)
        {
            if (!txtISBN.Text.Equals(""))
            {
                List<Book> books = DBConnection.findBook(txtISBN.Text);
                foreach (var b in books)
                {
                    listDisplayBooks.Items.Add(b.GetDisplayText(" - "));
                }
            }
            else
            {
                MessageBox.Show("Please provide the book ISBN in the text field");
            }
        }

        private void UserBook_Shown(object sender, EventArgs e)
        {
            lblWelcome.Text = "Welcome " + customer.FirstName + " " + customer.LastName;
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            int BookID = 0;
            int qty = 0;
            List<Book> books = DBConnection.findBook(txtISBN.Text);
            foreach (var item in books)
            {
                BookID = item.BookID;
                qty = item.Qty;
            }
            if(qty >= Convert.ToInt32(numQty.Value))
            {
                DBConnection.bookingBook(customer.CustomerID, BookID, Convert.ToInt32(numQty.Value), dateOfOreder.Value);
                DBConnection.updateBookQty(Convert.ToInt32(numQty.Value), BookID);
                MessageBox.Show("Book is booked");
            }
            else
            {
                MessageBox.Show("The Book's quantity is not enough");
            }
            
            
        }

        private void listDisplayBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                listDisplayBooks.HorizontalScrollbar = true;
                string[] tmp = listDisplayBooks.SelectedItem.ToString().Split(',');
                string isbn = tmp[0].Replace("ISBN:", "");
                txtISBN.Text = isbn;
            }catch(Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        private void btnDisplayAll_Click(object sender, EventArgs e)
        {
            listDisplayBooks.Items.Clear();
            List<Book> books = DBConnection.DisplayAllBooks();
            foreach (var item in books)
            {
                listDisplayBooks.Items.Add(item.GetDisplayText(" , "));
                listDisplayBooks.Items.Add("\n");

            }
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
