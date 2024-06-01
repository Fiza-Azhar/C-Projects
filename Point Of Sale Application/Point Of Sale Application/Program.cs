using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Point_Of_Sale_Application.BL;
using Point_Of_Sale_Application.UI;
using Point_Of_Sale_Application.DL;
namespace Point_Of_Sale_Application
{
    class Program
    {
        static void Main(string[] args)
        {
            string userPath = "users.txt";
            string productPath = "products.txt";
            string BuyPath = "buy products.txt";
            MuserDL.readUsersFromFile(userPath);
            ProductDL.readProductsFromFile(productPath);
            CustomerDL.readBuyProductFromFile(BuyPath);
            if (MuserDL.readUsersFromFile(productPath))
            {
                Console.WriteLine("Successfully read from file   ");
            }
            if (ProductDL.readProductsFromFile(productPath))
            {
                Console.WriteLine("Successfully read from file   ");
            }
            if (CustomerDL.readBuyProductFromFile(BuyPath))
            {
                Console.WriteLine("Successfully read from file   ");
            }
            char op;
            do
            {
                Console.Clear();
                MenuUI.Header();
                op = MenuUI.MainMenu();
                if (op == '1')
                {
                    Muser user = MuserDL.SignIn();
                    if (user != null)
                    {
                        if (user.isAdmin())
                        {
                            Console.Clear();
                            MenuUI.Header();
                            Console.WriteLine("ADMIN");
                            MenuUI.clearScreen();
                            do
                            {
                                Console.Clear();
                                MenuUI.Header();
                                op = MenuUI.AdminMenu();
                                Console.Clear();
                                if (op == '1')
                                {
                                    MenuUI.Header();
                                    Product p = ProductUI.AddProduct();
                                    ProductDL.AddProductIntoList(p);
                                    ProductDL.StoreProductIntoFile(productPath, p);
                                }
                                else if (op == '2')
                                {
                                    MenuUI.Header();
                                    ProductUI.viewAllProducts();
                                }
                                else if (op == '3')
                                {
                                    MenuUI.Header();
                                    ProductUI.HighestPrice();
                                }
                                else if (op == '4')
                                {
                                    MenuUI.Header();
                                    ProductDL.ViewSalesTax();
                                }
                                else if (op == '5')
                                {
                                    MenuUI.Header();
                                    ProductDL.OrderProducts();
                                }
                                MenuUI.clearScreen();
                                Console.ReadKey();
                            } while (op != '6');
                        }
                        else
                        {
                            Console.Clear();
                            MenuUI.Header();
                            Console.WriteLine("USER");
                            Console.ReadKey();
                            do
                            {
                                Console.Clear();
                                MenuUI.Header();
                                op = MenuUI.Customer_Menu();
                                Console.Clear();
                                if (op == '1')
                                {
                                    MenuUI.Header();
                                    ProductUI.viewAllProducts();
                                    Console.ReadKey();
                                }
                                else if (op == '2')
                                {
                                    MenuUI.Header();
                                    Customer p = CustomerUI.BuyProducts(ProductDL.products);
                                    CustomerDL.addBuyProductsIntoList(p);
                                    CustomerDL.StoreBuyProductIntoFile(BuyPath, p);

                                }
                                else if (op == '3')
                                {
                                    MenuUI.Header();
                                    float total = CustomerDL.GenerateInvoice();
                                    Console.Write("Total Payable Bill is: " + total);
                                    Console.Read();
                                }
                            } while (op != '4');
                        }
                    }
                }
                else if (op == '2')
                {
                    Muser user = MuserUI.AddUser();
                    MuserDL.addUserIntoList(user);
                    MuserDL.storeUserintoFile(user, userPath);
                }

            } while (op != '3');

        }
    }
}
