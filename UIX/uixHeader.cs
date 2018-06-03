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

        public static void hdrApply(Form frm, hdrUIX hdr, uixStyle style)
        {
            int maxX = frm.Size.Width;
            int maxY = frm.Size.Height;

            //Apply header bar Style
            hdr.Size = new Size(maxX, style.HeaderButtonSize + (style.HeaderButtonSpace * 2));
            hdr.Location = new Point(0, 0);
            hdr.BackColor = style.FormColor.DarkColor;

            //Apply header title style
            hdr.lbl.BringToFront();
            uixLabel.lblApply(hdr.lbl, style.FormColor, style.HeaderFont);
            hdr.lbl.Font = uixFont.fontSize(hdr.lbl.Font, 12.5f);
            hdr.lbl.BackColor = style.FormColor.DarkColor;

            hdr.pic.Location = new Point(style.HeaderButtonSpace, style.HeaderButtonSpace);
            hdr.pic.Size = new Size(style.HeaderButtonSize, style.HeaderButtonSize);
            hdr.pic.BackColor = style.FormColor.DarkColor;
            hdr.pic.SizeMode = PictureBoxSizeMode.Zoom;
            hdr.pic.BringToFront();

            //Calculate buttons
            int nextButtonX = maxX;
            //Close button
            if (hdr.btnClo != null)
            {
                nextButtonX = nextButtonX - style.HeaderButtonSize - style.HeaderButtonSpace;
                hdr.btnClo.Location = new Point(nextButtonX, style.HeaderButtonSpace);
                hdr.btnClo.BringToFront();

                uixButton.btnStyleClose(hdr.btnClo, style.HeaderButtonSize, style.ButtonWarningColor);
            }
            //Minimize button
            if (hdr.btnMin != null)
            {
                nextButtonX = nextButtonX - style.HeaderButtonSize - style.HeaderButtonSpace;
                hdr.btnMin.Location = new Point(nextButtonX, style.HeaderButtonSpace);
                hdr.btnMin.BringToFront();

                uixButton.btnStyleMinimize(hdr.btnMin, style.HeaderButtonSize, style.HeaderButtonColor);
            }

            uixUtil.defineSizeForWidht(hdr.lbl, nextButtonX - 10);
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
