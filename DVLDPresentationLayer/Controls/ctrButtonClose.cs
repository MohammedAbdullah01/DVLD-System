using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace DVLDPresentationLayer.Controls
{
    public partial class ctrButtonClose : UserControl
    {

        public string ButtonText
        {
            get { return btnClose.Text; }
            set { btnClose.Text = value; }
        }
        public ctrButtonClose()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Form parentForm = FindForm();
            if (parentForm != null)
            {
                parentForm.Close();
            }
        }
    }
}
