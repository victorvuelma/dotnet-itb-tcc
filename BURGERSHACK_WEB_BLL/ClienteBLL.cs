using BurgerShack.Common;
using System;
using System.Text;
using System.Web;
using vitorrdgs.Util.Data;

namespace BurgerShack.Web.Bll
{
    public class ClienteBLL
    {

        private string validarDados(string nome, string email, string senha, string cpf,
            string celular, string cartaoNumero, string cartaoValidade, string cartaoCVV)
        {
            StringBuilder errosBuilder = new StringBuilder();
            if (UtilValidar.vazio(nome))
            {
                errosBuilder.Append("É necessário informar o nome.");
            }
            else if (nome.Length < 10)
            {
                errosBuilder.Append("O nome informado é inválido.");
            }

            if (UtilValidar.vazio(email))
            {
                errosBuilder.Append("É necessário informar o e-mail.");
            }
            else if (!UtilValidar.validarEmail(email))
            {
                errosBuilder.Append("O e-mail informado é inválido.");
            }

            if (senha != null)
            {
                if (UtilValidar.vazio(senha))
                {
                    errosBuilder.Append("É necessário informar a senha.");
                }
                else if (senha.Length < 6)
                {
                    errosBuilder.Append("A senha precisa ter no minimo 6 caracteres.");
                }
            }

            if (UtilValidar.vazio(cpf))
            {
                errosBuilder.Append("É necessário informar o CPF.");
            }
            else if (!UtilValidar.validarCPF(cpf))
            {
                errosBuilder.Append("O CPF informado é inválido.");
            }

            if (UtilValidar.vazio(celular))
            {
                errosBuilder.Append("É necessário informar o celular.");
            }
            else if (!UtilValidar.validarCelular(celular))
            {
                errosBuilder.Append("O celular informado é inválido.");
            }

            if (UtilValidar.vazio(cartaoNumero))
            {
                errosBuilder.Append("É necessário informar o número do cartão.");
            }
            else if (cartaoNumero.ToString().Length != 16)
            {
                errosBuilder.Append("O número do cartão informado é inválido.");
            }

            if (UtilValidar.vazio(cartaoValidade))
            {
                errosBuilder.Append("É necessário informar a validade do cartão.");
            }
            else if (cartaoValidade.ToString().Length != 5)
            {
                errosBuilder.Append("A validade do cartão informada é inválida.");
            }
            else if (!UtilValidar.validarCartaoValidade(cartaoValidade))
            {
                errosBuilder.Append("A validade do cartão informada é inválida.");
            }

            if (UtilValidar.vazio(cartaoCVV))
            {
                errosBuilder.Append("É necessário informar o CVV do cartão.");
            }
            else if (cartaoCVV.ToString().Length != 3)
            {
                errosBuilder.Append("O CVV do cartão informado é inválido.");
            }

            return errosBuilder.ToString();
        }

        private string validarDadosLogin(string cpf, string senha)
        {
            if (!autenticado())
            {
                StringBuilder errosBuilder = new StringBuilder();

                if (UtilValidar.vazio(cpf))
                {
                    errosBuilder.Append("É necessário informar um CPF.");
                }
                else if (!UtilValidar.validarCPF(cpf))
                {
                    errosBuilder.Append("É necessário informar um CPF válido.");
                }

                if (UtilValidar.vazio(senha))
                {
                    errosBuilder.Append("É necessário informar a senha.");
                }

                return errosBuilder.ToString();
            }
            else
            {
                return "Você já se encontra autenticado.";
            }
        }

        public string autenticar(string cpf, string senha)
        {
            cpf = UtilFormatar.retirarFormatacao(cpf);

            string validar = validarDadosLogin(cpf, senha);

            if (string.IsNullOrEmpty(validar))
            {
                clnCliente objCliente = new clnCliente
                {
                    Cpf = cpf,
                    Hash = senha
                }.autenticarPorCPF();

                if (objCliente != null)
                {
                    HttpContext.Current.Session["clienteAutenticado"] = (clnCliente)objCliente;
                    return "1Autenticado com sucesso!";
                }
                else
                {
                    return "0Os dados informados são inválidos.";
                }
            }
            else
            {
                return "0" + validar;
            }
        }

        public void sair()
        {
            HttpContext.Current.Session["clienteAutenticado"] = null;
        }

        public bool autenticado()
        {
            return HttpContext.Current.Session["clienteAutenticado"] != null;
        }

        public clnCliente obterCliente()
        {
            return (clnCliente)HttpContext.Current.Session["clienteAutenticado"];
        }

