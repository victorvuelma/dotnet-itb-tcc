using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;
using UIX;
using SQL_POWERUP;
using System.Windows.Forms;

namespace BURGUER_SHACK_DESKTOP
{
    class App
    {

        private static sqlDatabase _appDatabase = new sqlDatabase
        {
            Database = AppDb.DATABASE,
            User = AppDb.USER,
            Pass = AppDb.PASS,
            Source = AppDb.SOURCE,
            ExceptionCall = delegate (Exception ex) {
                clnUtilMensagem.mostrarOk("Banco de Dados", "Um erro ocorreu ao tentar processar a requisição\n" + ex.Message, clnUtilMensagem.MensagemIcone.ERRO);
                Application.Restart();
            }
        };

        private static String _appName = "Burguer Shack";

        private static UIX.uixStyle _appVisualStyle = UIX.uixStyle.BLUE;
        private static UIX.uixTemplate _appVisualTemplate = new UIX.uixTemplate
        {
            Style = AppVisualStyle,
            Icon = Properties.Resources.burguershack_ico
        };

        public static sqlDatabase AppDatabase { get => _appDatabase; }
        public static String AppName { get => _appName; }

        public static UIX.uixTemplate AppVisualTemplate { get => _appVisualTemplate; }
        public static uixStyle AppVisualStyle { get => _appVisualStyle; }
    }
}
