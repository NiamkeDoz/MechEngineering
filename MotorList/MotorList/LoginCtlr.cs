using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        
        public void Authenicate(String username, String password)
        {
            Login log = new Login();
            if(username != DBUname && password != DBPword)
            {
                MessageBox.Show("Username & Password Incorrect!");
                //log.DisplayLoginError(false, false);
            }
            else if(username == DBUname && password != DBPword)
            {
                MessageBox.Show("Password Incorrect!");
                //log.DisplayLoginError(true, false);
                
            }
            else if (username != DBUname && password == DBPword)
            {
                MessageBox.Show("Password Incorrect!");
                //log.DisplayLoginError(false, true);
                
            }
            else
            {
                MessageBox.Show("Login Successful!");
                log.Hide();
                HomeGui home = new HomeGui(); 
                home.Show();
            }
        }
    }
}
