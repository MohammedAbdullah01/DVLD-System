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
    public partial class ctrScheduleTest : UserControl
    {

        public string TitleGroupBox
        {
            get { return grbScheduleTest.Text; }
            set { grbScheduleTest.Text = value; }
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
            get { return dtpDate.Text; }
            set { dtpDate.Text = value; }
        }

        public string Fees
        {
            get { return labValueFees.Text; }
            set { labValueFees.Text = value; }
        }

        public ctrRetakeTestInfo RetakeTestInfo
        {
            get { return ctrRetakeTestInfo1; }
        }


        public ctrScheduleTest()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void ctrScheduleTest_Load(object sender, EventArgs e)
        {
            dtpDate.Value = DateTime.Now;
            dtpDate.MinDate = DateTime.Now;
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = dtpDate.Value;
            string formattedDate = selectedDate.ToString("dddd");

            if (formattedDate == "Friday" || formattedDate == "Saturday")
            {
                MessageBox.Show("Tests cannot be scheduled on weekends. Please select a weekday.", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpDate.Value = DateTime.Now;
            }
            else
            {
                // Additional logic for valid date selection can be added here
            }
        }
    }
}
