using DVLDPresentationLayer.Controls;
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
    public partial class frmPersonDetails : Form
    {
        public frmPersonDetails()
        {
            
            InitializeComponent();
        }

        private void frmPersonDetails_Load(object sender, EventArgs e)
        {
            ctrHeaderTitleControl1.Title = "Person Details";
        }
    }
}
