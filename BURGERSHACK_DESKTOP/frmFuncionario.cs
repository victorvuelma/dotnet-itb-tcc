﻿using BurgerShack.Common;
using BurgerShack.Desktop.Util;
using System;
using System.Linq;
using System.Windows.Forms;
using vitorrdgs.UiX.Manager;
using vitorrdgs.Util.Data;
using vitorrdgs.Util.Form;

namespace BurgerShack.Desktop
{
    public partial class frmFuncionario : Form
    {

        private clnUtilFormValidar _validar;

        private bool _primeiroCadastro;
        private clnFuncionario _objFuncionario;

        internal clnFuncionario ObjFuncionario { get => _objFuncionario; set => _objFuncionario = value; }
        public bool PrimeiroCadastro { get => _primeiroCadastro; set => _primeiroCadastro = value; }

        public frmFuncionario()
        {
            InitializeComponent();

            _validar = new clnUtilFormValidar();
            _validar.addValidacao(txtNome, clnUtilFormValidar.Validacao.OBRIGATORIO);
            _validar.addValidacao(mtbCPF, new clnUtilFormValidar.Validacao[] { clnUtilFormValidar.Validacao.OBRIGATORIO, clnUtilFormValidar.Validacao.CPF });
            _validar.addValidacao(txtRG, clnUtilFormValidar.Validacao.OBRIGATORIO);
            _validar.addValidacao(mtbDataNasc, new clnUtilFormValidar.Validacao[] { clnUtilFormValidar.Validacao.OBRIGATORIO, clnUtilFormValidar.Validacao.DATA, clnUtilFormValidar.Validacao.DATA_NASC });
            _validar.addValidacao(mtbTelCel, new clnUtilFormValidar.Validacao[] { clnUtilFormValidar.Validacao.OBRIGATORIO, clnUtilFormValidar.Validacao.CELULAR });
            _validar.addValidacao(mtbTelRes, new clnUtilFormValidar.Validacao[] { clnUtilFormValidar.Validacao.OBRIGATORIO, clnUtilFormValidar.Validacao.TELEFONE });
            _validar.addValidacao(txtEmail, new clnUtilFormValidar.Validacao[] { clnUtilFormValidar.Validacao.OBRIGATORIO, clnUtilFormValidar.Validacao.EMAIL });
            _validar.addValidacao(cboGenero, clnUtilFormValidar.Validacao.OBRIGATORIO);

            _validar.addValidacao(txtSalario, new clnUtilFormValidar.Validacao[] { clnUtilFormValidar.Validacao.OBRIGATORIO, clnUtilFormValidar.Validacao.VALOR });
            _validar.addValidacao(cboSituacao, clnUtilFormValidar.Validacao.OBRIGATORIO);
            _validar.addValidacao(cboCargo, clnUtilFormValidar.Validacao.OBRIGATORIO);

            _validar.addValidacao(mtbEndCEP, new clnUtilFormValidar.Validacao[] { clnUtilFormValidar.Validacao.OBRIGATORIO, clnUtilFormValidar.Validacao.CEP });
            _validar.addValidacao(txtEndLogradouro, clnUtilFormValidar.Validacao.OBRIGATORIO);
            _validar.addValidacao(txtEndNr, new clnUtilFormValidar.Validacao[] { clnUtilFormValidar.Validacao.OBRIGATORIO, clnUtilFormValidar.Validacao.INT, clnUtilFormValidar.Validacao.QUANTIDADE });
            _validar.addValidacao(txtEndBairro, clnUtilFormValidar.Validacao.OBRIGATORIO);
            _validar.addValidacao(txtEndCidade, clnUtilFormValidar.Validacao.OBRIGATORIO);
            _validar.addValidacao(cboEndUF, clnUtilFormValidar.Validacao.OBRIGATORIO);

            mtbCPF.Mask = UtilMask.MASK_CPF;
            mtbDataNasc.Mask = UtilMask.MASK_DATA;
            cboGenero.addRange(new String[] { "M", "F" });
            mtbTelCel.Mask = UtilMask.MASK_CEL;
            mtbTelRes.Mask = UtilMask.MASK_TEL;
            mtbEndCEP.Mask = UtilMask.MASK_CEP;
        }

