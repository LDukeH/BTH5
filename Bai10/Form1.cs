using System.Drawing.Drawing2D;

namespace Bai10
{
    public partial class Form1 : Form
    {
        //Class luu tru thong tin cac duong net
        private class Stroke
        {
            public List<Point> Points = new List<Point>();
            public Pen Pen;
        }

        //De co the ve dau cuoi
        private bool isDrawing = false;

        private List<Stroke> strokes = new List<Stroke>();
        private Stroke currentStroke;

        public Form1()
        {
            InitializeComponent();

            //Initalize combobox
            dashStyle.DataSource = Enum.GetValues(typeof(DashStyle));
            dashCap.DataSource = Enum.GetValues(typeof(DashCap));
            endCap.DataSource = Enum.GetValues(typeof(LineCap));
            startCap.DataSource = Enum.GetValues(typeof(LineCap));
            lineJoin.DataSource = Enum.GetValues(typeof(LineJoin));

            dashStyle.SelectedIndex = 0;
            dashCap.SelectedIndex = 0;
            endCap.SelectedIndex = 0;
            startCap.SelectedIndex = 0;
            lineJoin.SelectedIndex = 0;
            lineWidth.SelectedIndex = 11;

            dashStyle.SelectedIndexChanged += onComboBoxChange;
            dashCap.SelectedIndexChanged += onComboBoxChange;
            endCap.SelectedIndexChanged += onComboBoxChange;
            startCap.SelectedIndexChanged += onComboBoxChange;
            lineJoin.SelectedIndexChanged += onComboBoxChange;
            lineWidth.SelectedIndexChanged += onComboBoxChange;

            panelDraw.Paint += PanelDraw_Paint;
            panelDraw.MouseDown += panelDrawMouseDown;
            panelDraw.MouseMove += PanelDraw_MouseMove;
            panelDraw.MouseUp += (s, e) => { isDrawing = false; };
        }

        private Pen createPen()
        {
            if (dashStyle.SelectedItem == null ||
                dashCap.SelectedItem == null ||
                startCap.SelectedItem == null ||
                endCap.SelectedItem == null)
                return null;

            Pen pen = new Pen(Color.Red, float.Parse(lineWidth.SelectedItem.ToString()));

            pen.DashStyle = (DashStyle)dashStyle.SelectedItem;
            pen.DashCap = (DashCap)dashCap.SelectedItem;
            pen.StartCap = (LineCap)startCap.SelectedItem;
            pen.EndCap = (LineCap)endCap.SelectedItem;
            pen.LineJoin = (LineJoin)lineJoin.SelectedItem;

            return pen;
        }

        private void panelDrawMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;

            isDrawing = true;

            currentStroke = new Stroke();
            currentStroke.Pen = createPen();

            if (currentStroke.Pen == null)
            {
                isDrawing = false;
                return;
            }

            currentStroke.Points.Add(e.Location);

            strokes.Add(currentStroke);
        }

        //De duong net di theo chuot
        private void PanelDraw_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isDrawing) return;

            currentStroke.Points.Add(e.Location);
            panelDraw.Invalidate();
        }

        //Ve lai panel khi thay doi combobox
        private void onComboBoxChange(object senders, EventArgs e)
        {
            panelDraw.Invalidate();
        }

        private void PanelDraw_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            foreach (var stroke in strokes)
            {
                if (stroke.Points.Count > 1)
                    g.DrawLines(stroke.Pen, stroke.Points.ToArray());
            }
        }
    }
}