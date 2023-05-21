using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SICP.Entidades.enums;
using SICP.Entidades;
using SICP.SubForms;
using SICP.Dados;

using System.Threading.Tasks;

namespace SICP.Controller
{
    class ControlFrmCadCimento
    {
        private FrmCadCimento _form;

        public ControlFrmCadCimento(FrmCadCimento WinForms)
        {
            _form = WinForms;
        }

        public void ControlRegistraMarcasCimento()
        {
            //CRIANDO OBJETO:
            MatConstrucao mat = new MatConstrucao();
            mat.Cod = GenerateCodigo();
            mat.Descricao = _form.txt_NomeMarcaCimento.Text;
            mat.Custo = _form.NumUp_ValorCusto.Value;
            mat.ValLucro = mat.CalculaValorLucro(_form.NumUp_PerLucro.Value);
            mat.Tipo = TipoMaterial.CIMENTO;
            mat.QtdeEstoque = int.Parse(_form.Cb_EstoqueInicial.SelectedItem.ToString());

            //INSERIR OBJETO NO BANCO DE DADOS:
            ConexaoDAO.ModifyOperation(MaterialDAO.InsertNewMaterial, mat);

            System.Windows.Forms.MessageBox.Show("Material Inserido com sucesso !");

        }

        


        public string GenerateCodigo()
        {
            Random rd = new Random();
            string codigo = "MC0000";
            bool teste = ConexaoDAO.ValidateOperation(MaterialDAO.VerificaSeCodeExist, codigo);

            while (teste)
            {
                int numeros = rd.Next();
                codigo = "MC" + numeros.ToString().Substring(0, 4);
                teste = ConexaoDAO.ValidateOperation(MaterialDAO.VerificaSeCodeExist, codigo);
            }
            return codigo;
        }
    }
}
