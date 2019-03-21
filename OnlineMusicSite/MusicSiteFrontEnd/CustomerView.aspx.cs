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
            clsCustomerCollection cust = new clsCustomerCollection();
            lstCustomers.DataSource = cust.CustomerList;
            lstCustomers.DataValueField = "CustomerId";
            lstCustomers.DataTextField = "CustomerName";
            lstCustomers.DataBind();
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            DisplayCustomers(txtSearch.Text);
        }
    }
}