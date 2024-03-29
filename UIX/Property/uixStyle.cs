﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace vitorrdgs.UiX.Property
{

    public class uixStyle
    {

        private uixSet _formColor;

        private int _headerButtonSize;
        private int _headerButtonSpace;

        private Font _contentFont;
        private Font _buttonFont;

        private uixSet _btnColor;
        private uixSet _btnImageColor;
        private uixSet _btnWarningColor;

        private uixSet _ctlColor;

        private uixSet _boxColor;
        private uixSet _boxWarningColor;

        public uixSet FormColor { get => _formColor; set => _formColor = value; }

        public int HeaderButtonSize { get => _headerButtonSize; set => _headerButtonSize = value; }
        public int HeaderButtonSpace { get => _headerButtonSpace; set => _headerButtonSpace = value; }

        public Font ContentFont { get => _contentFont; set => _contentFont = value; }
        public Font BoldFont { get => _buttonFont; set => _buttonFont = value; }

        public uixSet ButtonColor { get => _btnColor; set => _btnColor = value; }
        public uixSet ButtonImageColor { get => _btnImageColor; set => _btnImageColor = value; }
        public uixSet ButtonWarningColor { get => _btnWarningColor; set => _btnWarningColor = value; }

        public uixSet ContentColor { get => _ctlColor; set => _ctlColor = value; }
        public uixSet BoxColor { get => _boxColor; set => _boxColor = value; }
        public uixSet BoxWarningColor { get => _boxWarningColor; set => _boxWarningColor = value; }

        public static uixStyle BLUE = new uixStyle
        {
            FormColor = uixSet.INDIGO,
            HeaderButtonSize = 40,
            HeaderButtonSpace = 5,
            ContentFont = uixFont.CENTURY_REGULAR,
            BoldFont = uixFont.CENTURY_BOLD,
            ButtonColor = uixSet.BLUE,
            ButtonImageColor = uixSet.WHITE,
            ButtonWarningColor = uixSet.RED,
            ContentColor = uixSet.INDIGO,
            BoxColor = uixSet.BLUE,
            BoxWarningColor = uixSet.RED
        };

        //public static uixStyle SILVER = new uixStyle(
        //    uixSet.GRAY,
        //    uixSet.WHITE,
        //    40,
        //    5,
        //    uixFont.LATO_BLACK,
        //    uixFont.CENTURY_REGULAR,
        //    uixFont.CENTURY_BOLD,
        //    uixSet.GRAY,
        //    uixSet.WHITE,
        //    uixSet.RED,
        //    uixSet.GRAY,
        //    uixSet.GRAY,
        //    uixSet.GRAY,
        //    uixSet.WHITE
        //);

    }

}
