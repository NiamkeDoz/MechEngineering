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
    public partial class AddUser : Form
    {
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
    }
}
