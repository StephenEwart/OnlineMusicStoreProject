using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MusicSiteFrontEnd
{
    public partial class MusicSite : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCustomer_Click(object sender, EventArgs e)
        {
            Response.Redirect("CustomerView.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //link to artist.aspx
            Response.Redirect("Artist.aspx");
        }
    }
}