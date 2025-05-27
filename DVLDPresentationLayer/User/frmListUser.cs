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
    public partial class frmListUser : Form
    {
        public frmListUser()
        {
            InitializeComponent();
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            Form form = new frmAddNewUser();
            form.ShowDialog(this);
        }
    }
}
