using BurgerShack.Common;
using System;
using vitorrdgs.UiX;
using vitorrdgs.UiX.Property;

namespace BurgerShack.Desktop
{
    class AppDesktop
    {

        private static clnFuncionario _funcionarioAtual;

        private static uixStyle _visualStyle = uixStyle.BLUE;
        private static uixTemplate _visualTemplate = new uixTemplate
        {
            Style = VisualStyle,
            Icon = Properties.Resources.app_ico,
            ErrorImage = Properties.Resources.imagem_erro
        };


        public static uixTemplate VisualTemplate { get => _visualTemplate; }
        public static uixStyle VisualStyle { get => _visualStyle; }
        internal static clnFuncionario FuncionarioAtual { get => _funcionarioAtual; set => _funcionarioAtual = value; }

        internal static void startup()
        {
            App.DatabaseSql.ExceptionCall = (Exception ex, string detail) =>
                {
                    Console.WriteLine(detail);
                    throw ex;
                };
        }

    }
}
