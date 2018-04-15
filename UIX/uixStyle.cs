﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace UIX
{

    public class uixStyle
    {

        private uixSet _formColor;

        private uixSet _headerButtonColor;
        private uixSet _headerCloseButtonColor;

        private int _headerButtonSize;
        private int _headerButtonSpace;

        private Font _headerFont;
        private Font _contentFont;

        private uixSet _btnColor;
        private uixSet _grbColor;
        private uixSet _lblColor;
        private uixSet _pnlColor;
        private uixSet _txtColor;

        public uixStyle(uixSet formColor, uixSet headerButtonColor, uixSet headerCloseButtonColor,
            int headerButtonSize, int headerButtonSpace,
            Font headerFont, Font contentFont,
            uixSet btnColor, uixSet grbColor, uixSet lblColor, uixSet pnlColor, uixSet txtColor)
        {
            _formColor = formColor;

            _headerButtonColor = headerButtonColor;
            _headerCloseButtonColor = headerCloseButtonColor;

            _headerFont = headerFont;
            _contentFont = contentFont;

            _headerButtonSize = headerButtonSize;
            _headerButtonSpace = headerButtonSpace;

            _btnColor = btnColor;
            _grbColor = grbColor;
            _lblColor = lblColor;
            _pnlColor = pnlColor;
            _txtColor = txtColor;
        }

        public uixSet FormColor { get => _formColor; }
        public uixSet HeaderButtonColor { get => _headerButtonColor; }
        public uixSet HeaderCloseButtonColor { get => _headerCloseButtonColor; }

        public int HeaderButtonSize { get => _headerButtonSize; }
        public int HeaderButtonSpace { get => _headerButtonSpace; }

        public Font HeaderFont { get => _headerFont; }
        public Font ContentFont { get => _contentFont; }

        public uixSet ButtonColor { get => _btnColor; }
        public uixSet GroupBoxColor { get => _grbColor; }
        public uixSet LabelColor { get => _lblColor; }
        public uixSet PanelColor { get => _pnlColor; }
        public uixSet TextBoxColor { get => _txtColor; }

        public static uixStyle BLUE = new uixStyle(
            uixSet.INDIGO,
            uixSet.BLUE,
            uixSet.RED,
            30,
            5,
                        uixFont.LATO_BLACK,
            uixFont.CENTURY_REGULAR,
            uixSet.BLUE,
            uixSet.INDIGO,
            uixSet.INDIGO,
            uixSet.INDIGO,
            uixSet.BLUE
        );

        public static uixStyle SILVER = new uixStyle(
            uixSet.GRAY,
            uixSet.WHITE,
            uixSet.RED,
            30,
            5,
                                    uixFont.LATO_BLACK,
                        uixFont.CENTURY_REGULAR,
            uixSet.GRAY,
            uixSet.GRAY,
            uixSet.GRAY,
                        uixSet.GRAY,
            uixSet.WHITE
        );

    }

}
