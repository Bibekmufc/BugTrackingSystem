namespace BugTrackingSystem
{
    partial class Admin_Panel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.viewUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assignRolesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnlogout = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnassgn = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnview = new System.Windows.Forms.Button();
            this.lblwelcome = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewUsersToolStripMenuItem,
            this.addUsersToolStripMenuItem,
            this.assignRolesToolStripMenuItem,
            this.editUsersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 575);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(873, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            // 
            // viewUsersToolStripMenuItem
            // 
            this.viewUsersToolStripMenuItem.Name = "viewUsersToolStripMenuItem";
            this.viewUsersToolStripMenuItem.Size = new System.Drawing.Size(92, 24);
            this.viewUsersToolStripMenuItem.Text = "View Users";
            this.viewUsersToolStripMenuItem.Click += new System.EventHandler(this.viewUsersToolStripMenuItem_Click);
            // 
            // addUsersToolStripMenuItem
            // 
            this.addUsersToolStripMenuItem.Name = "addUsersToolStripMenuItem";
            this.addUsersToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.addUsersToolStripMenuItem.Text = "Add users";
            this.addUsersToolStripMenuItem.Click += new System.EventHandler(this.addUsersToolStripMenuItem_Click);
            // 
            // assignRolesToolStripMenuItem
            // 
            this.assignRolesToolStripMenuItem.Name = "assignRolesToolStripMenuItem";
            this.assignRolesToolStripMenuItem.Size = new System.Drawing.Size(104, 24);
            this.assignRolesToolStripMenuItem.Text = "Assign Roles";
            this.assignRolesToolStripMenuItem.Click += new System.EventHandler(this.assignRolesToolStripMenuItem_Click);
            // 
            // editUsersToolStripMenuItem
            // 
            this.editUsersToolStripMenuItem.Name = "editUsersToolStripMenuItem";
            this.editUsersToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.editUsersToolStripMenuItem.Text = "Edit Users";
            this.editUsersToolStripMenuItem.Click += new System.EventHandler(this.editUsersToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblwelcome);
            this.panel1.Controls.Add(this.btnlogout);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1009, 75);
            this.panel1.TabIndex = 2;
            // 
            // btnlogout
            // 
            this.btnlogout.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnlogout.Location = new System.Drawing.Point(840, 0);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(169, 75);
            this.btnlogout.TabIndex = 0;
            this.btnlogout.Text = "Log Out";
            this.btnlogout.UseVisualStyleBackColor = true;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnedit);
            this.panel2.Controls.Add(this.btnassgn);
            this.panel2.Controls.Add(this.btnadd);
            this.panel2.Controls.Add(this.btnview);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 579);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1009, 100);
            this.panel2.TabIndex = 3;
            // 
            // btnedit
            // 
            this.btnedit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnedit.Location = new System.Drawing.Point(563, 0);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(227, 100);
            this.btnedit.TabIndex = 3;
            this.btnedit.Text = "Edit Users";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.editUsersToolStripMenuItem_Click);
            // 
            // btnassgn
            // 
            this.btnassgn.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnassgn.Location = new System.Drawing.Point(790, 0);
            this.btnassgn.Name = "btnassgn";
            this.btnassgn.Size = new System.Drawing.Size(219, 100);
            this.btnassgn.TabIndex = 2;
            this.btnassgn.Text = "Assign Roles";
            this.btnassgn.UseVisualStyleBackColor = true;
            this.btnassgn.Click += new System.EventHandler(this.assignRolesToolStripMenuItem_Click);
            // 
            // btnadd
            // 
            this.btnadd.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnadd.Location = new System.Drawing.Point(202, 0);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(227, 100);
            this.btnadd.TabIndex = 1;
            this.btnadd.Text = "Add users";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.addUsersToolStripMenuItem_Click);
            // 
            // btnview
            // 
            this.btnview.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnview.Location = new System.Drawing.Point(0, 0);
            this.btnview.Name = "btnview";
            this.btnview.Size = new System.Drawing.Size(202, 100);
            this.btnview.TabIndex = 0;
            this.btnview.Text = "View Users";
            this.btnview.UseVisualStyleBackColor = true;
            this.btnview.Click += new System.EventHandler(this.viewUsersToolStripMenuItem_Click);
            // 
            // lblwelcome
            // 
            this.lblwelcome.AutoSize = true;
            this.lblwelcome.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwelcome.Location = new System.Drawing.Point(117, 16);
            this.lblwelcome.Name = "lblwelcome";
            this.lblwelcome.Size = new System.Drawing.Size(0, 35);
            this.lblwelcome.TabIndex = 1;
            // 
            // Admin_Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 679);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Admin_Panel";
            this.Text = "Admin_Panel";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem viewUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assignRolesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editUsersToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnview;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnassgn;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.Label lblwelcome;
    }
}