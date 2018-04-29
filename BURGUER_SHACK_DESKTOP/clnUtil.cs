using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Drawing;

using Caelum.Stella.CSharp.Validation;
using Caelum.Stella.CSharp.Format;

using Caelum.Stella.CSharp.Http;
using Caelum.Stella.CSharp.Http.Exceptions;

namespace BURGUER_SHACK_DESKTOP
{
    class clnUtil
    {

        public static String MASK_TEL = "(00) 0000-0000";
        public static String MASK_CEL = "(00) 00000-0000";

        public static String MASK_DATA = "00/00/0000";
        public static String MASK_CEP = "00000-000";

        public static String MASK_CNPJ = "00,000,000/0000-00";
        public static String MASK_IE = "000,000,000,000";
        public static String MASK_CPF = "000,000,000-00";
        public static String MASK_RG = "00,000,000-0";

        private static CPFValidator _cpfValidator = new CPFValidator();
        private static CNPJValidator _cnpjValidator = new CNPJValidator();

        private static CPFFormatter _cpfFormatter = new CPFFormatter();
        private static CNPJFormatter _cnpjFormatter = new CNPJFormatter();

        private static ViaCEP _viaCep = new ViaCEP();

        public static void definirEndereco(String cep, Control rua, Control bairro, Control cidade, Control estado, Control  nr)
        {
            if (validarCEP(cep))
            {
                Endereco end = obterEndereco(cep);
                if (end != null)
                {
                    rua.Text = end.Logradouro;
                    bairro.Text = end.Bairro;
                    cidade.Text = end.Localidade;
                    estado.Text = end.UF;
                    nr.Focus();
                }
                else
                {
                    clnMensagem.mostrarOk("Endereço", "Não foi possível obter as informações a partir do CEP, preencha manualmente", clnMensagem.MSG_ERRO);
                    rua.Focus();
                }
            }
        }

        public static Endereco obterEndereco(String cep)
        {
            try
            {
                return _viaCep.GetEndereco(new CEP(cep));
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static bool validarCEP(String cep)
        {
            try
            {
                new CEP(cep);
                return true;
            }
            catch (InvalidZipCodeFormat)
            {
                return false;
            }
        }

        public static String formatarCPF(String cpf)
        {
            return _cpfFormatter.Format(cpf);
        }

        public static bool validarCPF(String cpf)
        {
            return _cpfValidator.IsValid(cpf);
        }

        public static String formatarCNPJ(String cnpj)
        {
            return _cnpjFormatter.Format(cnpj);
        }

        public static bool validarCNPJ(String cnpj)
        {
            return _cnpjValidator.IsValid(cnpj);
        }

        public static bool validarEmail(String email)
        {
            try
            {
                new System.Net.Mail.MailAddress(email);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static void alterarConteudo(Panel pnlConteudo, UserControl uctConteudo, UIX.uctUIX uctUIX, String titulo)
        {
            if (pnlConteudo.Controls.Count == 1)
            {
                pnlConteudo.Controls.Remove(pnlConteudo.Controls[0]);
            }

            clnTemplate.CommonTemplate.uctApply(uctConteudo);

            pnlConteudo.Controls.Add(uctConteudo);
            uctConteudo.Location = new Point(0, 0);
            uctConteudo.Size = pnlConteudo.Size;
            if (!pnlConteudo.Visible)
            {
                pnlConteudo.Visible = true;
            }

            uctUIX.UIXTitle = clnTemplate.AppName + " - " + titulo;
        }

    }
}
