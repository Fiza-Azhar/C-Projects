using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using BSMS1.BL;
namespace BSMS1.DL
{
    class ProductDL
    {
        // ------- Saving Product Data into File -------
        static void saveProductData(string Path, Product book)
        {
            StreamWriter file = new StreamWriter(Path, true);
            file.WriteLine(book.BName + "," + book.BPrice + "," + book.BQty);
            file.Flush();
            file.Close();
        }
        /*public static void readFromFile(string path)
        {
            if (File.Exists(path))
            {
                StreamReader file = new StreamReader(path);
                string record;
                while ((record = file.ReadLine()) != null)
                {
                    string name = parseData(record, 1);
                    string pass = parseData(record, 2);
                    string role = parseData(record, 3);
                    Muser user = new Muser(name, path, role);
                    AddIntoList(user);
                }
                file.Close();
            }
        }*/
        public static string parseData(string record, int field)
        {
            int comma = 1;
            String item = "";
            for (int x = 0; x < record.Length; x++)
            {
                if (record[x] == ',')
                {
                    comma++;
                }
                else if (comma == field)
                {
                    item = item + record[x];
                }
            }
            return item;
        }
        // ------ Reading product file ------
        static void readProductData(string Path, string[] book, int[] price, int[] quantity, ref int productCount)
        {
            if (File.Exists(Path)) 
            { 
                StreamReader file = new StreamReader(Path);
            string record;
            while ((record = file.ReadLine()) != null)
            {
                   /* string name = parseData(record, 1);
                    string pass = parseData(record, 2);
                    string role = parseData(record, 3);*/
                    string Book = parseData(record, 1);
                    int Price = int.Parse(parseData(record, 2));
                    int Qty = int.Parse(parseData(record, 3));
            }
            fp.Close();
        }
    }
}
