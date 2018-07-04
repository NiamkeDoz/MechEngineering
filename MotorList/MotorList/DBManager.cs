using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MotorList
{
    public class DBManager
    {
        public DBManager()
        {

        }

        public void AddUser(string FName, string LName, int CredLevel, string Email, string Phone, string Username, string Password)
        {
            SqlConnection connection;
            try
            {
                connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Scooter\Documents\Practice C#\MotorList\MotorList\MotorList.mdf; Integrated Security = True");
                //Insert Query
                string insertQuery = "INSERT INTO Users (FName, LName, CredLevel, Email, Phone, Username, Password) VALUES (@FName, @LName, @CredLevel, @Email, @Phone, @Username, @Password)";
                SqlCommand command = new SqlCommand(insertQuery, connection);
                connection.Open();
                command.Parameters.AddWithValue("@FName", FName);
                command.Parameters.AddWithValue("@LName", LName);
                command.Parameters.AddWithValue("@CredLevel", CredLevel);
                command.Parameters.AddWithValue("@Phone", Phone);
                command.Parameters.AddWithValue("@Email", Email);
                command.Parameters.AddWithValue("@Username", Username);
                command.Parameters.AddWithValue("@Password", Password);

                command.ExecuteNonQuery();

                MessageBox.Show("Success");
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }
        }
    }
}
