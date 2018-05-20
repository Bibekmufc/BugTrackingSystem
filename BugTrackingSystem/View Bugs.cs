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
    public partial class View_Bugs : Form
    {
        //connecting to mysql database
        MySqlConnection conn = new MySqlConnection("datasource=localhost; port=3306; username=root; database=bugtrack; password=; SslMode=none;");
        MySqlDataAdapter ad;
        MySqlCommand myCommand;
        public static string bugid;
        public static string code, Language;
        DataSet dt;
        DataTable d;
        int selectedRow;
        public View_Bugs()
        {
            InitializeComponent();
        }

        //action when show bug button is clicked
        private void btnshow_Click(object sender, EventArgs e)
        {
            try
            {
                //sql query to select from bugs table
                string query = "select * from bugs where assigned_to='" + Login.email + "'";
                ad = new MySqlDataAdapter(query, conn);
                conn.Open();
                DataSet dt = new DataSet();
                ad.Fill(dt, "bugs");
                dataGridView1.DataSource = dt.Tables["bugs"];
                dataGridView1.Columns["author"].Visible = false;
                dataGridView1.Columns["assigned_to"].Visible = false;
                dataGridView1.Columns["link"].Visible = false;
                dataGridView1.Columns["syntax"].Visible = false;
                dataGridView1.Columns["class"].Visible = false;
                dataGridView1.Columns["method"].Visible = false;
                dataGridView1.Columns["line_no"].Visible = false;
                dataGridView1.Columns["presented_by"].Visible = false;
                conn.Close();
            }
            catch (Exception)
            {
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                selectedRow = e.RowIndex;
                DataGridViewRow row = dataGridView1.Rows[selectedRow];
                // display datagridview selected row data into labels and textbox
                bugid = row.Cells[0].Value.ToString();
                lblpname.Text = row.Cells[1].Value.ToString();
                lblauthor.Text = row.Cells[2].Value.ToString();
                lblassgnto.Text = row.Cells[3].Value.ToString();
                lblsummary.Text = row.Cells[4].Value.ToString();
                lbllink.Text = row.Cells[5].Value.ToString();
                code = row.Cells[6].Value.ToString();
                lbllanguage.Text = row.Cells[7].Value.ToString();
                Language = row.Cells[7].Value.ToString();
                lblclass.Text = row.Cells[8].Value.ToString();
                lblmethod.Text = row.Cells[9].Value.ToString();
                lblline.Text = row.Cells[10].Value.ToString();
                lblassgnby.Text = row.Cells[11].Value.ToString();
                cmbstatus.Text = row.Cells[12].Value.ToString();
                lbldate.Text = row.Cells[14].Value.ToString();
                
            }
            catch (Exception) { }

        }

        //action when update button is clicked
        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                string myQuery = "UPDATE bugs set status='" + cmbstatus.SelectedItem + "' where id=" + bugid;
                myCommand = new MySqlCommand(myQuery, conn);
                conn.Open();
                if (myCommand.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Status updated successfully!", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Problem connecting to database", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            myCommand.Connection.Close();
        }

        private void lbllink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(lbllink.Text);
        }

        private void btnview_Click(object sender, EventArgs e)
        {
            Code c = new Code();
            c.Show();
        }

       
    }
}
