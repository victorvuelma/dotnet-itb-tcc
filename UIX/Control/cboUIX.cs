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

        public void add(int id, object obj)
        {
            cbo.Items.Add(new UIXComboBoxItem
            {
                Id = id,
                Name = obj.ToString()
            });
        }

        public void add(object obj)
        {
            add(cbo.Items.Count, obj);
        }

        public void addRange(object[] objects)
        {
            foreach (object obj in objects)
            {
                add(obj);
            }
        }

        public void clear()
        {
            cbo.Items.Clear();
        }

        public bool contains(string nome)
        {
            foreach (UIXComboBoxItem item in Items)
            {
                if (item.Name.Equals(nome))
                {
                    return true;
                }
            }
            return false;
        }

        public List<UIXComboBoxItem> Items
        {
            get
            {
                List<UIXComboBoxItem> items = new List<UIXComboBoxItem>();
                foreach (object obj in cbo.Items)
                {
                    if (obj is UIXComboBoxItem item)
                        items.Add(item);
                }
                return items;
            }
        }

        public UIXComboBoxItem SelectedItem => (UIXComboBoxItem)cbo.SelectedItem;
        //---- PROPRIEDADES UIX

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

        public new String Name
        {
            get => base.Name;
            set
            {
                base.Name = value;
                cbo.Name = value;
            }
        }

        private void update()
        {
            if (_loaded)
            {
                if (Size.Height < cbo.Height)
                {
                    Size = new Size(Width, cbo.Height);
                    return;
                }

                lbl.AutoSize = true;
                switch (LabelPosition)
                {
                    case uixEnum.uixLabelPosition.SIDE:
                        lbl.MaximumSize = new Size(0, 0);
                        cbo.Location = new Point(lbl.Location.X + lbl.Size.Width, cbo.Location.Y);
                        cbo.Size = new Size(Size.Width - cbo.Location.X, Size.Height);
                        break;
                    case uixEnum.uixLabelPosition.UP:
                        lbl.MaximumSize = new Size(Width, 1000);
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

        public class UIXComboBoxItem
        {

            private string _name;
            private int _id;

            public string Name { get => _name; set => _name = value; }
            public int Id { get => _id; set => _id = value; }

            public override string ToString()
            {
                return Name;
            }

        }

        private void cboUIX_SizeChanged(object sender, EventArgs e)
        {
            update();
        }

        private void cboUIX_FontChanged(object sender, EventArgs e)
        {
            update();
        }
    }
}