        public string alterar(string nome, string senha, string celular,
            string cartaoNumero, string cartaoValidade, string cartaoCVV)
        {
            if (autenticado())
            {
                clnCliente objCliente = obterCliente();

                cartaoNumero = UtilFormatar.retirarFormatacao(cartaoNumero);

                string validar = validarDados(nome, objCliente.Email, ((senha == "") ? null : senha), objCliente.Cpf, celular, cartaoNumero, cartaoValidade, cartaoCVV);

                if (string.IsNullOrEmpty(validar))
                {
                    objCliente = obterCliente();
                    objCliente.Nome = nome;
                    objCliente.TelCelular = UtilFormatar.retirarFormatacao(celular);
                    objCliente.CartaoNumero = UtilFormatar.retirarFormatacao(cartaoNumero);
                    objCliente.CartaoValidade = UtilFormatar.retirarFormatacao(cartaoValidade);
                    objCliente.CartaoCVV = UtilFormatar.retirarFormatacao(cartaoCVV);
                    if (senha != "")
                    {
                        objCliente.Hash = senha;
                    }

                    objCliente.alterar();

                    return "1Seus dados foram atualizados com sucesso!";
                }
                else
                {
                    return "0" + validar;
                }
            }
            else
            {
                return "0Você não está autenticado";
            }
        }

        public string cadastrar(string nome, string email, string senha, string cpf, string celular,
            string cartaoNumero, string cartaoValidade, string cartaoCVV)
        {
            if (!autenticado())
            {
                cartaoNumero = UtilFormatar.retirarFormatacao(cartaoNumero);
                cpf = UtilFormatar.retirarFormatacao(cpf);

                string validar = validarDados(nome, email, senha, cpf, celular, cartaoNumero, cartaoValidade, cartaoCVV);

                if (string.IsNullOrEmpty(validar))
                {
                    clnCliente objClienteEmail = new clnCliente
                    {
                        Email = email
                    }.obterPorEmail();
                    if (objClienteEmail != null)
                    {
                        validar += "E-mail já cadastrado.";
                    }

                    clnCliente objClienteCPF = new clnCliente
                    {
                        Cpf = cpf
                    }.obterPorCPF();
                    if (objClienteCPF != null)
                    {
                        validar += "CPF já cadastrado.";
                    }

                    if (string.IsNullOrEmpty(validar))
                    {
                        clnCliente objCliente = new clnCliente
                        {
                            Nome = nome,
                            Email = email,
                            Hash = senha,
                            Ativo = true,
                            TelCelular = UtilFormatar.retirarFormatacao(celular),
                            Cpf = cpf,
                            Cadastro = DateTime.Now,
                            CartaoCVV = UtilFormatar.retirarFormatacao(cartaoCVV),
                            CartaoNumero = UtilFormatar.retirarFormatacao(cartaoNumero),
                            CartaoValidade = UtilFormatar.retirarFormatacao(cartaoValidade)
                        };
                        objCliente.gravar();

                        HttpContext.Current.Session["clienteAutenticado"] = (clnCliente)objCliente;
                        return "1Cadastrado com sucesso!";
                    }
                }
                return "0" + validar;
            }
            else
            {
                return "0Você já está autenticado";
            }
        }

        private string gerarTokenCliente(clnCliente objCliente)
        {
            String tokenCliente = objCliente.Cpf + "-" + objCliente.Email + "-" + objCliente.obterHash();
            tokenCliente = vitorrdgs.Util.Hash.Hash.HASH.cyph(tokenCliente);

            return tokenCliente;
        }

        private String construirToken(clnCliente objCliente)
        {
            String tokenCliente = gerarTokenCliente(objCliente);

            DateTime tempoParaRecuperar = DateTime.Now;
            tempoParaRecuperar.AddHours(3);

            String tokenDataHora = UtilFormatar.formatarData(tempoParaRecuperar) + "$" + UtilFormatar.formatarHora(tempoParaRecuperar);
            String token = tokenCliente + "&" + tokenDataHora;

            return UtilConvert.ToBase64(token);
        }

        private string validarCPFEmail(string cpf, string email)
        {
            StringBuilder errosBuilder = new StringBuilder();

            if (UtilValidar.vazio(cpf))
            {
                errosBuilder.Append("É necessário informar um CPF.");
            }
            else if (!UtilValidar.validarCPF(cpf))
            {
                errosBuilder.Append("É necessário informar um CPF válido.");
            }

            if (UtilValidar.vazio(email))
            {
                errosBuilder.Append("É necessário informar o email.");
            }
            else if (!UtilValidar.validarEmail(email))
            {
                errosBuilder.Append("É necessário informar um email válido.");
            }

            return errosBuilder.ToString();
        }

