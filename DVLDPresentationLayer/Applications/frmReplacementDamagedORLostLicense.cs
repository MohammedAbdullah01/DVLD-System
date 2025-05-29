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
    public partial class frmReplacementDamagedORLostLicense : Form
    {
        public frmReplacementDamagedORLostLicense()
        {
            InitializeComponent();
        }

        private void btnIssueReplacement_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Replacement License Issued Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void radBtnDamaged_CheckedChanged(object sender, EventArgs e)
        {
            this.Text = ctrHeaderTitleControl1.Title = ctrHeaderTitleControl1.Title.Replace("Lost", "Damaged");
            ctrApplicationInfoLicenseReplacement1.ApplicationFees = "5";
        }

        private void radBtnLost_CheckedChanged(object sender, EventArgs e)
        {
            this.Text = ctrHeaderTitleControl1.Title = ctrHeaderTitleControl1.Title.Replace("Damaged", "Lost");
            ctrApplicationInfoLicenseReplacement1.ApplicationFees = "10";

        }

        private void frmReplacementDamagedORLostLicense_Load(object sender, EventArgs e)
        {
            radBtnDamaged.Checked = true;
        }
    }
}
