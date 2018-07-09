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

        public EventHandler TextChange;

        private bool _loaded = false;

        private IButtonControl _acceptButton;
        private uixEnum.uixLabelPosition _labelPosition = uixEnum.uixLabelPosition.SIDE;

        private uixEnum.uixTextBoxMode _mode = uixEnum.uixTextBoxMode.ALL;
        private char[] allowedChars = new char[] { };

        public txtUIX()
        {
            InitializeComponent();
        }

        //---- PROPRIEDADES UIX
        public IButtonControl AcceptButton { get => _acceptButton; set => _acceptButton = value; }

        public uixEnum.uixTextBoxMode Mode
        {
            get => _mode; set
            {
                allowedChars = uixUtil.getChars(value);
                _mode = value;
            }
        }

        public uixEnum.uixLabelPosition LabelPosition
        {
            get => _labelPosition;
            set
            {
                _labelPosition = value;
                update();
            }
        }
        //---- PROPRIEDADES UIX

        public int MaxLength { get => txt.MaxLength; set => txt.MaxLength = value; }

        public new bool Enabled { get => txt.Enabled; set => txt.Enabled = value; }

        public override String Text { get => txt.Text; set => txt.Text = value; }

        public ScrollBars ScrollBars { get => txt.ScrollBars; set => txt.ScrollBars = value; }

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

        public bool Multiline
        {
            get => txt.Multiline;
            set
            {
                txt.Multiline = value;
                update();
            }
        }

        public new String Name
        {
            get => base.Name;
            set
            {
                base.Name = value;
                txt.Name = value;
            }
        }

        private void update()
        {
            if (_loaded)
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
        }

        private void txtUIX_Load(object sender, EventArgs e)
        {
            _loaded = true;

            update();

            if (Mode == uixEnum.uixTextBoxMode.MONEY && String.IsNullOrWhiteSpace(txt.Text))
            {
                txt.Text = "0,00";
            }
        }

        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
                if (AcceptButton != null)
                {
                    AcceptButton.PerformClick();
                }
            }
            else
            if (allowedChars.Count() >= 1)
            {
                if (!char.IsControl(e.KeyChar) && !allowedChars.Contains(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void txt_TextChanged(object sender, EventArgs e)
        {
            if (Mode == uixEnum.uixTextBoxMode.MONEY)
            {
                if (!txt.Text.Contains(",") && !txt.Text.Contains("."))
                {
                    txt.Text = txt.Text + ",00";
                }
                else
                {
                    string[] num = txt.Text.Split(',');
                    if (num.Length > 1)
                    {
                        if (num[1].Length > 2)
                        {
                            num[1] = num[1].Substring(0, 2);
                        }
                        txt.Text = num[0] + "," + num[1];
                    }

                    uixUtil.defineForMoney(txt);
                }
            }
            if (TextChange != null)
            {
                TextChange(sender, e);
            }
        }
    }
}
