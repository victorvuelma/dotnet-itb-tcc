using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

using SQL_POWERUP;
using System.Data.SqlClient;

namespace BURGUER_SHACK_DESKTOP
{
    class clnFuncionario
    {

        public enum funcionarioSituacao
        {
            TREINAMENTO,
            PLENO,
            DEMITIDO
        }

        private int _cod;

        private int _codCargo;
        private int _codFoto;

        private String _nome;
        private String _cpf;
        private String _rg;

        private char _genero;
        private DateTime _dataNascimento;

        private string _telRes;
        private string _telCel;
        private string _email;

        private double _salario;
        private DateTime _dataContratacao;
        private DateTime? _dataDemissao;
        private funcionarioSituacao _situacao;

        private String _endLogradouro;
        private String _endNumero;
        private String _endComplemento;
        private String _endCEP;
        private String _endBairro;
        private String _endLocalidade;
        private String _endUF;

        public int Cod { get => _cod; set => _cod = value; }
        public int CodCargo { get => _codCargo; set => _codCargo = value; }
        public int CodFoto { get => _codFoto; set => _codFoto = value; }
        public string Nome { get => _nome; set => _nome = value; }
        public string Cpf { get => _cpf; set => _cpf = value; }
        public string Rg { get => _rg; set => _rg = value; }
        public char Genero { get => _genero; set => _genero = value; }
        public DateTime DataNascimento { get => _dataNascimento; set => _dataNascimento = value; }
        public string TelRes { get => _telRes; set => _telRes = value; }
        public string TelCel { get => _telCel; set => _telCel = value; }
        public string Email { get => _email; set => _email = value; }
        public double Salario { get => _salario; set => _salario = value; }
        public DateTime DataContratacao { get => _dataContratacao; set => _dataContratacao = value; }
        public DateTime? DataDemissao { get => _dataDemissao; set => _dataDemissao = value; }
        internal funcionarioSituacao Situacao { get => _situacao; set => _situacao = value; }
        public string EndLogradouro { get => _endLogradouro; set => _endLogradouro = value; }
        public string EndNumero { get => _endNumero; set => _endNumero = value; }
        public string EndComplemento { get => _endComplemento; set => _endComplemento = value; }
        public string EndCEP { get => _endCEP; set => _endCEP = value; }
        public string EndBairro { get => _endBairro; set => _endBairro = value; }
        public string EndLocalidade { get => _endLocalidade; set => _endLocalidade = value; }
        public string EndUF { get => _endUF; set => _endUF = value; }


        private char prefixo(funcionarioSituacao situacao)
        {
            switch (situacao)
            {
                case funcionarioSituacao.DEMITIDO:
                    return 'D';
                case funcionarioSituacao.PLENO:
                    return 'P';
                default:
                    return 'T';
            }
        }

        private funcionarioSituacao situacao(char prefixo)
        {
            switch (prefixo)
            {
                case 'D':
                    return funcionarioSituacao.DEMITIDO;
                case 'P':
                    return funcionarioSituacao.PLENO;
                default:
                    return funcionarioSituacao.TREINAMENTO;
            }
        }

    }
}
