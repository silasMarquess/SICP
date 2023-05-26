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
            PreparaControle();
        }

        public void PreparaControle()
        {
            Cb_AnoVenda.Items.Clear();
            for(int i = DateTime.Now.Year; i >= (DateTime.Now.Year - 10); i--)
            {
                Cb_AnoVenda.Items.Add(i);
            }
            int ano = DateTime.Now.Year;
            Cb_AnoVenda.SelectedItem = ano;
            Cb_MesVenda.SelectedIndex = DateTime.Now.Month -1 ;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            try
            {
                _control.ControlNewVenda();
            }
            catch (DomainsException ex)
            {
                MessageBox.Show(ex.Message);

            }catch(ArgumentOutOfRangeException ex)
            {
                MessageBox.Show("Erro: Nemhuma Marca Selecionada no momento !");
            }
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
            _control.ControlBuscaVendaMes();
           // _control.MostraListaMarcasCimento();
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

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            try
            {
            _control.ControlBuscaVendaMes();

            }catch(DomainsException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Cb_MarcaCimento_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                _control.FiltraListaCimento();

            }catch(DomainsException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
