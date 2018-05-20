using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BugTrackingSystem
{
    public partial class Dashboard : Form
    {
        //initializing variables
        public static string searchItem;
        public Dashboard(string user, string userRole)
        {
            InitializeComponent();
            lblwelcome.Text = "Welcome " + user + " | " + userRole;
        }

        private void btnhome_Click(object sender, EventArgs e)
        {

        }


        //logout button
        private void btnlogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //report a bug button
        SubmitReport s;
        private void btnreport_Click(object sender, EventArgs e)
        {
            if(s == null)
            {
                SubmitReport s = new SubmitReport();
                s.FormClosed += S_FormClosed;
                s.MdiParent = this;
                s.Show();
            }
            else
            {
                s.Activate();
            }
            
        }

        private void S_FormClosed(object sender, FormClosedEventArgs e)
        {
            s = null;
           // throw new NotImplementedException();
        }


        //bug histroy button
        Bug_History bh;
        private void button1_Click(object sender, EventArgs e)
        {
            if(bh == null)
            {
                Bug_History bh = new Bug_History();
                bh.FormClosed += Bh_FormClosed;
                bh.MdiParent = this;
                bh.Show();
            }
            else
            {
                bh.Activate();
            }
        }

        private void Bh_FormClosed(object sender, FormClosedEventArgs e)
        {
            bh = null;
            //throw new NotImplementedException();
        }

        //search button clicked
        private void btnsearch_Click(object sender, EventArgs e)
        {
            if (bh == null)
            {
                Bug_History bh = new Bug_History();
                bh.FormClosed += Bh_FormClosed;
                bh.MdiParent = this;
                bh.Show();
            }
            else
            {
                bh.Activate();
            }
        }


        //search query
        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            searchItem = txtsearch.Text;
        }

        Password p;
        private void btnpass_Click(object sender, EventArgs e)
        {
            if(p == null)
            {
                Password p = new Password();
                p.FormClosed += P_FormClosed;
                p.MdiParent = this;
                p.Show();
            }
        }

        private void P_FormClosed(object sender, FormClosedEventArgs e)
        {
            p = null;
          //  throw new NotImplementedException();
        }

        //view bugs button
        View_Bugs vb;
        private void btnview_Click(object sender, EventArgs e)
        {
            if (Login.userRole == "tester")
            {
                btnview.Enabled = false;
            }
            else
            {
                if (vb == null)
                {
                    View_Bugs vb = new View_Bugs();
                    vb.FormClosed += Vb_FormClosed;
                    vb.MdiParent = this;
                    vb.Show();
                }
            }
        }

        private void Vb_FormClosed(object sender, FormClosedEventArgs e)
        {
            vb = null;
            //throw new NotImplementedException();
        }
    }
}
