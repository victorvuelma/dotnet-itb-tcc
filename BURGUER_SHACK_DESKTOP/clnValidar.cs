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

        public static int VAZIO = 1;

        public static int EMAIL = 10;
        public static int CPF = 11;
        public static int CNPJ = 12;
        public static int CEP = 13;

        private List<ValidarData> _controlValidar = new List<ValidarData>();
        private string _motivo = "";

        public void addValidacao(Control control, int tipo)
        {
            addValidacao(control, new int[] { tipo });
        }

        public void addValidacao(Control control, int[] tipos)
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
                clnMensagem.mostrarOk("Verifique as informações", Motivo, clnMensagem.MSG_ERRO);
            }

            return formValido;
        }

        public string Motivo { get => _motivo; }

        class ValidarData
        {

            private Control _control;
            private List<int> _validacoes;

            private string _motivo;

            public ValidarData(Control control)
            {
                _control = control;
                _validacoes = new List<int>();

                _motivo = "";
            }

            public void addValidacoes(int[] validacoes)
            {
                foreach (int validacao in validacoes)
                {
                    addValidacao(validacao);
                }
            }

            public void addValidacao(int validacao)
            {
                _validacoes.Add(validacao);
            }

            public bool validar()
            {
                bool valido = true;
                _motivo = "";

                String conteudo = _control.Text;

                foreach (int validador in _validacoes)
                {
                    bool val = true;
                    string res = "";
                    switch (validador)
                    {
                        case 1:
                            val = !String.IsNullOrWhiteSpace(conteudo);
                            res = "precisa ser preenchido.";
                            break;
                        case 10:
                            val = clnUtil.validarEmail(conteudo);
                            res = "deve conter um e-mail válido.";
                            break;
                        case 11:
                            val = clnUtil.validarCPF(conteudo);
                            res = "deve conter CPF válido.";
                            break;
                        case 12:
                            val = clnUtil.validarCNPJ(conteudo);
                            res = "deve conter CNPJ válido.";
                            break;
                        case 13:
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
                        UIX.uixTextBox.txtApply(txt.box, UIX.uixSet.RED);
                    }
                }
                else
                {
                    if (_control is UIX.txtUIX)
                    {
                        UIX.txtUIX txt = (UIX.txtUIX)_control;
                        UIX.uixTextBox.txtApply(txt.box, clnTemplate.CommonTemplate.Style.TextBoxColor);
                    }
                }

                return valido;
            }

            public Control Control { get => _control; }
            public string Motivo { get => _motivo; }
        }

    }
}
