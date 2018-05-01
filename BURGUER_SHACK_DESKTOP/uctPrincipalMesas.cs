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

            List<Control> mesas = new List<Control>();
            for(int i = 1; i <= 25; i++)
            {
                int mesa = i;

                UIX.btnUIX btn = new UIX.btnUIX();
                btn.Description = "MESA " + mesa;
                btn.Image = global::BURGUER_SHACK_DESKTOP.Properties.Resources.mesa;
                btn.Name = "btnMesa" + mesa;
                btn.Size = new Size(100, 100);

                btn.Click += (object sender, EventArgs e) =>
                {
                    abrirMesa(mesa);
                };

                mesas.Add(btn);
            }

            clnUtil.adicionarControles(pnlMesas, mesas, 20);

            clnUtil.atualizarTabIndex(Controls);
        }
        
        private void uctPedidoMesa_Load(object sender, EventArgs e)
        {
            pnlLivre.BackColor = UIX.uixColor.WHITE;
            pnlMesas.BackColor = grbMesas.BackColor;
        }

        public void abrirMesa(int mesa)
        {
            frmMesa frmMesa = new frmMesa();

            frmMesa.Mesa = mesa;

            frmMesa.ShowDialog();
        }

    }
}
