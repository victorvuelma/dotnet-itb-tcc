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
            CarregarListaDeImpressoras();
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
                descontoCompra = descontoCompra / 100;
                valorCompra = valorCompra - (descontoCompra* valorCompra);
                lblTotal.Text = "R$ " + valorCompra;
            }
            catch
            {

            }
        }

        private class Item
        {
            public string Name;
            public int Value;
            public Item(string name, int value)
            {
                Name = name; Value = value;
            }
            public override string ToString()
            {
                return Name;
            }
        }

        private async void uctPedidoConta_Load(object sender, EventArgs e)
        {
            await Task.Delay(1);
            lblTotal.BackColor = UIX.uixColor.INDIGO_DARK;
            lblTroco.BackColor = UIX.uixColor.INDIGO_DARK;
            label3.BackColor = UIX.uixColor.INDIGO_DARK;
            label4.BackColor = UIX.uixColor.INDIGO_DARK;
            txtProdutos.BackColor = Color.PaleGoldenrod;
            txtProdutos.ForeColor = Color.Black;
            txtProdutos.Font = new Font("Courier New", 8);

            cboTributos.Items.Add(new Item("0.0", 1));
            cboTributos.Items.Add(new Item("0.25", 2));
            cboTributos.Items.Add(new Item("0.50", 3));
            cboTributos.Items.Add(new Item("1.0", 4));
        }

        //------------------ IMPRESSÃO ------------------//

        private void CarregarListaDeImpressoras()
        {
            impressoraComboBox.Items.Clear();

            foreach (var printer in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
            {
                impressoraComboBox.Items.Add(printer);
                impressoraComboBox.Text = "Microsoft Print to PDF";
            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            using (var printDocument = new System.Drawing.Printing.PrintDocument())
            {
                printDocument.PrintPage += printDocument_PrintPage;
                printDocument.PrinterSettings.PrinterName = impressoraComboBox.SelectedItem.ToString();
                printDocument.Print();
            }
        }

        void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            var printDocument = sender as System.Drawing.Printing.PrintDocument;

            if (printDocument != null)
            {
                using (var font = new Font("Courier New", 8))
                using (var brush = new SolidBrush(Color.Black))
                {
                    e.Graphics.DrawString(
                        txtProdutos.Text,
                        font,
                        brush,
                        new RectangleF(0, 0, printDocument.DefaultPageSettings.PrintableArea.Width, printDocument.DefaultPageSettings.PrintableArea.Height));
                }
            }
        }

    }
}
