using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tesha_s_Cofee_Shop.UI
{
    class MenuUI
    {
        public static void header(string name)
        {
            Console.WriteLine("********************************************");
            Console.WriteLine("*          "+name+" Coffee Shop             *");
            Console.WriteLine("********************************************");
        }
        // ------------- MAIN MENU ------------
        public static char MainMenu()
        {
            Console.WriteLine("");
            Console.WriteLine("1- Add Menu Item");
            Console.WriteLine("2- View the cheapest item in the menu");
            Console.WriteLine("3- View the Drink's Menu");
            Console.WriteLine("4- View the Food's Menu");
            Console.WriteLine("5- Add Order");
            Console.WriteLine("6- Fulfill the Order");
            Console.WriteLine("7- View the Order's List");
            Console.WriteLine("8- Total Payable Amount");
            Console.WriteLine("9- Exit");
            Console.WriteLine("Enter Your Option: ");
            char op;
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
        // -------- invalid option ------
        public static void Invalid()
        {
            Console.WriteLine("Wrong Input");
        }
    }
}
