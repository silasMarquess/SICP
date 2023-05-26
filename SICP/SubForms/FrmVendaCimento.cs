using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SICP.Entidades;
using SICP.Entidades.enums;
using SICP.Controller;

namespace SICP.SubForms
{
    public partial class FrmVendaCimento : Form
    {
        private Venda _venda = new Venda();

        private ControlVendaCimento _control;
        public FrmVendaCimento()
        {
            InitializeComponent();
            _control = new ControlVendaCimento(this);
        }

        public FrmVendaCimento(Item i)
        {
            InitializeComponent();
            _venda.AddNewItem(i);
            _control = new ControlVendaCimento(this);
            txt_ValorCimentoUnidade.Text = i.Produto.CalculaValorVenda().ToString("F2") + " R$";
            lb_MarcaCimento.Text = i.Produto.Descricao.ToUpper();
            NumUp_Qtde.Maximum = i.Produto.QtdeEstoque;
            Lb_CodigoVenda.Text = _control.GenerateCodigo();

            ProcessaVenda();
        }

        private void NumUp_Qtde_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (NumUp_Qtde.Value == _venda.GetItem(0).Produto.QtdeEstoque) throw new DomainsException("A Venda Atingiu o estoque de cimento dessa marca. Atualize seu estoque");
                ProcessaVenda();
            }
            catch (DomainsException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void ProcessaVenda()
        {
            _venda.GetItem(0).Qtde = int.Parse(NumUp_Qtde.Value.ToString());

            _venda.Codigo = Lb_CodigoVenda.Text;
            _venda.Total = _venda.CalculaTotalBruto();
            _venda.Adicional = NumUp_ValorAdicional.Value;
            _venda.Desconto = NumUp_ValorDesconto.Value;
           

            txt_TotalBruto.Text = _venda.Total.ToString("F2") + " R$";
            txt_TotalLiquido.Text = _venda.CalculaTotalLiquido().ToString("F2") + " R$";
            txt_LucroLiquido.Text = _venda.CalculaTotalLucro().ToString("F2") + " R$";

        }

        private void NumUp_ValorAdicional_ValueChanged(object sender, EventArgs e)
        {
            ProcessaVenda();
        }

        private void NumUp_ValorDesconto_ValueChanged(object sender, EventArgs e)
        {
            ProcessaVenda();
        }

        private void btn_FecharVenda_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_NomeCliente.Text == "") throw new DomainsException("O nome do cliente é obrigatório !");
                _venda.Cliente = txt_NomeCliente.Text;
                _venda.Data = DateTime.Now;
                _control.ControlCadVenda(_venda);
                Lb_CodigoVenda.Text = _control.GenerateCodigo();

            }catch(DomainsException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
