using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Point_Of_Sale_Application.BL;
namespace Point_Of_Sale_Application.UI
{
    class MuserUI
    {
        // ---------- Adding User ------------
        public static Muser AddUser()
        {
            Console.WriteLine("Enter UserName: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Password: ");
            string Pass = Console.ReadLine();
            Console.WriteLine("Enter Role: ");
            string role = Console.ReadLine();
            Muser user = new Muser(name, Pass, role);
            return user;
        }

        public static Muser AddUserWithoutrole()
        {
            Console.Write("Enter UserName: ");
            string name = Console.ReadLine();
            Console.Write("Enter Password: ");
            string password = Console.ReadLine();
            Muser user = new Muser(name, password);
            return user;
        }
    }
}
