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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void Phone_Enter(object sender, EventArgs e)
        {
            if(PhoneTxtBx.Text == "123-456-7890")
            {
                PhoneTxtBx.Text = "";
                PhoneTxtBx.ForeColor = Color.Black;
            }
        }

        private void Phone_Leave(object sender, EventArgs e)
        {
            if(PhoneTxtBx.Text == "")
            {
                PhoneTxtBx.Text = "123-456-7890";
                PhoneTxtBx.ForeColor = Color.Gray;
            }
        }

        private void Email_Enter(object sender, EventArgs e)
        {
            if(EmailTxtBx.Text == "name@name.com")
            {
                EmailTxtBx.Text = "";
                EmailTxtBx.ForeColor = Color.Black;
            }
        }

        private void Email_Leave(object sender, EventArgs e)
        {
            if(EmailTxtBx.Text == "")
            {
                EmailTxtBx.Text = "name@name.com";
                EmailTxtBx.ForeColor = Color.Gray;
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login form = new Login();
            form.Show();
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
