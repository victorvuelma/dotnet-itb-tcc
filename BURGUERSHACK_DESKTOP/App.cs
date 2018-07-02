﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;
using UIX;
using SQL_POWERUP;
using System.Windows.Forms;

namespace BURGUERSHACK_DESKTOP
{
    class App
    {

        private static String _name = "Burguer Shack";

        private static sqlDatabase _databaseSql = new sqlDatabase
        {
            Database = AppDb.DATABASE,
            User = AppDb.USER,
            Pass = AppDb.PASS,
            Source = AppDb.SOURCE,
            ExceptionCall = (Exception ex) =>
            {
                clnUtilMensagem.mostrarOk("Banco de Dados", "Um erro ocorreu ao tentar processar a requisição\n" + ex.Message, clnUtilMensagem.MensagemIcone.ERRO);
                Application.Restart();
            }
        };

        private static UIX.uixStyle _visualStyle = UIX.uixStyle.BLUE;
        private static UIX.uixTemplate _visualTemplate = new UIX.uixTemplate
        {
            Style = VisualStyle,
            Icon = Properties.Resources.app_ico,
            ErrorImage = Properties.Resources.imagem_erro
        };

        public static String Name { get => _name; }

        public static sqlDatabase DatabaseSql { get => _databaseSql; }

        public static UIX.uixTemplate VisualTemplate { get => _visualTemplate; }
        public static uixStyle VisualStyle { get => _visualStyle; }
    }
}
