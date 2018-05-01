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
    public partial class uctMesaConta : UserControl
    {

        private int _mesa;

        public int Mesa { get => _mesa; set => _mesa = value; }

        public uctMesaConta()
        {
            InitializeComponent();
            CarregarListaDeImpressoras();

            this.mtbClienteCPF.Mask = clnUtil.MASK_CPF;
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
            txtNota.BackColor = Color.PaleGoldenrod;
            txtNota.ForeColor = Color.Black;
            txtNota.Font = new Font("Courier New", 8);
        }

        //------------------ IMPRESSÃO ------------------//

        private void CarregarListaDeImpressoras()
        {
            cboImpressora.Items.Clear();

            foreach (var printer in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
            {
                cboImpressora.Items.Add(printer);
                cboImpressora.Text = "Microsoft Print to PDF";
            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            using (var printDocument = new System.Drawing.Printing.PrintDocument())
            {
                printDocument.PrintPage += printDocument_PrintPage;
                printDocument.PrinterSettings.PrinterName = cboImpressora.SelectedItem.ToString();
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
                        txtNota.Text,
                        font,
                        brush,
                        new RectangleF(0, 0, printDocument.DefaultPageSettings.PrintableArea.Width, printDocument.DefaultPageSettings.PrintableArea.Height));
                }
            }
        }

        private void grbPedidoConta_Enter(object sender, EventArgs e)
        {

        }
    }
}
