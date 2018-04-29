using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BURGUER_SHACK_DESKTOP
{
    public partial class uctGerenFuncionario : UserControl
    {
        public uctGerenFuncionario()
        {
            InitializeComponent();
        }

        private void mtbEndCEP_Validated(object sender, EventArgs e)
        {
            if (clnUtil.validarCEP(mtbEndCEP.Text))
            {
                clnUtil.definirEndereco(mtbEndCEP.Text, txtEndLogradouro, txtEndBairro, txtEndCidade, cboEndUF, txtEndNr);
            }
        }
    }
}
