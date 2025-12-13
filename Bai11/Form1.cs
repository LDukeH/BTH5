using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Bai11
{
    public partial class Form1 : Form
    {
        private Point startPoint;
        private Color _color = Color.Black;

        public Form1()
        {
            InitializeComponent();

            panelDraw.MouseDown += panelDrawMouseDown;
            panelDraw.MouseUp += panelDrawMouseUp;
        }

        private void colorButton_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    _color = colorDialog.Color;
                }
            }
        }

        private void panelDrawMouseDown(object sender, MouseEventArgs e)
        {
            startPoint = e.Location;
        }

        private void panelDrawMouseUp(object sender, MouseEventArgs e)
        {
            Graphics g = panelDraw.CreateGraphics();
            g.SmoothingMode = SmoothingMode.AntiAlias;

            Point endPoint = e.Location;
            if (endPoint == startPoint)
                return;

            //Phan rect se bao quanh cac hinh ve
            Rectangle rect = getRect(startPoint, endPoint);
            if (rect.Width == 0 || rect.Height == 0)
                return;

            //Cac brush tao san
            SolidBrush solidBrush = new SolidBrush(_color);
            HatchBrush hatchBrush = new HatchBrush(HatchStyle.Horizontal, Color.Blue, Color.Green);
            LinearGradientBrush linearBrush = new LinearGradientBrush(rect, Color.Red, Color.Green, LinearGradientMode.Vertical);

            Image img = Image.FromFile("texture.png");
            TextureBrush textureBrush = new TextureBrush(img);

            if (lineRadio.Checked)
            {
                float width = (float)penWidth.Value;
                Pen p = new Pen(_color, width);
                g.DrawLine(p, startPoint, endPoint);
            }

            //Ve rectangle
            if (rectRadio.Checked)
            {
                if (solidRadio.Checked)
                {
                    g.FillRectangle(solidBrush, rect);
                }
                else if (hatchRadio.Checked)
                {
                    g.FillRectangle(hatchBrush, rect);
                }
                else if (linearRadio.Checked)
                {
                    g.FillRectangle(linearBrush, rect);
                }
                else if (textureRadio.Checked)
                {
                    g.FillRectangle(textureBrush, rect);
                }
            }

            //Ve ellipse
            if (elipseRadio.Checked)
            {
                if (solidRadio.Checked)
                {
                    g.FillEllipse(solidBrush, rect);
                }
                else if (hatchRadio.Checked)
                {
                    g.FillEllipse(hatchBrush, rect);
                }
                else if (linearRadio.Checked)
                {
                    g.FillEllipse(linearBrush, rect);
                }
                else if (textureRadio.Checked)
                {
                    g.FillEllipse(textureBrush, rect);
                }
            }
        }

        private Rectangle getRect(Point p1, Point p2)
        {
            int x = Math.Min(p1.X, p2.X);
            int y = Math.Min(p1.Y, p2.Y);
            int width = Math.Abs(p1.X - p2.X);
            int height = Math.Abs(p1.Y - p2.Y);
            return new Rectangle(x, y, width, height);
        }
    }
}