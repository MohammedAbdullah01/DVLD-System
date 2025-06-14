using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLDPresentationLayer.DetainLicenses
{
    public partial class frmListDetainedLicenses : Form
    {
        public frmListDetainedLicenses()
        {
            InitializeComponent();
        }

        private void btnReleaseDetaine_Click(object sender, EventArgs e)
        {
           Form form = new frmReleaseDetainedLicense();
            form.ShowDialog();

        }

        private void btnLicenseDetaine_Click(object sender, EventArgs e)
        {
            Form form = new frmDetainLicense();
            form.ShowDialog();

            MessageBox.Show("This feature is not implemented yet. Please contact the system administrator for more information.", "Feature Not Implemented", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
