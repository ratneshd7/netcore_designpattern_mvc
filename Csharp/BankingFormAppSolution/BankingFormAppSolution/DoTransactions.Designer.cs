namespace BankingFormAppSolution
{
    partial class DoTransactions
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
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.radBtnDeposite = new System.Windows.Forms.RadioButton();
            this.radBtnWithdraw = new System.Windows.Forms.RadioButton();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(225, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Do Transactions !!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(153, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Amount :";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(321, 131);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(165, 26);
            this.txtAmount.TabIndex = 2;
            // 
            // radBtnDeposite
            // 
            this.radBtnDeposite.AutoSize = true;
            this.radBtnDeposite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radBtnDeposite.Location = new System.Drawing.Point(197, 215);
            this.radBtnDeposite.Name = "radBtnDeposite";
            this.radBtnDeposite.Size = new System.Drawing.Size(114, 29);
            this.radBtnDeposite.TabIndex = 3;
            this.radBtnDeposite.TabStop = true;
            this.radBtnDeposite.Text = "Deposite";
            this.radBtnDeposite.UseVisualStyleBackColor = true;
            // 
            // radBtnWithdraw
            // 
            this.radBtnWithdraw.AutoSize = true;
            this.radBtnWithdraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radBtnWithdraw.Location = new System.Drawing.Point(348, 215);
            this.radBtnWithdraw.Name = "radBtnWithdraw";
            this.radBtnWithdraw.Size = new System.Drawing.Size(119, 29);
            this.radBtnWithdraw.TabIndex = 4;
            this.radBtnWithdraw.TabStop = true;
            this.radBtnWithdraw.Text = "Withdraw";
            this.radBtnWithdraw.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(249, 279);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(152, 57);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.doTransaction);
            // 
            // DoTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 410);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.radBtnWithdraw);
            this.Controls.Add(this.radBtnDeposite);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DoTransactions";
            this.Text = "DoTransactions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.RadioButton radBtnDeposite;
        private System.Windows.Forms.RadioButton radBtnWithdraw;
        private System.Windows.Forms.Button btnSubmit;
    }
}