        private void salvar()
        {
            if (_validar.validar(this))
            {
                int codCargo = cboCargo.SelectedItem.Id;
                clnArquivo objArquivo = null;
                if (ObjFuncionario != null)
                {
                    clnArquivo objArquivoAtual = new clnArquivo
                    {
                        Cod = ObjFuncionario.CodFoto
                    }.obterPorCod();
                    if (!objArquivoAtual.Local.Equals(picImagem.ImageLocation))
                    {
                        objArquivo = new clnArquivo
                        {
                            Local = picImagem.ImageLocation
                        };
                        objArquivo.gravar();
                    }
                    else
                    {
                        objArquivo = objArquivoAtual;
                    }
                }
                else
                {
                    objArquivo = new clnArquivo
                    {
                        Local = picImagem.ImageLocation
                    };
                    objArquivo.gravar();
                }

                if (ObjFuncionario == null)
                {
                    clnFuncionario objFuncionarioCpf = new clnFuncionario
                    {
                        Cpf = UtilFormatar.retirarFormatacao(mtbCPF.Text)
                    }.obterPorCPF();

                    if (objFuncionarioCpf == null)
                    {
                        clnFuncionario objFuncionario = new clnFuncionario
                        {
                            CodCargo = codCargo,
                            CodFoto = objArquivo.Cod,
                            Nome = txtNome.Text,
                            Cpf = UtilFormatar.retirarFormatacao(mtbCPF.Text),
                            Rg = txtRG.Text,
                            Genero = cboGenero.Text,
                            DataNascimento = UtilConvert.ObterData(mtbDataNasc.Text),
                            TelRes = UtilFormatar.retirarFormatacao(mtbTelRes.Text),
                            TelCel = UtilFormatar.retirarFormatacao(mtbTelCel.Text),
                            Email = txtEmail.Text,
                            Salario = UtilConvert.ToDecimal(txtSalario.Text),
                            DataContratacao = DateTime.Now,
                            Situacao = (clnFuncionario.funcionarioSituacao)Enum.Parse(typeof(clnFuncionario.funcionarioSituacao), cboSituacao.Text),
                            EndCEP = UtilFormatar.retirarFormatacao(mtbEndCEP.Text),
                            EndLogradouro = txtEndLogradouro.Text,
                            EndNumero = txtEndNr.Text,
                            EndComplemento = txtEndComplemento.Text,
                            EndBairro = txtEndBairro.Text,
                            EndLocalidade = txtEndCidade.Text,
                            EndUF = cboEndUF.Text
                        };
                        objFuncionario.gravar();
                        ObjFuncionario = objFuncionario;

                        UtilMensagem.mostrarOk("Cadastro de Funcionário", "Funcionário cadastrado com sucesso!");
                        Close();
                    }
                    else
                    {
                        UtilMensagem.mostrarOk("Cadastro de Funcionário", "Não foi possível cadastrar o funcionário, o CPF já está cadastrado!");
                        mtbCPF.Focus();
                    }
                }
                else
                {
                    ObjFuncionario.Nome = txtNome.Text;
                    ObjFuncionario.CodCargo = codCargo;
                    ObjFuncionario.CodFoto = objArquivo.Cod;
                    ObjFuncionario.DataNascimento = UtilConvert.ObterData(mtbDataNasc.Text);
                    ObjFuncionario.Email = txtEmail.Text;
                    ObjFuncionario.Genero = cboGenero.Text;
                    ObjFuncionario.TelRes = UtilFormatar.retirarFormatacao(mtbTelRes.Text);
                    ObjFuncionario.TelCel = UtilFormatar.retirarFormatacao(mtbTelCel.Text);
                    ObjFuncionario.Salario = UtilConvert.ToDecimal(txtSalario.Text);
                    ObjFuncionario.Situacao = (clnFuncionario.funcionarioSituacao)Enum.Parse(typeof(clnFuncionario.funcionarioSituacao), cboSituacao.Text);
                    ObjFuncionario.EndCEP = UtilFormatar.retirarFormatacao(mtbEndCEP.Text);
                    ObjFuncionario.EndLogradouro = txtEndLogradouro.Text;
                    ObjFuncionario.EndNumero = txtEndNr.Text;
                    ObjFuncionario.EndComplemento = txtEndComplemento.Text;
                    ObjFuncionario.EndBairro = txtEndBairro.Text;
                    ObjFuncionario.EndLocalidade = txtEndCidade.Text;
                    ObjFuncionario.EndUF = cboEndUF.Text;
                    ObjFuncionario.alterar();

                    UtilMensagem.mostrarOk("Alteração de Funcionário", "Funcionário alterado com sucesso!");
                    Close();
                }
            }
        }

