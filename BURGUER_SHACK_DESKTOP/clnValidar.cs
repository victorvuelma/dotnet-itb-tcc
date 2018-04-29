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

        private List<ValidarData> controlValidar = new List<ValidarData>();

        public void addValidacao(Control control, int[] tipos)
        {
            ValidarData data = null;
            foreach (ValidarData dt in controlValidar)
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
                controlValidar.Add(data);
            }

            data.addValidacoes(tipos);
        }

        public bool validar()
        {
            bool formValido = true;

            foreach (ValidarData controlValidar in controlValidar)
            {
                bool controlValido = controlValidar.validar();
                if (formValido && !controlValido)
                {
                    formValido = false;
                }
            }

            return formValido;
        }

        class ValidarData
        {

            private Control _control;
            private List<int> _validacoes;

            public ValidarData(Control control)
            {
                _control = control;
                _validacoes = new List<int>();
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

                String conteudo = _control.Text;

                foreach (int validador in _validacoes)
                {
                    bool res = true;
                    switch (validador)
                    {
                        case 1:
                            res = !String.IsNullOrWhiteSpace(conteudo);
                            break;
                    }
                    if (!res)
                    {
                        valido = false;
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
                } else
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

        }

    }
}
