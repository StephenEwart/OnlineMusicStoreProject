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

        public void DisplayCustomer(int customerId)
        {
            
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("CustomerView.aspx");
        }
    }
}