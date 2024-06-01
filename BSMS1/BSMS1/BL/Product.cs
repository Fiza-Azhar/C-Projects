using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSMS1.BL
{
    class Product
    {
        private string bName;
        private int bPrice;
        private int bQty;

        public string BName { get => bName; set => bName = value; }
        public int BPrice { get => bPrice; set => bPrice = value; }
        public int BQty { get => bQty; set => bQty = value; }

        public Product(string bName, int bPrice, int bQty)
        {
            this.bName = bName;
            this.bPrice = bPrice;
        }
    }
}
