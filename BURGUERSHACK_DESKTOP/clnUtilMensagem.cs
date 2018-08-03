using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using vitorrdgs.UiX;
using System.Drawing;
using vitorrdgs.UiX.Component;

namespace BURGERSHACK_DESKTOP
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
            return (msgUIX.confirmarSim(AppDesktop.VisualTemplate, titulo, mensagem).Equals(msgUIX.MessageResult.YES));
        }

        public static void mostrarOk(String titulo, String mensagem)
        {
            msgUIX.mostrarOk(AppDesktop.VisualTemplate, titulo, mensagem);
        }

    }
}
