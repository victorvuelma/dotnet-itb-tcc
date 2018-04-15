using System;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;

namespace UIX
{
    public class UIXUtil
    {
        public static Color fromRGB(int r, int g, int b)
        {
            return Color.FromArgb(r, g, b);
        }
    }

    public class UIXColor
    {
        public static Color AQUA_LIGHT = UIXUtil.fromRGB(26, 188, 156);
        public static Color AQUA_DARK = UIXUtil.fromRGB(22, 160, 133);

        public static Color BLUE_LIGHT = UIXUtil.fromRGB(52, 152, 219);
        public static Color BLUE_DARK = UIXUtil.fromRGB(41, 128, 185);

        public static Color GREEN_LIGHT = UIXUtil.fromRGB(46, 204, 113);
        public static Color GREEN_DARK = UIXUtil.fromRGB(39, 174, 96);

        public static Color GRAY_LIGHT = UIXUtil.fromRGB(149, 165, 166);
        public static Color GRAY_DARK = UIXUtil.fromRGB(127, 140, 141);

        public static Color INDIGO_LIGHT = UIXUtil.fromRGB(52, 73, 94);
        public static Color INDIGO_DARK = UIXUtil.fromRGB(44, 62, 80);

        public static Color PURPLE_LIGHT = UIXUtil.fromRGB(155, 89, 182);
        public static Color PURPLE_DARK = UIXUtil.fromRGB(142, 68, 173);

        public static Color RED_LIGHT = UIXUtil.fromRGB(231, 76, 60);
        public static Color RED_DARK = UIXUtil.fromRGB(192, 57, 43);

        public static Color SILVER = UIXUtil.fromRGB(189, 195, 199);
        public static Color WHITE = UIXUtil.fromRGB(236, 240, 241);

        public static Color YELLOW_LIGHT = UIXUtil.fromRGB(241, 196, 15);
        public static Color YELLOW_DARK = UIXUtil.fromRGB(243, 156, 18);

    }

    public class UIXFont
    {

        public static Font CENTURY_REGULAR = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

        public static Font LATO_BLACK = new System.Drawing.Font("Lato Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

        public static Font SANS_SERIF = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);

        public static Font fontSize(Font font, float size)
        {
            return new Font(font.FontFamily, size, font.Style, font.Unit);
        }

    }

    public class UIXSet
    {

        private Color _contentColor;
        private Color _darkColor;
        private Color _lightColor;

        private UIXSet(Color darkColor, Color lightColor, Color contentColor)
        {
            _contentColor = contentColor;
            _darkColor = darkColor;
            _lightColor = lightColor;
        }

        public Color ContentColor { get => _contentColor; }
        public Color DarkColor { get => _darkColor; }
        public Color LightColor { get => _lightColor; }

        public static UIXSet AQUA = new UIXSet(UIXColor.AQUA_DARK, UIXColor.AQUA_LIGHT, UIXColor.WHITE);
        public static UIXSet BLUE = new UIXSet(UIXColor.BLUE_DARK, UIXColor.BLUE_LIGHT, UIXColor.WHITE);
        public static UIXSet GRAY = new UIXSet(UIXColor.GRAY_DARK, UIXColor.GRAY_LIGHT, UIXColor.INDIGO_LIGHT);
        public static UIXSet GREEN = new UIXSet(UIXColor.GREEN_DARK, UIXColor.GREEN_LIGHT, UIXColor.WHITE);
        public static UIXSet INDIGO = new UIXSet(UIXColor.INDIGO_DARK, UIXColor.INDIGO_LIGHT, UIXColor.WHITE);
        public static UIXSet PURPLE = new UIXSet(UIXColor.PURPLE_DARK, UIXColor.PURPLE_LIGHT, UIXColor.WHITE);
        public static UIXSet RED = new UIXSet(UIXColor.RED_DARK, UIXColor.RED_LIGHT, UIXColor.WHITE);
        public static UIXSet WHITE = new UIXSet(UIXColor.SILVER, UIXColor.WHITE, UIXColor.INDIGO_LIGHT);

    }

    public class UIXStyle
    {

        private UIXSet _formColor;

        private UIXSet _headerButtonColor;
        private UIXSet _headerCloseButtonColor;

        private int _headerButtonSize;
        private int _headerButtonSpace;

        private Font _headerFont;
        private Font _contentFont;

        private UIXSet _btnColor;
        private UIXSet _grbColor;
        private UIXSet _lblColor;
        private UIXSet _txtColor;

        public UIXStyle(UIXSet formColor, UIXSet headerButtonColor, UIXSet headerCloseButtonColor,
            int headerButtonSize, int headerButtonSpace,
            Font headerFont, Font contentFont,
            UIXSet btnColor, UIXSet grbColor, UIXSet lblColor, UIXSet txtColor)
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
            _txtColor = txtColor;
        }

