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
    public partial class ctrLocalDrivingLicenseFilterBy : UserControl
    {

        public ComboBox ComboBoxFilterBy
        {
            get { return cmbLocalDrivingLicenseFilterBy; }
        }

        public TextBox TextBoxInputFilterBy
        {
            get { return txbLocalDrivingLicenseFilterBy; }
        }
        public ctrLocalDrivingLicenseFilterBy()
        {
            InitializeComponent();
            cmbLocalDrivingLicenseFilterBy.Items.Add("None");
            cmbLocalDrivingLicenseFilterBy.Items.Add("Local Driving License ID");
            cmbLocalDrivingLicenseFilterBy.Items.Add("Person ID");
            cmbLocalDrivingLicenseFilterBy.Items.Add("Full Name");
            cmbLocalDrivingLicenseFilterBy.Items.Add("Driving Class");
            cmbLocalDrivingLicenseFilterBy.Items.Add("Status");

            cmbLocalDrivingLicenseFilterBy.SelectedIndex = 0;

        }

        private void txbPersonFilterBy_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Text changed in the filter text box.");
        }

        private void cmbLocalDrivingLicenseFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txbLocalDrivingLicenseFilterBy.Visible = cmbLocalDrivingLicenseFilterBy.SelectedIndex != 0;
            txbLocalDrivingLicenseFilterBy.Focus();
        }
    }
}
