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
        private List<MatConstrucao> _listaCimentos;

        public ControlRegCimentos(FrmCimento form)
        {
            _form = form;
        }

        public void GetListaCimentoGalpao()
        {
            List<MatConstrucao> listaGeral = ConexaoDAO.getLisObjectOperation(MaterialDAO.GetListaMaterial);
            _listaCimentos = listaGeral.FindAll(VerificaSeCimento);

            //MOSTRANDO LISTA 
            foreach (MatConstrucao i in _listaCimentos)
            {
                ListViewItem item = new ListViewItem(new string[] { i.Cod, i.Descricao, i.Custo.ToString(), i.QtdeEstoque.ToString() });
                _form.Lv_ListaCimentoGalpao.Items.Add(item);
            }
        }

        public void ControlDeleteMarca()
        {
            DialogResult res = MessageBox.Show("Deseja realmente deletar o material selecionado ?", "Confirme:", MessageBoxButtons.YesNo);
            if (res == DialogResult.No) throw new DomainsException("Operação cancelada com sucesso !");
            MatConstrucao CimentoSelecionado = _listaCimentos.Find(GetCimentoForCod);
            ConexaoDAO.ModifyOperation(MaterialDAO.DeleteMat, CimentoSelecionado);
            MessageBox.Show("Material selecionado deletado com sucesso !");
        }

        public void ControlUpdateCimento()
        {
            MatConstrucao CimentoSelecionado = _listaCimentos.Find(GetCimentoForCod);
            FrmCadCimento cad = new FrmCadCimento(CimentoSelecionado);
            cad.ShowDialog();
        }






        //DELEGATE
        public bool VerificaSeCimento(MatConstrucao mat)
        {
            return (mat.Tipo == TipoMaterial.CIMENTO) ? true : false;
        }

        public bool GetCimentoForCod(MatConstrucao mat)
        {
            int index = _form.Lv_ListaCimentoGalpao.SelectedIndices[0];
            string codigo = _form.Lv_ListaCimentoGalpao.SelectedItems[index].SubItems[0].Text;
            return (mat.Cod == codigo) ? true : false;
        }

    }
}
