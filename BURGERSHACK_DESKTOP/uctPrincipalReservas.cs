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

namespace BurgerShack.Desktop
{
    public partial class uctPrincipalReservas : UserControl
    {

        public uctPrincipalReservas()
        {
            InitializeComponent();
        }

        private void exibirReservas()
        {
            List<clnReserva> objReservas = new clnReserva
            {
                Agendado = dtpListar.Value.Date
            }.obterPorDataAgendada();

            lstReservas.LimparOpcoes();
            foreach (clnReserva objReserva in objReservas)
            {
                lstReservas.Adicionar(objReserva.Cod, "RESERVA " + objReserva.Cod, Properties.Resources.reserva, AppDesktop.VisualStyle.BoxColor, () =>
                {
                    abrirReserva(objReserva);
                    return UIXItemsList.ListResult.NENHUM;
                });
            }
            lstReservas.exibirItens();
        }

        private void abrirReserva(clnReserva objReserva)
        {
            frmReserva frmReserva = new frmReserva
            {
                ObjReserva = objReserva
            };
            frmReserva.ShowDialog();
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
            new frmReserva{}.ShowDialog();
        }
    }
}
