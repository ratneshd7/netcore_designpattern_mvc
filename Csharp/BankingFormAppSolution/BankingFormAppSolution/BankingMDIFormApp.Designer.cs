namespace BankingFormAppSolution
{
    partial class BankingMDIFormApp
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
            this.registerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.login = new System.Windows.Forms.ToolStripMenuItem();
            this.dotransaction = new System.Windows.Forms.ToolStripMenuItem();
            this.viewPassbook = new System.Windows.Forms.ToolStripMenuItem();
            this.logout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerToolStripMenuItem,
            this.login,
            this.dotransaction,
            this.viewPassbook,
            this.logout});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(844, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registerToolStripMenuItem
            // 
            this.registerToolStripMenuItem.Name = "registerToolStripMenuItem";
            this.registerToolStripMenuItem.Size = new System.Drawing.Size(87, 29);
            this.registerToolStripMenuItem.Text = "Register";
            this.registerToolStripMenuItem.Click += new System.EventHandler(this.registerToolStripMenuItem_Click);
            // 
            // login
            // 
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(68, 29);
            this.login.Text = "Login";
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // dotransaction
            // 
            this.dotransaction.Name = "dotransaction";
            this.dotransaction.Size = new System.Drawing.Size(135, 29);
            this.dotransaction.Text = "Dotransaction";
            this.dotransaction.Visible = false;
            this.dotransaction.Click += new System.EventHandler(this.dotransaction_Click);
            // 
            // viewPassbook
            // 
            this.viewPassbook.Name = "viewPassbook";
            this.viewPassbook.Size = new System.Drawing.Size(137, 29);
            this.viewPassbook.Text = "ViewPassbook";
            this.viewPassbook.Visible = false;
            this.viewPassbook.Click += new System.EventHandler(this.viewPassbook_Click);
            // 
            // logout
            // 
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(81, 29);
            this.logout.Text = "Logout";
            this.logout.Visible = false;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // BankingMDIFormApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 378);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "BankingMDIFormApp";
            this.Text = "BankingMDIFormApp";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem login;
        private System.Windows.Forms.ToolStripMenuItem dotransaction;
        private System.Windows.Forms.ToolStripMenuItem viewPassbook;
        private System.Windows.Forms.ToolStripMenuItem logout;
    }
}