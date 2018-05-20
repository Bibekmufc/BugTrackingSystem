using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BugTrackingSystem
{
    public partial class Password : Form
    {
        //variables used to change password
        public static string user, email, userRole;
        public static int uid;
        MySqlConnection con = new MySqlConnection("datasource=localhost; port=3306; username=root; database=bugtrack; password=; SslMode=none;");
        MySqlCommand myCommand;

        string pas = Login.userPassword;
        public Password()
        {
            InitializeComponent();
        }

        //when the change password button is pressed
        private void btnchange_Click(object sender, EventArgs e)
        {
            //validation to check whether the fields are empty or not
            if (txtopass.Text == "")
            {
                lblopass.Text = "Please enter your old password ";
            }
            else if (txtnewpass.Text == "")
            {
                lblnewpass.Text = "Please enter a new password ";
            }
            else if (!pas.Equals(txtopass.Text))
            {
                MessageBox.Show("Passwords do not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtopass.Focus();
            }
            else
            {
                try
                {
                    //sql query to update password
                    string myQuery = "UPDATE users set password='" + txtnewpass.Text + "' where id=" + Login.uid;
                    myCommand = new MySqlCommand(myQuery, con);
                    con.Open();
                    if (myCommand.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Password Updated Successfully!", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Could not connect to database", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                myCommand.Connection.Close();
            }
        }
    }
}
