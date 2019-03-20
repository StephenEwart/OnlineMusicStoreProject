using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MusicSiteFrontEnd
{
    public partial class Customer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                DisplayCustomers();
            }
        }

        void DisplayCustomers()
        {
            clsCustomerCollection customer = new clsCustomerCollection();
            lstCustomers.DataSource = customer.customerList;
            lstCustomers.DataValueField = "CustomerId";
            lstCustomers.DataTextField = "CustomerName";
            lstCustomers.DataBind();
        }
    }
}