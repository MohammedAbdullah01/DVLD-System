using DVLDPresentationLayer.Applications;
using DVLDPresentationLayer.DetainLicenses;
using DVLDPresentationLayer.Driver;
using DVLDPresentationLayer.Persons;
using DVLDPresentationLayer.User;
using DVLDPresentationLayer.User.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLDPresentationLayer
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            //Application.Run(new frmListPersons());
            //Application.Run(new frmAddOrEditPerson());
            //Application.Run(new frmPersonDetails());
            //Application.Run(new frmListUser());
            //Application.Run(new frmLoginScreen());
            //Application.Run(new frmAddNewUser());
            //Application.Run(new frmManageApplicationTypes());
            //Application.Run(new frmUpdateApplicationType());
            //Application.Run(new frmManageTestTypes());
            //Application.Run(new frmUpdateTestType());
            //Application.Run(new frmLocalDrivingLicense()); 
            //Application.Run(new frmScheduleTest()); 
            //Application.Run(new frmTakeTest());
            //Application.Run(new frmListDrivers());
            //Application.Run(new frmLicenseInfo());
            //Application.Run(new frmNewInternationalLicenseApplication());
            //Application.Run(new frmLicenseHistory());
            //Application.Run(new frmListInternationalLicensesApplication());
            //Application.Run(new frmRenewLocalDrivingLicense()); 
            //Application.Run(new frmReplacementDamagedORLostLicense());
            Application.Run(new frmListDetainedLicenses());
            //Application.Run(new frmReleaseDetainedLicense());
            //Application.Run(new frmDetainLicense());

        }
    }
}
