namespace Bai06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            fontList.DrawMode = DrawMode.OwnerDrawFixed;
            fontList.ItemHeight = 24;
            fontList.DrawItem += new DrawItemEventHandler(listBoxFontsDrawItem);

            foreach (FontFamily font in FontFamily.Families)
            {
                fontList.Items.Add(font.Name);
            }
        }

        private void listBoxFontsDrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();

            if (e.Index >= 0)
            {
                string fontName = fontList.Items[e.Index].ToString();
                Font fontToDraw;
                FontFamily family = new FontFamily(fontName);

                if (family.IsStyleAvailable(FontStyle.Regular))
                    fontToDraw = new Font(family, 12, FontStyle.Regular);
                else if (family.IsStyleAvailable(FontStyle.Bold))
                    fontToDraw = new Font(family, 12, FontStyle.Bold);
                else if (family.IsStyleAvailable(FontStyle.Italic))
                    fontToDraw = new Font(family, 12, FontStyle.Italic);
                else
                    fontToDraw = new Font("Arial", 12);

                Brush textBrush = new SolidBrush(e.ForeColor);

                e.Graphics.DrawString(fontName, fontToDraw, textBrush, e.Bounds);
                fontToDraw.Dispose();
                family.Dispose();
                textBrush.Dispose();
            }

            e.DrawFocusRectangle();
        }
    }
}