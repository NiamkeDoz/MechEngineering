using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MotorList
{
    public partial class Login : Form
    {
        private string Uname;
        private string Pword;
        public bool loginStatus = false;

        public Login()
        {
            InitializeComponent();
        }

        /***************************************
         *         GETTERS & SETTERS           *
         ***************************************/         
        public string GetUsernameErr()
        {
            return this.UsernameErr.Text;
        }

        public void SetUsernameErr(string msg)
        {
            this.UsernameErr.Text = msg;
        }

        public string GetPasswordErr()
        {
            return this.PasswordErr.Text;
        }

        public void SetPasswordErr(string msg)
        {
            this.PasswordErr.Text = msg;
        }


        /****************************************
         *      Username & Password Features    *
         ***************************************/

        private void Username_Enter(object sender, EventArgs e)
        {
            if(UnameTxtBx.Text == "Username")
            {
                UnameTxtBx.Text = "";
                UnameTxtBx.ForeColor = Color.Black;
            }
        }

        private void Uesrname_Leave(object sender, EventArgs e)
        {
            if (UnameTxtBx.Text == "")
            {
                UnameTxtBx.Text = "Username";
                UnameTxtBx.ForeColor = Color.Gray;
                
            }
        }

        private void Password_Enter(object sender, EventArgs e)
        {
            if(PwdTxtBx.Text == "Password")
            {
                PwdTxtBx.Text = "";
                PwdTxtBx.ForeColor = Color.Black;
            }
        }

        private void Password_Leave(object sender, EventArgs e)
        {
            if(PwdTxtBx.Text == "")
            {
                PwdTxtBx.Text = "Password";
                PwdTxtBx.ForeColor = Color.Gray;
            }
        }

        private void CheckSubmission()
        {
            //If the Username and Password matches the placeholder send a flag to the user.
            if(UnameTxtBx.Text == "Username" && PwdTxtBx.Text == "Password")
            {
                this.UsernameErr.Visible = true;
                this.PasswordErr.Visible = true;
            }
            else
            {
                this.UsernameErr.Visible = false;
                this.PasswordErr.Visible = false;
            }
        }

        public void DisplayLoginError(bool UnameErr, bool PwordErr)
        {
            //Display the username and password error message if both are incorrect.
            if (UnameErr == false && PwordErr == false)
            {
                this.UsernameErr.Visible = true;
                this.PasswordErr.Visible = true;
            }
            //Display the username Error if username is incorrect.
            else if (UnameErr == true && PwordErr == false)
            {
                this.UsernameErr.Visible = true;
            }
            //Display the password Error if password is incorrect.
            else if(UnameErr == false && PwordErr != false)
            {
                this.PasswordErr.Visible = true;
            }
            else
            {
                this.UsernameErr.Visible = false;
                this.PasswordErr.Visible = false;
            }
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            Uname = UnameTxtBx.Text;
            Pword = PwdTxtBx.Text;
            //Keeps trying to login until the username and password combination is correct.

            LoginCtlr login = new LoginCtlr(Uname, Pword);
            this.Hide();
            
            //LoginCtlr login = new LoginCtlr(Uname, Pword);
            //HomeGui form = new HomeGui();
            //form.Show();
            
            
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SignUp_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUp form = new SignUp();
            form.Show();
        }
    }
}
