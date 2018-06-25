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

        private static String _configName = "Burguer Shack";

        private static sqlDatabase _databaseSql = new sqlDatabase
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

        private static UIX.uixStyle _visualStyle = UIX.uixStyle.BLUE;
        private static UIX.uixTemplate _visualTemplate = new UIX.uixTemplate
        {
            Style = VisualStyle,
            Icon = Properties.Resources.app_ico
        };

        public static String Name { get => _configName; }
        
        public static sqlDatabase DatabaseSql { get => _databaseSql; }

        public static UIX.uixTemplate VisualTemplate { get => _visualTemplate; }
        public static uixStyle VisualStyle { get => _visualStyle; }
    }
}
