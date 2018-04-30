using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using UIX;
using System.Drawing;

namespace BURGUER_SHACK_DESKTOP
{
    class clnMensagem
    {

        public static int MSG_ERRO = 0;
        public static int MSG_INFO = 1;
        public static int MSG_OK = 2;

        public static int OP_OK = 0;
        public static int OP_S_N = 1;

        public static bool mostrarSimNao(String titulo, String mensagem, int icone)
        {
            return (mostrarMensagem(titulo, mensagem, icone, OP_S_N).resultado == 2);
        }

        public static void mostrarOk(String titulo, String mensagem, int icone)
        {
            mostrarMensagem(titulo, mensagem, icone, OP_OK);
        }

        private static msgUIX mostrarMensagem(String titulo, String mensagem, int icone, int tipo)
        {

            msgUIX msg = msgUIX.messageBox(titulo, mensagem, Icone(icone), clnTemplate.CommonTemplate);

            switch (tipo)
            {
                case 0:
                    msg.btnYes.Text = "Ok";
                    msg.btnNo.Visible = false;
                    break;
                case 1:
                    msg.btnYes.Text = "Sim";
                    msg.btnNo.Text = "Não";
                    uixButton.btnApply(msg.btnNo, clnTemplate.CommonTemplate.Style.WarningButtonColor, clnTemplate.CommonTemplate.Style.ContentFont);
                    break;
            }

            msg.ShowDialog();

            return msg;
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
