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
        public frmAddCustomer(int customerId)
        {
            InitializeComponent();

            if (customerId != 0)
            {

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            clsCustomerCollection collect = new clsCustomerCollection();
            string outcome = collect.ThisCustomer.InputValidation(txtCustomerName.Text, txtUsername.Text, txtEmail.Text, txtPassword.Text, txtConfirmPassword.Text, txtPhoneNo.Text, txtCardDetails.Text, txtAddress.Text);
            if (outcome == "")
            {
                collect.ThisCustomer.mCustomerName = txtCustomerName.Text;
                collect.ThisCustomer.mUsername = txtUsername.Text;
                collect.ThisCustomer.mEmail = txtEmail.Text;
                collect.ThisCustomer.mPassword = txtPassword.Text;
                collect.ThisCustomer.mPhoneNo = txtPhoneNo.Text;
                collect.ThisCustomer.mCardDetails = txtCardDetails.Text;
                collect.ThisCustomer.mAddress = txtAddress.Text;

                collect.Add();
            }
            else
            {
                DialogResult dr = MessageBox.Show("You have Errors With your Data : " + Environment.NewLine + outcome, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
