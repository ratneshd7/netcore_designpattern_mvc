using System;
using System.Windows.Forms;
using BankCore;
using System.Configuration;

namespace BankingFormAppSolution
{
    public partial class LoginForm : Form
    {
        private BankingMDIFormApp _bankingMDIFormApp;
        public LoginForm()
        {
            InitializeComponent();
        }
        public LoginForm(BankingMDIFormApp form)
        {
            _bankingMDIFormApp = form;
            InitializeComponent();
        }
        string connectionString = ConfigurationManager.ConnectionStrings["BankApp"].ConnectionString;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            BankMaster bms = new BankMaster(connectionString);
           
            if (bms.authenticateUser(txtUsername.Text, txtloginPassword.Text))
            {
                MessageBox.Show("loged in, Successfully");
               
                // btnRegister.Visible = false;
                this._bankingMDIFormApp.openButtonVisible(txtUsername.Text);
                this.Close();
                return;
            }
            else
            {
                MessageBox.Show("Wrong Credentials");
                return;
            }
        }
    }

}
