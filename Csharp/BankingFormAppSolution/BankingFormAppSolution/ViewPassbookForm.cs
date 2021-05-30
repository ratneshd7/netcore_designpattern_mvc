using BankCore;
using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace BankingFormAppSolution
{
    public partial class ViewPassbookForm : Form
    {
        private BankingMDIFormApp _bankingMDIFormApp;
        private bool dateStatus;
        public String name;
        public ViewPassbookForm()
        {
            InitializeComponent();
        }
        public ViewPassbookForm(BankingMDIFormApp form)
        {
            _bankingMDIFormApp = form;
            InitializeComponent();
        }
        string connectionString = ConfigurationManager.ConnectionStrings["BankApp"].ConnectionString;
        private void btnShowPassbook(object sender, EventArgs e)
        {
            name = _bankingMDIFormApp._loginName;
            BankMaster bms = new BankMaster(connectionString);
            dateStatus = validateDate(dtpFromDate.Value.Date,dtpToDate.Value.Date);

            if (!dateStatus)
            {
                MessageBox.Show("Invalid Date");
            }
            else
            {
                DataTable dataTable= bms.getPassBookData(name, dtpFromDate.Value.Date, dtpToDate.Value.Date);
                dgvViewPassbook.DataSource = dataTable;
            }
        }
        private bool validateDate(DateTime fromDate,DateTime toDate)
        {
            if (fromDate > DateTime.Now.Date)
            {
                return false;
            }
            if (toDate> DateTime.Now.Date)
            {
                return false;
            }
            if (fromDate > toDate)
            {
                return false;
            }
            return true;
        }
    }
}
