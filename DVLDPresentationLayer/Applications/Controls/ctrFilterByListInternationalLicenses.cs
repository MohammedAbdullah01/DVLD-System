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
    public partial class ctrFilterByListInternationalLicenses : UserControl
    {
        public ctrFilterByListInternationalLicenses()
        {
            InitializeComponent();

            cmbInternationalLicensesFilterBy.Items.Add("None");
            cmbInternationalLicensesFilterBy.Items.Add("International License ID");
            cmbInternationalLicensesFilterBy.Items.Add("Local License ID");
            cmbInternationalLicensesFilterBy.Items.Add("Driver ID");
            cmbInternationalLicensesFilterBy.Items.Add("Issue Date");
            cmbInternationalLicensesFilterBy.Items.Add("Expiration Date");
            cmbInternationalLicensesFilterBy.Items.Add("Is Active");
            cmbInternationalLicensesFilterBy.SelectedIndex = 0;

            cmbActive.Items.Add("Yes");
            cmbActive.Items.Add("No");
        }

        private void cmbInternationalLicensesFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedFilter = cmbInternationalLicensesFilterBy.SelectedItem.ToString() ?? "None";

            if (selectedFilter == "None")
            {
                txbInternationalLicensesFilterBy.Text = string.Empty;
                txbInternationalLicensesFilterBy.Visible = false;
                cmbActive.Visible = false;
            }
            else if (selectedFilter != "None" && selectedFilter != "Is Active")
            {
                txbInternationalLicensesFilterBy.Visible = true;
                txbInternationalLicensesFilterBy.Focus();
            }
            else if (selectedFilter == "Is Active")
            {
                txbInternationalLicensesFilterBy.Visible = false;
                cmbActive.Visible = true;
                cmbActive.SelectedIndex = 0;
            }
        }

        private void txbInternationalLicensesFilterBy_TextChanged(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(txbInternationalLicensesFilterBy.Text))
                MessageBox.Show("Filter text changed: " + txbInternationalLicensesFilterBy.Text);
        }

        private void cmbActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbActive.SelectedItem.ToString())
            {
                case "Yes":
                    MessageBox.Show("Yes selected");
                    break;
                case "No":
                    MessageBox.Show("No selected");
                    break;
                default:
                    MessageBox.Show("Please select a valid option.");
                    break;
            }
        }
    }
}
