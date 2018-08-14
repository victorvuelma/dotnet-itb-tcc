using BurgerShack.Common.UTIL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using vitorrdgs.UiX.Component;
using vitorrdgs.UiX.Manager;
using static System.Windows.Forms.Control;

namespace BurgerShack.Desktop.UTIL
{
    class clnUtilFormValidar
    {

        public enum Validacao
        {
            OBRIGATORIO,
            EMAIL,
            CPF,
            CNPJ,
            CEP,
            INT,
            QUANTIDADE,
            DOUBLE,
            VALOR,
            DATA,
            DATA_NASC,
            DATA_FUTURA,
            HORA,
            CELULAR,
            TELEFONE
        }

        private Dictionary<string, ValidarData> _controleValidacoes = new Dictionary<string, ValidarData>();

        public void addValidacao(Control control, Validacao validacao)
        {
            addValidacao(control, new Validacao[] { validacao });
        }

        public void addValidacao(Control control, Validacao[] validacoes)
        {
            if (control is UIXComboBox cbo)
            {
                control = cbo.cbo;
            }
            else if (control is vitorrdgs.UiX.Component.UIXMaskedTextBox mtb)
            {
                control = mtb.mtb;
            }
            else if (control is UIXTextBox txt)
            {
                control = txt.txt;
            }

            if (!_controleValidacoes.TryGetValue(control.Name, out ValidarData data))
            {
                data = new ValidarData();
                _controleValidacoes.Add(control.Name, data);
            }
            data.addValidacoes(validacoes);
        }

        public bool validar(Form form)
        {
            StringBuilder motivoBuilder = new StringBuilder();
            bool frmValido = validarControls(form.Controls, motivoBuilder);

            if (!frmValido)
            {
                clnUtilMensagem.mostrarOk("Verifique as informações", motivoBuilder.ToString());
            }

            return frmValido;
        }

        public bool validar(UserControl uct)
        {
            StringBuilder motivoBuilder = new StringBuilder();
            bool uctValido = validarControls(uct.Controls, motivoBuilder);

            if (!uctValido)
            {
                clnUtilMensagem.mostrarOk("Verifique as informações", motivoBuilder.ToString());
            }

            return uctValido;
        }

        private bool validarControls(ControlCollection controls, StringBuilder motivoBuilder)
        {
            bool valido = true;
            foreach (Control control in controls)
            {
                bool controlValido = true;
                if (control is TextBoxBase || control is ComboBox)
                {
                    if (_controleValidacoes.TryGetValue(control.Name, out ValidarData validar))
                    {
                        controlValido = validar.validar(control);
                        validar.formatar(control, controlValido);

                        String motivoControl = validar.Motivo;
                        if (motivoControl.Length > 0)
                        {
                            if (motivoBuilder.Length > 0)
                            {
                                motivoBuilder.Append('\r').Append('\n');
                            }
                            motivoBuilder.Append(control.AccessibleName.Replace("*", "")).Append(' ').Append(motivoControl);
                        }
                    }
                }
                else
                {
                    bool controlsValidos = validarControls(control.Controls, motivoBuilder);
                    if (controlValido && !controlsValidos)
                    {
                        controlValido = false;
                    }
                }

                if (valido && !controlValido)
                {
                    valido = false;
                    control.Focus();
                }
            }

            return valido;
        }

        class ValidarData
        {

            private List<Validacao> _validacoes;

            private String _motivo;

            public String Motivo { get => _motivo; }

            public ValidarData()
            {
                _validacoes = new List<Validacao>();

                _motivo = "";
            }

            public void addValidacoes(Validacao[] tiposValidacao)
            {
                foreach (Validacao tipoValidacao in tiposValidacao)
                {
                    addValidacao(tipoValidacao);
                }
            }

            public void addValidacao(Validacao validacao)
            {
                _validacoes.Add(validacao);
            }

            public bool validar(Control control)
            {
                if (!control.Visible || !control.Enabled)
                {
                    return true;
                }
                String conteudo = clnUtil.obterConteudo(control);
                if (!_validacoes.Contains(Validacao.OBRIGATORIO) && clnUtilValidar.vazio(conteudo))
                {
                    return true;
                }

                bool valido = true;
                _motivo = "";
                conteudo = control.Text;
                foreach (Validacao tipo in _validacoes)
                {
                    bool val = true;
                    String res = "";
                    switch (tipo)
                    {
                        case Validacao.OBRIGATORIO:
                            val = !clnUtilValidar.vazio(conteudo);
                            res = "precisa ser preenchido.";
                            break;
                        case Validacao.EMAIL:
                            val = clnUtilValidar.validarEmail(conteudo);
                            res = "deve conter um e-mail válido.";
                            break;
                        case Validacao.CPF:
                            val = clnUtilValidar.validarCPF(conteudo);
                            res = "deve conter um CPF válido.";
                            break;
                        case Validacao.CNPJ:
                            val = clnUtilValidar.validarCNPJ(conteudo);
                            res = "deve conter um CNPJ válido.";
                            break;
                        case Validacao.CEP:
                            val = clnUtilValidar.validarCEP(conteudo);
                            res = "deve conter um CEP válido.";
                            break;
                        case Validacao.INT:
                            val = clnUtilValidar.validarInt(conteudo);
                            res = "deve conter um número inteiro.";
                            break;
                        case Validacao.QUANTIDADE:
                            val = clnUtilConvert.ToInt(conteudo) > 0;
                            res = "deve conter um número maior que ZERO.";
                            break;
                        case Validacao.DATA:
                            val = clnUtilValidar.validarData(conteudo);
                            res = "deve conter uma data válida";
                            break;
                        case Validacao.DATA_NASC:
                            val = clnUtilValidar.validarDataNasc(conteudo);
                            res = "deve conter uma data da nascimento.";
                            break;
                        case Validacao.CELULAR:
                            val = clnUtilValidar.validarCelular(conteudo);
                            res = "deve conter um número de celular válido.";
                            break;
                        case Validacao.TELEFONE:
                            val = clnUtilValidar.validarTelefone(conteudo);
                            res = "deve conter um número de telefone válido.";
                            break;
                        case Validacao.DATA_FUTURA:
                            val = clnUtilValidar.validarDataFutura(conteudo);
                            res = "deve conter uma data futura.";
                            break;
                        case Validacao.HORA:
                            val = clnUtilValidar.validarHora(conteudo);
                            res = "deve conter uma hora válida.";
                            break;
                        case Validacao.VALOR:
                            val = clnUtilValidar.validarValor(conteudo);
                            res = "deve conter um valor válido.";
                            break;
                        case Validacao.DOUBLE:
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

            public void formatar(Control control, bool valido)
            {
                if (!valido)
                {
                    if (control is TextBoxBase txt)
                    {
                        uixTextBox.txtApply(txt, AppDesktop.VisualStyle.BoxWarningColor);
                    }
                    else if (control is ComboBox cbo)
                    {
                        uixComboBox.cboApply(cbo, AppDesktop.VisualStyle.BoxWarningColor);
                    }
                }
                else
                {
                    if (control is TextBoxBase txt)
                    {
                        uixTextBox.txtApply(txt, AppDesktop.VisualStyle.BoxColor);
                    }
                    else if (control is ComboBox cbo)
                    {
                        uixComboBox.cboApply(cbo, AppDesktop.VisualStyle.BoxColor);
                    }
                }
            }

        }

    }
}
