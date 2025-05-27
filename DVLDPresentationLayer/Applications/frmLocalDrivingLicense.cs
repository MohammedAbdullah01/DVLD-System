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
    public partial class frmLocalDrivingLicense : Form
    {
        public frmLocalDrivingLicense()
        {
            InitializeComponent();
        }

        private void btnAddApplication_Click(object sender, EventArgs e)
        {
            Form newApplicationForm = new frmNewLocalDrivingLicenseApplication();
            newApplicationForm.ShowDialog();
        }
    }
}
