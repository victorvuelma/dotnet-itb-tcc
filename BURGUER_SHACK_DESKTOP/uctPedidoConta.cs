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
    public partial class uctPedidoConta : UserControl
    {
        public uctPedidoConta()
        {
            InitializeComponent();
        }

        private void rboCartao_CheckedChanged(object sender, EventArgs e)
        {
            grpConta.Enabled = false;
        }

        private void rboDinheiro_CheckedChanged(object sender, EventArgs e)
        {
            grpConta.Enabled = true;
        }

        private void txtValorDinheiro_Leave(object sender, EventArgs e)
        {
            string valorTroco1 = txtValor.Text;
            string valorTroco2 = txtValorDinheiro.Text;
            try
            {
            double Troco1 = Convert.ToDouble(valorTroco1);
            double Troco2 = Convert.ToDouble(valorTroco2);
            double Troco = Troco2 - Troco1;
            lblTroco.Text = "R$ " + Troco;
            }
            catch
            {
                MessageBox.Show("Você deve inserir valores corretos.", "Erro");
            }
        }

        private void txtDesconto_Leave(object sender, EventArgs e)
        {
            try
            {
                double valorCompra = Convert.ToDouble(txtValor.Text);
                double descontoCompra = Convert.ToDouble(txtDesconto.Text);
                valorCompra = (valorCompra * descontoCompra) / 100;
                lblTotal.Text = "R$ " + valorCompra;
            }
            catch
            {

            }
        }
    }
}
