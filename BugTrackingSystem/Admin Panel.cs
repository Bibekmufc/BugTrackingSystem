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
    public partial class Admin_Panel : Form
    {
        public Admin_Panel()
        {
            InitializeComponent();
        }

        ViewUsers v;
        private void viewUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(v == null)
            {
                ViewUsers v = new ViewUsers();
                v.FormClosed += V_FormClosed;
                v.MdiParent = this;
                v.Show();
            }
            else
            {
                v.Activate();
            }
            
        }

        private void V_FormClosed(object sender, FormClosedEventArgs e)
        {
            v = null;
            //throw new NotImplementedException();
        }

        Register r;
        private void addUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(r == null)
            {
                Register r = new Register();
                r.FormClosed += R_FormClosed;
                r.MdiParent = this;
                r.Show();
            }
            else
            {
                r.Activate();
            }
        }

        private void R_FormClosed(object sender, FormClosedEventArgs e)
        {
            r = null;
            //throw new NotImplementedException();
        }

        Assign a;
        private void assignRolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(a == null)
            {
                Assign a = new Assign();
                a.FormClosed += A_FormClosed;
                a.MdiParent = this;
                a.Show();
            }
            else
            {
                a.Activate();
            }
        }

        private void A_FormClosed(object sender, FormClosedEventArgs e)
        {
            a = null;
            //throw new NotImplementedException();
        }

        EditUsers eu;
        private void editUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(eu == null)
            {
                EditUsers eu = new EditUsers();
                eu.FormClosed += Eu_FormClosed;
                eu.MdiParent = this;
                eu.Show();
            }
            else
            {
                eu.Activate();
            }
            
        }

        private void Eu_FormClosed(object sender, FormClosedEventArgs e)
        {
            eu = null;
            //throw new NotImplementedException();
        }
    }
}
