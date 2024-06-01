using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ocean_Navigation.UI
{
    class MenuUI
    {
        public static void Header()
        {
            Console.WriteLine("\t\t\t********************************");
            Console.WriteLine("\t\t\t*       Ocean Navigation       *");
            Console.WriteLine("\t\t\t********************************");

        }
        public static char MainMenu()
        {
            Header();
            char op;
            Console.WriteLine("\t -------- MAIN MENU ----------");
            Console.WriteLine("1-Add Ship");
            Console.WriteLine("2-View Ship Position");
            Console.WriteLine("3-View Ship Serial Number");
            Console.WriteLine("4-Change Ship Position");
            Console.WriteLine("5-Exit");
            Console.Write("Your Option: ");
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
