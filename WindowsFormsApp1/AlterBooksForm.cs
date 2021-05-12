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
    public partial class AlterBooksForm : Form
    {
        Employee employee;
        int index = 0;
        public AlterBooksForm(Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            listDisplay.Items.Clear();
            List<Book> books = DBConnection.DisplayAllBooks();

            if (index < books.Count - 1)
            {
                index++;
            }
            else
            {
                index = 0;
            }
            listDisplay.Items.Add(books[index].GetDisplayText(" , "));
            txtSearchBook.Text = books[index].ISBN;
            listDisplay.Items.Add("\n");
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            listDisplay.Items.Clear();
            List<Book> books = DBConnection.DisplayAllBooks();
            index = 0;
            if (index == 0)
            {
                listDisplay.Items.Add(books[index].GetDisplayText(" , "));
                txtSearchBook.Text = books[index].ISBN;
                listDisplay.Items.Add("\n");
            }
            else
            {
                MessageBox.Show("These is the last record");
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            listDisplay.Items.Clear();
            List<Book> books = DBConnection.DisplayAllBooks();
            index = books.Count() - 1;
            if (index == books.Count() - 1)
            {
                listDisplay.Items.Add(books[index].GetDisplayText(" , "));
                txtSearchBook.Text = books[index].ISBN;
                listDisplay.Items.Add("\n");
            }
            else
            {
                MessageBox.Show("These is the last record");
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            listDisplay.Items.Clear();
            List<Book> books = DBConnection.DisplayAllBooks();
            if (index > 0)
            {
                index--;
            }
            else
            {
                index = books.Count() - 1;
            }
            listDisplay.Items.Add(books[index].GetDisplayText(" , "));
            txtSearchBook.Text = books[index].ISBN;
            listDisplay.Items.Add("\n");
        }

        private void btnRmove_Click(object sender, EventArgs e)
        {
            var d = MessageBox.Show("Are you sure? ", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (d == DialogResult.Yes)
            {

                if (listDisplay.GetSelected(listDisplay.SelectedIndex))
                {
                    var tmp = listDisplay.SelectedItem.ToString().Split(',');
                    string isbn = tmp[0].Replace("ISBN:", "");
                    DBConnection.deleteBook(isbn);
                    listDisplay.Items.Remove(listDisplay.SelectedItem);
                    MessageBox.Show("Book successfully deleted");
                }
            }
        }

        private void btnDisplayAll_Click(object sender, EventArgs e)
        {
            listDisplay.Items.Clear();
            List<Book> books = DBConnection.DisplayAllBooks();
            books.Count.Equals(listDisplay.Items.Count);
            foreach (var item in books)
            {
                listDisplay.Items.Add(item.GetDisplayText(" , "));
                listDisplay.Items.Add("\n");
                books = null;
            }
            
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            listDisplay.Items.Clear();
            if (!txtSearchBook.Text.Equals(""))
            {
                List<Book> books = DBConnection.findBook(txtSearchBook.Text);
                foreach (var b in books)
                {
                    listDisplay.Items.Add(b.GetDisplayText(" - "));
                }
            }
            else
            {
                MessageBox.Show("Please provide the Book ISBN in the text field");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtTitle.Text.Equals("") || txtDescreption.Text.Equals("") || txtISBN.Text.Equals("") || txtBookName.Text.Equals(""))
            {
                MessageBox.Show("These are requried field please fill");
            }
            else
            {
                Book book = new Book(txtTitle.Text, cmboCategory.Text, txtDescreption.Text, txtISBN.Text, Convert.ToInt32(numQty.Value), txtBookName.Text);
                if (DBConnection.insertBook(book))
                {
                    MessageBox.Show("Book added successfully");
                }
                else
                {
                    MessageBox.Show("Please try again later");
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtISBN.Text.Equals("") || txtTitle.Text.Equals("") || txtDescreption.Text.Equals("") || txtISBN.Text.Equals("") || txtBookName.Text.Equals(""))
            {
                MessageBox.Show("These are requried field please fill");
            }
            else
            {
                Book book = new Book(txtTitle.Text, cmboCategory.Text, txtDescreption.Text, txtISBN.Text,
             Convert.ToInt32(numQty.Value), txtBookName.Text);
                if (DBConnection.updateBook(book))
                {
                    MessageBox.Show("Book is updated succesfully");
                }
                else
                {
                    MessageBox.Show("Please try again later");
                }
            }
           
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AlterBooksForm_Load(object sender, EventArgs e)
        {
            lblEmployeeName.Text = "Welcome " + employee.FullName;
            List<string> book = DBConnection.cmboBook();
            listDisplay.HorizontalScrollbar = true;
            cmboBook.Items.AddRange(book.ToArray());
            cmboCategory.Items.AddRange(DBConnection.getCategorie().ToArray());
            cmboCategory.SelectedIndex = 0;
            book = null;
        }

        private void tabControl1_TabIndexChanged(object sender, EventArgs e)
        {
        }

        private void cmboBook_SelectedIndexChanged(object sender, EventArgs e)
        {
            listDisplay.Items.Clear();
            var tmp = cmboBook.SelectedItem.ToString().Split(',');
            string isbn = tmp[0].Replace("ISBN:", "");
            txtSearchBook.Text = isbn;
            List<Book> books = DBConnection.findBook(txtSearchBook.Text);
            foreach (var item in books)
            {

                listDisplay.Items.Add(item.GetDisplayText(" - "));

            }
            books = null;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmboBook.Items.Clear();
            List<string> book = DBConnection.cmboBook();
            cmboBook.Items.AddRange(book.ToArray());
        }
    }
}
