using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Windows.Forms;

namespace vitorrdgs.UiX.Component
{
    public partial class UIXButton : Button
    {

        public new event EventHandler Click;

        private Color _hoverColor;
        private Color _backColor;

        public UIXButton()
        {
            InitializeComponent();

            HoverColor = Color.Transparent;
        }

        public Color HoverColor { get => _hoverColor; set => _hoverColor = value; }

        [Editor("System.ComponentModel.Design.MultilineStringEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        public String Description
        {
            get => lbl.Text;
            set
            {
                value = value.ToUpper();
                lbl.Text = value;
                base.Text = value;
                update();
            }
        }

        public new Image Image { get => pic.Image; set => pic.Image = value; }

        public String ImageLocation { get => pic.ImageLocation; set => pic.ImageLocation = value; }

        private void update()
        {
            int MARGIN = 3;

            pnl.Size = new Size(Size.Width - (MARGIN * 2), Size.Height - (MARGIN * 2));
            pnl.Location = new Point(MARGIN, MARGIN);

            lbl.Size = new Size(pnl.Width, lbl.Height);
            uixUtil.defineSizeForWidht(lbl);
            lbl.AutoSize = true;
            lbl.Location = new Point(0, pnl.Height - lbl.Height);
            int height = lbl.Height;
            lbl.AutoSize = false;
            lbl.Size = new Size(pnl.Width, height);

            int picSize = pnl.Height - lbl.Height;
            pic.Size = new Size(picSize, picSize);
            pic.Location = new Point((pnl.Width / 2) - (picSize / 2), 0);
        }

        private void onMouseEnter(object sender, EventArgs e)
        {
            _backColor = BackColor;
            BackColor = HoverColor;
        }

        private void onMouseLeave(object sender, EventArgs e)
        {
            BackColor = _backColor;
        }

        private void onClick(object sender, EventArgs e)
        {
            if (sender != this)
            {
                Cursor.Current = Cursors.WaitCursor;
                Click?.Invoke(this, e);
                Cursor.Current = Cursors.Default;
            }
        }

        private void btnUIX_BackColorChanged(object sender, EventArgs e)
        {
            pic.BackColor = BackColor;
            lbl.BackColor = BackColor;
            pnl.BackColor = BackColor;
        }

        private void btnUIX_FontChanged(object sender, EventArgs e)
        {
            lbl.Font = Font;
            update();
        }

        private void btnUIX_SizeChanged(object sender, EventArgs e)
        {
            update();
        }
    }
}
