using System;
using System.Windows.Forms;
using System.Drawing;

namespace UIX
{

    public partial class hdrUIX : UserControl
    {

        public event EventHandler Close;
        public event EventHandler Min;

        public hdrUIX()
        {
            InitializeComponent();
        }

        public bool ButtonCloseEnabled { get => btnClo.Visible; set => btnClo.Visible = value; }
        public bool ButtonMinEnabled { get => btnMin.Visible; set => btnMin.Visible = value; }

        public Image Image { get => pic.Image; set => pic.Image = value; }

        public String Title
        {
            get => lbl.Text;
            set
            {
                lbl.Text = value;
                uixUtil.defineSizeForWidht(lbl);
                if (ParentForm != null)
                    ParentForm.Text = value;
            }
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            Min?.Invoke(this, e);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close?.Invoke(this, e);
        }

        private void hdrUIX_SizeChanged(object sender, EventArgs e)
        {
            lbl.Size = Size;
            btnClo.Location = new Point(Size.Width - 50, 10);
            btnMin.Location = new Point(Size.Width - 100, 10);
        }

        private void hdrUIX_Load(object sender, EventArgs e)
        {
            ParentForm.Text = Title;

            Rectangle resolution = Screen.PrimaryScreen.Bounds;
            _maxX = resolution.Width - ParentForm.Width;
            _maxY = resolution.Height - ParentForm.Height;
        }

        // DRAG
        private bool _dragging = false;
        private Point _dragCursorPoint, _dragFormPoint;
        private int _maxX, _maxY;

        private void mouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void mouseMove(object sender, MouseEventArgs e)
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
                ParentForm.Location = location;
            }
        }

        private void mouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _dragCursorPoint = Cursor.Position;
            _dragFormPoint = ParentForm.Location;
        }


    }
}
