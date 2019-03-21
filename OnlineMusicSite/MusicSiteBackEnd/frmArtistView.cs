using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;

namespace MusicSiteBackEnd
{
    public partial class frmArtistView : Form
    {
        public frmArtistView()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //get selected index
            int ArtistID = lstArtist.SelectedIndex;
            //instanciate clsDataConnection
            clsDataConnection dataConnect = new clsDataConnection();
            //add parameter ArtistName
            dataConnect.AddParameter("@ArtistName", lstArtist.Text);
            //execute sproc
            dataConnect.Execute("sproc_tblArtist_Delete");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //get the primary key value from the list box
            int ArtistID = Convert.ToInt32(lstArtist.SelectedValue);
            //open frmEdit
            frmAddArtist newAdd = new frmAddArtist();
            newAdd.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //get the primary key value from the list box
            int ArtistID = Convert.ToInt32(lstArtist.SelectedValue);
            //open frmEdit
            frmArtistEdit newEdit = new frmArtistEdit();
            newEdit.Show();
        }

        private void frmArtistView_Load(object sender, EventArgs e)
        {

        }

        private void btnPopulate_Click(object sender, EventArgs e)
        {
            DisplayArtists("");
        }

        void DisplayArtists(string nameFilter)
        {
            //create instance of customer collection
            clsArtistCollection Artists = new clsArtistCollection();

            string ArtistName;
            int index = 0;
            lstArtist.Items.Clear();
            Artists.ReportByArtistName(nameFilter);
            int recordCount = Artists.Count;
            while (index < recordCount)
            {
                ArtistName = Convert.ToString(Artists.ArtistList[index].ArtistName);
                lstArtist.Items.Add(ArtistName);
                index++;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DisplayArtists(txtArtist.Text);
        }
    }
}
