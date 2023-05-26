using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SICP.Dados;
using System.Windows.Forms;
using SICP.Entidades;
using SICP.Entidades.enums;
using SICP.SubForms;

namespace SICP.Controller
{
    class ControlRegCimentos
    {
        private FrmCimento _form;
        private List<MatConstrucao> _ListaMatGeral;
        private List<Venda> _listaVenda;

        public ControlRegCimentos(FrmCimento form)
        {
            _form = form;
        }

        public void GetListaCimentoGalpao()
        {
            List<MatConstrucao> listaGeral = ConexaoDAO.getLisObjectOperation(MaterialDAO.GetListaMaterial);
            _ListaMatGeral = listaGeral.FindAll(VerificaSeCimento);

            //MOSTRANDO LISTA 
            foreach (MatConstrucao i in _ListaMatGeral)
            {
                ListViewItem item = new ListViewItem(new string[] { i.Cod, i.Descricao.ToUpper(), i.CalculaValorVenda().ToString() + " R$", i.QtdeEstoque.ToString(), i.ValLucro.ToString() + " R$", i.CalculaLucroTotal().ToString() + " R$", i.Custo.ToString() + " R$" }); ;
                _form.Lv_ListaCimentoGalpao.Items.Add(item);
            }
        }

        public void ControlNewVenda()
        {
            MatConstrucao cimentoSelecionado = _ListaMatGeral.Find(GetCimentoForCod);
            Item i = new Item(0, 0, cimentoSelecionado);
            FrmVendaCimento form = new FrmVendaCimento(i);
            form.ShowDialog();
        }

        public void ControlBuscaVendaMes()
        {
            _listaVenda = ConexaoDAO.getLisObjectOperation(VendasDAO.GetListaVendas);
            _listaVenda.ForEach(GetListaItensForVenda);
            _listaVenda = _listaVenda.FindAll(VerificaSeVendaCimento);
            _listaVenda = _listaVenda.FindAll(GetListaVendaMes);

            MostraListaMarcasCimento();
            _form.Lv_VendaCimento.Items.Clear();
            foreach (Venda obj in _listaVenda)
            {
                ListViewItem item = new ListViewItem(new string[] {obj.Codigo,obj.Cliente,obj.ListaItens[0].Produto.Descricao,obj.ListaItens[0].Qtde.ToString(),obj.Adicional.ToString("F2"),obj.Desconto.ToString("F2"),
                obj.Total.ToString("F2"),obj.Data.ToShortDateString()});
                _form.Lv_VendaCimento.Items.Add(item);
            }
        }

        public void FiltraListaCimento()
        {

            int qtde = 0;
            decimal Total = 0;
            decimal TotalLucro = 0;
            decimal TotalLiquido = 0;

            List<Venda> listaFiltrada = null;

            if (_form.Cb_MarcaCimento.SelectedItem.ToString()=="TODAS")
            {
                listaFiltrada = _listaVenda;
            }
            else
            {
                listaFiltrada = _listaVenda.FindAll(GetListaCimentoForMarca);
            }

            foreach (Venda v in listaFiltrada)
            {
                qtde += v.ListaItens[0].Qtde;
                Total += v.CalculaTotalBruto();
                TotalLiquido += v.CalculaTotalLiquido();
                TotalLucro += v.CalculaTotalLucro();
            }
            _form.txt_QtdeVendidos.Text = qtde.ToString()+" Unidades";
            _form.txt_TotalLiquido.Text = TotalLiquido.ToString("F2");
            _form.txt_LucroApurado.Text = TotalLucro.ToString("F2");
            _form.txt_TotalVendido.Text = Total.ToString("F2");

        }



        public void MostraListaMarcasCimento()
        {
            HashSet<string> lista = new HashSet<string>();
            foreach (Venda v in _listaVenda)
            {
                lista.Add(v.ListaItens[0].Produto.Descricao);
            }

            _form.Cb_MarcaCimento.Items.Clear();

            foreach (string nomeMarca in lista)
            {
                _form.Cb_MarcaCimento.Items.Add(nomeMarca);
            }
            _form.Cb_MarcaCimento.Items.Add("TODAS");
        }



        public void ControlDeleteMarca()
        {
            DialogResult res = MessageBox.Show("Deseja realmente deletar o material selecionado ?", "Confirme:", MessageBoxButtons.YesNo);
            if (res == DialogResult.No) throw new DomainsException("Operação cancelada com sucesso !");
            MatConstrucao CimentoSelecionado = _ListaMatGeral.Find(GetCimentoForCod);
            if (CimentoSelecionado == null) throw new DomainsException("");
            ConexaoDAO.ModifyOperation(MaterialDAO.DeleteMat, CimentoSelecionado);
            MessageBox.Show("Material selecionado deletado com sucesso !");
        }

        public void ControlUpdateCimento()
        {
            MatConstrucao CimentoSelecionado = _ListaMatGeral.Find(GetCimentoForCod);
            FrmCadCimento cad = new FrmCadCimento(CimentoSelecionado);
            cad.ShowDialog();
        }




        //DELEGATE
        public bool VerificaSeCimento(MatConstrucao mat)
        {
            return (mat.Tipo == TipoMaterial.CIMENTO) ? true : false;
        }

        public bool VerificaSeVendaCimento(Venda v)
        {
            return (v.ListaItens[0].Produto.Tipo == TipoMaterial.CIMENTO) ? true : false;
        }

        public void GetListaItensForVenda(Venda v)
        {
            ConexaoDAO.ModifyOperation(VendasDAO.getItensForVenda, v);
        }

        public bool GetListaVendaMes(Venda venda)
        {
            int year = int.Parse(_form.Cb_AnoVenda.SelectedItem.ToString());
            int mes = _form.Cb_MesVenda.SelectedIndex;

            return (venda.Data.Year == year && venda.Data.Month == (mes + 1)) ? true : false;
        }

        public bool GetListaCimentoForMarca(Venda venda)
        {
            string marcaCimento = _form.Cb_MarcaCimento.SelectedItem.ToString();
            return (venda.ListaItens[0].Produto.Descricao == marcaCimento) ? true : false;
        }

        public bool GetCimentoForCod(MatConstrucao mat)
        {
            int index = _form.Lv_ListaCimentoGalpao.CheckedIndices[0];
            string codigo = _form.Lv_ListaCimentoGalpao.Items[index].SubItems[0].Text;
            return (mat.Cod == codigo) ? true : false;
        }

    }
}
