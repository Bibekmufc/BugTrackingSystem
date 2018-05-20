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
        public static string email;
        public static string user, userPassword;
        string pass;
        string userRole;
        public static int uid;
        MySqlConnection con = new MySqlConnection("datasource=localhost; port=3306; username=root; database=bugtrack; password=; SslMode=none;");
        MySqlDataAdapter ada;
        DataTable dt;
        public Login()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register r = new Register();
            r.Show();
            
        }

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


        public void login()
        {
            user = txtuname.Text;
            pass = txtpass.Text;
            dt = new DataTable();
            try
            {
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

        private void button2_Click(object sender, EventArgs e)
        {
            SubmitReport s = new SubmitReport();
            s.Show();
        }

        private void btndash_Click(object sender, EventArgs e)
        {
            Dashboard d = new Dashboard(user, userRole);
                d.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Admin_Panel a = new Admin_Panel(uid, email, userRole);
            a.Show();
        }
    }
}
