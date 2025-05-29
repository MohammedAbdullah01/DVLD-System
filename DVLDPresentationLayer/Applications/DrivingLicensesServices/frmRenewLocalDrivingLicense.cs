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
    public partial class frmRenewLocalDrivingLicense : Form
    {
        public frmRenewLocalDrivingLicense()
        {
            InitializeComponent();
        }

        private void btnRenew_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your local driving license has been renewed successfully.", "Renewal Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
