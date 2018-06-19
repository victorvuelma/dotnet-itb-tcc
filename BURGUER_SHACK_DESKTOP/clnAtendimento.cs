using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQL_POWERUP;
using System.Data.SqlClient;

namespace BURGUER_SHACK_DESKTOP
{
    public class clnAtendimento
    {

        public enum atendimentoSituacao
        {
            ANDAMENTO,
            FINALIZADO
        }

        private int _cod = -1;
        private int? _codCliente;
        private int _codFuncionario = -1;
        private int? _codReserva;
        private List<int> _codMesas = new List<int>();

        private DateTime _inicio;
        private DateTime? _fim;
        private atendimentoSituacao _situacao;

        public int Cod { get => _cod; set => _cod = value; }
        public int? CodCliente { get => _codCliente; set => _codCliente = value; }
        public int CodFuncionario { get => _codFuncionario; set => _codFuncionario = value; }
        public int? CodReserva { get => _codReserva; set => _codReserva = value; }
        public List<int> CodMesas { get => _codMesas; set => _codMesas = value; }
        public DateTime Inicio { get => _inicio; set => _inicio = value; }
        public DateTime? Fim { get => _fim; set => _fim = value; }
        public atendimentoSituacao Situacao { get => _situacao; set => _situacao = value; }

        private clnAtendimento obter(SqlDataReader reader)
        {
            clnAtendimento objAtendimento = new clnAtendimento
            {
                Cod = clnUtilConvert.ToInt(reader["id"]),
                CodCliente = clnUtilConvert.ToNullableInt(reader["id_cliente"]),
                CodFuncionario = clnUtilConvert.ToInt(reader["id_funcionario"]),
                CodReserva = clnUtilConvert.ToNullableInt(reader["id_reserva"]),
                Inicio = clnUtilConvert.ToDateTime(reader["inicio"]),
                Fim = clnUtilConvert.ToNullableDateTime(reader["fim"]),
                Situacao = situacao(clnUtilConvert.ToChar(reader["situacao"]))
            };
            objAtendimento.obterMesas();

            return objAtendimento;
        }

        private void obterMesas()
        {
            sqlCommandSelect objSelect = new sqlCommandSelect();
            objSelect.table("atendimento_mesa").Columns.select("id_mesa");
            objSelect.Where.where("id_atendimento", Cod);

            SqlDataReader reader = objSelect.execute(App.AppDatabase);
            while (reader.Read())
                CodMesas.Add(clnUtilConvert.ToInt(reader["id_mesa"]));
            reader.Close();
        }

        public clnAtendimento obterPorCodigo()
        {
            sqlCommandSelect objSelect = new sqlCommandSelect();
            objSelect.table("atendimento");
            objSelect.Where.where("id", Cod);

            clnAtendimento objAtendimento = null;
            SqlDataReader reader = objSelect.execute(App.AppDatabase);
            if (reader.Read())
                objAtendimento = obter(reader);
            reader.Close();

            return objAtendimento;
        }

        public void gravar()
        {
            sqlCommandInsert objInsert = new sqlCommandInsert();
            objInsert.Insert.val("id_cliente", CodCliente).val("id_funcionario", CodFuncionario).val("id_reserva", CodReserva)
                            .val("inicio", Inicio).val("fim", Fim).val("situacao", prefixo(Situacao));
            objInsert.table("atendimento");

            Cod = objInsert.executeWithOutput(App.AppDatabase);
            this.obterMesas();
        }

        public void adicionarMesa(int codMesa)
        {
            if (!CodMesas.Contains(codMesa))
            {
                CodMesas.Add(codMesa);
                sqlCommandInsert objInsert = new sqlCommandInsert();
                objInsert.table("atendimento_mesa");
                objInsert.Insert.val("id_atendimento", Cod)
                                .val("id_mesa", codMesa);
                objInsert.execute(App.AppDatabase);

                clnMesa objMesa = new clnMesa
                {
                    Cod = codMesa
                }.obterPorCodigo();
                objMesa.Situacao = clnMesa.mesaSituacao.OCUPADA;
                objMesa.alterar();
            }
        }

        public void removerMesa(int codMesa)
        {
            if (CodMesas.Contains(codMesa))
            {
                CodMesas.Remove(codMesa);
                sqlCommandDelete objDelete = new sqlCommandDelete();
                objDelete.table("atendimento_mesa");
                objDelete.Where.where("id_atendimento", Cod)
                                .where("id_mesa", codMesa);
                objDelete.execute(App.AppDatabase);

                clnMesa objMesa = new clnMesa
                {
                    Cod = codMesa
                }.obterPorCodigo();
                objMesa.Situacao = clnMesa.mesaSituacao.DISPONIVEL;
                objMesa.alterar();
            }
        }

        public atendimentoSituacao situacao(char prefixo)
        {
            switch (prefixo)
            {
                case 'A':
                    return atendimentoSituacao.ANDAMENTO;
                default:
                    return atendimentoSituacao.FINALIZADO;
            }
        }

        public char prefixo(atendimentoSituacao situacao)
        {
            switch (situacao)
            {
                case atendimentoSituacao.ANDAMENTO:
                    return 'A';
                default:
                    return 'F';
            }
        }

    }
}
