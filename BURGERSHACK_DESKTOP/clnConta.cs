using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using vitorrdgs.SqlMaster;
using System.Data.SqlClient;

using BurgerShack.Common;
using vitorrdgs.SqlMaster.Command;
using vitorrdgs.Util.Data;

namespace BurgerShack.Desktop
{
    public class clnConta
    {

        private int _cod = -1;
        private bool _ativo = true;

        private int _codAtendimento = -1;
        private int _codFuncionario = -1;

        private decimal _valor;

        private bool _taxaServico;
        private decimal _desconto;

        public int CodAtendimento { get => _codAtendimento; set => _codAtendimento = value; }
        public int CodFuncionario { get => _codFuncionario; set => _codFuncionario = value; }
        public decimal Valor { get => _valor; set => _valor = value; }
        public bool TaxaServico { get => _taxaServico; set => _taxaServico = value; }
        public decimal Desconto { get => _desconto; set => _desconto = value; }
        public int Cod { get => _cod; set => _cod = value; }
        public bool Ativo { get => _ativo; set => _ativo = value; }

        private clnConta obter(SqlDataReader reader) => new clnConta
        {
            Cod = UtilConvert.ToInt(reader["id"]),
            CodAtendimento = UtilConvert.ToInt(reader["id_atendimento"]),
            CodFuncionario = UtilConvert.ToInt(reader["id_funcionario"]),
            Valor = UtilConvert.ToDecimal(reader["valor"]),
            TaxaServico = UtilConvert.ToBool(reader["taxa_servico"]),
            Desconto = UtilConvert.ToDecimal(reader["desconto"]),
            Ativo = UtilConvert.ToBool(reader["ativo"])
        };

        public clnConta obterPorCod()
        {
            sqlSelect objSelect = new sqlSelect();
            objSelect.table("conta");
            objSelect.Where.where("id", Cod);

            SqlDataReader reader = objSelect.execute(App.DatabaseSql);
            clnConta objConta = null;
            if (reader.Read())
                objConta = obter(reader);
            reader.Close();

            return objConta;
        }

        public clnConta obterPorCodAtendimento()
        {
            sqlSelect objSelect = new sqlSelect();
            objSelect.table("conta");
            objSelect.Where.where("id_atendimento", CodAtendimento);
            objSelect.Order.order("id", vitorrdgs.SqlMaster.Element.sqlElementOrder.orderOperation.ASC);

            SqlDataReader reader = objSelect.execute(App.DatabaseSql);
            clnConta objConta = null;
            if (reader.Read())
                objConta = obter(reader);
            reader.Close();

            return objConta;
        }

        public void gravar()
        {
            sqlInsert objInsert = new sqlInsert();
            objInsert.table("conta");
            objInsert.Value.val("id_atendimento", CodAtendimento)
                            .val("id_funcionario", CodFuncionario)
                            .val("desconto", Desconto)
                            .val("valor", Valor)
                            .val("ativo", UtilConvert.ToBit(Ativo))
                            .val("taxa_servico", UtilConvert.ToBit(TaxaServico));

            Cod = objInsert.executeWithOutput(App.DatabaseSql);
        }


    }
}
