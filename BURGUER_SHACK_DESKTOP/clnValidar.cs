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
                //TODO: VALIDAR EFETIVAMENTE.
                return false;
            }

            public Control Control { get => _control; }

        }

    }
}
