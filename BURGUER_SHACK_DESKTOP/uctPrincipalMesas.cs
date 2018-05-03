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
    public partial class uctPrincipalMesas : UserControl
    {
        public uctPrincipalMesas()
        {
            InitializeComponent();

            mostrarMesas();
        }

        private void mostrarMesas()
        {
            pnlMesas.Visible = false;
            pnlMesas.Controls.Clear();

            List<Control> mesaControles = new List<Control>();
            foreach (clnMesa mesa in new clnMesa().obterMesas())
            {
                UIX.btnUIX btn = new UIX.btnUIX();
                btn.Description = "MESA " + mesa.Cod;
                btn.Name = "btnMesa" + mesa.Cod;
                btn.Size = new Size(100, 100);
                if (mesa.Uso)
                {
                    btn.ForeColor = pnlOcupada.BackColor;
                    btn.Image = global::BURGUER_SHACK_DESKTOP.Properties.Resources.mesauso;
                }
                else
                {
                    btn.Image = global::BURGUER_SHACK_DESKTOP.Properties.Resources.mesa;
                }
                btn.Click += (object sender, EventArgs e) =>
                {
                    abrirMesa(mesa);
                };

                mesaControles.Add(btn);
            }
            clnUtil.adicionarControles(pnlMesas, mesaControles, 20);

            clnApp.AppVisualTemplate.pnlApply(pnlMesas);

            pnlMesas.Visible = true;
        }

        public void abrirMesa(clnMesa mesa)
        {
            frmMesa frmMesa = new frmMesa();
            frmMesa.Mesa = mesa.Cod;

            frmMesa.ShowDialog();

            mostrarMesas();
        }

        private void uctPedidoMesa_Load(object sender, EventArgs e)
        {
            pnlLivre.BackColor = UIX.uixColor.WHITE;
            pnlOcupada.BackColor = UIX.uixColor.INDIGO_DARK;

            pnlMesas.BackColor = BackColor;
        }

    }
}
