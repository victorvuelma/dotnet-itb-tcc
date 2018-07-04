﻿using BURGUERSHACK_COMMON;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace BURGUERSHACK_DESKTOP
{
    class clnUtilFormValidar
    {

        public enum ValidarTipo
        {
            OBRIGATORIO,
            EMAIL,
            CPF,
            CNPJ,
            CEP,
            INT,
            INT_MAIOR_0,
            DOUBLE,
            VALOR,
            DATA,
            DATA_NASC,
            DATA_FUTURA,
            HORA,
            CELULAR,
            TELEFONE
        }

        private List<ValidarData> _validarControles = new List<ValidarData>();

        public void addValidacao(Control control, ValidarTipo tipo)
        {
            addValidacao(control, new ValidarTipo[] { tipo });
        }

        public void addValidacao(Control control, ValidarTipo[] tipos)
        {
            if (control is UIX.cboUIX cbo)
            {
                control = cbo.cbo;
            }
            else if (control is UIX.mtbUIX mtb)
            {
                control = mtb.mtb;
            }
            else if (control is UIX.txtUIX txt)
            {
                control = txt.txt;
            }

            ValidarData data = null;
            foreach (ValidarData dt in _validarControles)
            {
                if (dt.Control.Equals(control))
                {
                    data = dt;
                    break;
                }
            }
            if (data == null)
            {
                data = new ValidarData(control);
                _validarControles.Add(data);
            }

            data.addValidacoes(tipos);
        }

        public bool valido()
        {
            bool formValido = true;

            StringBuilder motivoBuilder = new StringBuilder();
            foreach (ValidarData controlValidar in _validarControles)
            {
                bool controlValido = controlValidar.validar();
                controlValidar.formatar(controlValido);

                String motivoControl = controlValidar.Motivo;
                if (motivoControl.Length > 0)
                {
                    motivoBuilder.Append(controlValidar.Control.AccessibleName.Replace("*", "")).Append(' ').Append(motivoControl).Append('\n');
                }
                if (formValido && !controlValido)
                {
                    formValido = false;
                    controlValidar.Control.Focus();
                }
            }

            if (!formValido)
            {
                clnUtilMensagem.mostrarOk("Verifique as informações", motivoBuilder.ToString(), clnUtilMensagem.MensagemIcone.ERRO);
            }

            return formValido;
        }

        class ValidarData
        {

            private Control _control;
            private List<ValidarTipo> _validacoes;

            private String _motivo;

            public Control Control { get => _control; }
            public String Motivo { get => _motivo; }

            public ValidarData(Control control)
            {
                _control = control;
                _validacoes = new List<ValidarTipo>();

                _motivo = "";
            }

            public void addValidacoes(ValidarTipo[] tiposValidacao)
            {
                foreach (ValidarTipo tipoValidacao in tiposValidacao)
                {
                    addValidacao(tipoValidacao);
                }
            }

            public void addValidacao(ValidarTipo validacao)
            {
                _validacoes.Add(validacao);
            }

            public bool validar()
            {
                if (!Control.Visible || !Control.Enabled)
                {
                    return true;
                }
                String conteudo = clnUtil.obterConteudo(Control);
                if (!_validacoes.Contains(ValidarTipo.OBRIGATORIO) && clnUtilValidar.vazio(conteudo))
                {
                    return true;
                }

                bool valido = true;
                _motivo = "";
                conteudo = Control.Text;
                foreach (ValidarTipo tipo in _validacoes)
                {
                    bool val = true;
                    String res = "";
                    switch (tipo)
                    {
                        case ValidarTipo.OBRIGATORIO:
                            val = !clnUtilValidar.vazio(conteudo);
                            res = "precisa ser preenchido.";
                            break;
                        case ValidarTipo.EMAIL:
                            val = clnUtilValidar.validarEmail(conteudo);
                            res = "deve conter um e-mail válido.";
                            break;
                        case ValidarTipo.CPF:
                            val = clnUtilValidar.validarCPF(conteudo);
                            res = "deve conter um CPF válido.";
                            break;
                        case ValidarTipo.CNPJ:
                            val = clnUtilValidar.validarCNPJ(conteudo);
                            res = "deve conter um CNPJ válido.";
                            break;
                        case ValidarTipo.CEP:
                            val = clnUtilValidar.validarCEP(conteudo);
                            res = "deve conter um CEP válido.";
                            break;
                        case ValidarTipo.INT:
                            val = clnUtilValidar.validarInt(conteudo);
                            res = "deve conter um número inteiro.";
                            break;
                        case ValidarTipo.INT_MAIOR_0:
                            val = clnUtilConvert.ToInt(conteudo) > 0;
                            res = "deve conter um número maior que ZERO.";
                            break;
                        case ValidarTipo.DATA:
                            val = clnUtilValidar.validarData(conteudo);
                            res = "deve conter uma data válida";
                            break;
                        case ValidarTipo.DATA_NASC:
                            val = clnUtilValidar.validarDataNasc(conteudo);
                            res = "deve conter uma data da nascimento.";
                            break;
                        case ValidarTipo.CELULAR:
                            val = clnUtilValidar.validarCelular(conteudo);
                            res = "deve conter um número de celular válido.";
                            break;
                        case ValidarTipo.TELEFONE:
                            val = clnUtilValidar.validarTelefone(conteudo);
                            res = "deve conter um número de telefone válido.";
                            break;
                        case ValidarTipo.DATA_FUTURA:
                            val = clnUtilValidar.validarDataFutura(conteudo);
                            res = "deve conter uma data futura.";
                            break;
                        case ValidarTipo.HORA:
                            val = clnUtilValidar.validarHora(conteudo);
                            res = "deve conter uma hora válida.";
                            break;
                        case ValidarTipo.VALOR:
                            val = clnUtilValidar.validarValor(conteudo);
                            res = "deve conter um valor válido.";
                            break;
                        case ValidarTipo.DOUBLE:
                            val = clnUtilValidar.validarDouble(conteudo);
                            res = "deve conter um número decimal válido.";
                            break;
                    }
                    if (!val)
                    {
                        valido = false;
                        _motivo = res;
                        break;
                    }
                }

                return valido;
            }

            public void formatar(bool valido)
            {
                if (!valido)
                {
                    if (Control is TextBoxBase txt)
                    {
                        UIX.uixTextBox.txtApply(txt, AppDesktop.VisualStyle.BoxWarningColor);
                    } else if (Control is ComboBox cbo)
                    {
                        UIX.uixComboBox.cboApply(cbo, AppDesktop.VisualStyle.BoxWarningColor);
                    }
                }
                else
                {
                    if (Control is TextBoxBase txt)
                    {
                        UIX.uixTextBox.txtApply(txt, AppDesktop.VisualStyle.BoxColor);
                    }
                    else if (Control is ComboBox cbo)
                    {
                        UIX.uixComboBox.cboApply(cbo, AppDesktop.VisualStyle.BoxColor);
                    }
                }
            }

        }

    }
}