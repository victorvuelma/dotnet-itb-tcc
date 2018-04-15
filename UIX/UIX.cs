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
        public static Color AQUA_LIGHT = UIX.UIXUtil.fromRGB(26, 188, 156);
        public static Color AQUA_DARK = UIX.UIXUtil.fromRGB(22, 160, 133);

        public static Color BLUE_LIGHT = UIX.UIXUtil.fromRGB(52, 152, 219);
        public static Color BLUE_DARK = UIX.UIXUtil.fromRGB(41, 128, 185);

        public static Color GREEN_LIGHT = UIX.UIXUtil.fromRGB(46, 204, 113);
        public static Color GREEN_DARK = UIX.UIXUtil.fromRGB(39, 174, 96);

        public static Color GRAY_LIGHT = UIX.UIXUtil.fromRGB(149, 165, 166);
        public static Color GRAY_DARK = UIX.UIXUtil.fromRGB(127, 140, 141);

        public static Color INDIGO_LIGHT = UIX.UIXUtil.fromRGB(52, 73, 94);
        public static Color INDIGO_DARK = UIX.UIXUtil.fromRGB(44, 62, 80);

        public static Color PURPLE_LIGHT = UIX.UIXUtil.fromRGB(155, 89, 182);
        public static Color PURPLE_DARK = UIX.UIXUtil.fromRGB(142, 68, 173);

        public static Color RED_LIGHT = UIX.UIXUtil.fromRGB(231, 76, 60);
        public static Color RED_DARK = UIX.UIXUtil.fromRGB(192, 57, 43);

        public static Color SILVER = UIX.UIXUtil.fromRGB(189, 195, 199);
        public static Color WHITE = UIX.UIXUtil.fromRGB(236, 240, 241);

        public static Color YELLOW_LIGHT = UIX.UIXUtil.fromRGB(241, 196, 15);
        public static Color YELLOW_DARK = UIX.UIXUtil.fromRGB(243, 156, 18);

    }

    public class UIXFont
    {

        public static Font LATO_BLACK(float size)
        {
            return new System.Drawing.Font("Lato Black", size, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        public static Font SANS_SERIF(float size)
        {
            return new System.Drawing.Font("Microsoft Sans Serif", size, System.Drawing.FontStyle.Bold);
        }

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

        public static UIX.UIXSet AQUA = new UIX.UIXSet(UIX.UIXColor.AQUA_DARK, UIX.UIXColor.AQUA_LIGHT, UIX.UIXColor.WHITE);
        public static UIX.UIXSet BLUE = new UIX.UIXSet(UIX.UIXColor.BLUE_DARK, UIX.UIXColor.BLUE_LIGHT, UIX.UIXColor.WHITE);
        public static UIX.UIXSet GRAY = new UIX.UIXSet(UIX.UIXColor.GRAY_DARK, UIX.UIXColor.GRAY_LIGHT, UIX.UIXColor.INDIGO_LIGHT);
        public static UIX.UIXSet GREEN = new UIX.UIXSet(UIX.UIXColor.GREEN_DARK, UIX.UIXColor.GREEN_LIGHT, UIX.UIXColor.WHITE);
        public static UIX.UIXSet INDIGO = new UIX.UIXSet(UIX.UIXColor.INDIGO_DARK, UIX.UIXColor.INDIGO_LIGHT, UIX.UIXColor.WHITE);
        public static UIX.UIXSet PURPLE = new UIX.UIXSet(UIX.UIXColor.PURPLE_DARK, UIX.UIXColor.PURPLE_LIGHT, UIX.UIXColor.WHITE);
        public static UIX.UIXSet RED = new UIX.UIXSet(UIX.UIXColor.RED_DARK, UIX.UIXColor.RED_LIGHT, UIX.UIXColor.WHITE);
        public static UIX.UIXSet WHITE = new UIX.UIXSet(UIX.UIXColor.SILVER, UIX.UIXColor.WHITE, UIX.UIXColor.INDIGO_LIGHT);

    }

    public class UIXStyle
    {

        private UIX.UIXSet _formColor;

        private UIX.UIXSet _headerButtonColor;
        private UIX.UIXSet _headerCloseButtonColor;

        private int _headerButtonSize;
        private int _headerButtonSpace;

        private UIX.UIXSet _btnColor;
        private UIX.UIXSet _grbColor;
        private UIX.UIXSet _lblColor;
        private UIX.UIXSet _txtColor;

        public UIXStyle(UIX.UIXSet formColor, UIX.UIXSet headerButtonColor, UIX.UIXSet headerCloseButtonColor,
            int headerButtonSize, int headerButtonSpace,
            UIX.UIXSet btnColor, UIX.UIXSet grbColor, UIX.UIXSet lblColor, UIX.UIXSet txtColor)
        {
            _formColor = formColor;
            _headerButtonColor = headerButtonColor;
            _headerCloseButtonColor = headerCloseButtonColor;
            _headerButtonSize = headerButtonSize;
            _headerButtonSpace = headerButtonSpace;
            _btnColor = btnColor;
            _grbColor = grbColor;
            _lblColor = lblColor;
            _txtColor = txtColor;
        }

        public UIX.UIXSet FormColor { get => _formColor; }
        public UIX.UIXSet HeaderButtonColor { get => _headerButtonColor; }
        public UIX.UIXSet HeaderCloseButtonColor { get => _headerCloseButtonColor; }

        public int HeaderButtonSize { get => _headerButtonSize; }
        public int HeaderButtonSpace { get => _headerButtonSpace; }

        public UIX.UIXSet ButtonColor { get => _btnColor; }
        public UIX.UIXSet GroupBoxColor { get => _grbColor; }
        public UIX.UIXSet LabelColor { get => _lblColor; }
        public UIX.UIXSet TextBoxColor { get => _txtColor; }

        public static UIXStyle BLUE = new UIXStyle(
            UIXSet.INDIGO,
            UIXSet.BLUE,
            UIXSet.RED,
            30,
            5,
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
            UIXSet.WHITE,
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

        private UIX.UIXStyle _style;
        private UIX.UIXImageTemplate _imageTemplate;

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
            else if (ctl is TextBox)
            {
                this.txtApply((TextBox)ctl);
            }
        }

        public void btnApply(Button btn)
        {
            UIX.UIXButton.btnApply(btn, Style.ButtonColor);
        }

        public void grbApply(GroupBox grb)
        {
            UIX.UIXGroupBox.grbApply(grb, Style.GroupBoxColor);
        }

        public void lblApply(Label lbl)
        {
            UIX.UIXLabel.lblApply(lbl, Style.LabelColor);
        }

        public void txtApply(TextBox txt)
        {
            UIX.UIXTextBox.txtApply(txt, Style.TextBoxColor);
        }

        public void frmApply(Form frm, ctlUIX ctl)
        {
            UIX.UIXForm.frmApply(frm, ctl, Style);

            foreach (Control control in frm.Controls)
            {
                this.ctlApply(control);
            }

        }

        public UIX.UIXStyle Style { get => _style; }

        public UIX.UIXImageTemplate ImageTemplate { get => _imageTemplate; }

    }

    public class UIXForm
    {

        public static void frmApply(Form frm, ctlUIX ctl, UIXStyle style)
        {
            frm.FormBorderStyle = FormBorderStyle.None;

            UIX.UIXHeader.hdrApply(frm, ctl, style);

            UIX.UIXHeader.hdrMove(frm, new Control[] { ctl, ctl.lblTitulo, ctl.picFormIcon });
        }
    }

    public class UIXHeader
    {

        public static void hdrApply(Form frm, ctlUIX ctl, UIXStyle style)
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
            UIX.UIXLabel.lblApply(ctl.lblTitulo, style.FormColor, UIX.UIXFont.LATO_BLACK(10f));
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

                UIX.UIXButton.btnStyleClose(ctl.btnSair, style.HeaderButtonSize, style.HeaderCloseButtonColor);
            }
            //Minimize button
            if (ctl.btnMin != null)
            {
                nextButtonX = nextButtonX - style.HeaderButtonSize - style.HeaderButtonSpace;
                ctl.btnMin.Location = new Point(nextButtonX, style.HeaderButtonSpace);
                ctl.btnMin.BringToFront();

                UIX.UIXButton.btnStyleMinimize(ctl.btnMin, style.HeaderButtonSize, style.HeaderButtonColor);
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
            UIX.UIXButton.btnApply(btn, colorSet);
            btn.Font = font;
        }

        public static void btnSquare(Button btn, int size)
        {
            UIX.UIXButton.btnSize(btn, size, size);
        }

        public static void btnSize(Button btn, int x, int y)
        {
            btn.Height = y;
            btn.Width = x;
        }

        public static void btnStyleClose(Button btn, int size, UIXSet colorSet)
        {
            UIX.UIXButton.btnApply(btn, colorSet, UIXFont.SANS_SERIF(12));
            btn.Text = "X";
            btn.TabIndex = int.MaxValue;
            UIX.UIXButton.btnSquare(btn, size);
        }

        public static void btnStyleMinimize(Button btn, int size, UIXSet colorSet)
        {
            UIX.UIXButton.btnApply(btn, colorSet, UIXFont.SANS_SERIF(12));
            btn.Text = "_";
            btn.TabIndex = int.MaxValue;
            UIX.UIXButton.btnSquare(btn, size);
        }

    }

    public class UIXCheckBox
    {
        public static void chkApply(CheckBox box, UIXSet colorSet)
        {
            box.FlatStyle = FlatStyle.Flat;
            box.ForeColor = colorSet.ContentColor;
            box.BackColor = colorSet.DarkColor;
            box.Font = UIX.UIXFont.LATO_BLACK(box.Font.Size);
        }
    }

    public class UIXComboBox
    {
        public static void cboApply(ComboBox box, UIXSet colorSet)
        {
            box.FlatStyle = FlatStyle.Popup;
            box.BackColor = colorSet.DarkColor;
            box.ForeColor = colorSet.ContentColor;
            box.Margin = new Padding(0);
            box.Font = UIX.UIXFont.LATO_BLACK(box.Font.Size);
        }
    }

    public class UIXGroupBox
    {
        public static void grbApply(GroupBox grb, UIXSet colorSet)
        {
            grb.FlatStyle = FlatStyle.Flat;
            grb.BackColor = colorSet.LightColor;
            grb.ForeColor = colorSet.ContentColor;
            grb.Font = UIX.UIXFont.LATO_BLACK(grb.Font.Size);
        }
    }

    public class UIXLabel
    {
        public static void lblApply(Label lbl, UIXSet colorSet, Font font)
        {
            lbl.Font = font;
            UIX.UIXLabel.lblApply(lbl, colorSet);
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

    public class UIXTextBox
    {
        public static void txtApply(TextBox txt, UIXSet colorSet)
        {
            txt.BackColor = colorSet.LightColor;
            txt.ForeColor = colorSet.ContentColor;
            txt.BorderStyle = BorderStyle.None;
            txt.Margin = new Padding(5);
            txt.Font = UIX.UIXFont.LATO_BLACK(txt.Font.Size);
        }
    }

}
