using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_Of_Sale_Application.BL
{
    class Product
    {
        private string Pname;
        private string P_Ctg;
        private int P_Price;
        private int Stock_Qty;
        private int Minimum_Stock;
        private float SalesTax;
        public Product(string Pname, string P_Ctg, int P_Price, int Stock_Qty, int Minimum_Stock, float SalesTax)
        {
            this.Pname = Pname;
            this.P_Ctg = P_Ctg;
            this.P_Price = P_Price;
            this.Stock_Qty = Stock_Qty;
            this.Minimum_Stock = Minimum_Stock;
            this.SalesTax = SalesTax;
        }
        public Product(string Pname, string P_Ctg, int P_Price, int Stock_Qty, int Minimum_Stock)
        {
            this.Pname = Pname;
            this.P_Ctg = P_Ctg;
            this.P_Price = P_Price;
            this.Stock_Qty = Stock_Qty;
            this.Minimum_Stock = Minimum_Stock;
        }
        public Product()
        {

        }
        public string getProdName()
        {
            return Pname;
        }
        public void setPName(string name)
        {
            Pname = name;
        }
        public string getP_ctg()
        {
            return P_Ctg;
        }
        public void setCategory(string ctg)
        {
            P_Ctg = ctg;
            if (ctg == "Grocery")
            {
                SalesTax = 10;
            }
            else if (ctg == "Fruit")
            {
                SalesTax = 5;
            }
            else
            {
                SalesTax = 15;
            }
        }
        public int getStock()
        {
            return Stock_Qty;
        }
        public void setStock(int quantity)
        {
            Stock_Qty = quantity;
        }
        public int getPrice()
        {
            return P_Price;
        }
        public void setPrice(int price)
        {
            P_Price = price;
        }
        public int getMinQty()
        {
            return Minimum_Stock;
        }
        public void setMinQty(int M_qty)
        {
            Minimum_Stock = M_qty;
        }
        public float getSalesTax()
        {
            return SalesTax;
        }
        public void setSalesTax()
        {
            if (P_Ctg == "Grocery")
            {
                SalesTax = 10;
            }
            else if (P_Ctg == "Fruit")
            {
                SalesTax = 5;
            }
            else
            {
                SalesTax = 15;
            }
        }
    }
}
