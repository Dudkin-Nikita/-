using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApp1
{
    class Circle : Shape
    {
        private int radius, x_position, y_position;

        public Circle(Pen pen, int x, int y, int rad, SolidBrush brush) : base(pen, brush)
        {
            this.radius = rad;
            this.x_position = x;
            this.y_position = y;
        }

        public override void Draw_Shape(Graphics graphics)
        {
            graphics.DrawEllipse(pen, x_position, y_position, radius, radius);
            graphics.FillEllipse(brush, x_position, y_position, radius, radius);
        }
    }
}
