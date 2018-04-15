using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Drawing;

namespace UIX
{
    public class uixHeader
    {

        public static void hdrApply(Form frm, uctUIX ctl, uixStyle style)
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
            uixLabel.lblApply(ctl.lblTitulo, style.FormColor, style.HeaderFont);
            ctl.lblTitulo.Font = uixFont.fontSize(ctl.lblTitulo.Font, 10f);
            ctl.lblTitulo.BackColor = style.FormColor.DarkColor;

            ctl.picFormIcon.Location = new Point(style.HeaderButtonSpace, style.HeaderButtonSpace);
            ctl.picFormIcon.Size = new Size(style.HeaderButtonSize, style.HeaderButtonSize);
            ctl.picFormIcon.BackColor = style.FormColor.DarkColor;
            ctl.picFormIcon.SizeMode = PictureBoxSizeMode.Zoom;
            ctl.picFormIcon.BringToFront();

            //Calculate buttons
            int nextButtonX = maxX;
            //Close button
            if (ctl.btnClose != null)
            {
                nextButtonX = nextButtonX - style.HeaderButtonSize - style.HeaderButtonSpace;
                ctl.btnClose.Location = new Point(nextButtonX, style.HeaderButtonSpace);
                ctl.btnClose.BringToFront();

                uixButton.btnStyleClose(ctl.btnClose, style.HeaderButtonSize, style.HeaderCloseButtonColor);
            }
            //Minimize button
            if (ctl.btnMin != null)
            {
                nextButtonX = nextButtonX - style.HeaderButtonSize - style.HeaderButtonSpace;
                ctl.btnMin.Location = new Point(nextButtonX, style.HeaderButtonSpace);
                ctl.btnMin.BringToFront();

                uixButton.btnStyleMinimize(ctl.btnMin, style.HeaderButtonSize, style.HeaderButtonColor);
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

}
