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
            _listaCimentos.FindAll(VerificaSeCimento);

        }
        


        //DELEGATE
        public bool VerificaSeCimento(MatConstrucao mat)
        {
            return (mat.Tipo == TipoMaterial.CIMENTO) ? true : false;
        }

    }
}
