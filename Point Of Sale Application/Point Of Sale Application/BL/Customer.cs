using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_Of_Sale_Application.BL
{
    class Customer
    {
        private string ProductName;
        private int Quantity;

        public Customer(string ProductName, int Quantity)
        {
            this.ProductName = ProductName;
            this.Quantity = Quantity;
        }

        public Customer()
        {

        }

        internal Product Product
        {
            get => default;
            set
            {
            }
        }

        public string getProName()
        {
            return ProductName;
        }
        public void setProName(string name)
        {
            ProductName = name;
        }
        public int getProQuantity()
        {
            return Quantity;
        }
        public void setProQuantity(int qty)
        {
            Quantity = qty;
        }
    }
}
