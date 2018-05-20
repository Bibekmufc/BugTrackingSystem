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
    public partial class Login : Form
    {
        //initializing variables
        public static string email;
        public static string user, userPassword, userRole;
        string pass;
        public static int uid;
        //connecting to mysql database
        MySqlConnection con = new MySqlConnection("datasource=localhost; port=3306; username=root; database=bugtrack; password=; SslMode=none;");
        MySqlDataAdapter ada;
        DataTable dt;
        public Login()
        {
            InitializeComponent();
        }

        //action when login button is clicked
        private void btnlogin_Click(object sender, EventArgs e)
        {
            //validation
            if (txtuname.Text == "")
            {
                lbluname.Text = "Please enter username ";
            }
            else if (txtpass.Text == "")
            {
                lblpass.Text = " Please enter password ";
            }

            login();
        }

        //login method
        public void login()
        {
            user = txtuname.Text;
            pass = txtpass.Text;
            dt = new DataTable();
            try
            {
                //sql query to select data from database
                string query = "select u.id, u.email, u.username, u.password, r.u_type from users u, user_roles ur, roles r  where " +
                    "u.id = ur.user_id  and r.id = ur.role_id and u.username ='" + user + "' and u.password='" + pass + "'";
                ada = new MySqlDataAdapter(query, con);
                ada.Fill(dt);

                IDataReader uRes = dt.CreateDataReader();

                if (dt.Rows.Count == 1)
                {
                    while (uRes.Read())
                    {

                        uid = uRes.GetInt32(0);
                        email = uRes.GetString(1);
                        userRole = uRes.GetString(4);
                        userPassword = uRes.GetString(3);

                    }
                    if (userRole == "admin")
                    {
                        Admin_Panel ap = new Admin_Panel(uid, email, userRole);
                        ap.Show();
                        this.Visible = false;
                    }
                    else
                    {
                        Dashboard d = new Dashboard(user, userRole);
                        d.Show();
                        this.Visible = false;
                    }
                }
                else
                {
                    MessageBox.Show("Incorrect username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error in a database connection", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
