using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using UIX;
using System.Drawing;

namespace BURGUER_SHACK_DESKTOP
{
    class clnMessage
    {

        public static void mostrarMensagem(String titulo, String conteudo, int tipo )
        {

            msgUIX msg = msgUIX.messageBox(titulo, Icone(tipo), clnTemplate.CommonTemplate);

            msg.Show();

        }

        private static Image Icone(int tipo)
        {
            switch (tipo)
            {
                case 0:
                    return BURGUER_SHACK_DESKTOP.Properties.Resources.erro;
                case 1:
                    return BURGUER_SHACK_DESKTOP.Properties.Resources.info;
                default:
                    return BURGUER_SHACK_DESKTOP.Properties.Resources.confirmar;
            }
        }

    }
}
