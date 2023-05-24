using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SICP.SubForms;
using SICP.Controller;


namespace SICP.SubForms
{
    public partial class FrmCimento : Form
    {
        private ControlRegCimentos _control;
        public FrmCimento()
        {
            InitializeComponent();
            _control = new ControlRegCimentos(this);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            FrmVendaCimento vendaForm = new FrmVendaCimento();
            vendaForm.ShowDialog();
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            FrmCadCimento CimentoCad = new FrmCadCimento();
            CimentoCad.ShowDialog();
        }

        private void bunifuLabel8_Click(object sender, EventArgs e)
        {

        }

        private void bunifuPanel1_Click(object sender, EventArgs e)
        {

        }

        private void FrmCimento_Load(object sender, EventArgs e)
        {
            _control.GetListaCimentoGalpao();
        }

        private void Lv_ListaCimentoGalpao_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dELETARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                _control.ControlDeleteMarca();

            }
            catch (DomainsException ex)
            {
                MessageBox.Show(ex.Message);

            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show("ERRO: Nada Selecionado !");
            }
        }

        private void eDITARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                _control.ControlUpdateCimento();

            }
            catch (DomainsException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show("ERRO: Nada Selecionado !");
            }
        }
    }
}
