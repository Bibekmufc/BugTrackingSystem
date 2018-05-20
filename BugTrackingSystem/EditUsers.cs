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

    public partial class EditUsers : Form
    {
        MySqlConnection conn = new MySqlConnection("datasource=localhost; port=3306; username=root; database=bugtrack; password=; SslMode=none;");
        MySqlDataAdapter ad;
        DataTable dt;
        MySqlCommand myCommand;
        public EditUsers()
        {
            InitializeComponent();
            lblid.Text = Convert.ToString(Login.uid);
            viewProfile();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (txtname.Text == "")
            {
                lblname.Text = "Please enter your name ";
            }
            else if (txtemail.Text == "")
            {
                lblemail.Text = " Please enter your email ";
            }
            else if (txtuname.Text == "")
            {
                lbluname.Text = " Please enter a username ";
            }
            else if (txtopass.Text == "")
            {
                lblopass.Text = "Please enter your old password ";
            }
            else if (txtnewpass.Text == "")
            {
                lblnpass.Text = "Please enter a new password ";
            }
            else
            {
                updateProfile();
            }
        }
        //load admin profile on the textbox
        public void viewProfile()
        {
            try
            {
                string query = "select * from users where id =" + lblid.Text;
                dt = new DataTable();
                ad = new MySqlDataAdapter(query, conn);
                ad.Fill(dt);

                IDataReader uRes = dt.CreateDataReader();

                if (dt.Rows.Count == 1)
                {
                    //Read the data and store them in the list
                    while (uRes.Read())
                    {
                        txtname.Text = uRes.GetString(1);
                        txtemail.Text = uRes.GetString(2);
                        txtuname.Text = uRes.GetString(3);                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Couldn't retrieve data", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void updateProfile()
        {
            try
            {
                string myQuery = "UPDATE users set name='" + txtname.Text + "', email='" + txtemail.Text + "', username='" + txtuname.Text + "', password='" + txtnewpass.Text + "' WHERE id=" + lblid.Text;
                myCommand = new MySqlCommand(myQuery, conn);
                conn.Open();
                if (myCommand.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Sucessfully updated!", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error in a database connection", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            myCommand.Connection.Close();
        }
    }
}
