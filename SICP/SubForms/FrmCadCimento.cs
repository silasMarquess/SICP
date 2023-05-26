using System;
using System.Windows.Forms;
using SICP.Controller;
using SICP.Entidades.enums;
using SICP.Entidades;

namespace SICP.SubForms
{
    partial class FrmCadCimento : Form
    {
        private ControlFrmCadCimento _control;
       

        public FrmCadCimento()
        {
            InitializeComponent();
            _control = new ControlFrmCadCimento(this);
            _control.PreperadaControles();
            btn_EditarDados.Visible = false;
            btn_CadastrarMarca.Visible = true;

            LB_Operacao.Text = "_CADASTRANDO";
        }

       
        public FrmCadCimento(MatConstrucao mat)
        {
            InitializeComponent();
            _control = new ControlFrmCadCimento(this);
            _control.PreperadaControles();
            txt_NomeMarcaCimento.Text = mat.Descricao;
            NumUp_EstoqueInicial.Text = mat.QtdeEstoque.ToString();
            NumUp_ValorCusto.Value = mat.Custo;
            if (mat.Custo != 0) NumUp_PerLucro.Value = (mat.ValLucro / mat.Custo) * 100;
            NumUp_ValorVenda.Value = mat.CalculaValorVenda();

            btn_EditarDados.Visible = true;
            btn_CadastrarMarca.Visible = false;
            LB_Operacao.Text = "_EDITANDO";
            lb_codigoMat.Text = mat.Cod;
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
            decimal ValorAcrescimo = (NumUp_PerLucro.Value / 100) * valorCusto;
            NumUp_ValorVenda.Value = valorCusto + ValorAcrescimo;
            Lb_ValLucro.Text = ValorAcrescimo.ToString("F2") + " R$";
        }

        private void NumUp_ValorVenda_ValueChanged(object sender, EventArgs e)
        {
            decimal valorVenda = NumUp_ValorVenda.Value;
            decimal valorCusto = NumUp_ValorCusto.Value;
            decimal diferenca = 0;

            if (valorVenda >= valorCusto)
            {
                diferenca = valorVenda - valorCusto;
            }

            decimal percLucro = (diferenca / valorCusto) * 100;
            NumUp_PerLucro.Value = percLucro;
        }

        private void btn_CadastrarMarca_Click(object sender, EventArgs e)
        {
            try
            {
                _control.ControlRegistraMarcasCimento();
            }
            catch (DomainsException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btn_EditarDados_Click(object sender, EventArgs e)
        {
            try
            {
                _control.ControlUpdateMarcaCimento();

            }
            catch (DomainsException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void NumUp_ValorCusto_ValueChanged(object sender, EventArgs e)
        {
            decimal valorCusto = NumUp_ValorCusto.Value;
            decimal ValorAcrescimo = (NumUp_PerLucro.Value / 100) * valorCusto;
            NumUp_ValorVenda.Value = valorCusto + ValorAcrescimo;
            Lb_ValLucro.Text = ValorAcrescimo.ToString("F2") + " R$";
        }
    }
}
