using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorList
{
    class LoginCtlr
    {
        String DBUname = "Admin";
        String DBPword = "password";

        public LoginCtlr(String Username, String Password)
        {
            Authenicate(Username, Password);
        }
        
        public bool Authenicate(String username, String Password)
        {
            Login log = new Login();
            if(username != DBUname)
            {
                
            }
            return true;
        }
    }
}
