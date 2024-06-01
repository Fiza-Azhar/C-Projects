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
    class MuserDL
    {
       public static List<Muser> users = new List<Muser>();

        public static void addUserIntoList(Muser user)
        {
            users.Add(user);
        }
        public static bool readUsersFromFile(string path)
        {
            StreamReader file = new StreamReader(path);
            string record;
            if (File.Exists(path))
            {
                while ((record = file.ReadLine()) != null)
                {
                    string[] splittedRecord = record.Split(',');
                    string name = splittedRecord[0];
                    string password = (splittedRecord[1]);
                    string role = splittedRecord[2];
                    Muser user = new Muser(name, password, role);
                    addUserIntoList(user);
                }
                file.Close();
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void storeUserintoFile(Muser user, string path)
        {
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(user.getName() + "," + user.getPass() + "," + user.getRole());
            file.Flush();
            file.Close();
        }
        public static Muser SignIn()
        {
            Muser user = MuserUI.AddUserWithoutrole();
            foreach (Muser storedUser in users)
            {
                if (storedUser.getName() == user.getName() && storedUser.getPass() == user.getPass())
                {
                    return storedUser;
                }
            }
            return null;
        }


    }
}
