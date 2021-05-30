namespace BankingFormAppSolution
{
    partial class ViewPassbookForm
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
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.lblPassbook = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.btnViewPassbook = new System.Windows.Forms.Button();
            this.dgvViewPassbook = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewPassbook)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.Location = new System.Drawing.Point(588, 117);
            this.dtpFromDate.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(327, 35);
            this.dtpFromDate.TabIndex = 0;
            // 
            // lblPassbook
            // 
            this.lblPassbook.AutoSize = true;
            this.lblPassbook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassbook.Location = new System.Drawing.Point(345, 29);
            this.lblPassbook.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPassbook.Name = "lblPassbook";
            this.lblPassbook.Size = new System.Drawing.Size(274, 29);
            this.lblPassbook.TabIndex = 1;
            this.lblPassbook.Text = "View Passbook By Date ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(182, 123);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "From Date :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(209, 216);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "To Date :";
            // 
            // dtpToDate
            // 
            this.dtpToDate.Location = new System.Drawing.Point(588, 210);
            this.dtpToDate.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(327, 35);
            this.dtpToDate.TabIndex = 4;
            // 
            // btnViewPassbook
            // 
            this.btnViewPassbook.Location = new System.Drawing.Point(401, 265);
            this.btnViewPassbook.Name = "btnViewPassbook";
            this.btnViewPassbook.Size = new System.Drawing.Size(206, 78);
            this.btnViewPassbook.TabIndex = 6;
            this.btnViewPassbook.Text = "View PassBook";
            this.btnViewPassbook.UseVisualStyleBackColor = true;
            this.btnViewPassbook.Click += new System.EventHandler(this.btnShowPassbook);
            // 
            // dgvViewPassbook
            // 
            this.dgvViewPassbook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewPassbook.Location = new System.Drawing.Point(169, 350);
            this.dgvViewPassbook.Name = "dgvViewPassbook";
            this.dgvViewPassbook.RowTemplate.Height = 28;
            this.dgvViewPassbook.Size = new System.Drawing.Size(728, 224);
            this.dgvViewPassbook.TabIndex = 7;
            // 
            // ViewPassbookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 586);
            this.Controls.Add(this.dgvViewPassbook);
            this.Controls.Add(this.btnViewPassbook);
            this.Controls.Add(this.dtpToDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPassbook);
            this.Controls.Add(this.dtpFromDate);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "ViewPassbookForm";
            this.Text = "ViewPassbookForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewPassbook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.Label lblPassbook;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.Button btnViewPassbook;
        private System.Windows.Forms.DataGridView dgvViewPassbook;
    }
}