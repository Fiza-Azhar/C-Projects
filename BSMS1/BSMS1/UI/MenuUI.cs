using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSMS1.UI
{
    class MenuUI
    {
        public static void header()
        {
            Console.WriteLine("\t\t@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
            Console.WriteLine("\t\t@               Book Store Management system                 @");
            Console.WriteLine("\t\t@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
        }
        // -----Main Menu ------
        static char menu()
        {
            header();
            char op;
            Console.WriteLine("");
            Console.WriteLine("\tPress 1 to Login:");
            Console.WriteLine("\tPress 2 to Exit:");
            Console.Write("\tEnter Option: ");
            op = char.Parse(Console.ReadLine());
            return op;
        }
        //------ Admin Menu-------
        public static char admin_menu()
        {
            Console.Clear();
            header();
            char op;
            Console.WriteLine("");
            Console.WriteLine("------- Admin Menu -------");
            Console.WriteLine("");
            Console.WriteLine("Press 1 to Add New Book:");
            Console.WriteLine("Press 2 to view all available books:");
            Console.WriteLine("Press 3 to Update an Exisitng Book Record: ");
            Console.WriteLine("Press 4 to Delete an Exisitng item:");
            Console.WriteLine("Press 5 to Add User");
            Console.WriteLine("Press 6 to Exit: ");
            Console.WriteLine("Enter Option: ");
            op = char.Parse(Console.ReadLine());
            return op;
        }

        //------- Customer menu -------
        public static char user_menu()
        {
            Console.Clear();
            header();
            Char op;
            Console.WriteLine("");
            Console.WriteLine("-------- User Menu -------");
            Console.WriteLine("Press 1 to Buy an item: ");
            Console.WriteLine("Press 2 to view the cart: ");
            Console.WriteLine("Press 3 to Exit: ");
            Console.WriteLine("Enter Option: ");
            op = char.Parse(Console.ReadLine());
            return op;
        }
    }
}
