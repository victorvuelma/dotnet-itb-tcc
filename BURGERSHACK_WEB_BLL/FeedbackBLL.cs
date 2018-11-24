using BurgerShack.Common;
using System;
using System.Text;
using vitorrdgs.Util.Data;

namespace BurgerShack.Web.Bll
{
    public class FeedbackBLL
    {

        private string validarDados(string nome, string email, string mensagem)
        {
            StringBuilder errosBuilder = new StringBuilder();
            if (UtilValidar.vazio(nome))
            {
                errosBuilder.Append("É necessário informar o nome.");
            }
            else if (nome.Length < 10)
            {
                errosBuilder.Append("O nome informádo é invalido.");
            }

            if (UtilValidar.vazio(email))
            {
                errosBuilder.Append("É necessário informar o e-mail.");
            }
            else if (!UtilValidar.validarEmail(email))
            {
                errosBuilder.Append("O e-mail informado é inválido.");
            }

            if (UtilValidar.vazio(mensagem))
            {
                errosBuilder.Append("É necessário informar a mensagem.");
            }
            else if (mensagem.Length < 15)
            {
                errosBuilder.Append("A mensagem informada é inválida.");
            }

            return errosBuilder.ToString();
        }

        public string enviarFeedback(string nome, string email, string mensagem)
        {
            string validar = validarDados(nome, email, mensagem);

            if (String.IsNullOrEmpty(validar))
            {
                string envio = enviarEmailDeRecebimento(nome, email);
                if (!string.IsNullOrEmpty(envio))
                {
                    return "0" + envio;
                }
                envio = enviarEmailDoFeedback(nome, email, mensagem);
                if (!string.IsNullOrEmpty(envio))
                {
                    return "0" + envio;
                }
                return "1Mensagem enviada com sucesso!";
            }
            else
            {
                return "0" + validar;
            }
        }

        private string enviarEmailDoFeedback(string nome, string email, string mensagem)
        {
            StringBuilder conteudo = new StringBuilder();
            conteudo.Append("Um novo feedback foi recebido!");
            conteudo.Append("<br/>");
            conteudo.Append("<br/>Nome: ").Append(nome);
            conteudo.Append("<br/>");
            conteudo.Append("<br/>E-mail: ").Append(email);
            conteudo.Append("<br/>");
            conteudo.Append("<br/>Mensagem: ").Append(mensagem);
            conteudo.Append("<br/>");
            conteudo.Append("<br/>(Esta mensagem é automática)");

            return App.EmailClient.SendEmail(nome, email, App.EmailClient.CredentialEmail, App.Name + " - Novo Feedback Recebido!", conteudo.ToString());
        }

        private string enviarEmailDeRecebimento(string nome, string email)
        {
            StringBuilder conteudo = new StringBuilder();
            conteudo.Append("Olá ").Append(nome);
            conteudo.Append("<br/>");
            conteudo.Append("<br/>Obrigado por enviar o seu Feedback!");
            conteudo.Append("<br/>Se for necessário entraremos em contato novamente para mais detalhes!");
            conteudo.Append("<br/>");
            conteudo.Append("<br/>Atenciosamente,");
            conteudo.Append("<br/>Equipe ").Append("<a href='").Append(App.Webiste).Append("'>").Append(App.Name).Append("</a>").Append(".");
            conteudo.Append("<br/>");
            conteudo.Append("<br/>(Esta mensagem é automática)");

            return App.EmailClient.SendEmail(App.Name, App.EmailClient.CredentialEmail, email, "Recebemos o seu Feedback!", conteudo, App.TemplateEmail);
        }

    }

}
