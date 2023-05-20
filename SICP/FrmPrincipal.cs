using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SICP.Controller;
using SICP.SubForms;

namespace SICP
{
    public partial class FrmPrincipal : Form
    {
        private ControlFormPrincipal _control;
        public FrmPrincipal()
        {
            InitializeComponent();
            _control = new ControlFormPrincipal(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _control.AddPainelFilho(new FrmCimento());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _control.AddPainelFilho(new FrmProdutoSN());
        }
    }
}
