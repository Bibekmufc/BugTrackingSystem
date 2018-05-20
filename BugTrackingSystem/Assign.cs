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
    public partial class Assign : Form
    {
        MySqlConnection con = new MySqlConnection("datasource=localhost; port=3306; username=root; database=bugtrack; password=; SslMode=none;");
        MySqlDataAdapter ad;
        DataSet dt;
        DataTable d;
        MySqlCommand myCommand;
        int userId, roleID = -1;
        public Assign()
        {
            InitializeComponent();
            selectRole();
            selectUsers();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            //validation
            if (cmbuser.Text == "")
            {
                lblu.Text = " •Please Select Any  User";
            }
            else if (cmbrole.Text == "")
            {
                lblr.Text = "•Please Select Any Role";
            }
            else
            {
                getUser();
                getRole();
                addUserRole();
            }
        }

        //fecth data from database and load it into a combo box
        public void selectRole()
        {
            dt = new DataSet();
            try
            {
                string query = "select id, u_type from roles";
                MySqlCommand cmd = new MySqlCommand(query, con);
                ad = new MySqlDataAdapter(query, con);
                ad.Fill(dt);
                cmbrole.DataSource = dt.Tables[0];
                cmbrole.DisplayMember = "u_type";
                cmbrole.ValueMember = "id";
                cmbrole.Enabled = true;
                cmbrole.SelectedIndex = -1;
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
            }
        }
        //fecth data from database and load it into a combo box
        public void selectUsers()
        {
            dt = new DataSet();
            try
            {
                string query = "select id, username from users";
                MySqlCommand cmd = new MySqlCommand(query, con);
                ad = new MySqlDataAdapter(query, con);
                ad.Fill(dt);
                cmbuser.DataSource = dt.Tables[0];
                cmbuser.DisplayMember = "username";
                cmbuser.ValueMember = "id";
                cmbuser.Enabled = true;
                cmbuser.SelectedIndex = -1;
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
            }
        }
        //add user's their role
        public void addUserRole()
        {
            try
            {
                string myInsertQuery = "INSERT INTO user_roles(user_id, role_id) values(" + userId + "," + roleID + ")";
                myCommand = new MySqlCommand(myInsertQuery, con);
                con.Open();
                if (myCommand.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Added Sucessfully!", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error in a database connection", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            myCommand.Connection.Close();
        }
        //get the specific user
        public void getUser()
        {
            d = new DataTable();
            try
            {
                string query = "select id from users where username='" + cmbuser.Text + "'";
                ad = new MySqlDataAdapter(query, con);
                ad.Fill(d);

                IDataReader uRes = d.CreateDataReader();

                while (uRes.Read())
                {
                    userId = uRes.GetInt32(0);
                }

            }
            catch (Exception)
            {
                //MessageBox.Show("Error in a database connection", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //get the specific role for user
        public void getRole()
        {

            d = new DataTable();
            try
            {
                string query = "select id from roles where u_type='" + cmbrole.Text + "'";
                ad = new MySqlDataAdapter(query, con);
                ad.Fill(d);

                IDataReader uRes = d.CreateDataReader();

                if (d.Rows.Count == 1)
                {
                    while (uRes.Read())
                    {
                        roleID = uRes.GetInt32(0);
                    }
                }
            }
            catch (Exception)
            {
                //MessageBox.Show("Error in a database connection", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Assign_Load(object sender, EventArgs e)
        {

        }
    }
}
