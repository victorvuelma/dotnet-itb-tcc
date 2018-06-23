using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using UIX;
using System.Drawing;

namespace BURGUER_SHACK_DESKTOP
{
    class clnUtilMensagem
    {

        public enum MensagemIcone
        {
            OK,
            ERRO,
            INFO
        }

        public static int OP_OK = 0;
        public static int OP_S_N = 1;

        public static bool mostrarSimNao(String titulo, String mensagem, MensagemIcone icone)
        {
            return (mostrarMensagem(titulo, mensagem, icone, OP_S_N).resultado == 2);
        }

        public static void mostrarOk(String titulo, String mensagem, MensagemIcone icone)
        {
            mostrarMensagem(titulo, mensagem, icone, OP_OK);
        }

        private static msgUIX mostrarMensagem(String titulo, String mensagem, MensagemIcone icone, int tipo)
        {
            msgUIX msg = msgUIX.messageBox(titulo, mensagem, Icone(icone), App.VisualTemplate);

            switch (tipo)
            {
                case 0:
                    msg.btnYes.Text = "Ok";
                    msg.btnNo.Visible = false;
                    break;
                case 1:
                    msg.btnYes.Text = "Sim";
                    msg.btnNo.Text = "Não";
                    uixButton.btnApply(msg.btnYes, App.VisualStyle.ButtonWarningColor);
                    break;
            }

            msg.ShowDialog();

            return msg;
        }

        private static Image Icone(MensagemIcone tipo)
        {
            switch (tipo)
            {
                case MensagemIcone.ERRO:
                    return BURGUER_SHACK_DESKTOP.Properties.Resources.erro;
                case MensagemIcone.INFO:
                    return BURGUER_SHACK_DESKTOP.Properties.Resources.info;
                default:
                    return BURGUER_SHACK_DESKTOP.Properties.Resources.confirmar;
            }
        }

    }
}
