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

        public static void alterarConteudo(Panel pnlConteudo, UserControl uctConteudo, UIX.uctUIX uctUIX, String titulo)
        {

            clnTemplate.CommonTemplate.uctApply(uctConteudo);

            pnlConteudo.Controls.Add(uctConteudo);
            uctConteudo.Location = new Point(0, 0);
            uctConteudo.Size = pnlConteudo.Size;

            if (pnlConteudo.Controls.Count == 2)
            {
                pnlConteudo.Controls.Remove(pnlConteudo.Controls[0]);
            }

            if (!pnlConteudo.Visible)
            {
                pnlConteudo.Visible = true;
            }

            uctUIX.UIXTitle = clnTemplate.AppName + " - " + titulo;
        }

    }
}
