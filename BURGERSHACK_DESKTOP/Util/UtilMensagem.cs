using System;
using vitorrdgs.UiX.Component;

namespace BurgerShack.Desktop.Util
{
    class UtilMensagem
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
            return mostrarSimNao(titulo, mensagem);
        }

        public static bool mostrarSimNao(String titulo, String mensagem)
        {
            return (UIXMessage.confirmarSim(AppDesktop.VisualTemplate, titulo, mensagem).Equals(UIXMessage.MessageResult.YES));
        }

        public static void mostrarOk(String titulo, String mensagem)
        {
            UIXMessage.mostrarOk(AppDesktop.VisualTemplate, titulo, mensagem);
        }
    }
}