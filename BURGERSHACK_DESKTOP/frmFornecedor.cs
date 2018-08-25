using BurgerShack.Common;
using BurgerShack.Desktop.Util;
using System;
using System.Windows.Forms;
using vitorrdgs.UiX.Manager;
using vitorrdgs.Util.Data;
using vitorrdgs.Util.Form;

namespace BurgerShack.Desktop
{
    public partial class frmFornecedor : Form
    {

        private clnUtilFormValidar _validar;

        private clnFornecedor _objFuncionario;

        internal clnFornecedor ObjFornecedor { get => _objFuncionario; set => _objFuncionario = value; }

        public frmFornecedor()
        {
            InitializeComponent();

            _validar = new clnUtilFormValidar();
            _validar.addValidacao(txtRazaoSocial, clnUtilFormValidar.Validacao.OBRIGATORIO);
            _validar.addValidacao(mtbCNPJ, new clnUtilFormValidar.Validacao[] { clnUtilFormValidar.Validacao.OBRIGATORIO, clnUtilFormValidar.Validacao.CNPJ });
            _validar.addValidacao(mtbTel, new clnUtilFormValidar.Validacao[] { clnUtilFormValidar.Validacao.OBRIGATORIO, clnUtilFormValidar.Validacao.TELEFONE });
            _validar.addValidacao(txtEmail, new clnUtilFormValidar.Validacao[] { clnUtilFormValidar.Validacao.OBRIGATORIO, clnUtilFormValidar.Validacao.EMAIL });

            _validar.addValidacao(mtbEndCEP, new clnUtilFormValidar.Validacao[] { clnUtilFormValidar.Validacao.OBRIGATORIO, clnUtilFormValidar.Validacao.CEP });
            _validar.addValidacao(txtEndLogradouro, clnUtilFormValidar.Validacao.OBRIGATORIO);
            _validar.addValidacao(txtEndNr, new clnUtilFormValidar.Validacao[] { clnUtilFormValidar.Validacao.OBRIGATORIO, clnUtilFormValidar.Validacao.INT, clnUtilFormValidar.Validacao.QUANTIDADE });
            _validar.addValidacao(txtEndBairro, clnUtilFormValidar.Validacao.OBRIGATORIO);
            _validar.addValidacao(txtEndCidade, clnUtilFormValidar.Validacao.OBRIGATORIO);
            _validar.addValidacao(cboEndUF, clnUtilFormValidar.Validacao.OBRIGATORIO);

            mtbCNPJ.Mask = UtilMask.MASK_CNPJ;
            mtbTel.Mask = UtilMask.MASK_TEL;
            mtbEndCEP.Mask = UtilMask.MASK_CEP;
        }

        private void salvar()
        {
            if (_validar.validar(this))
            {
                if (ObjFornecedor == null)
                {
                    clnFornecedor objFornecedorCNPJ = new clnFornecedor
                    {
                        Cnpj = UtilFormatar.retirarFormatacao(mtbCNPJ.Text)
                    }.obterPorCNPJ();

                    if (objFornecedorCNPJ == null)
                    {
                        clnFornecedor objFornecedor = new clnFornecedor
                        {
                            RazaoSocial = txtRazaoSocial.Text,
                            Cnpj = UtilFormatar.retirarFormatacao(mtbCNPJ.Text),
                            Telefone = UtilFormatar.retirarFormatacao(mtbTel.Text),
                            Email = txtEmail.Text,
                            EndCEP = UtilFormatar.retirarFormatacao(mtbEndCEP.Text),
                            EndLogradouro = txtEndLogradouro.Text,
                            EndNumero = txtEndNr.Text,
                            EndComplemento = txtEndComplemento.Text,
                            EndBairro = txtEndBairro.Text,
                            EndLocalidade = txtEndCidade.Text,
                            EndUF = cboEndUF.Text
                        };
                        objFornecedor.gravar();
                        ObjFornecedor = objFornecedor;
                        UtilMensagem.mostrarOk("Cadastro de Fornecedor", "Fornecedor cadastrado com sucesso!");
                        Close();
                    }
                    else
                    {
                        UtilMensagem.mostrarOk("Cadastro de Fornecedor", "Não foi possível cadastrar o fornecedor, o CNPJ já está cadastrado!");
                        mtbCNPJ.Focus();
                    }
                }
                else
                {
                    ObjFornecedor.RazaoSocial = txtRazaoSocial.Text;
                    ObjFornecedor.Email = txtEmail.Text;
                    ObjFornecedor.Telefone = UtilFormatar.retirarFormatacao(mtbTel.Text);
                    ObjFornecedor.EndCEP = UtilFormatar.retirarFormatacao(mtbEndCEP.Text);
                    ObjFornecedor.EndLogradouro = txtEndLogradouro.Text;
                    ObjFornecedor.EndNumero = txtEndNr.Text;
                    ObjFornecedor.EndComplemento = txtEndComplemento.Text;
                    ObjFornecedor.EndBairro = txtEndBairro.Text;
                    ObjFornecedor.EndLocalidade = txtEndCidade.Text;
                    ObjFornecedor.EndUF = cboEndUF.Text;
                    ObjFornecedor.alterar();
                    UtilMensagem.mostrarOk("Alteração de Fornecedor", "Fornecedor alterado com sucesso!");
                    Close();
                }
            }
        }

