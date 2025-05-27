using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLDPresentationLayer.Applications
{
    public partial class frmScheduleTest : Form
    {
        public frmScheduleTest()
        {
            InitializeComponent();

            string changeTitle = "Written";

            switch (changeTitle)
            {
                case "Written":
                    ctrScheduleTest1.TitleGroupBox = "Schedule Written Test";
                    break;
                case "Driving":
                    ctrScheduleTest1.TitleGroupBox = "Schedule Driving Test";
                    break;
                default:
                    ctrScheduleTest1.TitleGroupBox = "Schedule Test";
                    break;
            }
        }
    }
}
