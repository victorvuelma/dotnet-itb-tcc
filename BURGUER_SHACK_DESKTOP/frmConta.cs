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

        private int _codFuncionario;
        private clnAtendimento _objAtendimento;

        private clnConta _objConta;

        public clnConta ObjConta { get => _objConta; set => _objConta = value; }
        public clnAtendimento ObjAtendimento { get => _objAtendimento; set => _objAtendimento = value; }
        public int CodFuncionario { get => _codFuncionario; set => _codFuncionario = value; }

        public frmConta()
        {
            InitializeComponent();
        }

        private double obterValorTotal()
        {
            if (ObjConta == null)
            {
                return clnUtilConta.calcularValor(clnUtilPedido.calcularValor(ObjAtendimento), chkServico.Checked, obterDesconto());
            }
            else
            {
                return ObjConta.Valor;
            }
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
            double valorTotal = obterValorTotal();
            lblValorTotal.Text = "Valor Total: " + clnUtil.formatarValor(valorTotal);

            webConta.Navigate(clnArquivo.CACHE.guardar("conta", clnUtilConta.gerarConta(ObjAtendimento, obterPessoas(), chkServico.Checked, obterDesconto())));
        }

        private void atualizarPago()
        {
            if (ObjConta != null)
            {
                double valor = 0.0;

                clnPagamento objPagamentos = new clnPagamento
                {
                    CodConta = ObjConta.CodAtendimento
                };

                foreach(clnPagamento objPagamento in objPagamentos.obterPorConta())
                {
                    valor += objPagamento.Valor;
                }

                lblValorPago.Text = "Valor Pago: " + clnUtil.formatarValor(valor);
            }
        }

        private void salvarConta()
        {
            double valor = clnUtilPedido.calcularValor(ObjAtendimento);

            ObjConta = new clnConta
            {
                CodAtendimento = ObjAtendimento.Cod,
                Desconto = obterDesconto(),
                TaxaServico = chkServico.Checked,
                CodFuncionario = CodFuncionario,
                Valor = valor
            };
            ObjConta.gravar();

            btnFinalizar.Hide();
            grbAlterar.Hide();
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

            if (ObjConta != null)
            {
                grbAlterar.Hide();
                btnFinalizar.Hide();

                txtDesconto.Text = clnUtilConvert.ToString(ObjConta.Desconto);
                chkServico.Checked = ObjConta.TaxaServico;

                atualizarPago();
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

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            salvarConta();
        }

        private void btnPagamento_Click(object sender, EventArgs e)
        {
            frmPagamento frmNovoPagamento = new frmPagamento
            {

            };
            frmNovoPagamento.ShowDialog();

            atualizarPago();
        }
    }
}
