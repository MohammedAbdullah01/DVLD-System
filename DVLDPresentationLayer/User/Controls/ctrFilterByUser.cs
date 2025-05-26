using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLDPresentationLayer.User.Controls
{
    public partial class ctrFilterByUser : UserControl
    {

        public ComboBox ComboBoxFilterBy
        {
            get { return cmbUserFilterBy; }
        }

        public TextBox TextBoxInputFilterByUser
        {
            get { return txbUserFilterBy; }
        }
        public ctrFilterByUser()
        {
            InitializeComponent();
            cmbUserFilterBy.Items.Add("None");
            cmbUserFilterBy.Items.Add("User ID");
            cmbUserFilterBy.Items.Add("User Name");
            cmbUserFilterBy.Items.Add("Person ID");
            cmbUserFilterBy.Items.Add("Full Name");
            cmbUserFilterBy.Items.Add("Is Active");

            cmbUserFilterBy.SelectedIndex = 0;
        }

        private void comboActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboActive.SelectedItem.ToString())
            {
                case "All":
                    MessageBox.Show("All selected");
                    break;
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

        private void cmbUserFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedFilter = cmbUserFilterBy.SelectedItem.ToString() ?? "None";

            txbUserFilterBy.Enabled = selectedFilter != "None";

            if (selectedFilter == "None")
            {
                txbUserFilterBy.Text = string.Empty;
                txbUserFilterBy.Visible = false;
                comboActive.Visible = false;
            }
            else if (selectedFilter != "None" && selectedFilter != "Is Active")
            {
                txbUserFilterBy.Visible = true;
                txbUserFilterBy.Focus();
            }
            else if (selectedFilter == "Is Active")
            {
                txbUserFilterBy.Visible = false;
                comboActive.Visible = true;
                comboActive.SelectedIndex = 0;
            }
        }

        private void txbUserFilterBy_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Text changed in the filter text box.");
        }
    }
}
