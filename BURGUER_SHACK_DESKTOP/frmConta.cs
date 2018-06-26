﻿using System;
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

                foreach (clnPagamento objPagamento in objPagamentos.obterPorConta())
                {
                    valor += objPagamento.Valor;
                }

                lblValorPago.Text = "Valor Pago: " + clnUtil.formatarValor(valor);

                if (valor >= ObjConta.Valor)
                {
                    ObjAtendimento.Fim = DateTime.Now;
                    ObjAtendimento.Situacao = clnAtendimento.atendimentoSituacao.FINALIZADO;
                    ObjAtendimento.alterar();

                    foreach (int codMesa in ObjAtendimento.CodMesas)
                    {
                        clnMesa objMesa = new clnMesa
                        {
                            Cod = codMesa
                        }.obterPorCodigo();
                        objMesa.Situacao = clnMesa.mesaSituacao.DISPONIVEL;
                        objMesa.alterar();
                    }
                    clnUtilMensagem.mostrarOk("Conta", "Atendimento finalizado automaticamente.", clnUtilMensagem.MensagemIcone.OK);
                    Close();
                }
            }
        }

        private void finalizarConta()
        {
            if (clnUtilMensagem.mostrarSimNao("Conta", "Você deseja realmente finalizar a conta?", clnUtilMensagem.MensagemIcone.INFO))
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

                clnPedido objPedidos = new clnPedido
                {
                    CodAtendimento = ObjAtendimento.Cod
                };

                foreach (clnPedido objPedido in objPedidos.obterPorAtendimento())
                {
                    objPedido.Situacao = clnPedido.pedidoSituacao.PRONTO;
                    objPedido.alterar();
                }

                btnFinalizar.Hide();
                grbAlterar.Hide();
                btnPagamento.Show();
            }
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
                btnPagamento.Show();

                txtDesconto.Text = clnUtilConvert.ToString(ObjConta.Desconto);
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
                ObjConta = ObjConta,
                CodFuncionario = CodFuncionario
            };
            frmNovoPagamento.ShowDialog();

            atualizarPago();
        }
    }
}
