using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Drawing;

namespace BURGUER_SHACK_DESKTOP
{
    class clnUtil
    {

        public static void maskTel(UIX.mtbUIX mtb)
        {
            mtb.Mask = "(00) 0000-0000";
        }

        public static void maskCel(UIX.mtbUIX mtb)
        {
            mtb.Mask = "(00) 00000-0000";
        }

        public static void maskDN(UIX.mtbUIX mtb)
        {
            mtb.Mask = "00/00/0000";
        }

        public static void maskCPF(UIX.mtbUIX mtb)
        {
            mtb.Mask = "000,000,000-00";
        }

        public static void maskRG(UIX.mtbUIX mtb)
        {
            mtb.Mask = "00,000,000-0";
        }

        public static void alterarConteudo(Panel pnlConteudo, UserControl uctConteudo, UIX.uctUIX uctUIX, String titulo)
        {
            if (pnlConteudo.Controls.Count == 1)
            {
                pnlConteudo.Controls.Remove(pnlConteudo.Controls[0]);
            }

            clnTemplate.CommonTemplate.uctApply(uctConteudo);

            pnlConteudo.Controls.Add(uctConteudo);
            uctConteudo.Location = new Point(0, 0);
            uctConteudo.Size = pnlConteudo.Size;
            if (!pnlConteudo.Visible)
            {
                pnlConteudo.Visible = true;
            }

            uctUIX.UIXTitle = clnTemplate.AppName + " - " + titulo;
        }

    }
}
