using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BURGUER_SHACK_DESKTOP
{
    public partial class frmConta : Form
    {

        private clnAtendimento _objAtendimento;
        private clnConta _objConta;

        public clnConta ObjConta { get => _objConta; set => _objConta = value; }
        public clnAtendimento ObjAtendimento { get => _objAtendimento; set => _objAtendimento = value; }

        public frmConta()
        {
            InitializeComponent();
        }

        private int obterPessoas()
        {
            if (clnUtil.validarInt(txtPessoas.Text))
            {
                return clnUtilConvert.ToInt(txtPessoas.Text);
            }
            return 1;
        }

        private double obterDesconto()
        {
            if (clnUtil.validarDouble(txtDesconto.Text))
            {
                return clnUtilConvert.ToDouble(txtDesconto.Text);
            }
            return 0.0;
        }

        private void exibirConta()
        {
            double valorTotal = clnUtilConta.calcularValor(clnUtilPedido.calcularValor(ObjAtendimento), chkServico.Checked, obterDesconto());
            lblValorTotal.Text = "Valor Total: " + clnUtil.formatarValor(valorTotal);

            webConta.Navigate(clnArquivo.CACHE.guardar("conta", clnUtilConta.gerarConta(ObjAtendimento, obterPessoas(), chkServico.Checked, obterDesconto())));
        }

        private void fechar()
        {
            Close();
        }

        private void frmConta_Load(object sender, EventArgs e)
        {
            clnUtil.atualizarForm(this);
            UIX.uixButton.btnApply(btnVoltar, App.VisualStyle.ButtonWarningColor);
            txtPessoas.Text = "1";

            exibirConta();
            hdrUIX.Title = App.Name + " - Atendimento " + ObjAtendimento.Cod + " :: Conta";

            if (ObjConta == null)
            {

            }
            else
            {
                grbAlterar.Hide();
                btnFinalizar.Hide();
            }
        }

        private void hdrUIX_Close(object sender, EventArgs e)
        {
            fechar();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            exibirConta();

            webConta.ShowPrintDialog();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            exibirConta();
        }

        private void chkServico_CheckedChanged(object sender, EventArgs e)
        {
            exibirConta();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            fechar();
        }
    }
}
