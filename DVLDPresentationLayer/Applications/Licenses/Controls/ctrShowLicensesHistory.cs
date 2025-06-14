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
    public partial class ctrShowLicensesHistory : UserControl
    {
        public ctrShowLicensesHistory()
        {
            InitializeComponent();
        }

        private void linkLabShowLicensesHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form form = new frmLicenseHistory();
            form.ShowDialog(this);
        }
    }
}
