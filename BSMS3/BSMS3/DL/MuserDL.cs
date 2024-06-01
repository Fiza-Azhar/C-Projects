using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BSMS3.BL;
using System.IO;
namespace BSMS3.DL
{
    class MuserDL
    {
        private static List<Muser> usersList = new List<Muser>();
        public static void AddIntoList(Muser user)
        {
            usersList.Add(user);
        }
        public static Muser signIn(Muser user)
        {
            foreach (Muser usr in usersList)
            {
                if (usr.UserName == user.UserName && usr.UserPass == user.UserPass)
                {
                    return usr;
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
        public static bool readDataFromFile(string path)
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
                    Muser user = new Muser(name, pass, role);
                    AddIntoList(user);
                }
                file.Close();
                return true;
            }
            else
            {
                return false;
            }

        }

        public static void storeUserIntoFile(Muser user, string path)
        {
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(user.UserName + "," + user.UserPass + "," + user.UserRole);
            file.Flush();
            file.Close();
        }
    }
}
