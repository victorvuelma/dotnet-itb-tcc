using System;
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
        private uixSet _btnWarningColor;

        private int _headerButtonSize;
        private int _headerButtonSpace;

        private Font _headerFont;
        private Font _contentFont;
        private Font _buttonFont;

        private uixSet _btnColor;
        private uixSet _btnImageColor;
        private uixSet _grbColor;
        private uixSet _lblColor;
        private uixSet _pnlColor;
        private uixSet _txtColor;

        public uixSet FormColor { get => _formColor; set => _formColor = value; }
        public uixSet HeaderButtonColor { get => _headerButtonColor; set => _headerButtonColor = value; }

        public int HeaderButtonSize { get => _headerButtonSize; set => _headerButtonSize = value; }
        public int HeaderButtonSpace { get => _headerButtonSpace; set => _headerButtonSpace = value; }

        public Font HeaderFont { get => _headerFont; set => _headerFont = value; }
        public Font ContentFont { get => _contentFont; set => _contentFont = value; }
        public Font BoldFont { get => _buttonFont; set => _buttonFont = value; }

        public uixSet ButtonColor { get => _btnColor; set => _btnColor = value; }
        public uixSet ButtonImageColor { get => _btnImageColor; set => _btnImageColor = value; }
        public uixSet ButtonWarningColor { get => _btnWarningColor; set => _btnWarningColor = value; }

        public uixSet GroupBoxColor { get => _grbColor; set => _grbColor = value; }
        public uixSet LabelColor { get => _lblColor; set => _lblColor = value; }
        public uixSet PanelColor { get => _pnlColor; set => _pnlColor = value; }
        public uixSet TextBoxColor { get => _txtColor; set => _txtColor = value; }

        public static uixStyle BLUE = new uixStyle
        {
            FormColor = uixSet.INDIGO,
            HeaderButtonColor = uixSet.BLUE,
            HeaderButtonSize = 40,
            HeaderButtonSpace = 5,
            HeaderFont = uixFont.LATO_BLACK,
            ContentFont = uixFont.CENTURY_REGULAR,
            BoldFont = uixFont.CENTURY_BOLD,
            ButtonColor = uixSet.BLUE,
            ButtonImageColor = uixSet.WHITE,
            ButtonWarningColor = uixSet.RED,
            GroupBoxColor = uixSet.INDIGO,
            LabelColor = uixSet.INDIGO,
            PanelColor = uixSet.INDIGO,
            TextBoxColor = uixSet.BLUE
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
