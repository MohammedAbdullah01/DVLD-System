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
    public partial class ctrRetakeTestInfo : UserControl
    {
        public string RetakeAppFees
        {
            get { return labValueRetakeAppFees.Text; }
            set { labValueRetakeAppFees.Text = value; }
        }
        public string RetakeAppID
        {
            get { return labValueRTestAppID.Text; }
            set { labValueRTestAppID.Text = value; }
        }
        public string TotalFees
        {
            get { return labValueTotalFees.Text; }
            set { labValueTotalFees.Text = value; }
        }
        public ctrRetakeTestInfo()
        {
            InitializeComponent();
        }
    }
}
