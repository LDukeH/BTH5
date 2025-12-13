namespace Bai04
{
    public partial class Form1 : Form
    {
        private int[] fontSizes = { 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72 };
        public Form1()
        {
            InitializeComponent();

            foreach (FontFamily font in FontFamily.Families)
            {
                fontToolStrip.Items.Add(font.Name);
            }
            foreach (int size in fontSizes)
            {
                sizeToolStrip.Items.Add(size);
            }
            fontToolStrip.Text = "Tahoma";
            fontToolStrip.SelectedItem = "Tahoma";
            sizeToolStrip.Text = "14";
            sizeToolStrip.SelectedItem = "14";

            fontToolStrip.SelectedIndexChanged += fontToolStrip_SelectedIndexChanged;
            sizeToolStrip.SelectedIndexChanged += sizeToolStrip_SelectedIndexChanged;

            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
        }

        private void fontToolStrip_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }

        private void sizeToolStrip_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }

        private void ChangeFont()
        {
            if (fontToolStrip.Text != "" && sizeToolStrip.Text != "")
            {
                try
                {
                    float size = float.Parse(sizeToolStrip.Text);
                    mainText.Font = new Font(fontToolStrip.Text, size);
                }
                catch
                {
                    MessageBox.Show("Kích thước không hợp lệ!");
                }
            }
        }

        private void ToggleStyle(FontStyle style)
        {
            Font currentFont = mainText.Font;
            if (currentFont == null) return;

            FontStyle newFontStyle;

            if (currentFont.Style.HasFlag(style))
            {
                newFontStyle = currentFont.Style & ~style;
            }
            else
            {
                newFontStyle = currentFont.Style | style;
            }
            mainText.Font = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
        }

        private void boldButton_Click(object sender, EventArgs e)
        {
            
                ToggleStyle(FontStyle.Bold);
        }

        private void italicButton_Click(object sender, EventArgs e)
        {
                ToggleStyle(FontStyle.Italic);
     
        }

        private void underlineButton_Click(object sender, EventArgs e)
        {
                ToggleStyle(FontStyle.Underline); 
        }

        private void colorButton_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    mainText.ForeColor = colorDialog.Color;
                    colorButton.BackColor = colorDialog.Color;
                }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                mainText.TextAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                mainText.TextAlign = ContentAlignment.MiddleCenter;
            }
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                mainText.TextAlign = ContentAlignment.MiddleRight;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
