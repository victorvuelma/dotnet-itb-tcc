using System;
using System.Drawing;
using vitorrdgs.UiX.Component;
using vitorrdgs.UiX.Manager;
using vitorrdgs.UiX.Property;

namespace BurgerShack.Desktop.Util
{
    class UtilButton
    {

        public static void excluir(UIXButton btn)
        {
            botao(btn, Properties.Resources.excluir, "Excluir", AppDesktop.VisualStyle.ButtonWarningColor);
        }

        public static void salvar(UIXButton btn)
        {
            botao(btn, Properties.Resources.salvar, "Salvar", AppDesktop.VisualStyle.ButtonColor);
        }

        public static void alterar(UIXButton btn)
        {
            botao(btn, Properties.Resources.alterar, "Alterar", AppDesktop.VisualStyle.ButtonColor);
        }

        public static void restaurar(UIXButton btn)
        {
            botao(btn, Properties.Resources.alterar, "Restaurar", AppDesktop.VisualStyle.ButtonColor);
        }

        public static void voltar(UIXButton btn)
        {
            botao(btn, Properties.Resources.voltar, "Voltar", AppDesktop.VisualStyle.ButtonColor);
        }

        public static void cancelar(UIXButton btn)
        {
            botao(btn, Properties.Resources.voltar, "Cancelar", AppDesktop.VisualStyle.ButtonWarningColor);
        }

        private static void botao(UIXButton btn, Image img, String text, uixSet colorSet)
        {
            btn.Image = img;
            btn.Description = text;
            uixButton.btnApply(btn, colorSet);
        }

    }
}
