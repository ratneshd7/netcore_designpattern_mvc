using System;
using System.Linq;
using System.Windows.Forms;

namespace BankingFormAppSolution
{
    public partial class BankingMDIFormApp : Form
    {
        public String _loginName;
        public BankingMDIFormApp()
        {
            InitializeComponent();
        }

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Form frm = new Form();
            //frm.MdiParent = this;
            //frm.Show();
          
            Boolean isformOpen = false;

            if (this.MdiChildren.Count() >= 1)
            {
                //MessageBox.Show("" + this.MdiChildren.Count());
                foreach (Form f in this.MdiChildren)
                {
                    if (f.Name == "RegisterForm")
                    {
                        isformOpen = true;
                        break;
                    }
                    f.Close();
                }

            }
            if (!isformOpen)
            {
                RegisterForm frm = new RegisterForm();
                frm.MdiParent = this;
                frm.Show();
            }

        }

        private void login_Click(object sender, EventArgs e)
        {
           
            Boolean isformOpen = false;
            
            if (this.MdiChildren.Count() >= 1)
            {
               // MessageBox.Show(""+this.MdiChildren.Count());
                foreach (Form f in this.MdiChildren)
                {
                    if (f.Name == "LoginForm")
                    {

                        isformOpen = true;
                        break;
                    }
                    f.Close();                   
                }
            }
            if (!isformOpen)
            {
                LoginForm frm = new LoginForm(this);
                frm.MdiParent = this;
                frm.Show();
            }
          
        }

        private void dotransaction_Click(object sender, EventArgs e)
        {

            Boolean isformOpen = false;

            if (this.MdiChildren.Count() >= 1)
            {
                // MessageBox.Show(""+this.MdiChildren.Count());
                foreach (Form f in this.MdiChildren)
                {
                    if (f.Name == "DoTransactions")
                    {

                        isformOpen = true;
                        break;
                    }
                    f.Close();
                }
            }
            if (!isformOpen)
            {
                DoTransactions frm = new DoTransactions(this);
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void viewPassbook_Click(object sender, EventArgs e)
        {
            Boolean isformOpen = false;

            if (this.MdiChildren.Count() >= 1)
            {
                // MessageBox.Show(""+this.MdiChildren.Count());
                foreach (Form f in this.MdiChildren)
                {
                    if (f.Name == "ViewPassbookForm")
                    {

                        isformOpen = true;
                        break;
                    }
                    f.Close();
                }
            }
            if (!isformOpen)
            {
                ViewPassbookForm frm = new ViewPassbookForm(this);
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.login.Visible = true;
            this.registerToolStripMenuItem.Visible = true;
            this.dotransaction.Visible = false;
            this.viewPassbook.Visible = false;
            this.logout.Visible = false;
            if (this.MdiChildren.Count() >= 1)
            {
                // MessageBox.Show(""+this.MdiChildren.Count());
                foreach (Form f in this.MdiChildren)
                {
                    f.Close();
                }
            }
        }
        public void openButtonVisible(String name )
        {
            _loginName = name;
            this.login.Visible = false;
            this.registerToolStripMenuItem.Visible = false;
           // this.dotransaction.Available = true;
            this.dotransaction.Visible = true;
            this.viewPassbook.Visible = true;
            this.logout.Visible = true;
            
        }
    }
}
