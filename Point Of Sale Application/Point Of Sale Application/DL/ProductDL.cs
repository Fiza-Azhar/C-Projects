using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Point_Of_Sale_Application.BL;
using System.IO;
namespace Point_Of_Sale_Application.DL
{
    class ProductDL
    {
        static public List<Product> products = new List<Product>();
        // ---------- adding into list ---------
        public static void AddProductIntoList(Product p)
        {
            products.Add(p);
        }
        // ----------- View Sales Tax ------------
        public static void ViewSalesTax()
        {
            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].getP_ctg() == "Grocery" || products[i].getP_ctg() == "grocery")
                {
                    Console.Write("Product Name: " + products[i].getProdName());
                    Console.WriteLine("Sales Tax: " + products[i].getSalesTax() + "%");
                }
                else if (products[i].getP_ctg() == "Fruit" || products[i].getP_ctg() == "fruit")
                {
                    Console.Write("Product Name: " + products[i].getProdName());
                    Console.WriteLine("Sales Tax: " + products[i].getSalesTax() + "%");
                }
                else
                {
                    Console.Write("Product Name: " + products[i].getProdName());
                    Console.WriteLine("Sales Tax: " + products[i].getSalesTax() + "%");
                }
            }
        }
        // -------------- storing in File ------------
        public static void StoreProductIntoFile(string path, Product p)
        {
            StreamWriter f1 = new StreamWriter(path, true);
            f1.WriteLine(p.getProdName() + "," + p.getP_ctg() + "," + p.getPrice() + "," + p.getStock() + "," + p.getMinQty());
            f1.Flush();
            f1.Close();
        }
        // ------------READ FROM FILE ------------
        public static bool readProductsFromFile(string path)
        {
            StreamReader file = new StreamReader(path);
            string record;
            if (File.Exists(path))
            {
                while ((record = file.ReadLine()) != null)
                {
                    string[] splittedRecord = record.Split(',');
                    string name = splittedRecord[0];
                    string type = (splittedRecord[1]);
                    int price = int.Parse(splittedRecord[2]);
                    int Stock = int.Parse(splittedRecord[3]);
                    int minQ = int.Parse(splittedRecord[4]);
                    Product product = new Product(name, type, price, Stock, minQ);
                    AddProductIntoList(product);
                }
                file.Close();
                return true;
            }
             else
             {
                return false;
             }
           
        }
        // ----------- Sorted list ------------
        static public List<Product> SortedData()
        {
            List<Product> sortList = new List<Product>();
            sortList = products.OrderByDescending(o => o.getPrice()).ToList();
            return sortList;
        }
        // ------------- products to b ordered -------------
        public static void OrderProducts()
        {
            Console.WriteLine("Products To be Ordered are: ");
            foreach(Product i in products)
            {
                if(i.getStock() <= i.getMinQty())
                {
                    Console.WriteLine(i.getProdName());
                }
            }
        }
    }
}
