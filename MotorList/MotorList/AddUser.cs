using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MotorList
{
    public partial class AddUser : Form
    {
        private string FirstName;
        private string LastName;
        private int CredLevel;
        private string Email;
        private string Phone;
        private string Username;
        private string Password;

        public AddUser()
        {
            InitializeComponent();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            //When the Back button is clicked the Add user form is hidden and the Home Page is brought back.
            this.Hide();
            HomeGui form = new HomeGui();
            form.Show();
        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            //When the Add User Form loads the Standard User Radio Button is checked.
            StandardBtn.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DBManager Database = new DBManager();

            FirstName = FName.Text;
            LastName = LNameTxtBx.Text;
            Email = EmailTxtBx.Text;
            Phone = PhoneTxtBx.Text;
            Username = UNameTxtBx.Text;
            Password = PWordTxtBx.Text;

            //Determines the User Type and assigns a credential level.
            if(StandardBtn.Checked == true)
            {
                CredLevel = 1;
            }
            else if(SellerBtn.Checked == true)
            {
                CredLevel = 2;
            }else if(AdminBtn.Checked == true)
            {
                CredLevel = 3;
            }

            Database.AddUser(FirstName, LastName, CredLevel, Email, Phone, Username, Password);

            
            
            
        }
    }
}
