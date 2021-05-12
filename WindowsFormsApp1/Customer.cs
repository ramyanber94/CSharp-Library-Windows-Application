using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Customer
    {
        private string firstName;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        private string lastName;

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        private string userName;

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        private string passward;

        public string Passward
        {
            get { return passward; }
            set { passward = value; }
        }

        private string address;

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        private string zip;

        public string Zip
        {
            get { return zip; }
            set { zip = value; }
        }

        private string city;

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        private string state;

        public string State
        {
            get { return state; }
            set { state = value; }
        }

        private int customerID;

        public int CustomerID
        {
            get { return customerID; }
            set { customerID = value; }
        }


        public Customer(string lastName, string firstName, string address, string city, string state,
            string zip,string email, string userName, string passward )
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.address = address;
            this.city = city;
            this.state = state;
            this.zip = zip;
            this.email = email;
            this.userName = userName;
            this.passward = passward;
        
        }

        public Customer(int customerID,  string lastName, string firstName, string address, string city, string state, string zip,
            string email, string userName, string passward )
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.userName = userName;
            this.passward = passward;
            this.address = address;
            this.zip = zip;
            this.city = city;
            this.state = state;
            this.customerID = customerID;
        }

        public Customer()
        {
        }
    }
}
