using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLDPresentationLayer.Persons
{
    public partial class frmListPersons : Form
    {
        public frmListPersons()
        {
            InitializeComponent();
        }

        private void frmListPersons_Load(object sender, EventArgs e)
        {
            string[] row1 = new string[] { "100000", "nn1010101010", "Mohamed" , "Ahmed" , "Abd alghany" , "mohamed al ghdfar" , "male" , "10/10/2025" , "Egypt" , "012154789510" , "mohamed50@gmail.com" };
            dGVListPersons.Rows.Add(row1);

            ctrPersonListFilterBy1.ComboBoxFilterBy.Items.Add("None");
            ctrPersonListFilterBy1.ComboBoxFilterBy.Items.Add("Person ID");
            ctrPersonListFilterBy1.ComboBoxFilterBy.Items.Add("National ID");
            ctrPersonListFilterBy1.ComboBoxFilterBy.Items.Add("First Name");
            ctrPersonListFilterBy1.ComboBoxFilterBy.Items.Add("Second Name");
            ctrPersonListFilterBy1.ComboBoxFilterBy.Items.Add("Third Name");
            ctrPersonListFilterBy1.ComboBoxFilterBy.Items.Add("Last Name");
            ctrPersonListFilterBy1.ComboBoxFilterBy.Items.Add("Gender");
            ctrPersonListFilterBy1.ComboBoxFilterBy.Items.Add("Nationality");
            ctrPersonListFilterBy1.ComboBoxFilterBy.Items.Add("Phone");
            ctrPersonListFilterBy1.ComboBoxFilterBy.Items.Add("Email");

            ctrPersonListFilterBy1.ComboBoxFilterBy.SelectedIndex = 0;  
            ctrPersonListFilterBy1.TextBoxInputFilterByPerson.Enabled = false;

        }
    }
}
