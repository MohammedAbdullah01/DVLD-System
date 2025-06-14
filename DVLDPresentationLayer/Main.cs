using DVLDPresentationLayer.Applications;
using DVLDPresentationLayer.DetainLicenses;
using DVLDPresentationLayer.Persons;
using DVLDPresentationLayer.User;
using DVLDPresentationLayer.User.Controls;
using DVLDPresentationLayer.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLDPresentationLayer
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private void MenuItemLocalLicense_Click(object sender, EventArgs e)
        {
            frmLocalDrivingLicense frmLocalDrivingLicense = new frmLocalDrivingLicense();
            frmLocalDrivingLicense.ShowDialog();
        }

        private void MenuItemInternationalLicense_Click(object sender, EventArgs e)
        {
            frmListInternationalLicensesApplication frmListInternationalLicensesApplication = new frmListInternationalLicensesApplication();
            frmListInternationalLicensesApplication.ShowDialog();
        }

        private void MenuItemPersons_Click(object sender, EventArgs e)
        {
            frmListPersons frmListPersons = new frmListPersons();
            frmListPersons.ShowDialog();
        }


        private void MenuItemCurrentUserInfo_Click(object sender, EventArgs e)
        {
            frmUserDetails frmUserDetails = new frmUserDetails();
            frmUserDetails.ShowDialog();
        }

        private void MenuItemChangePassword_Click(object sender, EventArgs e)
        {
            frmUserChangePassword frmUserChangePassword = new frmUserChangePassword();
            frmUserChangePassword.ShowDialog();
        }

        private void MenuItemSignOut_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLoginScreen frmLoginScreen = new frmLoginScreen();
            frmLoginScreen.ShowDialog();
        }

        private void MenuItemLocalDrivingLicenseApplications_Click(object sender, EventArgs e)
        {
            frmLocalDrivingLicense frmLocalDrivingLicense = new frmLocalDrivingLicense();
            frmLocalDrivingLicense.ShowDialog();
        }

        private void MenuItemInternationalLicenseApplications_Click(object sender, EventArgs e)
        {
            frmListInternationalLicensesApplication frmListInternationalLicensesApplication = new frmListInternationalLicensesApplication();
            frmListInternationalLicensesApplication.ShowDialog();
        }

        private void MenuItemManageDetainedLicenses_Click(object sender, EventArgs e)
        {
            frmListDetainedLicenses frmListDetainedLicenses = new frmListDetainedLicenses();
            frmListDetainedLicenses.ShowDialog();
        }

        private void MenuItemDetainLicense_Click(object sender, EventArgs e)
        {
            frmDetainLicense frmDetainLicense = new frmDetainLicense(); 
            frmDetainLicense.ShowDialog();
        }

        private void MenuItemReleaseDetainedLicense_Click(object sender, EventArgs e)
        {
            frmReleaseDetainedLicense frmReleaseDetainedLicense = new frmReleaseDetainedLicense();
            frmReleaseDetainedLicense.ShowDialog();
        }

        private void MenuItemManageApplicationTypes_Click(object sender, EventArgs e)
        {
            frmManageApplicationTypes frmManageApplicationTypes = new frmManageApplicationTypes();
            frmManageApplicationTypes.ShowDialog();
        }

        private void MenuItemManageTestTypes_Click(object sender, EventArgs e)
        {
            frmManageTestTypes frmManageTestTypes = new frmManageTestTypes();
            frmManageTestTypes.ShowDialog();
        }

        private void MenuItemUsers_Click(object sender, EventArgs e)
        {
            frmListUser frmListUser = new frmListUser();
            frmListUser.ShowDialog();
        }
    }
}
