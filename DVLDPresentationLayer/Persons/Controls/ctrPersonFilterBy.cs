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
    public partial class ctrPersonFilterBy : UserControl
    {

        public Button ButtonSearch;
        public string FilterByValue
        {
            get { return combFilterBy.Text; }
            set { combFilterBy.Text = value; }
        }
        public ctrPersonFilterBy()
        {
            ButtonSearch = btnSearch;
            InitializeComponent();
        }

    }
}
