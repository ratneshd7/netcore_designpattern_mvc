using BankCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingFormAppSolution
{
    public partial class DoTransactions : Form
    {
        public String name;
        private bool status;
        private BankingMDIFormApp _bankingMDIFormApp;
        private String _type;
        public DoTransactions()
        {
            InitializeComponent();
        }
        public DoTransactions(BankingMDIFormApp form)
        {
            _bankingMDIFormApp = form;
            InitializeComponent();
        }
        string connectionString = ConfigurationManager.ConnectionStrings["BankApp"].ConnectionString;

        private void doTransaction(object sender, EventArgs e)
        {
            name = _bankingMDIFormApp._loginName;
            BankMaster bms = new BankMaster(connectionString);
            if (radBtnDeposite.Checked)
            {
                _type = "D";
               status= bms.performDeposite(name,_type,float.Parse(txtAmount.Text));
                if (status)
                {
                    MessageBox.Show("Amount Deposited Successfully");
                }
                else
                {
                    MessageBox.Show("Something Went wrong");
                }
                
            }
            if (radBtnWithdraw.Checked)
            {
                _type = "W";
                status= bms.performWithdraw(name, _type, float.Parse(txtAmount.Text));
                if (status)
                {
                    MessageBox.Show("Amount Withdrawal Successfully");
                }
                else
                {
                    MessageBox.Show("Something Went wrong");
                }
            }         
            
        }
    }
}
