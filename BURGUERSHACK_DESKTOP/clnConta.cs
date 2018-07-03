using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SQL_POWERUP;
using System.Data.SqlClient;
using BURGUERSHACK_COMMON;

namespace BURGUERSHACK_DESKTOP
{
    public class clnConta
    {

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

        private clnConta obter(SqlDataReader reader) => new clnConta
        {
            CodAtendimento = clnUtilConvert.ToInt(reader["id_atendimento"]),
            CodFuncionario = clnUtilConvert.ToInt(reader["id_funcionario"]),
            Valor = clnUtilConvert.ToDecimal(reader["valor"]),
            TaxaServico = clnUtilConvert.ToBool(reader["taxa_servico"]),
            Desconto = clnUtilConvert.ToDecimal(reader["desconto"])
        };

        public clnConta obterPorCodAtendimento()
        {
            sqlCommandSelect objSelect = new sqlCommandSelect();
            objSelect.table("conta");
            objSelect.Where.where("id_atendimento", CodAtendimento);

            SqlDataReader reader = objSelect.execute(App.DatabaseSql);
            clnConta objConta = null;
            if (reader.Read())
                objConta = obter(reader);
            reader.Close();

            return objConta;
        }

        public void gravar()
        {
            sqlCommandInsert objInsert = new sqlCommandInsert();
            objInsert.table("conta");
            objInsert.Insert.val("id_atendimento", CodAtendimento)
                            .val("id_funcionario", CodFuncionario)
                            .val("desconto", Desconto)
                            .val("valor", Valor)
                            .val("taxa_servico", clnUtilConvert.ToBit(TaxaServico));

            objInsert.execute(App.DatabaseSql);
        }


    }
}
