using BurgerShack.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vitorrdgs.Util.Data;

namespace BurgerShack.Web.Bll
{
    public class ReservaBLL
    {

        public string listarReservas(int codCliente)
        {
            List<clnReserva> objReservas = new clnReserva
            {
                CodCliente = codCliente
            }.obterPorCliente();

            if (objReservas.Count == 0)
            {
                return "<tr><td colspan='4'>Não foi encontrada nenhuma reserva.</td></tr>";
            }
            else
            {
                StringBuilder builder = new StringBuilder();

                foreach (clnReserva objReserva in objReservas)
                {
                    builder.Append("<tr>");
                    builder.Append("<td>").Append(objReserva.Cod).Append("</td>");
                    builder.Append("<td>").Append(UtilFormatar.formatarData(objReserva.Agendado)).Append("</td>");
                    builder.Append("<td>").Append(objReserva.Pessoas).Append("</td>");
                    builder.Append("<td>").Append(objReserva.Situacao).Append("</td>");
                    builder.Append("</tr>");
                }

                return builder.ToString();
            }
        }

    }
}
