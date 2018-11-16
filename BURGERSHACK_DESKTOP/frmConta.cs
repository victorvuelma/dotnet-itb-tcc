using BurgerShack.Common;
using BurgerShack.Desktop.Util;
using System;
using System.Windows.Forms;
using vitorrdgs.UiX.Manager;
using vitorrdgs.Util.Data;

namespace BurgerShack.Desktop
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

        private decimal obterValorTotal()
        {
            if (ObjConta == null)
            {
                return clnUtilConta.calcularValor(clnUtilPedido.calcularValor(ObjAtendimento), chkServico.Checked, obterDesconto());
            }
            else
            {
                return clnUtilConta.calcularValor(ObjConta);
            }
        }

        private int obterPessoas()
        {
            if (UtilValidar.validarInt(txtPessoas.Text))
            {
                return UtilConvert.ToInt(txtPessoas.Text);
            }
            return 1;
        }

        private decimal obterDesconto()
        {
            if (UtilValidar.validarDecimal(txtDesconto.Text))
            {
                return UtilConvert.ToDecimal(txtDesconto.Text);
            }
            return 0;
        }

        private void exibirConta()
        {
            decimal valorTotal = obterValorTotal();
            lblValorTotal.Text = "Valor Total: " + UtilFormatar.formatarValor(valorTotal);

            webConta.Navigate(clnArquivo.CACHE.guardar("conta", clnUtilConta.gerarConta(ObjAtendimento, obterPessoas(), chkServico.Checked, obterDesconto())));
        }

        private void atualizarPago()
        {
            if (ObjConta != null)
            {
                decimal valorPago = clnUtilConta.calcularValorPago(ObjConta.Cod);

                lblValorPago.Text = "Valor Pago: " + UtilFormatar.formatarValor(valorPago);

                if (valorPago >= obterValorTotal())
                {
                    ObjAtendimento.Fim = DateTime.Now;
                    ObjAtendimento.Situacao = clnAtendimento.atendimentoSituacao.FINALIZADO;
                    ObjAtendimento.alterar();

                    foreach (int codMesa in ObjAtendimento.CodMesas)
                    {
                        clnMesa objMesa = new clnMesa
                        {
                            Cod = codMesa
                        }.obterPorCod();
                        objMesa.Situacao = clnMesa.mesaSituacao.DISPONIVEL;
                        objMesa.alterar();
                    }
                    UtilMensagem.mostrarOk("Conta", "Atendimento finalizado automaticamente.");
                    Close();
                }
            }
        }

        private void finalizarConta()
        {
            if (UtilMensagem.mostrarSimNao("Conta", "Você deseja realmente finalizar a conta?", UtilMensagem.MensagemIcone.INFO))
            {
                ObjConta = new clnConta
                {
                    CodAtendimento = ObjAtendimento.Cod,
                    Desconto = obterDesconto(),
                    TaxaServico = chkServico.Checked,
                    CodFuncionario = AppDesktop.FuncionarioAtual.Cod,
                    Valor = clnUtilPedido.calcularValor(ObjAtendimento)
                };
                ObjConta.gravar();
                
                clnPedido objPedidos = new clnPedido
                {
                    CodAtendimento = ObjAtendimento.Cod
                };

                foreach (clnPedido objPedido in objPedidos.obterPorAtendimento())
                {
                    objPedido.finalizar();
                }

                btnFinalizar.Hide();
                grbAlterar.Hide();
                btnPagamento.Show();
                
                Numboard.ControlNumboard.esconderNumBoard();
            }
        }

        private void fechar()
        {
            Close();
        }

        private void frmConta_Load(object sender, EventArgs e)
        {
            clnUtil.atualizarForm(this);
            uixButton.btnApply(btnVoltar, AppDesktop.VisualStyle.ButtonWarningColor);
            txtPessoas.Text = "1";

            exibirConta();
            hdrUIX.Title = App.Name + " - Atendimento " + ObjAtendimento.Cod + " :: Conta";

            if (ObjConta != null)
            {
                grbAlterar.Hide();
                btnFinalizar.Hide();
                btnPagamento.Show();

                txtDesconto.Text = UtilConvert.ToString(ObjConta.Desconto);
                chkServico.Checked = ObjConta.TaxaServico;

                atualizarPago();
            }
            else
            {
                btnPagamento.Hide();
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
            finalizarConta();
        }

        private void btnPagamento_Click(object sender, EventArgs e)
        {
            frmPagamento frmNovoPagamento = new frmPagamento
            {
                ObjConta = ObjConta
            };
            frmNovoPagamento.ShowDialog();

            atualizarPago();
        }
    }
}
