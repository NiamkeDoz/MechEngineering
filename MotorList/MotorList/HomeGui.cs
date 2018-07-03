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
    public partial class HomeGui : Form
    {
        public HomeGui()
        {
            InitializeComponent();
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeGui home = new HomeGui();
            home.Show();
        }

        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            //Fix this later to log the user out of the system.
            
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void AddUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddUser form = new AddUser();
            form.Show();
        }
    }
}
