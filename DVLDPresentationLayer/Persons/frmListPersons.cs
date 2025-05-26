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
    public partial class frmListPersons : Form
    {
        public frmListPersons()
        {
            InitializeComponent();
            ctrPersonFilterBy1.ButtonSearch.Visible = false;
        }

        private void frmListPersons_Load(object sender, EventArgs e)
        {
            string[] row1 = new string[] { "100000", "nn1010101010", "Mohamed" , "Ahmed" , "Abd alghany" , "mohamed al ghdfar" , "male" , "10/10/2025" , "Egypt" , "012154789510" , "mohamed50@gmail.com" };
            dGVListPersons.Rows.Add(row1);

        }

        private void btnAddNewPerson_Click(object sender, EventArgs e)
        {
            frmAddOrEditPerson frmAddOrEditPerson = new frmAddOrEditPerson();
            frmAddOrEditPerson.ShowDialog();
        }
    }
}
