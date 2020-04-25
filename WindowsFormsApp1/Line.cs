using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApp1
{
    class Line : Shape
    {
        private Point point_1, point_2;
        public Line(Pen pen, Point first_point, Point second_point, SolidBrush brush) : base(pen, brush)
        {
            this.point_1 = first_point;
            this.point_2 = second_point;
        }
        public override void Draw_Shape(Graphics graphics)
        {
            graphics.DrawLine(pen, point_1, point_2);
        }
    }
}
