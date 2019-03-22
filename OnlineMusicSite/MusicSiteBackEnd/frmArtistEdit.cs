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
    public partial class frmArtistEdit : Form
    {
        public frmArtistEdit()
        {
            InitializeComponent();
        }



        public void EditArtist()
        {
            //instance of data connection class
            clsDataConnection dataConnect = new clsDataConnection();
            //add parameters to SQL
            dataConnect.AddParameter("@ArtistName", txtArtistName.Text);
            dataConnect.AddParameter("@ArtistGenre", txtGenre.Text);
            dataConnect.AddParameter("@ArtistBio", txtBio.Text);
            //execute stored procedure
            dataConnect.Execute("sproc_tblArtist_Update");
        }

        private void frmArtistEdit_Load(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //call edit artist function
            EditArtist();
            lblError.Text = " Edit Completed";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //closes form
            this.Close();
        }
    }
}
