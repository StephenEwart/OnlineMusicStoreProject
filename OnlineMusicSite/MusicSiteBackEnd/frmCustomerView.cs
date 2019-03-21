using ClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicSiteBackEnd
{
    public partial class frmCustomerView : Form
    {
        public frmCustomerView()
        {
            InitializeComponent();
        }

        private void lstCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnDelete.Enabled = true;
            btnEdit.Enabled = true;
        }

        private void frmCustomerView_Load(object sender, EventArgs e)
        {
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;

            DisplayCustomers("");
        }

        void DisplayCustomers(string nameFilter)
        {
            //create instance of customer collection
            clsCustomerCollection customers = new clsCustomerCollection();

            string customerId;
            int index = 0;
            lstCustomers.Items.Clear();
            customers.FilterByName(nameFilter);
            int recordCount = customers.Count;
            while (index < recordCount)
            {
                customerId = Convert.ToString(customers.CustomerList[index].mCustomerId);
                lstCustomers.Items.Add(customerId);
                index++;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmAddCustomer addCustomer = new frmAddCustomer(Convert.ToInt32(lstCustomers.SelectedItem));
            addCustomer.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            clsCustomerCollection customer = new clsCustomerCollection();
            DialogResult dr = MessageBox.Show("Are you sure you want to delete this customer", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                customer.Delete(Convert.ToInt32(lstCustomers.SelectedItem));
            }
            DisplayCustomers("");
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            clsCustomerCollection cust = new clsCustomerCollection();
            cust.sortCustomerList();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DisplayCustomers(txtSearch.Text);
        }

        private void btnDisplayAll_Click(object sender, EventArgs e)
        {
            DisplayCustomers("");
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
