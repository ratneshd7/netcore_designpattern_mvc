using System;
using System.Windows.Forms;

namespace WelcomFormApp
{
    public partial class WelcomeWindowsForm : Form
    {
        public WelcomeWindowsForm()
        {
            InitializeComponent();
        }

        private void WelcomeWindowsForm_Load(object sender, EventArgs e)
        {

        }

        private void lblDisplay_Click(object sender, EventArgs e)
        {
            
        }

        private void btnWish_Click(object sender, EventArgs e)
        {

            lblDisplay.Text ="Welcome Says "+ txtUserName.Text;
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            //lblDisplay.Text = txtUserName.Text;
        }
    }
}
