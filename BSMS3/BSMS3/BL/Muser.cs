using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSMS3.BL
{
    class Muser
    {
        private string userName;
        private string userPass;
        private string userRole;

        public string UserName { get => userName; set => userName = value; }
        public string UserPass { get => userPass; set => userPass = value; }
        public string UserRole { get => userRole; set => userRole = value; }
        public Muser(string userName, string userPass, string userRole)
        {
            this.UserName = userName;
            this.UserPass = userPass;
            this.UserRole = userRole;
        }
        public Muser(string userName, string userPass)
        {
            this.UserName = userName;
            this.UserPass = userPass;
            this.UserRole = "NA";
        }
    }
}
