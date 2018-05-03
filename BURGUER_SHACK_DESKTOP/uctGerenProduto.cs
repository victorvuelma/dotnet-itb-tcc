using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace BURGUER_SHACK_DESKTOP
{
    public partial class uctGerenProduto : UserControl
    {
        public uctGerenProduto()
        {
            InitializeComponent();
        }

        private void txtDataCadastro_Load(object sender, EventArgs e)
        {
            String dia = DateTime.Now.Day.ToString();
            String mes = DateTime.Now.Month.ToString();
            String ano = DateTime.Now.Year.ToString();

            txtDataCadastro.Text = dia + "/" + mes + "/" + ano;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(cboTipo.Text) || String.IsNullOrWhiteSpace(txtNome.Text) ||
                String.IsNullOrWhiteSpace(txtDescricao.Text) || String.IsNullOrWhiteSpace(txtDataCadastro.Text) ||
                String.IsNullOrWhiteSpace(txtPeso.Text) || String.IsNullOrWhiteSpace(txtICMS.Text) ||
                String.IsNullOrWhiteSpace(txtPrecoCusto.Text) || String.IsNullOrWhiteSpace(txtPrecoVenda.Text) ||
                picFotoProduto.Image == Properties.Resources.padrao)
            {
                MessageBox.Show("Campos com * são obrigatorios.", "Ops");
            }
            else
            {

            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "png|*.png";
            if (file.ShowDialog() == DialogResult.OK)
            {
                picFotoProduto.ImageLocation = file.FileName;
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            picFotoProduto.Image = Properties.Resources.padrao;
        }

        private void txtICMS_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
