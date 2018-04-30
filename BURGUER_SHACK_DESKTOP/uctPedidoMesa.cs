using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BURGUER_SHACK_DESKTOP
{
    public partial class uctPedidoMesa : UserControl
    {
        public uctPedidoMesa()
        {
            InitializeComponent();

            List<Control> mesas = new List<Control>();
            for(int i = 1; i <= 24; i++)
            {
                int mesa = i;

                UIX.btnUIX btn = new UIX.btnUIX();
                btn.Description = "MESA " + mesa;
                btn.HoverColor = System.Drawing.Color.Transparent;
                btn.Image = global::BURGUER_SHACK_DESKTOP.Properties.Resources.mesalivre1;
                btn.Name = "btnMesa" + mesa;
                btn.Size = new System.Drawing.Size(80, 80);

                btn.Click += (object sender, EventArgs e) =>
                {
                    abrirNovoPedido(mesa);
                };

                mesas.Add(btn);
            }

            clnUtil.adicionarControles(grbMesas, mesas, 20);
        }
        
        private void uctPedidoMesa_Load(object sender, EventArgs e)
        {
            pnlLivre.BackColor = System.Drawing.Color.White;
        }

        public void abrirNovoPedido(int mesa)
        {
            uctPedidoNovo pedidoNovo = new uctPedidoNovo();
            pedidoNovo.MesaAtual = mesa;
            clnUtil.alterarConteudo(pedidoNovo, "Mesa " + mesa + " - Novo Pedido");
        }

    }
}
