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
            for(int i = 1; i <= 30; i++)
            {
                int mesa = i;

                UIX.btnUIX btn = new UIX.btnUIX();
                btn.Description = "MESA " + mesa;
                btn.Image = global::BURGUER_SHACK_DESKTOP.Properties.Resources.mesalivre1;
                btn.Name = "btnMesa" + mesa;

                btn.Click += (object sender, EventArgs e) =>
                {
                    abrirMesa(mesa);
                };

                mesas.Add(btn);
            }

            clnUtil.adicionarControles(pnlMesas, mesas, 16);
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
