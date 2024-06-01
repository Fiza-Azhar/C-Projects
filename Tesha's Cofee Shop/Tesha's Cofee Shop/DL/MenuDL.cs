using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using Tesha_s_Cofee_Shop.BL;
namespace Tesha_s_Cofee_Shop.DL
{
    class MenuDL
    {
        public static List<MenuItem> menu = new List<MenuItem>();
        public static List<string> orders = new List<string>();

        internal MenuItem MenuItem
        {
            get => default;
            set
            {
            }
        }

        public static void addItemIntoMenu(MenuItem item)
        {
            menu.Add(item);
        }
        // ------- Saving Product Data into File -------
        public static void StoreProductDataIntoFile(string path, MenuItem item)
        {
            StreamWriter f1 = new StreamWriter(path, true);
            f1.WriteLine(item.getName() + "," + item.getPrice() + "," + item.getType());
            f1.Flush();
            f1.Close();
        }
        // ------------Reading from file ----------
         public static bool readProductDataFromFile(string path)
         {
             StreamReader f = new StreamReader(path);
             string record;
             if (File.Exists(path))
             {
                 while ((record = f.ReadLine()) != null)
                 {
                     string[] splittedRecord = record.Split(',');
                     string name = splittedRecord[0];
                    int price = int.Parse(splittedRecord[1]);
                    string type = splittedRecord[2];
                     MenuItem m = new MenuItem(name, type, price);
                     addItemIntoMenu(m);
                 }
                 f.Close();
                 return true;
             }
             else
             {
                 return false;
             }
         }
        public static string cheapest_item()
        {
            string small = " ";
            int c = 1;
            int smallest = 1;
            foreach (MenuItem i in MenuDL.menu)
            {
                if (c == 1)
                {
                    smallest = i.getPrice();
                    c = 2;
                }
                if (smallest > i.getPrice())
                {
                    smallest = i.getPrice();
                    small = i.getName();
                }
            }
            return small;
        }
        public static int DueAmount()
        {
            int price = 0;
            foreach (string n in MenuDL.orders)
            {
                foreach (MenuItem item in MenuDL.menu)
                {
                    if (n == item.getName())
                    {
                        price = price + item.getPrice();
                    }
                }
            }
            return price;
        }

    }
}
