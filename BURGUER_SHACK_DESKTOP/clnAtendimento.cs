using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQL_POWERUP;

namespace BURGUER_SHACK_DESKTOP
{
    public class clnAtendimento
    {

        public enum atendimentoSituacao
        {
            ANDAMENTO,
            FINALIZADO
        }

        private int _cod;
        private List<int> _codMesas;

        private DateTime _inicio;
        private DateTime _fim;

        private atendimentoSituacao _situacao;

        public int Cod { get => _cod; set => _cod = value; }
        public List<int> CodMesas { get => _codMesas; set => _codMesas = value; }
        public DateTime Inicio { get => _inicio; set => _inicio = value; }
        public DateTime Fim { get => _fim; set => _fim = value; }
        public atendimentoSituacao Situacao { get => _situacao; set => _situacao = value; }

        public clnAtendimento obterPorCodigo()
        {
            return new clnAtendimento();
        }

        public void gravar()
        {
            //throw new NotImplementedException();
        }

        public void adicionarMesa(int codMesa)
        {
            if (!CodMesas.Contains(codMesa))
            {
                CodMesas.Add(codMesa);
                sqlCommandInsert objInsert = new sqlCommandInsert();
                objInsert.table("atendimento_mesa").Insert.with("id_atendimento", Cod).with("id_mesa", codMesa);
                objInsert.insert(App.AppDatabase);
            }
        }

        public void removerMesa(int codMesa)
        {
            if (CodMesas.Contains(codMesa))
            {
                CodMesas.Remove(codMesa);
                sqlCommandDelete objDelete = new sqlCommandDelete();
                objDelete.table("atendimento_mesa").Where.where("id_atendimento", Cod).where("id_mesa", codMesa);
                objDelete.delete(App.AppDatabase);
            }
        }

        public atendimentoSituacao situacao(String prefixo)
        {
            switch (prefixo.ToUpper())
            {
                case "A":
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
