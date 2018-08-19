using System;
using System.Collections.Generic;
using System.Windows.Forms;
using vitorrdgs.UiX.Component;
using vitorrdgs.Util.Data;

namespace BurgerShack.Desktop
{
    public partial class uctAtendimentoPedidos : UserControl
    {

        private int _codAtendimento;

        private List<clnPedido> _objPedidos;

        public int CodAtendimento { get => _codAtendimento; set => _codAtendimento = value; }
        public List<clnPedido> ObjPedidos { get => _objPedidos; set => _objPedidos = value; }

        public uctAtendimentoPedidos()
        {
            InitializeComponent();
        }

        private void exibirPedidos()
        {
            lstPedidos.LimparOpcoes();
            foreach (clnPedido objPedido in ObjPedidos)
            {
                lstPedidos.Adicionar(objPedido.Cod, "Pedido " + objPedido.Cod, Properties.Resources.pedido, AppDesktop.VisualStyle.ButtonColor, () =>
                {
                    abrirPedido(objPedido);
                    return UIXItemsList.ListResult.NENHUM;
                });
            }
            lstPedidos.exibirItens();

            atualizarValor();
        }

        private void abrirNovoPedido()
        {
            frmPedido frmNovoPedido = new frmPedido
            {
                CodAtendimento = CodAtendimento,
                ObjPedido = new clnPedido(),
                ObjItens = new Dictionary<clnItem, List<clnItemIngrediente>>()
            };
            frmNovoPedido.ShowDialog();
            if (frmNovoPedido.ObjPedido.Cod != -1)
            {
                ObjPedidos.Add(frmNovoPedido.ObjPedido);
            }

            exibirPedidos();
        }

        private void abrirPedido(clnPedido objPedido)
        {
            frmPedido frmAbrirPedido = new frmPedido
            {
                CodAtendimento = CodAtendimento,
                ObjPedido = objPedido
            };
            frmAbrirPedido.ShowDialog();

            if (frmAbrirPedido.ObjPedido != objPedido && objPedido.Cod != -1)
            {
                objPedido.alterar();
            }
        }

        private void atualizarSituacao()
        {
            clnConta objConta = new clnConta
            {
                CodAtendimento = CodAtendimento
            }.obterPorCodAtendimento();

            if (objConta != null)
            {
                btnNovoPedido.Hide();

                decimal valorPago = clnUtilConta.calcularValorPago(objConta.CodAtendimento);

                if (valorPago < objConta.Valor)
                {
                    lblSituacao.Text = "Aguardando pagamento para finalizar atendimento.";
                    grbSituacao.Show();
                }
                else
                {
                    grbSituacao.Hide();
                }
            }
            else
            {
                grbSituacao.Hide();
            }
        }

        private void atualizarValor()
        {
            decimal valor = 0;

            foreach (clnPedido objPedido in ObjPedidos)
            {
                valor += clnUtilPedido.calcularValor(objPedido);
            }

            if (valor > 0)
            {
                lblValor.Text = UtilFormatar.formatarValor(valor);
                grbValor.Show();
            }
            else
            {
                grbValor.Hide();
            }
        }

        private void uctAtendimentoPedidos_Load(object sender, EventArgs e)
        {
            exibirPedidos();

            atualizarSituacao();
        }

        private void btnNovoPedido_Click(object sender, EventArgs e)
        {
            abrirNovoPedido();
        }
    }
}
