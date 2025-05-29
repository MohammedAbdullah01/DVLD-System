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
    public partial class ctrDriverLicenses : UserControl
    {
        public ctrDriverLicenses()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {

            tabControlDriverLicenses.SelectedTab = tabPageInternational;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            tabControlDriverLicenses.SelectedTab = tabPageLocal;
        }
    }
}
