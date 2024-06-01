using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using Tesha_s_Cofee_Shop.BL;
namespace Tesha_s_Cofee_Shop.DL
{
    class OrderDL
    {
        internal MenuItem MenuItem
        {
            get => default;
            set
            {
            }
        }

        public static List<string> OrderList()
        {
            if (MenuDL.orders.Count != 0)
            {
                return MenuDL.orders;
            }
            return null;
        }
        public static void AddOrder(string n)
        {
            bool flag = false;
            foreach (MenuItem i in MenuDL.menu)
            {
                if (i.getName() == n && !(MenuDL.orders.Contains(n)))
                {
                    MenuDL.orders.Add(n);
                    flag = true;
                    break;
                }
            }
            if (flag == false)
            {
                Console.WriteLine("This item is currently unavailable ...");
            }
        }
        public static void fulfill_Order()
        {
            if (MenuDL.orders.Count != 0)
            {
                for (int i = 0; i < MenuDL.orders.Count; i++)
                {
                    Console.WriteLine("The {0} is ready! ", MenuDL.orders[i]);
                    MenuDL.orders.RemoveAt(i);
                    break;
                }
            }
            else
            {
                Console.WriteLine("All orders have been fulfilled...");
            }
        }
    }
}
