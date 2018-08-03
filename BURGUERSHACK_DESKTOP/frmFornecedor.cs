﻿using BURGERSHACK_COMMON;
using BURGERSHACK_COMMON.UTIL;
using BURGERSHACK_DESKTOP.UTIL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using vitorrdgs.UiX.Manager;

namespace BURGERSHACK_DESKTOP
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

            mtbCNPJ.Mask = clnUtil.MASK_CNPJ;
            mtbTel.Mask = clnUtil.MASK_TEL;
            mtbEndCEP.Mask = clnUtil.MASK_CEP;
        }

        private void salvar()
        {
            if (_validar.validar(this))
            {
                if (ObjFornecedor == null)
                {
                    clnFornecedor objFornecedorCNPJ = new clnFornecedor
                    {
                        Cnpj = clnUtilFormatar.retirarFormatacao(mtbCNPJ.Text)
                    }.obterPorCNPJ();

                    if (objFornecedorCNPJ == null)
                    {
                        clnFornecedor objFornecedor = new clnFornecedor
                        {
                            RazaoSocial = txtRazaoSocial.Text,
                            Cnpj = clnUtilFormatar.retirarFormatacao(mtbCNPJ.Text),
                            Telefone = clnUtilFormatar.retirarFormatacao(mtbTel.Text),
                            Email = txtEmail.Text,
                            EndCEP = clnUtilFormatar.retirarFormatacao(mtbEndCEP.Text),
                            EndLogradouro = txtEndLogradouro.Text,
                            EndNumero = txtEndNr.Text,
                            EndComplemento = txtEndComplemento.Text,
                            EndBairro = txtEndBairro.Text,
                            EndLocalidade = txtEndCidade.Text,
                            EndUF = cboEndUF.Text
                        };
                        objFornecedor.gravar();
                        ObjFornecedor = objFornecedor;
                        clnUtilMensagem.mostrarOk("Cadastro de Fornecedor", "Fornecedor cadastrado com sucesso!");
                        Close();
                    }
                    else
                    {
                        clnUtilMensagem.mostrarOk("Cadastro de Fornecedor", "Não foi possível cadastrar o fornecedor, o CNPJ já está cadastrado!");
                        mtbCNPJ.Focus();
                    }
                }
                else
                {
                    ObjFornecedor.RazaoSocial = txtRazaoSocial.Text;
                    ObjFornecedor.Email = txtEmail.Text;
                    ObjFornecedor.Telefone = clnUtilFormatar.retirarFormatacao(mtbTel.Text);
                    ObjFornecedor.EndCEP = clnUtilFormatar.retirarFormatacao(mtbEndCEP.Text);
                    ObjFornecedor.EndLogradouro = txtEndLogradouro.Text;
                    ObjFornecedor.EndNumero = txtEndNr.Text;
                    ObjFornecedor.EndComplemento = txtEndComplemento.Text;
                    ObjFornecedor.EndBairro = txtEndBairro.Text;
                    ObjFornecedor.EndLocalidade = txtEndCidade.Text;
                    ObjFornecedor.EndUF = cboEndUF.Text;
                    ObjFornecedor.alterar();
                    clnUtilMensagem.mostrarOk("Alteração de Fornecedor", "Fornecedor alterado com sucesso!");
                    Close();
                }
            }
        }

        private void fechar()
        {
            if (ObjFornecedor == null)
            {
                if (clnUtilMensagem.mostrarSimNao("Cadastro de Fornecedor", "Deseja cancelar o cadastro?", clnUtilMensagem.MensagemIcone.ERRO))
                {
                    Close();
                }
            }
            else
            {
                if (clnUtilMensagem.mostrarSimNao("Alteração de Fornecedor", "Deseja cancelar as alterações?", clnUtilMensagem.MensagemIcone.ERRO))
                {
                    Close();
                }
            }
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            clnUtil.atualizarForm(this);
            uixButton.btnApply(btnCancelar, AppDesktop.VisualStyle.ButtonWarningColor);

            clnUtil.definirCEP(mtbEndCEP, txtEndLogradouro, txtEndBairro, txtEndCidade, cboEndUF.cbo, txtEndNr, txtEndComplemento);

            if (ObjFornecedor == null)
            {
                hdrUIX.Title = App.Name + " - Novo Fornecedor";
            }
            else
            {
                hdrUIX.Title = App.Name + " - Alterando Fornecedor " + ObjFornecedor.Cod;
                mtbCNPJ.Enabled = false;

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
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            salvar();
        }

        private void hdrUIX_Close(object sender, EventArgs e)
        {
            fechar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            fechar();
        }

    }
}
