﻿using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using vitorrdgs.UiX.Property;
using vitorrdgs.Util.Form;

namespace vitorrdgs.UiX.Component
{
    public partial class UIXTextBox : UserControl
    {

        public event EventHandler TextChange;

        private bool _loaded = false;

        private IButtonControl _acceptButton;
        private uixEnum.uixLabelPosition _labelPosition = uixEnum.uixLabelPosition.SIDE;

        private uixEnum.uixTextBoxMode _mode = uixEnum.uixTextBoxMode.ALL;
        private char[] allowedChars = new char[] { };

        public UIXTextBox()
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

        public override String Text
        {
            get => txt.Text; set
            {
                txt.Text = value;
                updateLabel();
            }
        }

        public ScrollBars ScrollBars { get => txt.ScrollBars; set => txt.ScrollBars = value; }

        public String Campo
        {
            get => txt.AccessibleName;
            set
            {
                txt.AccessibleName = value;
                updateLabel();
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

        private void updateLabel()
        {
            lbl.Text = Campo + ":";
            if (!txt.Enabled)
            {
                switch (LabelPosition)
                {
                    case uixEnum.uixLabelPosition.SIDE:
                        lbl.Text += " " + txt.Text;
                        break;
                    case uixEnum.uixLabelPosition.UP:
                        lbl.Text += "\n" + txt.Text;
                        break;
                }
            }
        }

        private void update()
        {
            if (_loaded)
            {
                if (Size.Height < txt.Height)
                {
                    Size = new Size(Width, txt.Height);
                    return;
                }

                lbl.AutoSize = true;
                switch (LabelPosition)
                {
                    case uixEnum.uixLabelPosition.SIDE:
                        lbl.MaximumSize = new Size(0, 0);
                        txt.Location = new Point(lbl.Location.X + lbl.Size.Width, txt.Location.Y);
                        txt.Size = new Size(Size.Width - txt.Location.X, Size.Height);
                        break;
                    case uixEnum.uixLabelPosition.UP:
                        lbl.MaximumSize = new Size(Width, 1000);
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

                    UtilFormValor.defineForMoney(txt);
                }
            }
            updateLabel();
            TextChange?.Invoke(sender, e);
        }

        private void txtUIX_SizeChanged(object sender, EventArgs e)
        {
            update();
        }

        private void txtUIX_FontChanged(object sender, EventArgs e)
        {
            update();
        }

        private void txt_EnabledChanged(object sender, EventArgs e)
        {
            txt.Visible = txt.Enabled;
            updateLabel();
        }

        private void txt_Enter(object sender, EventArgs e)
        {
            txt.SelectionStart = txt.Text.Length;
        }
    }
}
