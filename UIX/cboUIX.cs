using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.ComboBox;
using System.Drawing.Design;

namespace UIX
{
    public partial class cboUIX : UserControl
    {

        private bool _loaded = false;

        private IButtonControl _acceptButton;
        private uixEnum.uixLabelPosition _labelPosition = uixEnum.uixLabelPosition.SIDE;

        public cboUIX()
        {
            InitializeComponent();
        }

        //---- PROPRIEDADES UIX
        public IButtonControl AcceptButton { get => _acceptButton; set => _acceptButton = value; }

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

        [Editor("System.Windows.Forms.Design.ListControlStringCollectionEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        public ObjectCollection Items => cbo.Items;

        public object SelectedItem => cbo.SelectedItem;

        public bool FormattingEnabled { get => cbo.FormattingEnabled; set => cbo.FormattingEnabled = value; }

        public new bool Enabled { get => cbo.Enabled; set => cbo.Enabled = value; }

        public override String Text { get => cbo.Text; set => cbo.Text = value; }

        public String Campo
        {
            get => cbo.AccessibleName;
            set
            {
                cbo.AccessibleName = value;
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

        private void update()
        {
            if (_loaded)
            {
                lbl.AutoSize = true;
                switch (LabelPosition)
                {
                    case uixEnum.uixLabelPosition.SIDE:
                        cbo.Location = new Point(lbl.Location.X + lbl.Size.Width, cbo.Location.Y);
                        cbo.Size = new Size(Size.Width - cbo.Location.X, Size.Height);
                        break;
                    case uixEnum.uixLabelPosition.UP:
                        cbo.Location = new Point(0, lbl.Location.Y + lbl.Size.Height);
                        cbo.Size = new Size(Size.Width, Size.Height - cbo.Location.Y);
                        break;
                }
            }
        }

        private void cboUIX_Load(object sender, EventArgs e)
        {
            _loaded = true;

            update();
        }

        private void cbo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
                if (AcceptButton != null)
                {
                    AcceptButton.PerformClick();
                }
            }
        }
    }
}
