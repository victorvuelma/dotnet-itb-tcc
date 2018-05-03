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
            
            //
            // Masks
            //
            this.mtbEmpCNPJ.Mask = clnUtil.MASK_CNPJ;
            this.mtbEmpIE.Mask = clnUtil.MASK_IE;
            this.mtbResCPF.Mask = clnUtil.MASK_CPF;
            this.mtbResRG.Mask = clnUtil.MASK_RG;
            this.mtbResTelFixo.Mask = clnUtil.MASK_TEL;
            this.mtbResTelCom.Mask = clnUtil.MASK_TEL;
            this.mtbCntTelCom.Mask = clnUtil.MASK_TEL;
            this.mtbCntTelCom2.Mask = clnUtil.MASK_TEL;
            this.mtbCntTelCel.Mask = clnUtil.MASK_CEL;
            this.mtbCntFax.Mask = clnUtil.MASK_TEL;
            this.mtbEndCEP.Mask = clnUtil.MASK_CEP;
            this.mtbCtrConvInicio.Mask = clnUtil.MASK_DATA;
            this.mtbCtrConvTermino.Mask = clnUtil.MASK_DATA;

            clnUtil.definirCEP(mtbEndCEP, txtEndLogradouro, txtEndBairro, txtEndCidade, cboEndUF.cbo, txtEndNr);
        }

    }
}
