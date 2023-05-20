using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SICP.SubForms;

namespace SICP.SubForms
{
    public partial class FrmCimento : Form
    {
        public FrmCimento()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            FrmVendaCimento vendaForm = new FrmVendaCimento();
            vendaForm.ShowDialog();
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            FrmCadCimento CimentoCad = new FrmCadCimento();
            CimentoCad.ShowDialog();
        }

        private void bunifuLabel8_Click(object sender, EventArgs e)
        {

        }

        private void bunifuPanel1_Click(object sender, EventArgs e)
        {

        }
    }
}
