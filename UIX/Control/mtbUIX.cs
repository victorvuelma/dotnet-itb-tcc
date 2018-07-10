using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Design;

namespace UIX
{
    public partial class mtbUIX : UserControl
    {

        public event EventHandler TextChange;

        private bool _loaded = false;

        private IButtonControl _acceptButton;
        private uixEnum.uixLabelPosition _labelPosition = uixEnum.uixLabelPosition.SIDE;

        public mtbUIX()
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

        [Editor("System.Windows.Forms.Design.MaskPropertyEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        public String Mask { get => mtb.Mask; set => mtb.Mask = value; }

        public Type ValidatingType { get => mtb.ValidatingType; set => mtb.ValidatingType = value; }

        public int MaxLength { get => mtb.MaxLength; set => mtb.MaxLength = value; }

        public new bool Enabled { get => mtb.Enabled; set => mtb.Enabled = value; }

        public override String Text { get => mtb.Text; set => mtb.Text = value; }

        public String Campo
        {
            get => mtb.AccessibleName;
            set
            {
                mtb.AccessibleName = value;
                lbl.Text = value + ":";
                update();
            }
        }
        
        public new String Name
        {
            get => base.Name;
            set
            {
                base.Name = value;
                mtb.Name = value;
            }
        }

        private void update()
        {
            if (_loaded)
            {
                if (Size.Height < mtb.Height)
                {
                    Size = new Size(Width, mtb.Height);
                    return;
                }

                lbl.AutoSize = true;
                switch (LabelPosition)
                {
                    case uixEnum.uixLabelPosition.SIDE:
                        lbl.MaximumSize = new Size(0, 0);
                        mtb.Location = new Point(lbl.Location.X + lbl.Size.Width, mtb.Location.Y);
                        mtb.Size = new Size(Size.Width - mtb.Location.X, Size.Height);
                        break;
                    case uixEnum.uixLabelPosition.UP:
                        lbl.MaximumSize = new Size(Width, 1000);
                        mtb.Location = new Point(0, lbl.Location.Y + lbl.Size.Height);
                        mtb.Size = new Size(Size.Width, Size.Height - mtb.Location.Y);
                        break;
                }
            }
        }

        private void mtbUIX_Load(object sender, EventArgs e)
        {
            _loaded = true;

            update();
        }

        private void mtb_Click(object sender, EventArgs e)
        {
            mtb.SelectionStart = 0;
        }

        private void mtb_KeyPress(object sender, KeyPressEventArgs e)
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

        private void mtb_TextChanged(object sender, EventArgs e)
        {
            TextChange?.Invoke(sender, e);
        }

        private void mtbUIX_SizeChanged(object sender, EventArgs e)
        {
            update();
        }

        private void mtbUIX_FontChanged(object sender, EventArgs e)
        {
            update();
        }
    }
}
