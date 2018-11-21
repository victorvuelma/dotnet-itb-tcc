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

        public static bool validarCelular(String val)
        {
            return Regex.IsMatch(val, REGEX_CEL);
        }

        public static bool validarTelefone(String val)
        {
            return Regex.IsMatch(val, REGEX_TEL);
        }

        public static bool validarData(String val)
        {
            return DateTime.TryParseExact(val, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.AssumeLocal, out DateTime resultReq) || DateTime.TryParseExact(val, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.AssumeLocal, out DateTime result);
        }

        public static bool validarDataNasc(String val)
        {
            return UtilConvert.ObterData(val).CompareTo(DateTime.Now.Date) < 0;
        }

        public static bool validarDataFutura(String val)
        {
            return validarDataFutura(UtilConvert.ObterData(val));
        }

        public static bool validarDataFutura(DateTime val)
        {
            return val.Date.CompareTo(DateTime.Now.Date) >= 0;
        }

        public static bool validarHora(String val)
        {
            return DateTime.TryParseExact(val, "HH:mm", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.AssumeLocal, out DateTime result);
        }

        public static bool vazio(String val)
        {
            return val == null || String.IsNullOrWhiteSpace(val);
        }

        public static bool validarInt(String val)
        {
            return Int32.TryParse(val, out int r);
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

        public static bool validarCPF(String val)
        {
            return _cpfValidator.IsValid(val);
        }

        public static bool validarCNPJ(String val)
        {
            return _cnpjValidator.IsValid(val);
        }

        public static bool validarEmail(String val)
        {
            try
            {
                MailAddress mailAddress = new MailAddress(val);
                return mailAddress.Address.ToLower().Equals(val.ToLower());
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool validarCartaoValidade(String val)
        {
            if (DateTime.TryParseExact(val, "MM/yy", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.AssumeLocal, out DateTime result)){
                return validarDataFutura(result.Date);
            }
            return false;
        }


        public static bool validarCEP(String val)
        {
            try
            {
                new CEP(val);
                return true;
            }
            catch (InvalidZipCodeFormat)
            {
                return false;
            }
        }

    }
}
