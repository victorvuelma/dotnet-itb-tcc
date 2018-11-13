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
            } else if (!UtilValidar.validarCartaoValidade(cartaoValidade))
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

    }
}
