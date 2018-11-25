using BurgerShack.Common;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using vitorrdgs.UiX.Component;
using vitorrdgs.Util.Data;

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
                clnCliente objCliente = new clnCliente
                {
                    Cod = objReserva.CodCliente
                }.obterPorCod();

                lstReservas.Adicionar(objReserva.Cod, "RESERVA " + objReserva.Cod + "\n"
                    + objCliente.Nome.Split(' ')[0] + " - " + UtilFormatar.formatarHora(objReserva.Agendado),
                    Properties.Resources.reserva, AppDesktop.VisualStyle.BoxColor, () =>
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

            exibirReservas();
        }

        private void uctPrincipalReservas_Load(object sender, EventArgs e)
        {
            exibirReservas();

            btnNova.Focus();
        }

        private void dtpListar_ValueChanged(object sender, EventArgs e)
        {
            exibirReservas();
        }

        private void btnNova_Click(object sender, EventArgs e)
        {
            new frmReserva { }.ShowDialog();
            exibirReservas();
        }
    }
}
