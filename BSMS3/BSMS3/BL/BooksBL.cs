using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSMS3.BL
{
    public class BooksBL
    {
        private string Bname;
        private string author;
        private string ctg;
        private int stock;
        private int price;

        public string Bname1 { get => Bname; set => Bname = value; }
        public string Author { get => author; set => author = value; }
        public string Ctg { get => ctg; set => ctg = value; }
        public int Stock { get => stock; set => stock = value; }
        public int Price { get => price; set => price = value; }
        public BooksBL(string Bname, string author, string ctg, int stock, int price)
        {
            this.Bname = Bname;
            this.author = author;
            this.ctg = ctg;
            this.stock = stock;
            this.price = price;
        }
    }
}
