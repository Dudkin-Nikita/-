using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        List<Shape> List_of_shapes = new List<Shape>();
        Graphics graphics;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            List_of_shapes.Add(new Circle(new Pen(Color.Orange, 6), 50, 50, 100, new SolidBrush(Color.Navy)));
            List_of_shapes.Add(new Ellipse(new Pen(Color.Orange, 6), 40, 175, 120, 80, new SolidBrush(Color.Navy)));
            List_of_shapes.Add(new Rectangle(new Pen(Color.Orange, 6), 200, 50, 80, 120, new SolidBrush(Color.Navy)));
            List_of_shapes.Add(new Square(new Pen(Color.Orange, 6), 200, 175, 100, new SolidBrush(Color.Navy)));
            List_of_shapes.Add(new Triangle(new Pen(Color.Orange, 6), new Point(450, 50), new Point(375, 140),
            new Point(525, 140), new SolidBrush(Color.Navy)));
            List_of_shapes.Add(new Polygon(new Pen(Color.Orange, 6), new Point(390, 200), new Point(440, 200),
            new Point(475, 240), new Point(440, 280), new Point(390, 280), new Point(355, 240), new SolidBrush(Color.Navy)));
            List_of_shapes.Add(new Line(new Pen(Color.Orange, 6), new Point(50, 300), new Point(500, 300), new SolidBrush(Color.Navy)));
        }

        private void button_draw_Click(object sender, EventArgs e)
        {
            foreach (Shape shape in List_of_shapes)             
            {
                button_draw.Text = shape.ToString();
                shape.Draw_Shape(graphics);
            }

            button_draw.Enabled = false;
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            graphics = this.CreateGraphics();
        }
    }
}
