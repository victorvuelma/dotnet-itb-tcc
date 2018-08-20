using BurgerShack.Common;
using System.Collections.Generic;
using System.Data.SqlClient;
using vitorrdgs.SqlMaster.Command;
using vitorrdgs.Util.Data;

namespace BurgerShack.Desktop
{
    public class clnPedido
    {

        public enum pedidoSituacao
        {
            REALIZADO,
            PREPARO,
            PRONTO
        }

        private int _cod = -1;

        private int _codAtendimento = -1;
        private int _codFuncionario = -1;

        private decimal _valor;
        private pedidoSituacao _situacao;

        public int Cod { get => _cod; set => _cod = value; }
        public int CodAtendimento { get => _codAtendimento; set => _codAtendimento = value; }
        public int CodFuncionario { get => _codFuncionario; set => _codFuncionario = value; }
        public decimal Valor { get => _valor; set => _valor = value; }
        public pedidoSituacao Situacao { get => _situacao; set => _situacao = value; }

        private clnPedido obter(SqlDataReader reader) => new clnPedido
        {
            Cod = UtilConvert.ToInt(reader["id"]),
            CodAtendimento = UtilConvert.ToInt(reader["id_atendimento"]),
            CodFuncionario = UtilConvert.ToInt(reader["id_funcionario"]),
            Situacao = situacao(UtilConvert.ToChar(reader["situacao"])),
            Valor = UtilConvert.ToDecimal(reader["valor"])
        };

        public List<clnPedido> obterPorAtendimento()
        {
            sqlSelect objSelect = new sqlSelect();
            objSelect.table("pedido");
            objSelect.Where.where("id_atendimento", CodAtendimento);

            SqlDataReader reader = objSelect.execute(App.DatabaseSql);
            List<clnPedido> objPedidos = new List<clnPedido>();
            while (reader.Read())
                objPedidos.Add(obter(reader));
            reader.Close();

            return objPedidos;
        }

        public void alterar()
        {
            sqlUpdate objUpdate = new sqlUpdate();
            objUpdate.table("pedido");
            objUpdate.Value.val("valor", Valor)
                         .val("situacao", prefixo(Situacao));
            objUpdate.Where.where("id", Cod);

            objUpdate.execute(App.DatabaseSql);
        }

        public void gravar()
        {
            sqlInsert objInsert = new sqlInsert();
            objInsert.table("pedido");
            objInsert.Value.val("id_atendimento", CodAtendimento)
                            .val("id_funcionario", CodFuncionario)
                            .val("valor", Valor)
                            .val("situacao", prefixo(Situacao));

            Cod = objInsert.executeWithOutput(App.DatabaseSql);
        }

        private char prefixo(pedidoSituacao situacao)
        {
            switch (situacao)
            {
                case pedidoSituacao.PREPARO:
                    return 'E';
                case pedidoSituacao.PRONTO:
                    return 'P';
                default:
                    return 'R';
            }
        }

        private pedidoSituacao situacao(char prefixo)
        {
            switch (prefixo)
            {
                case 'E':
                    return pedidoSituacao.PREPARO;
                case 'P':
                    return pedidoSituacao.PRONTO;
                default:
                    return pedidoSituacao.REALIZADO;
            }
        }

    }
}
