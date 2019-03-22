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
    public partial class frmAlbumView : Form
    {
        public frmAlbumView()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        void DisplayAlbums()
        {
            ClassLibrary.clsAlbumCollection Albums = new ClassLibrary.clsAlbumCollection();
            lstAlbums.DataSource = Albums.AlbumsList;
            
        }

        protected void Page_Load (object sender, EventArgs e)
        {
            
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            Int32 AlbumID;
            if (lstAlbums.SelectedIndex !=-1)
            {
                AlbumID = Convert.ToInt32(lstAlbums.SelectedIndex);
               
            }
        }
    }
}
