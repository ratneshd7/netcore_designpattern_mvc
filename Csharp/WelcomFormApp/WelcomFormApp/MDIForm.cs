using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WelcomFormApp
{
    public partial class MDIForm : Form
    {
        public MDIForm()
        {
            InitializeComponent();
        }

        private void createNewForm_Click(object sender, EventArgs e)
        {
            Form frm = new Form();
            frm.MdiParent = this;
            frm.Text = "child"+ this.MdiChildren.Count();
            frm.Show();
        }

        private void closeAllForm_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                f.Close();
            }
          
        }

        private void exitForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Help Button Was Clicked");
        }
    }
}
