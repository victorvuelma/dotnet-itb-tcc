using Caelum.Stella.CSharp.Http;
using Caelum.Stella.CSharp.Http.Exceptions;
using Caelum.Stella.CSharp.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BURGERSHACK_COMMON.UTIL
{
    public class clnUtilValidar
    {

        private static String REGEX_CEL = @"^\([1-9]{2}\) (9[1-9])[0-9]{3}\-[0-9]{4}$";
        private static String REGEX_TEL = @"^\([1-9]{2}\) ([2-8])[0-9]{3}\-[0-9]{4}$";

        private static CPFValidator _cpfValidator = new CPFValidator();
        private static CNPJValidator _cnpjValidator = new CNPJValidator();

        public static bool validarCelular(String cel)
        {
            return Regex.IsMatch(cel, REGEX_CEL);
        }

        public static bool validarTelefone(String cel)
        {
            return Regex.IsMatch(cel, REGEX_TEL);
        }

        public static bool validarData(String data)
        {
            return DateTime.TryParseExact(data, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.AssumeLocal, out DateTime result);
        }

        public static bool validarDataNasc(String data)
        {
            return clnUtilConvert.ObterData(data).CompareTo(DateTime.Now.Date) < 0;
        }

        public static bool validarDataFutura(String data)
        {
            return clnUtilConvert.ObterData(data).CompareTo(DateTime.Now.Date) >= 0;
        }

        public static bool validarHora(String hora)
        {
            return DateTime.TryParseExact(hora, "HH:mm", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.AssumeLocal, out DateTime result);
        }

        public static bool vazio(String str)
        {
            return String.IsNullOrWhiteSpace(str);
        }

        public static bool validarInt(String inteiro)
        {
            return Int32.TryParse(inteiro, out int r);
        }

        public static bool validarValor(String val)
        {
            return Double.TryParse(val, out double value) && value > 0.0;
        }

        public static bool validarDouble(String val)
        {
            return Double.TryParse(val, out double r);
        }

        public static bool validarDecimal(String val)
        {
            return Decimal.TryParse(val, out decimal r);
        }

        public static bool validarCPF(String cpf)
        {
            return _cpfValidator.IsValid(cpf);
        }

        public static bool validarCNPJ(String cnpj)
        {
            return _cnpjValidator.IsValid(cnpj);
        }

        public static bool validarEmail(String mail)
        {
            try
            {
                System.Net.Mail.MailAddress mailAddress = new System.Net.Mail.MailAddress(mail);
                return mailAddress.Address.ToLower().Equals(mail.ToLower());
            }
            catch (Exception)
            {
                return false;
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

    }
}
