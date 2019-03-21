using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

namespace MusicSiteFrontEnd
{
    public partial class SingleCustomerView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
   
        }

        void DisplayCustomers(int custId)
        {
            clsCustomerCollection collect = new clsCustomerCollection();
            collect.ThisCustomer.Find(custId);
            txtName.Text = collect.ThisCustomer.mCustomerName;
            txtUsername.Text = collect.ThisCustomer.mUsername;
            txtEmail.Text = collect.ThisCustomer.mEmail;
            txtPhoneNo.Text = collect.ThisCustomer.mPhoneNo;
        }


        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("CustomerView.aspx");
        }
    }
}