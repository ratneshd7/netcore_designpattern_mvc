namespace BankingFormAppSolution
{
    partial class RegisterForm
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblOpeningBalance = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblRetypePwd = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtOpeningBalance = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtRetypePwd = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(82, 40);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(78, 29);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // lblOpeningBalance
            // 
            this.lblOpeningBalance.AutoSize = true;
            this.lblOpeningBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpeningBalance.Location = new System.Drawing.Point(55, 103);
            this.lblOpeningBalance.Name = "lblOpeningBalance";
            this.lblOpeningBalance.Size = new System.Drawing.Size(199, 29);
            this.lblOpeningBalance.TabIndex = 1;
            this.lblOpeningBalance.Text = "Opening Balance";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(72, 167);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(120, 29);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password";
            // 
            // lblRetypePwd
            // 
            this.lblRetypePwd.AutoSize = true;
            this.lblRetypePwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRetypePwd.Location = new System.Drawing.Point(59, 213);
            this.lblRetypePwd.Name = "lblRetypePwd";
            this.lblRetypePwd.Size = new System.Drawing.Size(202, 29);
            this.lblRetypePwd.TabIndex = 3;
            this.lblRetypePwd.Text = "Retype Password";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(260, 40);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(230, 35);
            this.txtName.TabIndex = 4;
            this.txtName.Leave += new System.EventHandler(this.tabName);
            // 
            // txtOpeningBalance
            // 
            this.txtOpeningBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOpeningBalance.Location = new System.Drawing.Point(260, 103);
            this.txtOpeningBalance.Name = "txtOpeningBalance";
            this.txtOpeningBalance.Size = new System.Drawing.Size(230, 35);
            this.txtOpeningBalance.TabIndex = 5;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(260, 167);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(230, 35);
            this.txtPassword.TabIndex = 6;
            // 
            // txtRetypePwd
            // 
            this.txtRetypePwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRetypePwd.Location = new System.Drawing.Point(260, 213);
            this.txtRetypePwd.Name = "txtRetypePwd";
            this.txtRetypePwd.Size = new System.Drawing.Size(230, 35);
            this.txtRetypePwd.TabIndex = 7;
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(174, 271);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(191, 57);
            this.btnRegister.TabIndex = 8;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 349);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtRetypePwd);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtOpeningBalance);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblRetypePwd);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblOpeningBalance);
            this.Controls.Add(this.lblName);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblOpeningBalance;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblRetypePwd;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtOpeningBalance;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtRetypePwd;
        private System.Windows.Forms.Button btnRegister;
    }
}