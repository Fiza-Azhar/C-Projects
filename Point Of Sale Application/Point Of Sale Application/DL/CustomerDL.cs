using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Point_Of_Sale_Application.BL;
using Point_Of_Sale_Application.UI;
namespace Point_Of_Sale_Application.DL
{
    class CustomerDL
    {
        static List<Customer> buyProducts = new List<Customer>();

        public static void addBuyProductsIntoList(Customer P)
        {
            buyProducts.Add(P);
        }
        public static void StoreBuyProductIntoFile(string path, Customer a)
        {
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(a.getProName() + "," + a.getProQuantity());
            file.Flush();
            file.Close();
        }

        public static bool readBuyProductFromFile(string path)
        {
            StreamReader file = new StreamReader(path);
            string record;
            if (File.Exists(path))
            {
                while ((record = file.ReadLine()) != null)
                {
                    string[] splittedRecord = record.Split(',');
                    string name = splittedRecord[0];
                    int Quantity = int.Parse(splittedRecord[1]);
                    Customer C = new Customer();
                    C.setProName(name);
                    C.setProQuantity(Quantity);
                    addBuyProductsIntoList(C);
                }
                file.Close();
                return true;
            }
            else
            {
                return false;
            }
        }

        static float calculateTax()
        {
            float totalTax = 0;
            for (int i = 0; i < buyProducts.Count; i++)
            {
                for (int j = 0; j < ProductDL.products.Count; j++)
                {
                    if (buyProducts[i].getProName() == ProductDL.products[j].getProdName())
                    {
                        totalTax = ((ProductDL.products[j].getSalesTax()) / 100) * (buyProducts[i].getProQuantity() * ProductDL.products[j].getPrice());
                    }
                }
            }
            return totalTax;
        }
        public static float GenerateInvoice()
        {
            float total = 0;
            float count = 0;
            for (int i = 0; i < buyProducts.Count; i++)
            {
                for (int j = 0; j < ProductDL.products.Count; j++)
                {
                    if (buyProducts[i].getProName() == ProductDL.products[j].getProdName())
                    {
                        count = calculateTax();
                        count = count + total;
                        total = ProductDL.products[i].getPrice() + count;
                    }
                }
            }
            return total;
        }
    }
}
