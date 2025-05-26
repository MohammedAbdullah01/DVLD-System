using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLDPresentationLayer.Persons.Controls
{
    public partial class ctrPersonListFilterBy : UserControl
    {

        public ComboBox ComboBoxFilterBy
        {
            get { return cmbPersonFilterBy; }
        }

        public TextBox TextBoxInputFilterByPerson
        {
            get { return txbPersonFilterBy; }
        }
        public ctrPersonListFilterBy()
        {
            InitializeComponent();
        }

        private void cmbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txbPersonFilterBy.Enabled = (cmbPersonFilterBy.SelectedIndex != 0) ? true : false;

            txbPersonFilterBy.Text = string.Empty;
            if (cmbPersonFilterBy.SelectedIndex == 0 && 
                !string.IsNullOrEmpty(txbPersonFilterBy.Text.Trim()))
            {
                txbPersonFilterBy.Text = string.Empty;
            }
        }

        private void ctrPersonListFilterBy_Load(object sender, EventArgs e)
        {
            cmbPersonFilterBy.Items.Add("None");
            cmbPersonFilterBy.Items.Add("Person ID");
            cmbPersonFilterBy.Items.Add("National ID");
            cmbPersonFilterBy.Items.Add("First Name");
            cmbPersonFilterBy.Items.Add("Second Name");
            cmbPersonFilterBy.Items.Add("Third Name");
            cmbPersonFilterBy.Items.Add("Last Name");
            cmbPersonFilterBy.Items.Add("Gender");
            cmbPersonFilterBy.Items.Add("Nationality");
            cmbPersonFilterBy.Items.Add("Phone");
            cmbPersonFilterBy.Items.Add("Email");

            cmbPersonFilterBy.SelectedIndex = 0;
            txbPersonFilterBy.Enabled = false;
        }

        private void txbPersonFilterBy_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Text changed in the filter text box.");
        }

        public void RemoveTextChangedHandler()
        {
            txbPersonFilterBy.TextChanged -= txbPersonFilterBy_TextChanged;
        }
    }
}
