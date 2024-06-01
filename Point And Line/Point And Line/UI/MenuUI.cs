using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_And_Line.UI
{
    class MenuUI
    {
        static public void header()
        {
            Console.WriteLine("\t\t*************************************");
            Console.WriteLine("\t\t        POINT LINE APPLICATION       ");
            Console.WriteLine("\t\t*************************************");
        }
        public static int MainMenu()
        {
            header();
            Console.WriteLine("-----Main Menu-----   ");
            Console.WriteLine("");
            Console.WriteLine("1- Make a line  ");
            Console.WriteLine("2- Update the begin point");
            Console.WriteLine("3- Update the end point");
            Console.WriteLine("4- Show the begin point");
            Console.WriteLine("5- Show the end point");
            Console.WriteLine("6- Get the length of the line");
            Console.WriteLine("7- Get the gradient of the line ");
            Console.WriteLine("8- Find the distance of begin point from zero coordinates ");
            Console.WriteLine("9- Find the distance of end point from zero coordinates ");
            Console.WriteLine("10- Exit");
            Console.Write("Choose your option: ");
            int option = int.Parse(Console.ReadLine());
            return option;
        }
        public static void ClearScreen()
        {
            Console.WriteLine("Press any key to continue....");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
