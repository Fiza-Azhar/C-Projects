using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Point_Of_Sale_Application.BL;
namespace Point_Of_Sale_Application.UI
{
    class CustomerUI
    {
        public static Customer BuyProducts(List<Product> products)
        {
            string name;
            int qty;
            Console.WriteLine("Enter Product Name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter Quantity: ");
            qty = int.Parse(Console.ReadLine());
            Customer p = new Customer();
            p.setProName(name);
            p.setProQuantity(qty);
            foreach(Product i in products)
            {
                if(i.getProdName() == name)
                {
                    int stk = i.getStock() - qty;
                    i.setStock(stk);
                }
            }
            return p;
        }
    }
}
