using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BSMS1.BL;
using System.IO;
using BSMS1.UI;
namespace BSMS1.DL
{
    class MuserDL
    {
        private static List<Muser> usersList = new List<Muser>();

        internal static List<Muser> UsersList { get => usersList; set => usersList = value; }

        public static void AddIntoList(Muser user)
        {
            UsersList.Add(user);
        }
        public static Muser signIn(Muser user)
        {
            foreach (Muser u in UsersList)
            {
                if (u.getName() == user.getName() && u.getPass() == user.getPass())
                {
                    return u;
                }
            }
            return null;
        }
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
        public static void readFromFile(string path)
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
        }
        public static void storeUserIntoFile(Muser user, string path)
        {
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(user.getName() + "," + user.getPass() + "," + user.getRole());
            file.Flush();
            file.Close();
        }
    }
}
