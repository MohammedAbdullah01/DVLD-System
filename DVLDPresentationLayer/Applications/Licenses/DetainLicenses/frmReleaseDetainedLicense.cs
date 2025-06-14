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
    public partial class frmReleaseDetainedLicense : Form
    {
        public frmReleaseDetainedLicense()
        {
            InitializeComponent();
        }

        private void btnRelease_Click(object sender, EventArgs e)
        {
            MessageBox.Show("License released successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
