﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SICP.SubForms
{
    public partial class FrmCadCimento : Form
    {
        public FrmCadCimento()
        {
            InitializeComponent();
        }

        private void btn_FecharJanela_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
