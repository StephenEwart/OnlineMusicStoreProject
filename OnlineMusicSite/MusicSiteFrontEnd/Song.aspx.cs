using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MusicSiteFrontEnd
{
    public partial class Song : System.Web.UI.Page
    {
        public object lstSongs { get; private set; }
        public object Songs { get; private set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            //if this is the first time that the page is displayed
            if (IsPostBack == false)
            {
                //update the list box
                DisplaySongs();
            }               
        }

        private void DisplaySongs()
        {

        }
    }
}