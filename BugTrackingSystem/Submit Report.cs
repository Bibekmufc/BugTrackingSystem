using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BugTrackingSystem
{
    public partial class SubmitReport : Form
    {
        //connecting c# to mysql database
        MySqlConnection conn = new MySqlConnection("datasource=localhost; port=3306; username=root; database=bugtrack; password=; SslMode=none;");
        MySqlDataAdapter ad;
        DataTable d;
        DataSet dt;
        MySqlCommand myCommand;
        string clickedtext;
        public SubmitReport()
        {
            InitializeComponent();
            getUsers();
        }
        //getting various text editor format for different languages selected
        private void SubmitReport_Load(object sender, EventArgs e)
        {
            txteditor.Language = FastColoredTextBoxNS.Language.CSharp;
        }

        private void Language_Click(object sender, EventArgs e)
        {

        }

        private void hToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txteditor.Language = FastColoredTextBoxNS.Language.HTML;
        }

        private void jSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txteditor.Language = FastColoredTextBoxNS.Language.JS;
        }

        private void cToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txteditor.Language = FastColoredTextBoxNS.Language.CSharp;
        }

        private void pHPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txteditor.Language = FastColoredTextBoxNS.Language.PHP;
        }

        public void getUsers()
        {
            dt = new DataSet();
            try
            {
                    //sql query to select user type developer
                    string query = "select u.id, u.email from users u, roles r, user_roles ur " +
                    "WHERE u.id = ur.user_id and r.id= ur.role_id and r.u_type = 'developer'";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                ad = new MySqlDataAdapter(query, conn);
                ad.Fill(dt);
                cmbassgn.DataSource = dt.Tables[0];
                cmbassgn.DisplayMember = "email";
                cmbassgn.ValueMember = "id";
                cmbassgn.Enabled = true;
                cmbassgn.SelectedIndex = -1;
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
            }
        }

        private void btnsub_Click(object sender, EventArgs e)
        {
            //validation to check if the fields are empty
            if (txtpname.Text == "")
            {
                lblpname.Text = "Please enter a project name ";
            }
            else if (txtclass.Text == "")
            {
                lblclass.Text = " Please enter a class name ";
            }
            else if (txtmethod.Text == "")
            {
                lblmethod.Text = " Please enter a method name ";
            }
            else if (txtline.Text == "")
            {
                lblline.Text = "Please enter a line number ";
            }
            else if (txtauthor.Text == "")
            {
                lblauthor.Text = "Please enter author's name ";
            }
            else if (cmbassgn.Text == "")
            {
                lblassgn.Text = "Please choose for whom it is assigned to ";
            }
            else if (txtsummary.Text == "")
            {
                lblsummary.Text = " Please enter summary of bug";
            }
            else if(txtlink.Text == "")
            {
                lbllink.Text = "Please enter your link to the code";
            }
            else if (cmbseverity.Text == "")
            {
                lblseverity.Text = " Please choose a severity level ";
            }
            else if (txteditor.Text == "")
            {
                lblcode.Text = "Please write an error code.";
            }
            else
            {
                //declaring variables
                string pName = txtpname.Text;
                string cName = txtclass.Text;
                string mName = txtmethod.Text;
                string line = txtline.Text;
                string author = txtauthor.Text;
                string assignTo = cmbassgn.Text;
                string summary = txtsummary.Text;
                string link = txtlink.Text;
                string severity = cmbseverity.Text;
                string code = txteditor.Text;

                try
                {
                    //sql query to insert data into bugs table as part of bug report submission
                    string myInsertQuery = "INSERT INTO bugs (project_name, author, assigned_to, summary, link, syntax, language," +
                        "class, method, line_no, presented_by, status, severity, date_added) " +
                        "Values('" + pName + "','" + author + "','" + assignTo + "', '" + summary + "','" + link + "','" + code + "', " +
                        "'" + clickedtext + "','" + cName + "','" + mName + "','" + line + "', '" + Login.user + "', 'Unsolved', '" + severity + "', '" + DateTime.Now + "')";
                    myCommand = new MySqlCommand(myInsertQuery);
                    myCommand.Connection = conn;
                    conn.Open();
                    if (myCommand.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Bug report submitted successfully.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                myCommand.Connection.Close();
            }
        }

        private void language_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            clickedtext = e.ClickedItem.Text;
        }
    }
}
