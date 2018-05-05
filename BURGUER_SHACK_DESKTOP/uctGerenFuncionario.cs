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

            //
            // Masks
            //
            this.mtbDadosCPF.Mask = clnUtil.MASK_CPF;
            this.mtbDadosRG.Mask = clnUtil.MASK_RG;
            this.mtbEndCEP.Mask = clnUtil.MASK_CEP;
            this.mtbDadosDtNasc.Mask = clnUtil.MASK_DATA;
            this.mtbContatoTelCel.Mask = clnUtil.MASK_CEL;
            this.mtbContatoTelCel2.Mask = clnUtil.MASK_CEL;
            this.mtbContatoTelRes.Mask = clnUtil.MASK_TEL;

            clnUtil.definirCEP(mtbEndCEP, txtEndLogradouro, txtEndBairro, txtEndCidade, cboEndUF.cbo, txtEndNr);
        }
    }
}
