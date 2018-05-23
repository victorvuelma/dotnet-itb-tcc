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
    public partial class uctPrincipalReservas : UserControl
    {
        public uctPrincipalReservas()
        {
            InitializeComponent();
        }

        private void mostrarMesas()
        {
            pnlMesas.Controls.Clear();

            List<Control> mesaControles = new List<Control>();
            foreach (clnMesa objMesa in new clnMesa().obterMesas())
            {
                UIX.btnUIX btn = new UIX.btnUIX
                {
                    Description = "MESA " + objMesa.Cod,
                    Name = "btnMesa" + objMesa.Cod,
                    Size = new Size(100, 100)
                };
                if (objMesa.Ocupada)
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
                    abrirMesa(objMesa);
                };

                mesaControles.Add(btn);
            }
            clnUtil.adicionarControles(pnlMesas, mesaControles, 20);
            mesaControles.Clear();

            pnlMesas.BackColor = BackColor;
        }

        public void abrirMesa(clnMesa objMesa)
        {
            clnAtendimento objAtendimento = null;
            if (objMesa.Ocupada)
            {
                int codAtendimento = objMesa.obterCodAtendimento();

                objAtendimento = new clnAtendimento
                {
                    Cod = codAtendimento
                }.obterPorCodigo();
            }
            else
            {
                if (clnUtilMensagem.mostrarSimNao("Atendimento", "Você deseja iniciar um novo atendimento para a Mesa " + objMesa.Cod + "?", clnUtilMensagem.MensagemIcone.INFO))
                {
                    objAtendimento = new clnAtendimento
                    {
                        Inicio = DateTime.Now,
                        Finalizado = false,
                        CodMesas = new List<int>()
                    };
                    objAtendimento.gravar();

                    objAtendimento.adicionarMesa(objMesa.Cod);

                    objMesa.Ocupada = true;
                    objMesa.alterar();
                }
                else
                {
                    return;
                }
            }
            frmAtendimento frmAtendimento = new frmAtendimento
            {
                ObjAtendimento = objAtendimento
            };
            frmAtendimento.ShowDialog();

            mostrarMesas();
        }

        private void uctPedidoMesa_Load(object sender, EventArgs e)
        {
            pnlLivre.BackColor = UIX.uixColor.WHITE;
            pnlOcupada.BackColor = UIX.uixColor.INDIGO_DARK;

            mostrarMesas();
        }

    }
}
