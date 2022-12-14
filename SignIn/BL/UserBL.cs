using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignIn.BL
{
    public class UserBL
    {
        private string UserName;
        private string UserPassword;
        private string UserRole;

        public string UserName1 { get => UserName; set => UserName = value; }
        public string UserPassword1 { get => UserPassword; set => UserPassword = value; }
        public string UserRole1 { get => UserRole; set => UserRole = value; }
        public UserBL(string UserName, string UserPassword, string UserRole)
        {
            this.UserName = UserName;
            this.UserPassword = UserPassword;
            this.UserRole = UserRole;
        }
        public UserBL(string UserName, string UserPassword)
        {
            this.UserName = UserName;
            this.UserPassword = UserPassword;
        }
        public bool isAdmin()
        {
            if (this.UserRole == "Admin")
            {
                return true;
            }
            return false;
        }
    }
}
