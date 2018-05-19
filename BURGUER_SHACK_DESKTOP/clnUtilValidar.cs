using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace BURGUER_SHACK_DESKTOP
{
    class clnUtilValidar
    {

        public enum ValidarTipo
        {
            VAZIO,
            EMAIL,
            CPF,
            CNPJ,
            CEP,
            INT
        }

        private List<ValidarData> _validarControles = new List<ValidarData>();

        public void addValidacao(Control control, ValidarTipo tipo)
        {
            addValidacao(control, new ValidarTipo[] { tipo });
        }

        public void addValidacao(Control control, ValidarTipo[] tipos)
        {
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

                String motivoControl = controlValidar.Motivo;
                if (motivoControl.Length > 0)
                {
                    motivoBuilder.Append(controlValidar.Control.AccessibleName).Append(' ').Append(motivoControl).Append('\n');
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
                bool valido = true;
                _motivo = "";

                String conteudo = _control.Text;
                foreach (ValidarTipo tipo in _validacoes)
                {
                    bool val = true;
                    String res = "";
                    switch (tipo)
                    {
                        case ValidarTipo.VAZIO:
                            val = !clnUtil.vazio(conteudo);
                            res = "precisa ser preenchido.";
                            break;
                        case ValidarTipo.EMAIL:
                            val = clnUtil.validarEmail(conteudo);
                            res = "deve conter um e-mail válido.";
                            break;
                        case ValidarTipo.CPF:
                            val = clnUtil.validarCPF(conteudo);
                            res = "deve conter CPF válido.";
                            break;
                        case ValidarTipo.CNPJ:
                            val = clnUtil.validarCNPJ(conteudo);
                            res = "deve conter CNPJ válido.";
                            break;
                        case ValidarTipo.CEP:
                            val = clnUtil.validarCEP(conteudo);
                            res = "deve conter CEP válido.";
                            break;
                        case ValidarTipo.INT:
                            val = clnUtil.validarInt(conteudo);
                            res = "deve conter um número inteiro.";
                            break;
                    }
                    if (!val)
                    {
                        valido = false;
                        _motivo = res;
                        break;
                    }
                }


                if (!valido)
                {
                    if (_control is UIX.txtUIX txt)
                    {
                        UIX.uixTextBox.txtApply(txt.txt, App.AppVisualStyle.TextBoxWarningColor);
                    }
                }
                else
                {
                    if (_control is UIX.txtUIX txt)
                    {
                        UIX.uixTextBox.txtApply(txt.txt, App.AppVisualStyle.TextBoxColor);
                    }
                }

                return valido;
            }

        }

    }
}
