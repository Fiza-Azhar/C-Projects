using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BSMS3.BL;
using System.IO;
namespace BSMS3.DL
{
    class CustomerDL
    {
        private static List<customer> orders = new List<customer>();

        internal static List<customer> Orders { get => orders; set => orders = value; }
        public static void AddIntoList(customer book)
        {
            orders.Add(book);
        }
    }
}
