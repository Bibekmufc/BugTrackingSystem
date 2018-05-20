namespace BugTrackingSystem
{
    partial class Password
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtopass = new System.Windows.Forms.TextBox();
            this.txtnewpass = new System.Windows.Forms.TextBox();
            this.btnchange = new System.Windows.Forms.Button();
            this.lblopass = new System.Windows.Forms.Label();
            this.lblnewpass = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 28.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(331, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = "Change Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(293, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Old Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(293, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "New Password";
            // 
            // txtopass
            // 
            this.txtopass.Location = new System.Drawing.Point(558, 202);
            this.txtopass.Name = "txtopass";
            this.txtopass.Size = new System.Drawing.Size(151, 22);
            this.txtopass.TabIndex = 2;
            this.txtopass.UseSystemPasswordChar = true;
            // 
            // txtnewpass
            // 
            this.txtnewpass.Location = new System.Drawing.Point(558, 274);
            this.txtnewpass.Name = "txtnewpass";
            this.txtnewpass.Size = new System.Drawing.Size(151, 22);
            this.txtnewpass.TabIndex = 2;
            this.txtnewpass.UseSystemPasswordChar = true;
            // 
            // btnchange
            // 
            this.btnchange.ForeColor = System.Drawing.Color.Firebrick;
            this.btnchange.Location = new System.Drawing.Point(407, 347);
            this.btnchange.Name = "btnchange";
            this.btnchange.Size = new System.Drawing.Size(181, 48);
            this.btnchange.TabIndex = 3;
            this.btnchange.Text = "Change Password";
            this.btnchange.UseVisualStyleBackColor = true;
            this.btnchange.Click += new System.EventHandler(this.btnchange_Click);
            // 
            // lblopass
            // 
            this.lblopass.AutoSize = true;
            this.lblopass.ForeColor = System.Drawing.Color.DarkRed;
            this.lblopass.Location = new System.Drawing.Point(558, 231);
            this.lblopass.Name = "lblopass";
            this.lblopass.Size = new System.Drawing.Size(0, 17);
            this.lblopass.TabIndex = 4;
            // 
            // lblnewpass
            // 
            this.lblnewpass.AutoSize = true;
            this.lblnewpass.ForeColor = System.Drawing.Color.DarkRed;
            this.lblnewpass.Location = new System.Drawing.Point(558, 313);
            this.lblnewpass.Name = "lblnewpass";
            this.lblnewpass.Size = new System.Drawing.Size(0, 17);
            this.lblnewpass.TabIndex = 4;
            // 
            // Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(878, 460);
            this.Controls.Add(this.lblnewpass);
            this.Controls.Add(this.lblopass);
            this.Controls.Add(this.btnchange);
            this.Controls.Add(this.txtnewpass);
            this.Controls.Add(this.txtopass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Password";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Password";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtopass;
        private System.Windows.Forms.TextBox txtnewpass;
        private System.Windows.Forms.Button btnchange;
        private System.Windows.Forms.Label lblopass;
        private System.Windows.Forms.Label lblnewpass;
    }
}