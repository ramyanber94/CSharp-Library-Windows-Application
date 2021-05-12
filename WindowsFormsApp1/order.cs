using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class order
    {
        private int qty;

        public int Qty
        {
            get { return qty; }
            set { qty = value; }
        }

        private DateTime dateOfOrder;

        public DateTime DateOfOrder
        {
            get { return dateOfOrder; }
            set { dateOfOrder = value; }
        }


    }
}
