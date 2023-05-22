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

namespace SICP.SubForms
{
    public partial class FrmCadCimento : Form
    {
        private ControlFrmCadCimento _control;

        public FrmCadCimento()
        {
            InitializeComponent();
            _control = new ControlFrmCadCimento(this);
            _control.PreperadaControles();
        }

        private void btn_FecharJanela_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuCards1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void NumUp_PerLucro_ValueChanged(object sender, EventArgs e)
        {
            decimal valorCusto = NumUp_ValorCusto.Value;
            decimal ValorAcrescimo = (NumUp_PerLucro.Value/100) * valorCusto;
            NumUp_ValorVenda.Value = valorCusto + ValorAcrescimo;
        }

        private void NumUp_ValorVenda_ValueChanged(object sender, EventArgs e)
        {
            decimal valorVenda = NumUp_ValorVenda.Value;
            decimal valorCusto = NumUp_ValorCusto.Value;
            decimal diferenca = 0;

            if (valorVenda >= valorCusto) {
              diferenca = valorVenda - valorCusto;
            }

            decimal percLucro = (diferenca / valorCusto) * 100;
            NumUp_PerLucro.Value = percLucro;
        }
    }
}
