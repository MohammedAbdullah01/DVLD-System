﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLDPresentationLayer.Controls
{
    public partial class ctrHeaderTitleControl : UserControl
    {

        public string Title
        {
            get { return labHeaderTitle.Text; }
            set { labHeaderTitle.Text = value; }
        }
        public ctrHeaderTitleControl()
        {
            InitializeComponent();
        }
    }
}
