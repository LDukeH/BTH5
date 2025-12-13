namespace Bai09
{
    public partial class Form1 : Form
    {
        string selectedShape = "Circle";
        public Form1()
        {
            InitializeComponent();

            drawingBox.Items.Add("Circle");
            drawingBox.Items.Add("Square");
            drawingBox.Items.Add("Ellipse");
            drawingBox.Items.Add("Filled Circle");
            drawingBox.Items.Add("Filled Square");
            drawingBox.Items.Add("Filled Ellipse");

            drawingBox.SelectedIndex = 0;
            
            drawingBox.SelectedIndexChanged += DrawingBox_SelectedIndexChanged;

            drawingPanel.Paint += DrawingPanel_Paint;
        }
        private void DrawingBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedShape = drawingBox.SelectedItem.ToString();

            //Ve lai panel
            drawingPanel.Invalidate();
        }

        private void DrawingPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Pen pen = new Pen(Color.Red, 3);
            SolidBrush brush = new SolidBrush(Color.Red);

            int width = drawingPanel.Width;
            int height = drawingPanel.Height;

            Rectangle rect = new Rectangle(width / 4, height / 4, width / 2, height / 2);

            switch (selectedShape)
            {
                case "Circle":
                    int circleSize = Math.Min(width, height) / 2;
                    Rectangle circleRect = new Rectangle(width / 2 - circleSize / 2, height / 2 - circleSize / 2, circleSize, circleSize);
                    g.DrawEllipse(pen, circleRect);
                    break;

                case "Square":
                    g.DrawRectangle(pen, rect.X, rect.Y, rect.Width/2, rect.Width/2);
                    break;

                case "Ellipse":
                    g.DrawEllipse(pen, rect);
                    break;


                case "Filled Circle":
                    int filledCircleSize = Math.Min(width, height) / 2;
                    Rectangle filledCircleRect = new Rectangle(width / 2 - filledCircleSize / 2, height / 2 - filledCircleSize / 2, filledCircleSize, filledCircleSize);
                    g.FillEllipse(brush, filledCircleRect);
                    break;

                case "Filled Square":
                    g.FillRectangle(brush, rect.X, rect.Y, rect.Width, rect.Width);
                    break;

                case "Filled Ellipse":
                    g.FillEllipse(brush, rect);
                    break;

            }

            pen.Dispose();
            brush.Dispose();
        }
    }
}
