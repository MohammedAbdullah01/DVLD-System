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
    public partial class frmNewLocalDrivingLicenseApplication : Form
    {
        public frmNewLocalDrivingLicenseApplication()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            tabControlNewLocalDrivingLicense.SelectedTab = ApplicationInfo;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            tabControlNewLocalDrivingLicense.SelectedTab = PersonalInfo;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Application saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
