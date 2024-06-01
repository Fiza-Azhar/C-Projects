using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tesha_s_Cofee_Shop.BL;
using Tesha_s_Cofee_Shop.UI;
using Tesha_s_Cofee_Shop.DL;
namespace Tesha_s_Cofee_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string menuPath = "menu.txt";
            string ShopName;
            //MenuDL.readProductDataFromFile(menuPath);
            Console.Write("Enter Shop Name: ");
            ShopName = Console.ReadLine();
            CoffeShop n = new CoffeShop(ShopName);
            n.setName(ShopName);
            //Console.Clear();
            if (MenuDL.readProductDataFromFile(menuPath))
            {
                Console.WriteLine("Products Data Loaded Successfully");
            }

            char op;
            do
            {
                //Console.Clear();
                MenuUI.header(ShopName);
                op = MenuUI.MainMenu();
                // ------------------Adding Item in Menu ---------------
                if (op == '1')
                {
                    Console.Clear();
                    MenuUI.header(ShopName);
                    MenuItem item = ProductUI.TakeItemInput();
                    MenuDL.addItemIntoMenu(item);
                    MenuDL.StoreProductDataIntoFile(menuPath, item);
                }
                // ----------------- Seeing cheapest item ---------------
                else if (op == '2')
                {
                    Console.Clear();
                    MenuUI.header(ShopName);
                    string Cheap_item;
                    Cheap_item = MenuDL.cheapest_item();
                    Console.WriteLine("Cheapest item is: {0}", Cheap_item);
                    Console.WriteLine(" ");
                }
                // ----------------------- View drinks menu ----------------
                else if (op == '3')
                {
                    Console.Clear();
                    MenuUI.header(ShopName);
                    ProductUI.viewDrinksMenu();
                }
                // ---------------------- View food menu -----------------
                else if (op == '4')
                {
                    Console.Clear();
                    MenuUI.header(ShopName);
                    ProductUI.viewFoodMenu();
                }
                // --------------------- Adding order --------------------
                else if (op == '5')
                {
                    Console.Clear();
                    MenuUI.header(ShopName);
                    ProductUI.viewDrinksMenu();
                    ProductUI.viewFoodMenu();
                    Console.WriteLine("What you want to order: ");
                    string name = Console.ReadLine();
                    OrderDL.AddOrder(name);
                }
                // ------------------- Fulfill orders ------------
                else if (op == '6')
                {
                    Console.Clear();
                    MenuUI.header(ShopName);
                    OrderDL.fulfill_Order();
                }
                // ------------------ View Order list -------------
                else if (op == '7')
                {
                    Console.Clear();
                    MenuUI.header(ShopName);
                    List<string> order = new List<string>();
                    order = OrderDL.OrderList();
                    for(int i = 0; i < order.Count; i++)
                    {
                        Console.WriteLine(MenuDL.orders[i]);
                    }
                }
                // ------------------ View Due Amount -------------
                else if(op == '8')
                {
                    Console.Clear();
                    MenuUI.header(ShopName);
                    int total = MenuDL.DueAmount();
                    Console.WriteLine("Total due amount is: {0}", total);
                    Console.WriteLine(" ");
                }
                MenuUI.clearScreen();
            } while (op != '9');
        }
    }
}
