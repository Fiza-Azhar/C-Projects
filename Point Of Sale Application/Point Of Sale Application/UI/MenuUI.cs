using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_Of_Sale_Application.UI
{
    class MenuUI
    {
        public static void Header()
        {
            Console.WriteLine("\t\t########################################");
            Console.WriteLine("\t\t         Point Of Sale Application      ");
            Console.WriteLine("\t\t########################################");
        }
        public static char MainMenu()
        {
            char op;
            Console.WriteLine("\t ---------- Main Menu ----------");
            Console.WriteLine("");
            Console.WriteLine("Press..");
            Console.WriteLine(" 1-Sign In");
            Console.WriteLine(" 2-Sign up");
            Console.WriteLine(" 3-Exit");
            Console.Write("Enter Option: ");
            op = char.Parse(Console.ReadLine());
            return op;
        }
        public static char AdminMenu()
        {
            char op;
            Console.WriteLine("\t ---------- Admin Menu ----------");
            Console.WriteLine("1- Add Products.");
            Console.WriteLine("2- View All Products.");
            Console.WriteLine("3- Find Product with Highest Unit Price.");
            Console.WriteLine("4- View Sales Tax of All Products.");
            Console.WriteLine("5- Products to be Ordered.(less than threshold)");
            Console.WriteLine("6- Exit");
            Console.Write("Enter Option: ");
            op = char.Parse(Console.ReadLine());
            return op;
        }
        public static char Customer_Menu()
        {
            char op;
            Console.WriteLine("\t ---------- Customer Menu ----------");
            Console.WriteLine("1- View all the products");
            Console.WriteLine("2- Buy the products");
            Console.WriteLine("3- Generate invoice");
            Console.WriteLine("4- Exit");
            Console.Write("Enter Option: ");
            op = char.Parse(Console.ReadLine());
            return op;
        }
        // ------ClearScreen Function -------
        public static void clearScreen()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
