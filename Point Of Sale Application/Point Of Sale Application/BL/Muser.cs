using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_Of_Sale_Application.BL
{
    class Muser
    {
        private string name;
        private string pass;
        private string role;
        public Muser(string name, string pass, string role)
        {
            this.name = name;
            this.pass = pass;
            this.role = role;
        }
        public Muser(string name, string pass)
        {
            this.name = name;
            this.pass = pass;
            this.role = "NA";
        }

        internal Customer Customer
        {
            get => default;
            set
            {
            }
        }

        internal Product Product
        {
            get => default;
            set
            {
            }
        }

        public string getName()
        {
            return name;
        }
        public string getPass()
        {
            return pass;
        }
        public string getRole()
        {
            return role;
        }
        public bool isAdmin()
        {
            if (role == "Admin" || role == "admin")
            {
                return true;
            }
            return false;
        }
    }
}
