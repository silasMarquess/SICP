using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SICP.SubForms;
using SICP.Entidades;
using SICP.Dados;
using System.Windows.Forms;

namespace SICP.Controller
{
    class ControlVendaCimento
    {
        private FrmVendaCimento _form;
       
        public ControlVendaCimento(FrmVendaCimento form)
        {
            _form = form;
        }

        public void ControlCadVenda(Venda venda)
        {
            venda.GetItem(0).Produto.RemoveEstoque(venda.GetItem(0).Qtde);
            Action<Venda> act1 = VendasDAO.InsertNewVenda;
            act1 += VendasDAO.InsertItemsToVenda;

            ConexaoDAO.ModifyOperation(act1, venda);        
            //Atualizando estoque

            Action<MatConstrucao> act2 = MaterialDAO.UpdateEstoqueMat;
            ConexaoDAO.ModifyOperation(act2, venda.GetItem(0).Produto);

            MessageBox.Show("Nova Venda Registrada com sucesso ! Estoque Atualizado !");

        }


        public string GenerateCodigo()
        {
            Random rd = new Random();
            string codigo = "VE0001";

            bool teste = ConexaoDAO.ValidateOperation(VendasDAO.VerificaSeCodVendaExist, codigo);

            while (teste)
            {
                int numeros = rd.Next();
                codigo = "VE" + numeros.ToString().Substring(0, 4);
                teste = ConexaoDAO.ValidateOperation(MaterialDAO.VerificaSeCodeExist, codigo);
            }
            return codigo;
        }

    }
}
