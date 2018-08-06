using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using vitorrdgs.UiX.Component;

namespace BURGERSHACK_DESKTOP
{
    public partial class uctPrincipalReservas : UserControl
    {

        private int _codFuncionario;

        public int CodFuncionario { get => _codFuncionario; set => _codFuncionario = value; }

        public uctPrincipalReservas()
        {
            InitializeComponent();
        }

        private void exibirReservas()
        {
            pnlReservas.Controls.Clear();

            clnReserva objReservas = new clnReserva
            {
                Agendado = dtpListar.Value.Date
            };

            List<Control> reservasControles = new List<Control>();
            foreach (clnReserva objReserva in objReservas.obterPorDataAgendada())
            {
                btnLabelUIX btn = new btnLabelUIX
                {
                    Description = ("RESERVA #" + objReserva.Cod + " - " + objReserva.Agendado.ToString("HH:mm") +
                                    "\n" + objReserva.Situacao +
                                    "\n" + objReserva.Pessoas + " pessoas"),
                    Name = "btnReserva" + objReserva.Cod,
                    Size = new Size(120, 160),
                    Image = Properties.Resources.reserva
                };
                btn.Click += (object sender, EventArgs e) =>
                {
                    abrirReserva(objReserva);
                };

                reservasControles.Add(btn);
            }
            clnUtil.adicionarControles(pnlReservas, reservasControles, 20);
            reservasControles.Clear();
        }

        private void abrirReserva(clnReserva objReserva)
        {
            frmReserva frmReserva = new frmReserva
            {
                ObjReserva = objReserva,
                CodFuncionario = CodFuncionario
            };
            frmReserva.ShowDialog();

            exibirReservas();
        }

        private void uctPrincipalReservas_Load(object sender, EventArgs e)
        {
            exibirReservas();
        }

        private void dtpListar_ValueChanged(object sender, EventArgs e)
        {
            exibirReservas();
        }

        private void btnNova_Click(object sender, EventArgs e)
        {
            new frmReserva
            {
                CodFuncionario = CodFuncionario
            }.ShowDialog();
        }
    }
}