        public string enviarRecuperacao(string cpf, string email)
        {
            string valido = validarCPFEmail(cpf, email);

            if (string.IsNullOrEmpty(valido))
            {
                clnCliente objCliente = new clnCliente
                {
                    Email = email
                }.obterPorEmail();

                if (objCliente.Ativo && objCliente.Cpf.Equals(UtilFormatar.retirarFormatacao(cpf)))
                {
                    enviarToken(objCliente);
                }

                return "1Se seus dados são validos, enviamos um link de recuperação para você";
            }
            else
            {
                return "0" + valido;
            }
        }

        private void enviarToken(clnCliente objCliente)
        {
            string token = construirToken(objCliente);

            StringBuilder conteudo = new StringBuilder();
            conteudo.Append("Olá ").Append(objCliente.Nome);
            conteudo.Append("<br/>");
            conteudo.Append("<br/>Ao que parece, você acabou esquecendo a sua senha.");
            conteudo.Append("<br/>Utilize o link abaixo para redefinir ela:");
            conteudo.Append("<br/>");
            conteudo.Append("<br/>").Append(App.Webiste).Append("recuperar.cshtml?token=" + token + "&email=" + objCliente.Email);
            conteudo.Append("<br/>Não se esqueça, o link é válido por apenas 3 horas.");
            conteudo.Append("<br/>");
            conteudo.Append("<br/>Atenciosamente,");
            conteudo.Append("<br/>Equipe ").Append("<a href='").Append(App.Webiste).Append("'>").Append(App.Name).Append("</a>").Append(".");
            conteudo.Append("<br/>");
            conteudo.Append("<br/>(Esta mensagem é automática)");

            App.EmailClient.SendEmail(App.Name, App.EmailClient.CredentialEmail, objCliente.Email, App.Name + " - Esqueceu sua senha?", conteudo.ToString());
        }

        public bool tokenValidade(string token)
        {
            String conteudo = UtilConvert.FromBase64(token);
            String[] dataHora = conteudo.Split('&')[1].Split('$');
            DateTime tokenValidade = UtilConvert.ObterDataHora(dataHora[0], dataHora[1]);

            return DateTime.Now.CompareTo(tokenValidade) >= 1;
        }

        private string validarRecuperacao(string token, string email, string cpf, string senha)
        {
            StringBuilder errosBuilder = new StringBuilder();

            if (UtilValidar.vazio(cpf))
            {
                errosBuilder.Append("É necessário informar um CPF.");
            }
            else if (!UtilValidar.validarCPF(cpf))
            {
                errosBuilder.Append("É necessário informar um CPF válido.");
            }

            if (UtilValidar.vazio(email))
            {
                errosBuilder.Append("É necessário informar o email.");
            }
            else if (!UtilValidar.validarEmail(email))
            {
                errosBuilder.Append("É necessário informar um email válido.");
            }

            if (UtilValidar.vazio(senha))
            {
                errosBuilder.Append("É necessário informar a nova senha.");
            }
            else if (senha.Length < 6)
            {
                errosBuilder.Append("A senha precisa ter no minimo 6 caracteres.");
            }

            if (UtilValidar.vazio(token))
            {
                errosBuilder.Append("É necessário informar o token.");
            }
            else if (!tokenValidade(token))
            {
                errosBuilder.Append("O token informado já expirou.");
            }

            return errosBuilder.ToString();
        }

        public string recuperarSenha(string token, string email, string cpf, string senha)
        {
            string valido = validarRecuperacao(token, email, cpf, senha);

            if (string.IsNullOrEmpty(valido))
            {
                clnCliente objCliente = new clnCliente
                {
                    Email = email
                }.obterPorEmail();

                if(objCliente != null)
                {
                    if (objCliente.Cpf.Equals(UtilFormatar.retirarFormatacao(cpf)))
                    {
                        String tokenClienteValido = gerarTokenCliente(objCliente);
                        String tokenCliente = UtilConvert.FromBase64(token).Split('&')[0];

                        if (tokenCliente.Equals(tokenClienteValido))
                        {
                            objCliente.Hash = senha;
                            objCliente.alterar();
                            return "1Senha alterada com sucesso!";
                        } else
                        {
                            return "0O token informado é inválido.";
                        }
                        
                    }
                }
                return "0O cliente informado é inválido";
            }
            else
            {
                return "0" + valido;
            }
        }

    }
}
