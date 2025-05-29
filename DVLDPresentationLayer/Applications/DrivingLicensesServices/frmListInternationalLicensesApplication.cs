using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLDPresentationLayer.Applications
{
    public partial class frmListInternationalLicensesApplication : Form
    {
        public frmListInternationalLicensesApplication()
        {
            InitializeComponent();
        }

        private void btnAddInternationalLicense_Click(object sender, EventArgs e)
        {
            Form form = new frmNewInternationalLicenseApplication();
            form.ShowDialog(this);
        }
    }
}
