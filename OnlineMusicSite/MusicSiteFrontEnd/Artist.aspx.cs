using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;


namespace MusicSiteFrontEnd
{
    public partial class Artist : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if this is the first time the page is displayed
            if (IsPostBack == false)
            {
                //update the list box
                DisplayArtists();
            }
        }

        void DisplayArtists()
        {
            //create an instance of the artist collection
            clsArtistCollection Artists = new clsArtistCollection();
            //set the data source to the list of artists in the collection
            lstArtists.DataSource = Artists.ArtistList;
            //set the name of the primary key
            lstArtists.DataValueField = "ArtistID";
            //set the data field to display
            lstArtists.DataTextField = "ArtistName";
            //bind the data to the list
            lstArtists.DataBind();
        }
    }
}