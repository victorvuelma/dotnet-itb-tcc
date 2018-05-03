using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace BURGUER_SHACK_DESKTOP
{
    class clnValidar
    {

        public enum ValidarTipo
        {
            VAZIO,
            EMAIL,
            CPF,
            CNPJ,
            CEP
        }

        private List<ValidarData> _controlValidar = new List<ValidarData>();
        private string _motivo = "";

        public void addValidacao(Control control, ValidarTipo tipo)
        {
            addValidacao(control, new ValidarTipo[] { tipo });
        }

        public void addValidacao(Control control, ValidarTipo[] tipos)
        {
            ValidarData data = null;
            foreach (ValidarData dt in _controlValidar)
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
                _controlValidar.Add(data);
            }

            data.addValidacoes(tipos);
        }

        public bool valido()
        {
            bool formValido = true;
            _motivo = "";

            foreach (ValidarData controlValidar in _controlValidar)
            {
                bool controlValido = controlValidar.validar();

                string controlMotivo = controlValidar.Motivo;
                if (controlMotivo.Length > 0)
                {
                    _motivo += controlValidar.Control.AccessibleName + " " + controlMotivo;
                    _motivo += "\n";
                }

                if (formValido && !controlValido)
                {
                    formValido = false;
                    controlValidar.Control.Focus();
                }
            }

            if (!formValido)
            {
                clnMensagem.mostrarOk("Verifique as informações", Motivo, clnMensagem.MensagemIcone.ERRO);
            }

            return formValido;
        }

        public string Motivo { get => _motivo; }

        class ValidarData
        {

            private Control _control;
            private List<ValidarTipo> _validacoes;

            private string _motivo;

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
                    string res = "";
                    switch (tipo)
                    {
                        case ValidarTipo.VAZIO:
                            val = !String.IsNullOrWhiteSpace(conteudo);
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
                    if (_control is UIX.txtUIX)
                    {
                        UIX.txtUIX txt = (UIX.txtUIX)_control;
                        UIX.uixTextBox.txtApply(txt.txt, UIX.uixSet.RED);
                    }
                }
                else
                {
                    if (_control is UIX.txtUIX)
                    {
                        UIX.txtUIX txt = (UIX.txtUIX)_control;
                        UIX.uixTextBox.txtApply(txt.txt, clnApp.AppVisualStyle.TextBoxColor);
                    }
                }

                return valido;
            }

            public Control Control { get => _control; }
            public string Motivo { get => _motivo; }
        }

    }
}
