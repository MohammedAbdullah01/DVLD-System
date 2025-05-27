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
    public partial class ctrTakeTest : UserControl
    {
        public string TitleGroupBox
        {
            get { return grbTakeTest.Text; }
            set { grbTakeTest.Text = value; }
        }
        public string DrivingLicenseAppID
        {
            get { return labValueDLAppID.Text; }
            set { labValueDLAppID.Text = value; }
        }
        public string DrivingClass
        {
            get { return labValueDClass.Text; }
            set { labValueDClass.Text = value; }
        }
        public string FullName
        {
            get { return labValueName.Text; }
            set { labValueName.Text = value; }
        }
        public string Trial
        {
            get { return labValueTrial.Text; }
            set { labValueTrial.Text = value; }
        }
        public string Date
        {
            get { return labValueDate.Text; }
            set { labValueDate.Text = value; }
        }
        public string Fees
        {
            get { return labValueFees.Text; }
            set { labValueFees.Text = value; }
        }

        public string TestID
        {
            get { return labValueTestID.Text; }
            set { labValueTestID.Text = value; }
        }

        public ctrTakeTest()
        {
            InitializeComponent();
        }
    }
}
