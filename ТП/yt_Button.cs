using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace ТП
{
    public static class Drawer
    {
        public static GraphicsPath RoundedRectangle(Rectangle rectangle, float RoundSize)
        {
            GraphicsPath gp = new GraphicsPath();

            gp.AddArc(rectangle.X, rectangle.Y, RoundSize, RoundSize, 180, 90);
            gp.AddArc(rectangle.X + rectangle.Width - RoundSize, rectangle.Y, RoundSize, RoundSize, 270, 90);
            gp.AddArc(rectangle.X + rectangle.Width - RoundSize, rectangle.Y + rectangle.Height - RoundSize, RoundSize, RoundSize, 0, 90);
            gp.AddArc(rectangle.X, rectangle.Y + rectangle.Height - RoundSize, RoundSize, RoundSize, 90, 90);

            gp.CloseFigure();

            return gp;
        }
    }

    public class yt_Button : Button
    {
        private StringFormat SF = new StringFormat();

        private bool roundingEneble = false;
        [Description("Вкл/Выкл закругление")]
        public bool RoundingEneble
        {
            get => roundingEneble;
            set
            {
                roundingEneble = value;
                Refresh();
            }
        }

        private int roundingPercent = 100;
        [DisplayName("Rounding %")]
        [DefaultValue(100)]
        [Description("Радиус в процентах")]
        public int Rounding
        {
            get => roundingPercent;
            set
            {
                if (value >= 0 && value <= 100)
                {
                    roundingPercent = value;
                    Refresh();
                }
            }
        }

        private bool MouseEntered = false;
        private bool MousePressed = false;

        public yt_Button()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.UserPaint, true);
            DoubleBuffered = true;

            Size = new Size(40, 40);

            BackColor = Color.FromArgb(224, 224, 224);

            SF.Alignment = StringAlignment.Center;
            SF.LineAlignment = StringAlignment.Center;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics graph = e.Graphics;
            graph.SmoothingMode = SmoothingMode.HighQuality;

            graph.Clear(Parent.BackColor);

            Rectangle rectangle = new Rectangle(0, 0, Width - 1, Height - 1);

            float roudingValuse = 0.1F;
            if(RoundingEneble && roundingPercent > 0)
            {
                roudingValuse = Height / 100F * roundingPercent;
            }

            GraphicsPath rectanglePath = Drawer.RoundedRectangle(rectangle, roudingValuse);

            graph.DrawPath(new Pen(BackColor), rectanglePath);
            graph.FillPath(new SolidBrush(BackColor), rectanglePath);

            if (MouseEntered)
            {
                graph.DrawPath(new Pen(Color.FromArgb(20, Color.Black)), rectanglePath);
                graph.FillPath(new SolidBrush(Color.FromArgb(20, Color.Black)), rectanglePath);
            }

            graph.DrawString(Text, Font, new SolidBrush(ForeColor), rectangle, SF);
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);

            MouseEntered = true;

            Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);

            MouseEntered = false;

            Invalidate();
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);

            MousePressed = true;

            Invalidate();
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);

            MousePressed = false;

            Invalidate();
        }
    }
}