        public UIXSet FormColor { get => _formColor; }
        public UIXSet HeaderButtonColor { get => _headerButtonColor; }
        public UIXSet HeaderCloseButtonColor { get => _headerCloseButtonColor; }

        public int HeaderButtonSize { get => _headerButtonSize; }
        public int HeaderButtonSpace { get => _headerButtonSpace; }

        public Font HeaderFont { get => _headerFont; }
        public Font ContentFont { get => _contentFont; }

        public UIXSet ButtonColor { get => _btnColor; }
        public UIXSet GroupBoxColor { get => _grbColor; }
        public UIXSet LabelColor { get => _lblColor; }
        public UIXSet TextBoxColor { get => _txtColor; }

        public static UIXStyle BLUE = new UIXStyle(
            UIXSet.INDIGO,
            UIXSet.BLUE,
            UIXSet.RED,
            30,
            5,
                        UIXFont.LATO_BLACK,
            UIXFont.CENTURY_REGULAR,
            UIXSet.BLUE,
            UIXSet.INDIGO,
            UIXSet.INDIGO,
            UIXSet.BLUE
        );

        public static UIXStyle SILVER = new UIXStyle(
            UIXSet.GRAY,
            UIXSet.WHITE,
            UIXSet.RED,
            30,
            5,
                                    UIXFont.LATO_BLACK,
                        UIXFont.CENTURY_REGULAR,
            UIXSet.GRAY,
            UIXSet.GRAY,
            UIXSet.GRAY,
            UIXSet.WHITE
        );

    }

    public class UIXImageTemplate
    {

        private Image _logo;
        private Icon _icon;

        public UIXImageTemplate(Image logo, Icon icon)
        {
            _logo = logo;
            _icon = icon;

        }

        public Image Logo { get => _logo; }
        public Icon Icon { get => _icon; }
    }

    public class UIXTemplate
    {

        private UIXStyle _style;
        private UIXImageTemplate _imageTemplate;

        public UIXTemplate(UIXStyle style, UIXImageTemplate imageTemplate)
        {
            this._style = style;
            this._imageTemplate = imageTemplate;
        }

        public void ctlApply(Control[] ctls)
        {
            foreach (Control control in ctls)
            {
                this.ctlApply(control);
            }
        }

        public void ctlApply(Control ctl)
        {
            if (ctl is Button)
            {
                this.btnApply((Button)ctl);
            }
            else if (ctl is GroupBox)
            {
                this.grbApply((GroupBox)ctl);
            }
            else if (ctl is Label)
            {
                this.lblApply((Label)ctl);
            }
            else if (ctl is Panel)
            {
                this.pnlApply((Panel)ctl);
            }
            else if (ctl is TextBox)
            {
                this.txtApply((TextBox)ctl);
            }
            else if (ctl is UserControl)
            {
                this.uctApply((UserControl)ctl);
            }
        }

        public void btnApply(Button btn)
        {
            UIXButton.btnApply(btn, Style.ButtonColor, Style.ContentFont);
        }

        public void grbApply(GroupBox grb)
        {
            UIXGroupBox.grbApply(grb, Style.GroupBoxColor, Style.ContentFont);

            foreach (Control ctl in grb.Controls)
            {
                ctlApply(ctl);
            }
        }

        public void lblApply(Label lbl)
        {
            UIXLabel.lblApply(lbl, Style.LabelColor, Style.ContentFont);
        }

        public void pnlApply(Panel pnl)
        {
            UIXPanel.pnlApply(pnl, Style.FormColor, Style.ContentFont);

            foreach (Control ctl in pnl.Controls)
            {
                ctlApply(ctl);
            }
        }

        public void txtApply(TextBox txt)
        {
            UIXTextBox.txtApply(txt, Style.TextBoxColor, Style.ContentFont);
        }

        public void uctApply(UserControl uct)
        {
            UIXUserControl.uctApply(uct, Style.FormColor, Style.ContentFont);

            foreach (Control ctl in uct.Controls)
            {
                ctlApply(ctl);
            }
        }

        public void frmApply(Form frm, uctUIX ctl)
        {
            UIXForm.frmApply(frm, ctl, Style);

            ctl.picFormIcon.Image = ImageTemplate.Logo;

            foreach (Control control in frm.Controls)
            {
                if (control != ctl)
                {
                    this.ctlApply(control);
                }
            }

        }

        public UIXStyle Style { get => _style; }

        public UIXImageTemplate ImageTemplate { get => _imageTemplate; }

    }

    public class UIXForm
    {

        public static void frmApply(Form frm, uctUIX ctl, UIXStyle style)
        {
            frm.FormBorderStyle = FormBorderStyle.None;

            UIXHeader.hdrApply(frm, ctl, style);

            UIXHeader.hdrMove(frm, new Control[] { ctl, ctl.lblTitulo, ctl.picFormIcon });
        }
    }

    public class UIXHeader
    {

        public static void hdrApply(Form frm, uctUIX ctl, UIXStyle style)
        {
            int maxX = frm.Size.Width;
            int maxY = frm.Size.Height;

            frm.BackColor = style.FormColor.LightColor;

            //Apply header bar Style
            ctl.Size = new Size(maxX, style.HeaderButtonSize + (style.HeaderButtonSpace * 2));
            ctl.Location = new Point(0, 0);
            ctl.BackColor = style.FormColor.DarkColor;

            //Apply header title style
            ctl.lblTitulo.Location = new Point(style.HeaderButtonSize + (style.HeaderButtonSpace * 2), 12);
            ctl.lblTitulo.BringToFront();
            UIXLabel.lblApply(ctl.lblTitulo, style.FormColor, style.HeaderFont);
            ctl.lblTitulo.Font = UIXFont.fontSize(ctl.lblTitulo.Font, 10f);
            ctl.lblTitulo.BackColor = style.FormColor.DarkColor;

            ctl.picFormIcon.Location = new Point(style.HeaderButtonSpace, style.HeaderButtonSpace);
            ctl.picFormIcon.Size = new Size(style.HeaderButtonSize, style.HeaderButtonSize);
            ctl.picFormIcon.BackColor = style.FormColor.DarkColor;
            ctl.picFormIcon.SizeMode = PictureBoxSizeMode.Zoom;
            ctl.picFormIcon.BringToFront();

            //Calculate buttons
            int nextButtonX = maxX;
            //Close button
            if (ctl.btnSair != null)
            {
                nextButtonX = nextButtonX - style.HeaderButtonSize - style.HeaderButtonSpace;
                ctl.btnSair.Location = new Point(nextButtonX, style.HeaderButtonSpace);
                ctl.btnSair.BringToFront();

                UIXButton.btnStyleClose(ctl.btnSair, style.HeaderButtonSize, style.HeaderCloseButtonColor);
            }
            //Minimize button
            if (ctl.btnMin != null)
            {
                nextButtonX = nextButtonX - style.HeaderButtonSize - style.HeaderButtonSpace;
                ctl.btnMin.Location = new Point(nextButtonX, style.HeaderButtonSpace);
                ctl.btnMin.BringToFront();

                UIXButton.btnStyleMinimize(ctl.btnMin, style.HeaderButtonSize, style.HeaderButtonColor);
            }
        }

        public static void hdrMove(Form frm, Control[] controls)
        {

            HeaderData data = new HeaderData(frm);

            foreach (Control control in controls)
            {
                control.MouseUp += new MouseEventHandler(data.mouseUp);
                control.MouseMove += new MouseEventHandler(data.mouseMove);
                control.MouseDown += new MouseEventHandler(data.mouseDown);
            }

        }

        private class HeaderData
        {

            private Form _frm;

            private bool _dragging = false;
            private Point _dragCursorPoint;
            private Point _dragFormPoint;
            private int _maxX;
            private int _maxY;

            public HeaderData(Form frm)
            {
                _frm = frm;

                Rectangle resolution = Screen.PrimaryScreen.Bounds;
                _maxX = resolution.Width - _frm.Size.Width;
                _maxY = resolution.Height - _frm.Size.Height;
            }

            public void mouseUp(object sender, MouseEventArgs e)
            {
                _dragging = false;
            }

            public void mouseMove(object sender, MouseEventArgs e)
            {
                if (_dragging)
                {
                    Point dif = Point.Subtract(Cursor.Position, new Size(_dragCursorPoint));
                    Point location = Point.Add(_dragFormPoint, new Size(dif));
                    if (location.X < 0)
                    {
                        location.X = 0;
                    }
                    else if (location.X > _maxX)
                    {
                        location.X = _maxX;
                    }
                    if (location.Y < 0)
                    {
                        location.Y = 0;
                    }
                    else if (location.Y > _maxY)
                    {
                        location.Y = _maxY;
                    }
                    _frm.Location = location;
                }
            }

            public void mouseDown(object sender, MouseEventArgs e)
            {
                _dragging = true;
                _dragCursorPoint = Cursor.Position;
                _dragFormPoint = _frm.Location;
            }

        }

    }

    public class UIXButton
    {

        public static void btnApply(Button btn, UIXSet colorSet)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.BackColor = colorSet.LightColor;
            btn.FlatAppearance.BorderColor = colorSet.DarkColor;
            btn.FlatAppearance.MouseDownBackColor = colorSet.DarkColor;
            btn.FlatAppearance.MouseOverBackColor = colorSet.DarkColor;
            btn.FlatAppearance.BorderSize = 0;
            btn.ForeColor = colorSet.ContentColor;
            btn.Cursor = Cursors.Hand;
        }

        public static void btnApply(Button btn, UIXSet colorSet, Font font)
        {
            UIXButton.btnApply(btn, colorSet);
            btn.Font = font;
        }

        public static void btnSquare(Button btn, int size)
        {
            UIXButton.btnSize(btn, size, size);
        }

        public static void btnSize(Button btn, int x, int y)
        {
            btn.Height = y;
            btn.Width = x;
        }

        public static void btnStyleClose(Button btn, int size, UIXSet colorSet)
        {
            UIXButton.btnApply(btn, colorSet, UIXFont.fontSize(UIXFont.SANS_SERIF, 12F));
            btn.Text = "X";
            btn.TabIndex = int.MaxValue;
            UIXButton.btnSquare(btn, size);
        }

        public static void btnStyleMinimize(Button btn, int size, UIXSet colorSet)
        {
            UIXButton.btnApply(btn, colorSet, UIXFont.fontSize(UIXFont.SANS_SERIF, 12F));
            btn.Text = "_";
            btn.TabIndex = int.MaxValue;
            UIXButton.btnSquare(btn, size);
        }

    }

    public class UIXCheckBox
    {
        public static void chkApply(CheckBox chk, UIXSet colorSet, Font font)
        {
            chk.Font = UIXFont.fontSize(font, chk.Font.Size);
            UIXCheckBox.chkApply(chk, colorSet);
        }

        public static void chkApply(CheckBox chk, UIXSet colorSet)
        {
            chk.FlatStyle = FlatStyle.Flat;
            chk.ForeColor = colorSet.ContentColor;
            chk.BackColor = colorSet.DarkColor;
        }
    }

    public class UIXComboBox
    {

        public static void cboApply(ComboBox cbo, UIXSet colorSet, Font font)
        {
            cbo.Font = UIXFont.fontSize(font, cbo.Font.Size);
            UIXComboBox.cboApply(cbo, colorSet);
        }

        public static void cboApply(ComboBox cbo, UIXSet colorSet)
        {
            cbo.FlatStyle = FlatStyle.Popup;
            cbo.BackColor = colorSet.DarkColor;
            cbo.ForeColor = colorSet.ContentColor;
            cbo.Margin = new Padding(0);
        }
    }

    public class UIXGroupBox
    {
        public static void grbApply(GroupBox grb, UIXSet colorSet, Font font)
        {
            grb.Font = UIXFont.fontSize(font, grb.Font.Size);
            grbApply(grb, colorSet);
        }

        public static void grbApply(GroupBox grb, UIXSet colorSet)
        {
            grb.FlatStyle = FlatStyle.Flat;
            grb.BackColor = colorSet.LightColor;
            grb.ForeColor = colorSet.ContentColor;
        }
    }

    public class UIXLabel
    {
        public static void lblApply(Label lbl, UIXSet colorSet, Font font)
        {
            lbl.Font = UIXFont.fontSize(font, lbl.Font.Size);
            UIXLabel.lblApply(lbl, colorSet);
        }

        public static void lblApply(Label lbl, UIXSet colorSet)
        {
            lbl.BackColor = colorSet.LightColor;
            lbl.ForeColor = colorSet.ContentColor;
        }
    }

    public class UIXListBox
    {
        public static void lstApply(ListBox box, UIXSet colorSet)
        {

        }
    }

    public class UIXPanel
    {

        public static void pnlApply(Panel pnl, UIXSet set, Font font)
        {
            pnl.Font = UIXFont.fontSize(font, pnl.Font.Size);
            UIXPanel.pnlApply(pnl, set);
        }

        public static void pnlApply(Panel pnl, UIXSet set)
        {
            pnl.BackColor = set.LightColor;
            pnl.ForeColor = set.ContentColor;
        }

    }

    public class UIXTextBox
    {

        public static void txtApply(TextBox txt, UIXSet colorSet, Font font)
        {
            txt.Font = UIXFont.fontSize(font, txt.Font.Size);
            UIXTextBox.txtApply(txt, colorSet);
        }

        public static void txtApply(TextBox txt, UIXSet colorSet)
        {
            txt.BackColor = colorSet.LightColor;
            txt.ForeColor = colorSet.ContentColor;
            txt.BorderStyle = BorderStyle.None;
            txt.Margin = new Padding(5);
        }
    }

    public class UIXUserControl
    {

        public static void uctApply(UserControl uct, UIXSet set, Font font)
        {
            uct.Font = UIXFont.fontSize(font, uct.Font.Size);
            UIXUserControl.uctApply(uct, set);
        }

        public static void uctApply(UserControl uct, UIXSet set)
        {
            uct.BackColor = set.LightColor;
            uct.ForeColor = set.ContentColor;
        }

    }

}
