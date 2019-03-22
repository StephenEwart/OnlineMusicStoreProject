using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

namespace MusicSiteFrontEnd
{
    public partial class CustomerView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DisplayCustomers("");
        }

        public void DisplayCustomers(string nameFilter)
        {
            //create instance of clsCustomercollection
            string customerId;
            string customerName;

            clsCustomerCollection collect = new clsCustomerCollection();
            int recordCount;
            int i = 0;

            lstCustomers.Items.Clear();
            collect.FilterByName(nameFilter);
            recordCount = collect.Count;
            while (i < recordCount)
            {
                customerId = Convert.ToString(collect.CustomerList[i].mCustomerId);
                customerName = Convert.ToString(collect.CustomerList[i].mCustomerName);
                ListItem entry = new ListItem(customerName, customerId);
                lstCustomers.Items.Add(entry);
                i++;
            }
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            DisplayCustomers(txtSearch.Text);
        }

        protected void btnView_Click(object sender, EventArgs e)
        {
            int customerId;
                customerId = Convert.ToInt32(lstCustomers.SelectedIndex);
                //transfer to single customer view page
                Session["customerId"] = customerId;
                Response.Redirect("SingleCustomerView.aspx");

        }
    }
}