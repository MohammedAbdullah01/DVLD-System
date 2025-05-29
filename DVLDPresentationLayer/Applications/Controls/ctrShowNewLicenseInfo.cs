using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLDPresentationLayer.Applications.Controls
{
    public partial class ctrShowNewLicenseInfo : UserControl
    {
        public ctrShowNewLicenseInfo()
        {
            InitializeComponent();
        }

        private void linkLabShowNewLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form form = new frmLicenseInfo();
            form.ShowDialog(this);
        }
    }
}
