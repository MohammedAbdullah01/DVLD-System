using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLDPresentationLayer.DetainLicenses.Controls
{
    public partial class ctrListDetainedLicensesFilterBy : UserControl
    {
        public ctrListDetainedLicensesFilterBy()
        {
            InitializeComponent();

            cmbDetainedFilterBy.Items.Add("None");
            cmbDetainedFilterBy.Items.Add("Detain ID");
            cmbDetainedFilterBy.Items.Add("National No");
            cmbDetainedFilterBy.Items.Add("Full Name");
            cmbDetainedFilterBy.Items.Add("Release Application ID");
            cmbDetainedFilterBy.Items.Add("Is Released");

            cmbDetainedFilterBy.SelectedIndex = 0;
        }

        private void cmbDetainedFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedFilter = cmbDetainedFilterBy.SelectedItem.ToString() ?? "None";


            if (selectedFilter == "None")
            {
                txbDetainedFilterBy.Text = string.Empty;
                txbDetainedFilterBy.Visible = false;
                cmbIsReleased.Visible = false;
            }
            else if (selectedFilter != "None" && selectedFilter != "Is Released")
            {
                txbDetainedFilterBy.Visible = true;
                txbDetainedFilterBy.Focus();
            }
            else if (selectedFilter == "Is Released")
            {
                txbDetainedFilterBy.Visible = false;
                cmbIsReleased.Visible = true;
                cmbIsReleased.SelectedIndex = 0;
            }
        }

        private void cmbIsReleased_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbIsReleased.SelectedItem.ToString())
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

        private void txbDetainedFilterBy_TextChanged(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(txbDetainedFilterBy.Text))
            {
                MessageBox.Show($"Filter applied: {txbDetainedFilterBy.Text}");
            }
        }
    }
}
