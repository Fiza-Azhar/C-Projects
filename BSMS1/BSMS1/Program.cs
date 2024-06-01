using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using BSMS1.BL;
using BSMS1.DL;
using BSMS1.UI;

namespace BSMS1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "users.txt";
            Muser user = MuserUI.AddUser();
    
            Muser valid = MuserDL.signIn(user);
            if (valid != null)
            {
                Console.WriteLine("valid user");
            }
            else
            {
                Console.WriteLine("not valid user");
            }
            /*    Muser user = MuserUI.AddUser();
                MuserDL.readFromFile(path);
                Muser u = MuserDL.signIn(user);
                if(u != null)
                {
                    Console.WriteLine("Valid");
                }
                else
                {
                    Console.WriteLine("inValid");

                }*/
        }

        
    }
}