using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BURGUERSHACK_DESKTOP
{
    public partial class uctAtendimentoPedidos : UserControl
    {

        private int _codFuncionario;
        private int _codAtendimento;

        private List<clnPedido> _objPedidos;

        public int CodFuncionario { get => _codFuncionario; set => _codFuncionario = value; }
        public int CodAtendimento { get => _codAtendimento; set => _codAtendimento = value; }
        public List<clnPedido> ObjPedidos { get => _objPedidos; set => _objPedidos = value; }

        public uctAtendimentoPedidos()
        {
            InitializeComponent();
        }

        private void exibirPedidos()
        {
            pnlPedidos.Controls.Clear();

            List<Control> pedidosControles = new List<Control>();
            foreach (clnPedido objPedido in ObjPedidos)
            {
                UIX.btnUIX btn = new UIX.btnUIX
                {
                    Description = "Pedido " + objPedido.Cod,
                    Name = "btnPedido" + objPedido.Cod,
                    Size = new Size(110, 110),
                    Image = Properties.Resources.pedido
                };
                btn.Click += (object sender, EventArgs e) =>
                {
                    abrirPedido(objPedido);
                };
                App.VisualTemplate.ctlApply(btn);

                pedidosControles.Add(btn);
            }
            clnUtil.adicionarControles(pnlPedidos, pedidosControles, 20);
            pedidosControles.Clear();

            atualizarValor();
        }

        private void abrirNovoPedido()
        {
            frmPedido frmNovoPedido = new frmPedido
            {
                CodAtendimento = CodAtendimento,
                CodFuncionario = CodFuncionario,
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
                lblValor.Text = clnUtil.formatarValor(valor);
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
