using BurgerShack.Common;
using System;
using System.Collections.Generic;
using System.Text;
using vitorrdgs.Util.Data;

namespace BurgerShack.Web.Bll
{
    public class ReservaBLL
    {

        private ClienteBLL clienteBLL = new ClienteBLL();

        public string listarReservas()
        {
            if (clienteBLL.autenticado())
            {
                List<clnReserva> objReservas = new clnReserva
                {
                    CodCliente = clienteBLL.obterCodCliente()
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
                        builder.Append("<td scope='row'>").Append(objReserva.Cod).Append("</td>");
                        builder.Append("<td>").Append(UtilFormatar.formatarData(objReserva.Agendado)).Append("</td>");
                        builder.Append("<td>").Append(objReserva.Pessoas).Append("</td>");
                        builder.Append("<td>").Append(objReserva.Situacao).Append("</td>");
                        builder.Append("</tr>");
                    }

                    return builder.ToString();
                }
            }
            else
            {
                return "Você não está autenticado.";
            }
        }

        public string validarDados(string cpf, string dataStr, string lugaresStr, string informacoes)
        {
            if (clienteBLL.autenticado())
            {
                StringBuilder errosBuilder = new StringBuilder();

                clnCliente objCliente = clienteBLL.obterCliente();
                if (UtilValidar.vazio(cpf))
                {
                    errosBuilder.AppendLine("É necessário informar um CPF.");
                }
                else if (!UtilValidar.validarCPF(cpf))
                {
                    errosBuilder.AppendLine("O CPF informado é inválido.");
                }
                else if (!UtilFormatar.retirarFormatacao(cpf).Equals(objCliente.Cpf))
                {
                    errosBuilder.AppendLine("O CPF foi informado incorretamente.");
                }

                if (UtilValidar.vazio(dataStr))
                {
                    errosBuilder.AppendLine("É necessário informar uma data.");
                }
                else if (!UtilValidar.validarData(dataStr))
                {
                    errosBuilder.AppendLine("A data informada é inválida.");
                }
                else if (!UtilValidar.validarDataFutura(dataStr))
                {
                    errosBuilder.AppendLine("A data informada é inválida.");
                }

                if (UtilValidar.vazio(lugaresStr))
                {
                    errosBuilder.AppendLine("É necessário informar os lugares.");
                }
                else if (!UtilValidar.validarValor(lugaresStr))
                {
                    errosBuilder.AppendLine("É necessário informar um valor válido para os lugares.");
                }
                else
                {
                    int lugares = UtilConvert.ToInt(lugaresStr);
                    if (lugares < 2)
                    {
                        errosBuilder.AppendLine("É necessário reservar no minimo 2 lugares.");
                    }
                    else if (lugares > 8)
                    {
                        errosBuilder.AppendLine("Não é possível reservar mais que 8 lugares.");
                    }
                }

                if (informacoes.Length > 256)
                {
                    errosBuilder.AppendLine("O limite de informações é de 256 caracteres.");
                }

                if (errosBuilder.Length == 0)
                {
                    int lugares = UtilConvert.ToInt(lugaresStr);
                    DateTime data = UtilConvert.ToDateTime(dataStr);

                    //TODAS AS INFORMAÇÕE ESTÃO OK, VALIDE SE NÃO TEM RESERVA E SE É POSSÍVEL
                    List<clnReserva> objReservas = new clnReserva
                    {
                        CodCliente = clienteBLL.obterCodCliente(),
                        Agendado = data,
                        Ativo = true,
                        Situacao = clnReserva.reservaSituacao.CANCELADA
                    }.obterPorClienteDataSituacao();

                    if (objReservas.Count > 0)
                    {
                        errosBuilder.AppendLine("Você já realizou uma reserva para esta data!");
                    }
                    else
                    {
                        int lugaresDisponiveis = new clnReserva
                        {
                            Agendado = data
                        }.obterLugaresDisponiveis();

                        lugaresDisponiveis = lugaresDisponiveis / 2;

                        if (lugares > lugaresDisponiveis)
                        {
                            errosBuilder.AppendLine("Não existem lugares disponiveis para esta data");
                        }
                    }
                }
                return errosBuilder.ToString();
            }
            else
            {
                return "Você não está autenticado.";
            }
        }

        public void atribuirMesas(int codReserva, int lugares)
        {
            while(lugares > 0)
            {
                // IRÁ ATRIBUIR AS MESAS AUTOMATICAMENTE.
            }
        }

    }
}

