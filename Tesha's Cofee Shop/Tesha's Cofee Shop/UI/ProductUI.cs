using System;
using Tesha_s_Cofee_Shop.BL;
using Tesha_s_Cofee_Shop.DL;
namespace Tesha_s_Cofee_Shop.UI
{
    class ProductUI
    {
        public static MenuItem TakeItemInput()
        {
            Console.WriteLine("Enter product Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Price: ");
            int price = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Type: ");
            string type = Console.ReadLine();
           /* MenuItem item = new MenuItem(name, type, price);
            return item;*/
            MenuItem m = new MenuItem();
            m.setName(name);
            m.setType(type);
            m.setPrice(price);
            return m;
        }
        public static void viewDrinksMenu()
        {
            if (MenuDL.menu.Count != 0)
            {
                Console.WriteLine("Name \t Type \t price");
                foreach (MenuItem item in MenuDL.menu)
                {
                    if (item.getType() == "drink")
                    {
                        Console.WriteLine(item.getName() + "\t" + item.getType() + "\t" + item.getPrice());
                    }

                }
            }
            else
            {
                Console.WriteLine("No entries yet");
            }
        }
        public static void viewFoodMenu()
        {
            if (MenuDL.menu.Count != 0)
            {
                foreach (MenuItem item in MenuDL.menu)
                {
                    if (item.getType() == "food")
                    {
                        Console.WriteLine(item.getName() + "\t" + item.getType() + "\t" + item.getPrice());
                    }
                }
            }
            else
            {
                Console.WriteLine("No entries yet");
            }
        }

    }
}
