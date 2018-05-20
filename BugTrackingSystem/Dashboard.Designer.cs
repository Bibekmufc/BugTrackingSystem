namespace BugTrackingSystem
{
    partial class Dashboard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnview = new System.Windows.Forms.Button();
            this.btnpass = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnreport = new System.Windows.Forms.Button();
            this.btnhome = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblwelcome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnsearch = new System.Windows.Forms.Button();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.btnlogout = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.btnview);
            this.panel1.Controls.Add(this.btnpass);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnreport);
            this.panel1.Controls.Add(this.btnhome);
            this.panel1.Location = new System.Drawing.Point(0, 96);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(216, 530);
            this.panel1.TabIndex = 0;
            // 
            // btnview
            // 
            this.btnview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnview.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnview.FlatAppearance.BorderSize = 0;
            this.btnview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnview.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnview.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnview.Image = global::BugTrackingSystem.Properties.Resources.view_icon;
            this.btnview.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnview.Location = new System.Drawing.Point(6, 427);
            this.btnview.Name = "btnview";
            this.btnview.Size = new System.Drawing.Size(207, 100);
            this.btnview.TabIndex = 4;
            this.btnview.Text = "View Bugs";
            this.btnview.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnview.UseVisualStyleBackColor = false;
            this.btnview.Click += new System.EventHandler(this.btnview_Click);
            // 
            // btnpass
            // 
            this.btnpass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnpass.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnpass.FlatAppearance.BorderSize = 0;
            this.btnpass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpass.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpass.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnpass.Image = global::BugTrackingSystem.Properties.Resources.Security_Password_2_icon;
            this.btnpass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnpass.Location = new System.Drawing.Point(3, 321);
            this.btnpass.Name = "btnpass";
            this.btnpass.Size = new System.Drawing.Size(207, 100);
            this.btnpass.TabIndex = 3;
            this.btnpass.Text = "Change Password";
            this.btnpass.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnpass.UseVisualStyleBackColor = false;
            this.btnpass.Click += new System.EventHandler(this.btnpass_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Image = global::BugTrackingSystem.Properties.Resources.Actions_view_history_icon;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(3, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(207, 100);
            this.button1.TabIndex = 2;
            this.button1.Text = "    Bug History";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnreport
            // 
            this.btnreport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnreport.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnreport.FlatAppearance.BorderSize = 0;
            this.btnreport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnreport.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreport.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnreport.Image = global::BugTrackingSystem.Properties.Resources.Document_write_icon2;
            this.btnreport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnreport.Location = new System.Drawing.Point(3, 109);
            this.btnreport.Name = "btnreport";
            this.btnreport.Size = new System.Drawing.Size(207, 100);
            this.btnreport.TabIndex = 1;
            this.btnreport.Text = "  Report  a  bug";
            this.btnreport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnreport.UseVisualStyleBackColor = false;
            this.btnreport.Click += new System.EventHandler(this.btnreport_Click);
            // 
            // btnhome
            // 
            this.btnhome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnhome.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnhome.FlatAppearance.BorderSize = 0;
            this.btnhome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnhome.Font = new System.Drawing.Font("Corbel", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhome.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnhome.Image = global::BugTrackingSystem.Properties.Resources.home_icon;
            this.btnhome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnhome.Location = new System.Drawing.Point(0, 3);
            this.btnhome.Name = "btnhome";
            this.btnhome.Size = new System.Drawing.Size(210, 100);
            this.btnhome.TabIndex = 0;
            this.btnhome.Text = "  Home";
            this.btnhome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnhome.UseVisualStyleBackColor = false;
            this.btnhome.Click += new System.EventHandler(this.btnhome_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.lblwelcome);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnsearch);
            this.panel2.Controls.Add(this.txtsearch);
            this.panel2.Controls.Add(this.btnlogout);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1184, 100);
            this.panel2.TabIndex = 1;
            // 
            // lblwelcome
            // 
            this.lblwelcome.AutoSize = true;
            this.lblwelcome.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwelcome.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblwelcome.Location = new System.Drawing.Point(57, 33);
            this.lblwelcome.Name = "lblwelcome";
            this.lblwelcome.Size = new System.Drawing.Size(0, 24);
            this.lblwelcome.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(398, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 35);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search";
            // 
            // btnsearch
            // 
            this.btnsearch.Image = global::BugTrackingSystem.Properties.Resources.search_icon;
            this.btnsearch.Location = new System.Drawing.Point(776, 36);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(75, 31);
            this.btnsearch.TabIndex = 2;
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(513, 36);
            this.txtsearch.Multiline = true;
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(243, 31);
            this.txtsearch.TabIndex = 1;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // btnlogout
            // 
            this.btnlogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnlogout.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnlogout.FlatAppearance.BorderSize = 0;
            this.btnlogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogout.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogout.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnlogout.Location = new System.Drawing.Point(1089, 0);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(95, 100);
            this.btnlogout.TabIndex = 0;
            this.btnlogout.Text = "Log Out";
            this.btnlogout.UseVisualStyleBackColor = false;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1184, 626);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnhome;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnreport;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Label lblwelcome;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnpass;
        private System.Windows.Forms.Button btnview;
    }
}