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
    public partial class uctGerenTerceirizada : UserControl
    {
        public uctGerenTerceirizada()
        {
            InitializeComponent();

            clnUtil.definirCEP(mtbEndCEP, txtEndLogradouro, txtEndBairro, txtEndCidade, cboEndUF, txtEndNr);

            mtbEmpCNPJ.Mask = clnUtil.MASK_CNPJ;
            mtbEmpIE.Mask = clnUtil.MASK_IE;
        }

    }
}
