using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLDPresentationLayer.Driver.Control
{
    public partial class ctrListDriverFilterBy : UserControl
    {
        public ctrListDriverFilterBy()
        {
            InitializeComponent();
        }

        private void ctrListDriverFilterBy_Load(object sender, EventArgs e)
        {
            cmbDriverFilterBy.Items.Add("None");
            cmbDriverFilterBy.Items.Add("Driver ID");
            cmbDriverFilterBy.Items.Add("Person ID");
            cmbDriverFilterBy.Items.Add("National No");

            cmbDriverFilterBy.SelectedIndex = 0;
        }

        private void cmbDriverFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedFilter = cmbDriverFilterBy.SelectedItem.ToString() ?? "None";


            if (selectedFilter == "None")
            {
                txbDriverFilterBy.Text = string.Empty;
                txbDriverFilterBy.Visible = false;
            }
            else
            {
                txbDriverFilterBy.Visible = true;
                txbDriverFilterBy.Focus();
            }
        }

        private void txbDriverFilterBy_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Filter text changed: " + txbDriverFilterBy.Text);
        }
    }
}
