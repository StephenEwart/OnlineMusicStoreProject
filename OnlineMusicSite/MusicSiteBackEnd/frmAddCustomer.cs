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
        public int customerId;

        public frmAddCustomer(int customerId)
        {
            InitializeComponent();
            this.customerId = customerId;
            txtCustomerId.Text = Convert.ToString(customerId);

            if (customerId != 0)
            {
                DisplayCustomers(customerId);
            }
        }

        void DisplayCustomers(int customerId)
        {
            clsCustomerCollection customer = new clsCustomerCollection();
            customer.ThisCustomer.Find(customerId);
            txtCustomerName.Text = customer.ThisCustomer.mCustomerName;
            txtUsername.Text = customer.ThisCustomer.mUsername;
            txtEmail.Text = customer.ThisCustomer.mEmail;
            txtPassword.Text = customer.ThisCustomer.mPassword;
            txtPhoneNo.Text = customer.ThisCustomer.mPhoneNo;
            txtCardDetails.Text = customer.ThisCustomer.mCardDetails;
            txtAddress.Text = customer.ThisCustomer.mAddress;
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            clsCustomer cust = new clsCustomer();
            string outcome;
            outcome = cust.InputValidation(txtCustomerName.Text, txtUsername.Text, txtEmail.Text, txtPassword.Text, txtConfirmPassword.Text, txtPhoneNo.Text, txtCardDetails.Text, txtAddress.Text);
            if (customerId != 0)
            {
                if (outcome == "")
                {
                    clsCustomerCollection collect = new clsCustomerCollection();
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
            else
            {
                if (outcome == "")
                {
                    clsCustomerCollection collect = new clsCustomerCollection();
                    collect.ThisCustomer.mCustomerId = customerId;
                    collect.ThisCustomer.mCustomerName = txtCustomerName.Text;
                    collect.ThisCustomer.mUsername = txtUsername.Text;
                    collect.ThisCustomer.mEmail = txtEmail.Text;
                    collect.ThisCustomer.mPassword = txtPassword.Text;
                    collect.ThisCustomer.mPhoneNo = txtPhoneNo.Text;
                    collect.ThisCustomer.mCardDetails = txtCardDetails.Text;
                    collect.ThisCustomer.mAddress = txtAddress.Text;

                    collect.Update();
                }
                else
                {
                    DialogResult dr = MessageBox.Show("You have Errors With your Data : " + Environment.NewLine + outcome, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
