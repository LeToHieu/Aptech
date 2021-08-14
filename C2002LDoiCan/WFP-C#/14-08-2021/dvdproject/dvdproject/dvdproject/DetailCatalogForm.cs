using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dvdproject
{
    public partial class DetailCatalogForm : Form
    {
        public InsertOrUpdate Status { get; set; }
        public tblDVDLibrary DVDLibrary { get; set; }
        public DetailCatalogForm()
        {
            InitializeComponent();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
