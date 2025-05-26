using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLDPresentationLayer.User
{
    public partial class frmAddNewUser : Form
    {
        public frmAddNewUser()
        {
            InitializeComponent();
            ctrHeaderTitleControl1.Title = "Add New User";
        }

        private void btnSaveAddUser_Click(object sender, EventArgs e)
        {
            MessageBox.Show("User saved successfully!");
        }

        private void btnNextAddUser_Click(object sender, EventArgs e)
        {
            tabControlPersonInfo.SelectedTab = tabPageLoginInfo;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            tabControlPersonInfo.SelectedTab = tabPagePersonInfo;
        }
    }
}
