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
    public partial class frmCustomerView : Form
    {
        public frmCustomerView()
        {
            InitializeComponent();
        }

        private void lstCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnDelete.Enabled = true;
            btnEdit.Enabled = true;
        }

        private void frmCustomerView_Load(object sender, EventArgs e)
        {
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
        }
    }
}