        private void fechar()
        {
            if (ObjFornecedor == null)
            {
                if (UtilMensagem.mostrarSimNao("Cadastro de Fornecedor", "Deseja cancelar o cadastro?", UtilMensagem.MensagemIcone.ERRO))
                {
                    Close();
                }
            }
            else
            {
                if (btnAlterar.Description.Equals("Salvar", StringComparison.InvariantCultureIgnoreCase))
                {
                    if (UtilMensagem.mostrarSimNao("Alteração de Fornecedor", "Deseja cancelar as alterações?", UtilMensagem.MensagemIcone.ERRO))
                    {
                        Close();
                    }
                }
                else
                {
                    Close();
                }
            }
        }

        private void excluir()
        {
            if (UtilMensagem.mostrarSimNao("Fornecedor", "Você deseja realmente excluir este fornecedor?", UtilMensagem.MensagemIcone.ERRO))
            {
                ObjFornecedor.Ativo = false;
                ObjFornecedor.alterar();

                btnAlterar.Hide();
                UtilButton.restaurar(btnExcluir);
                UtilForm.Disable(this);
            }
        }

        private void restaurar()
        {
            if (UtilMensagem.mostrarSimNao("Fornecedor", "Você deseja realmente restaurar este fornecedor?", UtilMensagem.MensagemIcone.OK))
            {
                ObjFornecedor.Ativo = true;
                ObjFornecedor.alterar();

                btnAlterar.Show();
                UtilButton.excluir(btnExcluir);
            }
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            clnUtil.atualizarForm(this);
            uixButton.btnApply(btnVoltar, AppDesktop.VisualStyle.ButtonWarningColor);

            clnUtil.definirCEP(mtbEndCEP, txtEndLogradouro, txtEndBairro, txtEndCidade, cboEndUF.cbo, txtEndNr, txtEndComplemento);

            if (ObjFornecedor == null)
            {
                hdrUIX.Title = App.Name + " - Novo Fornecedor";
            }
            else
            {
                hdrUIX.Title = App.Name + " - Fornecedor " + ObjFornecedor.Cod;

                txtRazaoSocial.Text = ObjFornecedor.RazaoSocial;
                mtbCNPJ.Text = ObjFornecedor.Cnpj;
                txtEmail.Text = ObjFornecedor.Email;
                mtbTel.Text = ObjFornecedor.Telefone;

                mtbEndCEP.Text = ObjFornecedor.EndCEP;
                txtEndLogradouro.Text = ObjFornecedor.EndLogradouro;
                txtEndNr.Text = ObjFornecedor.EndNumero;
                txtEndComplemento.Text = ObjFornecedor.EndComplemento;
                txtEndBairro.Text = ObjFornecedor.EndBairro;
                txtEndCidade.Text = ObjFornecedor.EndLocalidade;
                cboEndUF.Text = ObjFornecedor.EndUF;
                UtilForm.Disable(this);

                if (AppDesktop.FuncionarioAtual.CodCargo >= 3)
                {
                    btnExcluir.Show();
                    UtilButton.alterar(btnAlterar);
                    UtilButton.voltar(btnVoltar);
                    if (ObjFornecedor.Ativo)
                    {
                        UtilButton.excluir(btnExcluir);
                    }
                    else
                    {
                        btnAlterar.Hide();
                        UtilButton.restaurar(btnExcluir);
                    }
                }
            }

            txtRazaoSocial.Focus();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (btnAlterar.Description.Equals("Salvar", StringComparison.InvariantCultureIgnoreCase))
            {
                salvar();
            }
            else
            {
                UtilForm.Enable(this);
                mtbCNPJ.Enabled = false;

                UtilButton.cancelar(btnVoltar);
                UtilButton.salvar(btnAlterar);
            }
        }

        private void hdrUIX_Close(object sender, EventArgs e)
        {
            fechar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            fechar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (ObjFornecedor.Ativo)
            {
                excluir();
            }
            else
            {
                restaurar();
            }
        }
    }
}
