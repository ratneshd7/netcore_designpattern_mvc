using System;
using System.Windows.Forms;
using System.Configuration;
using BankCore;

namespace BankingFormAppSolution
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }
        string connectionString = ConfigurationManager.ConnectionStrings["BankApp"].ConnectionString;
        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtName.Text != " " && txtOpeningBalance.Text != " " && txtPassword.Text != "")
            {
                BankMaster bms = new BankMaster(txtName.Text, float.Parse(txtOpeningBalance.Text), txtPassword.Text, connectionString);
                if (bms.registerUser())
                {
                    MessageBox.Show("Registered Successfully");
                }
                else
                    MessageBox.Show("Something went wrong");
            }
            else
            {
                MessageBox.Show("Fill All Details");
            }
        }

        private void tabName(object sender, EventArgs e)
        {
            
            BankMaster bms = new BankMaster(connectionString);
            if (bms.checkUser(txtName.Text))
            {
                MessageBox.Show("User Already Registered Pls Login");
                btnRegister.Visible = false;
                return;
            }
            btnRegister.Visible = true;
        }       
    }
}
