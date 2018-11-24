using System;
using vitorrdgs.SqlMaster;
using vitorrdgs.Util;

namespace BurgerShack.Common
{
    public class App
    {

        private static string _email = "burgershackhamburgueria@gmail.com";
        private static string _endereco = "Calçada dos Lírios, 196 - Alphaville - Barueri";
        private static string _enderecoURL = "https://goo.gl/maps/UNELiYGVo932";
        private static string _facebook = "burgershack";
        private static string _name = "BurgerShack";
        private static string _telefone = "1149985255";
        private static string _webiste = "http://localhost:51061/";


        private static string _templateConta = Properties.Resources.html_template_conta;
        private static string _templateEmail = Properties.Resources.html_template_email;

        private static EmailClient _emailClient = new EmailClient
        {
            SmtpHost = "smtp.gmail.com",
            CredentialPassword = "burgerburger123",
            CredentialEmail = "burgershackhamburgueria@gmail.com"
        };

        private static sqlCredential _databaseSqlCredential = new sqlCredential
        {
            Database = AppLocal.DATABASE,
            User = AppLocal.USER,
            Pass = AppLocal.PASS,
            Source = AppLocal.SOURCE,
        };
        private static sqlDatabase _databaseSql = new sqlDatabase
        {
            ExceptionCall = (Exception ex, string error) => { throw ex; },
            Credential = DatabaseSqlCredential
        };

        public static string Email { get => _email; set => _email = value; }
        public static string EnderecoURL { get => _enderecoURL; set => _enderecoURL = value; }
        public static string Endereco { get => _endereco; set => _endereco = value; }
        public static string Facebook { get => _facebook; set => _facebook = value; }
        public static string Name { get => _name; set => _name = value; }
        public static string Telefone { get => _telefone; set => _telefone = value; }
        public static string Webiste { get => _webiste; set => _webiste = value; }

        public static sqlCredential DatabaseSqlCredential { get => _databaseSqlCredential; set => _databaseSqlCredential = value; }
        public static sqlDatabase DatabaseSql { get => _databaseSql; set => _databaseSql = value; }

        public static string TemplateEmail { get => _templateEmail; set => _templateEmail = value; }
        public static string TemplateConta { get => _templateConta; set => _templateConta = value; }

        public static EmailClient EmailClient { get => _emailClient; set => _emailClient = value; }
    }
}
