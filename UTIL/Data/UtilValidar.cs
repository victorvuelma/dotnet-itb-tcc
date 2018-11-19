using Caelum.Stella.CSharp.Http;
using Caelum.Stella.CSharp.Http.Exceptions;
using Caelum.Stella.CSharp.Validation;
using System;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace vitorrdgs.Util.Data
{
    public class UtilValidar
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
            return DateTime.TryParseExact(data, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.AssumeLocal, out DateTime resultReq) || DateTime.TryParseExact(data, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.AssumeLocal, out DateTime result);
        }

        public static bool validarDataNasc(String data)
        {
            return UtilConvert.ObterData(data).CompareTo(DateTime.Now.Date) < 0;
        }

        public static bool validarDataFutura(String data)
        {
            return validarDataFutura(UtilConvert.ObterData(data));
        }

        public static bool validarDataFutura(DateTime data)
        {
            return data.Date.CompareTo(DateTime.Now.Date) >= 0;
        }

        public static bool validarHora(String hora)
        {
            return DateTime.TryParseExact(hora, "HH:mm", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.AssumeLocal, out DateTime result);
        }

        public static bool vazio(String str)
        {
            return str == null || String.IsNullOrWhiteSpace(str);
        }

        public static bool validarInt(String inteiro)
        {
            return Int32.TryParse(inteiro, out int r);
        }

        public static bool validarValor(String val)
        {
            return Decimal.TryParse(val, out decimal value) && value > 0;
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
                MailAddress mailAddress = new MailAddress(mail);
                return mailAddress.Address.ToLower().Equals(mail.ToLower());
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool validarCartaoValidade(String validade)
        {
            if (DateTime.TryParseExact(validade, "MM/yy", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.AssumeLocal, out DateTime result)){
                return validarDataFutura(result.Date);
            }
            return false;
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
