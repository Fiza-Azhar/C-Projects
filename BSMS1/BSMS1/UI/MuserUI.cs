using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BSMS1.BL;
namespace BSMS1.UI
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
    }
}
