using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSMS3.BL
{
    class customer
    {
        private string name;
        private int qty;
        private string category;  
        private string author;
        private int price;

        public string Name { get => name; set => name = value; }
        public int Qty { get => qty; set => qty = value; }
         public string Author { get => author; set => author = value; }
         public string Category { get => category; set => category = value; }
        public int Price { get => price; set => price = value; }

        public BooksBL BooksBL
        {
            get => default;
            set
            {
            }
        }

        public Buy Buy
        {
            get => default;
            set
            {
            }
        }

        public customer(string name,string author, string category, int qty, int price)
        {
            this.name = name;
            this.author = author;
            this.category = category;
            this.qty = qty;
            this.price = price;
        }
        public customer(string name, int qty, int price)
        {
            this.name = name;
            this.qty = qty;
            this.price = price;
        }
    }
}
