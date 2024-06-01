using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tesha_s_Cofee_Shop.DL;
namespace Tesha_s_Cofee_Shop.BL
{
    class CoffeShop
    {
        private string shop_name;
        public CoffeShop(string shop_name)
        {
            this.shop_name = shop_name;
        }
        public CoffeShop()
        {

        }

        internal MenuItem MenuItem
        {
            get => default;
            set
            {
            }
        }

        public string getName()
        {
            return shop_name;
        }
        public void setName(string name)
        {
            shop_name = name;
        }
    }
}
