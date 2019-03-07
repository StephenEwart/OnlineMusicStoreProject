using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;

namespace MusicSiteBackEnd
{
    public partial class frmAddCustomer : Form
    {
        public frmAddCustomer()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            clsCustomerCollection collect = new clsCustomerCollection();
            string outcome = collect.mThisCustomer.InputValidation(txtCustomerName.Text, txtUsername.Text, txtEmail.Text, txtPassword.Text, txtConfirmPassword.Text, txtPhoneNo.Text, txtCardDetails.Text, txtAddress.Text);
            if (outcome == "")
            {

            }
        }
    }
}
