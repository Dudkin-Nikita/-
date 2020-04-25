using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApp1
{
    class Ellipse : Shape
    {
        private int height, width, x_position, y_position;

        public Ellipse(Pen pen, int x, int y, int hei, int wid, SolidBrush brush) : base(pen, brush)
        {
            this.height = hei;
            this.width = wid;
            this.x_position = x;
            this.y_position = y;
        }

        public override void Draw_Shape(Graphics graphics)
        {
            graphics.DrawEllipse(pen, x_position, y_position, height, width);
            graphics.FillEllipse(brush, x_position, y_position, height, width);
        }
    }
}
