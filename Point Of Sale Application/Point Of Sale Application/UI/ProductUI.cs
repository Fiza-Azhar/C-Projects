using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Point_Of_Sale_Application.BL;
using Point_Of_Sale_Application.DL;
namespace Point_Of_Sale_Application.UI
{
    class ProductUI
    {
        //  -------------- Adding Product ------------
        public static Product AddProduct()
        {
            string name;
            string ctg;
            int price;
            int qty;
            int min_qty;
            Console.Write("Enter Product Name: ");
            name = Console.ReadLine();
            Console.Write("Enter Product Category: ");
            ctg = Console.ReadLine();
            Console.Write("Enter Product Price: ");
            price = int.Parse(Console.ReadLine());
            Console.Write("Enter Stock Quantity: ");
            qty = int.Parse(Console.ReadLine());
            Console.Write("Enter Minimum Stock Quantity: ");
            min_qty = int.Parse(Console.ReadLine());
            Product item = new Product();
            item.setPName(name);
            item.setCategory(ctg);
            item.setPrice(price);
            item.setStock(qty);
            item.setMinQty(min_qty);
            item.setSalesTax();
            return item;
        }
        // ---------------- View All Products -----------
        static public void viewAllProducts()
        {
            Console.WriteLine("Name \t\t Price \t\t Category \t\t Avalable QTY \t\t Threshold QTY");
            foreach (Product p in ProductDL.products)
            { 
                Console.WriteLine(p.getProdName() + "\t\t" + p.getPrice() + "\t\t" + p.getP_ctg() + "\t\t" + p.getStock() + "\t\t" + p.getMinQty());
            }
        }
        // ------------- View Product of high price ---------
        static public void HighestPrice()
        {
            List<Product> sortedList = new List<Product>();
            sortedList = ProductDL.SortedData();
            Console.WriteLine("Product with highest price is: ");
            Console.WriteLine(sortedList[0].getProdName());
            Console.WriteLine("Price is ");
            Console.WriteLine(sortedList[0].getPrice());
        }
    }
}
