using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Book
    {
        private int qty;

        public int Qty
        {
            get { return qty; }
            set { qty = value; }
        }

        private string bookName;

        public string BookName
        {
            get { return bookName; }
            set { bookName = value; }
        }



        private string title;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        private string descreption;

        public string Descreption
        {
            get { return descreption; }
            set { descreption = value; }
        }

        private string category;

        public string Category
        {
            get { return category; }
            set { category = value; }
        }

        private string isbn;
        public string ISBN
        {
            get { return isbn; }
            set { isbn = value; }
        }

        private int bookID;

        public int BookID
        {
            get { return bookID; }
            set { bookID = value; }
        }

        public Book(int bookID, string title, string category, string descreption,  string isbn, int qty,  string bookName)
        {
            this.qty = qty;
            this.bookName = bookName;
            this.title = title;
            this.descreption = descreption;
            this.category = category;
            this.isbn = isbn;
            this.bookID = bookID;
        }

        public Book(string title, string category, string descreption , string isbn , int qty , string bookName)
        {
            this.title = title;
            this.category = category;
            this.descreption = descreption;
            this.isbn = isbn;
            this.qty = qty;
            this.bookName = bookName;
        }

        public Book()
        {
        }

        public virtual string GetDisplayText(string sep) =>
           "ISBN:" + isbn + sep +"Book Name: "+bookName + sep +"Title: "+title + sep +"Category: "+category + sep +"Descreption: "+ descreption + sep +"Quantity: "+ qty;
    }
}

