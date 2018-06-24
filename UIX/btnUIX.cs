using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIX
{
    public partial class btnUIX : Button
    {

        public new event EventHandler Click;

        private Color _hoverColor;
        private Color _backColor;

        public btnUIX()
        {
            base.Size = new Size(80, 80);

            InitializeComponent();

            HoverColor = Color.Transparent;
        }

        public Color HoverColor { get => _hoverColor; set => _hoverColor = value; }

        public new Color BackColor
        {
            get => base.BackColor;
            set
            {
                pic.BackColor = value;
                lbl.BackColor = value;
                base.BackColor = value;
            }
        }

        public new Font Font
        {
            get => base.Font;
            set
            {
                lbl.Font = value;
                update();
            }
        }

        public String Description
        {
            get => lbl.Text;
            set
            {
                lbl.Text = value;
                base.Text = value;
                update();
            }
        }

        public new Image Image { get => pic.Image; set => pic.Image = value; }

        public String ImageLocation { get => pic.ImageLocation; set => pic.ImageLocation = value; }

        public new Size Size
        {
            get => base.Size;
            set
            {
                Size oldSize = base.Size;

                int heightDiff = value.Height - oldSize.Height;
                int widthDiff = value.Width - oldSize.Width;

                pic.Size = new Size(pic.Size.Width + widthDiff, pic.Size.Height + heightDiff);
                pic.Location = new Point((value.Width / 2) - (pic.Size.Width / 2), pic.Location.Y);

                lbl.Size = new Size(value.Width, lbl.Size.Height);
                int lblY = value.Height - lbl.Height;
                lbl.Location = new Point(lbl.Location.X, lblY);

                base.Size = value;

                update();
            }
        }

        private void update()
        {
            UIX.uixUtil.defineSizeForWidht(lbl);
        }

        private void btnUIX_MouseEnter(object sender, EventArgs e)
        {
            _backColor = BackColor;
            BackColor = HoverColor;
        }

        private void btnUIX_MouseLeave(object sender, EventArgs e)
        {
            BackColor = _backColor;
        }

        private void onClick(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (Click != null)
            {
                Click(sender, e);
            }
            Cursor.Current = Cursors.Default;
        }

        private void btnUIX_BackColorChanged(object sender, EventArgs e)
        {
            BackColor = BackColor;
        }
    }
}
