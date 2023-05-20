using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SICP.SubForms;
using System.Windows.Forms;

namespace SICP.Controller
{
    class ControlFormPrincipal
    {
        private FrmPrincipal _form;

        public ControlFormPrincipal(FrmPrincipal form)
        {
            _form = form;
        }

        public void AddPainelFilho(Form painel)
        {
            if (_form.Pn_Pai.Controls.Count > 0)
            {
                _form.Pn_Pai.Controls.Clear();
            }

            painel.TopLevel = false;
            _form.Pn_Pai.Controls.Add(painel);
            painel.Dock = DockStyle.Fill;
            painel.Show();
        }
    }
}
