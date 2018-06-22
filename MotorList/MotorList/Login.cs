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
        String Username;
        String Password;

        public Login()
        {
            InitializeComponent();
        }

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

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            Username = UnameTxtBx.Text;
            Password = PwdTxtBx.Text;
            this.Hide();
            HomeGui form = new HomeGui();
            form.Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
