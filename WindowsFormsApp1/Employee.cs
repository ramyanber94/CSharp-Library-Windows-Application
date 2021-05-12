using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Employee
    {
        private int employeeCode;

        public int EmployeeCode
        {
            get { return employeeCode; }
            set { employeeCode = value; }
        }

        private string fullName;

        public string FullName
        {
            get { return fullName; }
            set { fullName = value; }
        }
        private string address;

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public Employee(int employeeCode, string fullName, string address)
        {
            this.employeeCode = employeeCode;
            this.fullName = fullName;
            this.address = address;
        }
    }
}