        private void fechar()
        {

            if (ObjFuncionario == null)
            {
                if (UtilMensagem.mostrarSimNao("Cadastro de Funcionário", "Deseja cancelar o cadastro?", UtilMensagem.MensagemIcone.ERRO))
                {
                    Close();
                }
            }
            else
            {
                if (btnAlterar.Description.Equals("Salvar", StringComparison.InvariantCultureIgnoreCase))
                {
                    if (UtilMensagem.mostrarSimNao("Alteração de Funcionário", "Deseja cancelar as alterações?", UtilMensagem.MensagemIcone.ERRO))
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

        private void desativar()
        {
            UtilButton.restaurar(btnExcluir);
            UtilForm.Disable(this);
            grbImagem.Visible = false;
        }

        private void excluir()
        {
            if (UtilMensagem.mostrarSimNao("Funcionário", "Você deseja realmente excluir este funcionário?", UtilMensagem.MensagemIcone.ERRO))
            {
                ObjFuncionario.Ativo = false;
                ObjFuncionario.alterar();

                clnAcesso objAcesso = new clnAcesso
                {
                    CodFuncionario = ObjFuncionario.Cod,
                    Ativo = false
                };
                objAcesso.alterarEstado();

                btnAlterar.Hide();
                desativar();

                UtilMensagem.mostrarOk("Funcionário", "Funcionário excluido com sucesso.");
                Close();
            }
        }

        private void restaurar()
        {
            if (UtilMensagem.mostrarSimNao("Funcionário", "Você deseja realmente restaurar este funcionário?", UtilMensagem.MensagemIcone.OK))
            {
                ObjFuncionario.Ativo = true;
                ObjFuncionario.alterar();

                clnAcesso objAcesso = new clnAcesso
                {
                    CodFuncionario = ObjFuncionario.Cod,
                    Ativo = true
                };
                objAcesso.alterarEstado();
                
                btnAlterar.Show();
                UtilButton.excluir(btnExcluir);

                UtilMensagem.mostrarOk("Funcionário", "Funcionário restaurado com sucesso.");
                Close();
            }
        }

        private void definirImagemPadrao()
        {
            picImagem.ImageLocation = clnArquivo.tempImage(global::BurgerShack.Desktop.Properties.Resources.imagem);
        }

        private void adicionarImagem()
        {
            OpenFileDialog objDialog = new OpenFileDialog
            {
                Filter = "png|*.png|jpg|*.jpg"
            };
            if (objDialog.ShowDialog() == DialogResult.OK)
            {
                picImagem.ImageLocation = objDialog.FileName;
            }
        }

        private void abrirAcesso()
        {
            frmConfirmar frmConfirmar = new frmConfirmar();
            frmConfirmar.ShowDialog();

            if (frmConfirmar.Confirmado)
            {
                clnAcesso objAcesso = new clnAcesso
                {
                    CodFuncionario = ObjFuncionario.Cod
                }.obterPorFuncionario();

                if (objAcesso == null)
                {
                    objAcesso = new clnAcesso
                    {
                        CodFuncionario = ObjFuncionario.Cod
                    };
                }
                frmAcesso frmAcesso = new frmAcesso
                {
                    ObjAcesso = objAcesso
                };
                frmAcesso.ShowDialog();
            }
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            clnUtil.atualizarForm(this);
            uixButton.btnApply(btnVoltar, AppDesktop.VisualStyle.ButtonWarningColor);

            clnUtil.definirCEP(mtbEndCEP, txtEndLogradouro, txtEndBairro, txtEndCidade, cboEndUF.cbo, txtEndNr, txtEndComplemento);

            foreach (clnCargo objCargo in new clnCargo().obterCargos())
            {
                cboCargo.add(objCargo.Cod, objCargo.Cod + " - " + objCargo.Nome);
            }
            cboSituacao.addRange(new object[] { clnFuncionario.funcionarioSituacao.TREINAMENTO, clnFuncionario.funcionarioSituacao.PLENO });

            if (ObjFuncionario == null)
            {
                hdrUIX.Title = App.Name + " - Novo Funcionário";

                definirImagemPadrao();

                if (PrimeiroCadastro)
                {
                    btnAcesso.Visible = false;
                    btnVoltar.Visible = false;

                    cboCargo.SelectedItem = cboCargo.Items.Last();
                    cboSituacao.SelectedItem = cboSituacao.Items.Last();
                }
            }
            else
            {
                hdrUIX.Title = App.Name + " - Funcionário " + ObjFuncionario.Cod;

                txtNome.Text = ObjFuncionario.Nome;
                mtbCPF.Text = ObjFuncionario.Cpf;
                txtRG.Text = ObjFuncionario.Rg;
                mtbDataNasc.Text = UtilFormatar.formatarData(ObjFuncionario.DataNascimento);
                cboGenero.Text = UtilConvert.ToString(ObjFuncionario.Genero);
                txtEmail.Text = ObjFuncionario.Email;
                mtbTelCel.Text = ObjFuncionario.TelCel;
                mtbTelRes.Text = ObjFuncionario.TelRes;

                txtSalario.Text = UtilConvert.ToString(ObjFuncionario.Salario);
                cboSituacao.Text = UtilConvert.ToString(ObjFuncionario.Situacao);

                mtbEndCEP.Text = ObjFuncionario.EndCEP;
                txtEndLogradouro.Text = ObjFuncionario.EndLogradouro;
                txtEndNr.Text = ObjFuncionario.EndNumero;
                txtEndComplemento.Text = ObjFuncionario.EndComplemento;
                txtEndBairro.Text = ObjFuncionario.EndBairro;
                txtEndCidade.Text = ObjFuncionario.EndLocalidade;
                cboEndUF.Text = ObjFuncionario.EndUF;

                clnCargo objCargo = new clnCargo
                {
                    Cod = ObjFuncionario.CodCargo
                }.obterPorCod();
                cboCargo.Text = objCargo.Cod + " - " + objCargo.Nome;

                clnArquivo objFoto = new clnArquivo
                {
                    Cod = ObjFuncionario.CodFoto
                }.obterPorCod();
                picImagem.ImageLocation = objFoto.Local;

                desativar();

                if (AppDesktop.FuncionarioAtual.CodCargo >= 3)
                {
                    btnExcluir.Show();
                    UtilButton.alterar(btnAlterar);
                    UtilButton.voltar(btnVoltar);
                    if (ObjFuncionario.Ativo)
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

            txtNome.Focus();
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

                mtbCPF.Enabled = false;
                grbImagem.Show();
                btnAcesso.Show();

                UtilButton.cancelar(btnVoltar);
                UtilButton.salvar(btnAlterar);
            }
        }

        private void hdrUIX_Close(object sender, EventArgs e)
        {
            fechar();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            fechar();
        }

        private void btnImgAdicionar_Click(object sender, EventArgs e)
        {
            adicionarImagem();
        }

        private void btnImgRemover_Click(object sender, EventArgs e)
        {
            if (UtilMensagem.mostrarSimNao("Imagem", "Deseja realmente remover a imagem?", UtilMensagem.MensagemIcone.INFO))
            {
                definirImagemPadrao();
            }
        }

        private void btnAcesso_Click(object sender, EventArgs e)
        {
            abrirAcesso();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (ObjFuncionario.Ativo)
            {
                excluir();
            }
            else
            {
                restaurar();
            }
            UtilButton.voltar(btnVoltar);
        }
    }
}
