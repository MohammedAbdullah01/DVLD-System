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
    public partial class ctrApplicationInfoLicenseReplacement : UserControl
    {
        public string ApplicationFees 
        {
            get { return labValueApplicationFees.Text; }
            set { labValueApplicationFees.Text = value; }
        }


        public ctrApplicationInfoLicenseReplacement()
        {
            InitializeComponent();
        }
    }
}
