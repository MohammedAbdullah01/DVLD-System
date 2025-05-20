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
    public partial class ctrPersonListFilterBy : UserControl
    {

        public ComboBox ComboBoxFilterBy
        {
            get { return cmbFilterBy; }
        }

        public TextBox TextBoxInputFilterByPerson
        {
            get { return txbInputFilterByPerson; }
        }
        public ctrPersonListFilterBy()
        {
            InitializeComponent();
        }

        private void cmbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextBoxInputFilterByPerson.Enabled = (cmbFilterBy.SelectedIndex != 0) ? true : false;
        }
    }
}
