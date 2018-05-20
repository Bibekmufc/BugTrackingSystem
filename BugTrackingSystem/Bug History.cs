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
    public partial class Bug_History : Form
    {
        //connecting to mysql database
        MySqlConnection conn = new MySqlConnection("datasource = localhost; port = 3306; username = root; database = bugtrack; password=; SslMode=none;");
        MySqlDataAdapter ad;
        DataSet dt;
        public Bug_History()
        {
            InitializeComponent();
        }

        private void Bug_History_Load(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(Dashboard.searchItem))  //search keywords to search for in the dashboard
                {
                    string query = "select * from bugs where summary like '%" + Dashboard.searchItem + "%' or project_name like '%" + Dashboard.searchItem + "%' ";
                    ad = new MySqlDataAdapter(query, conn);
                    conn.Open();
                    dt = new DataSet();
                    ad.Fill(dt, "bugs");
                    dataGridView1.DataSource = dt.Tables["bugs"]; ;
                    dataGridView1.Columns["date_added"].Visible = false;
                    conn.Close();
                }
                else
                {   //table to view the bug history
                    string query = "select * from bugs";
                    ad = new MySqlDataAdapter(query, conn);
                    conn.Open();
                    dt = new DataSet();
                    ad.Fill(dt, "bugs");
                    dataGridView1.DataSource = dt.Tables["bugs"]; ;
                    dataGridView1.Columns["date_added"].Visible = false;
                    conn.Close();
                }
                
            }
            catch (Exception)
            {
            }
        }
    }
    }

