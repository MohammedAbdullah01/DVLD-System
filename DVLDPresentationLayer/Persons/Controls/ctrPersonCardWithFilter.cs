using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLDPresentationLayer.UserControls
{
    public partial class ctrPersonCardWithFilter : UserControl
    {
        public ctrPersonCardWithFilter()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void ctrPersonCardWithFilter_Load(object sender, EventArgs e)
        {
            //combFindBy.SelectedIndex = 0;
            //btnSearch.Enabled = false;
            //ctrPersonFilterBy1.ButtonSearch
        }

        private void txtInputIdOrNational_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;

            if (!int.TryParse(txt.Text, out _))
            {
                txt.BackColor = Color.LightCoral;
                //btnSearch.Enabled = false;
            }
            else
            {
                txt.BackColor = Color.White; 
                //btnSearch.Enabled = true;
            }
        }
    }
}
