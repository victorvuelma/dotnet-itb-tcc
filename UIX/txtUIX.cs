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
    public partial class txtUIX : UserControl
    {

        private uixEnum.uixLabelPosition _labelPosition = uixEnum.uixLabelPosition.SIDE;
        private uixEnum.uixAllowedChars _allowedChars = uixEnum.uixAllowedChars.ALL;
        private char[] allowedChars = new char[] { };

        public txtUIX()
        {
            InitializeComponent();
        }

        public String Campo
        {
            get => txt.AccessibleName;
            set
            {
                txt.AccessibleName = value;
                lbl.Text = value + ":";
                update();
            }
        }

        public new Font Font
        {
            get => base.Font;
            set
            {
                base.Font = value;
                update();
            }
        }

        public new Size Size
        {
            get => base.Size;
            set
            {
                base.Size = value;
                update();
            }
        }

        public uixEnum.uixAllowedChars AllowedChars
        {
            get => _allowedChars; set
            {
                allowedChars = uixUtil.getChars(value);
                _allowedChars = value;
            }
        }

        public uixEnum.uixLabelPosition LabelPosition
        {
            get => _labelPosition;
            set {
                _labelPosition = value;
                update();
            }
        }

        public int MaxLength { get => txt.MaxLength; set => txt.MaxLength = value; }

        public new bool Enabled { get => txt.Enabled; set => txt.Enabled = value; }

        public override String Text { get => txt.Text; set => txt.Text = value; }

        public bool Multiline
        {
            get => txt.Multiline;
            set
            {
                txt.Multiline = value;
                update();
            }
        }

        private void update()
        {
            lbl.AutoSize = true;
            switch (LabelPosition)
            {
                case uixEnum.uixLabelPosition.SIDE:
                    txt.Location = new Point(lbl.Location.X + lbl.Size.Width, txt.Location.Y);
                    txt.Size = new Size(Size.Width - txt.Location.X, Size.Height);
                    break;
                case uixEnum.uixLabelPosition.UP:
                    txt.Location = new Point(0, lbl.Location.Y + lbl.Size.Height);
                    txt.Size = new Size(Size.Width, Size.Height - txt.Location.Y);
                    break;
            }
        }

        private void txtUIX_Load(object sender, EventArgs e)
        {
            update();
        }

        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (allowedChars.Count() >= 1)
            {
                if (!char.IsControl(e.KeyChar) && !allowedChars.Contains(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

    }
}
