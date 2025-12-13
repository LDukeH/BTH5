namespace Bai11
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelMenu = new Panel();
            groupBox3 = new GroupBox();
            linearRadio = new RadioButton();
            textureRadio = new RadioButton();
            hatchRadio = new RadioButton();
            solidRadio = new RadioButton();
            groupBox2 = new GroupBox();
            colorButton = new Button();
            penWidth = new NumericUpDown();
            label1 = new Label();
            groupBox1 = new GroupBox();
            elipseRadio = new RadioButton();
            rectRadio = new RadioButton();
            lineRadio = new RadioButton();
            panelDraw = new Panel();
            panelMenu.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)penWidth).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BorderStyle = BorderStyle.FixedSingle;
            panelMenu.Controls.Add(groupBox3);
            panelMenu.Controls.Add(groupBox2);
            panelMenu.Controls.Add(groupBox1);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(281, 843);
            panelMenu.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(linearRadio);
            groupBox3.Controls.Add(textureRadio);
            groupBox3.Controls.Add(hatchRadio);
            groupBox3.Controls.Add(solidRadio);
            groupBox3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.ForeColor = SystemColors.Highlight;
            groupBox3.Location = new Point(12, 327);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(250, 315);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Brushes";
            // 
            // linearRadio
            // 
            linearRadio.AutoSize = true;
            linearRadio.Font = new Font("Segoe UI", 9F);
            linearRadio.ForeColor = SystemColors.ControlText;
            linearRadio.Location = new Point(22, 165);
            linearRadio.Name = "linearRadio";
            linearRadio.Size = new Size(163, 24);
            linearRadio.TabIndex = 3;
            linearRadio.Text = "LinearGradientBrush";
            linearRadio.UseVisualStyleBackColor = true;
            // 
            // textureRadio
            // 
            textureRadio.AutoSize = true;
            textureRadio.Font = new Font("Segoe UI", 9F);
            textureRadio.ForeColor = SystemColors.ControlText;
            textureRadio.Location = new Point(22, 121);
            textureRadio.Name = "textureRadio";
            textureRadio.Size = new Size(114, 24);
            textureRadio.TabIndex = 2;
            textureRadio.Text = "TextureBrush";
            textureRadio.UseVisualStyleBackColor = true;
            // 
            // hatchRadio
            // 
            hatchRadio.AutoSize = true;
            hatchRadio.Font = new Font("Segoe UI", 9F);
            hatchRadio.ForeColor = SystemColors.ControlText;
            hatchRadio.Location = new Point(22, 78);
            hatchRadio.Name = "hatchRadio";
            hatchRadio.Size = new Size(105, 24);
            hatchRadio.TabIndex = 1;
            hatchRadio.Text = "HatchBrush";
            hatchRadio.UseVisualStyleBackColor = true;
            // 
            // solidRadio
            // 
            solidRadio.AutoSize = true;
            solidRadio.Checked = true;
            solidRadio.Font = new Font("Segoe UI", 9F);
            solidRadio.ForeColor = SystemColors.ControlText;
            solidRadio.Location = new Point(22, 38);
            solidRadio.Name = "solidRadio";
            solidRadio.Size = new Size(100, 24);
            solidRadio.TabIndex = 0;
            solidRadio.TabStop = true;
            solidRadio.Text = "SolidBrush";
            solidRadio.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(colorButton);
            groupBox2.Controls.Add(penWidth);
            groupBox2.Controls.Add(label1);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = SystemColors.Highlight;
            groupBox2.Location = new Point(12, 162);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(250, 127);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Pen";
            // 
            // colorButton
            // 
            colorButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            colorButton.ForeColor = SystemColors.ControlText;
            colorButton.Location = new Point(59, 78);
            colorButton.Name = "colorButton";
            colorButton.Size = new Size(130, 29);
            colorButton.TabIndex = 2;
            colorButton.Text = "Color...";
            colorButton.UseVisualStyleBackColor = true;
            colorButton.Click += colorButton_Click;
            // 
            // penWidth
            // 
            penWidth.Location = new Point(80, 31);
            penWidth.Name = "penWidth";
            penWidth.Size = new Size(150, 27);
            penWidth.TabIndex = 1;
            penWidth.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Desktop;
            label1.Location = new Point(22, 33);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 0;
            label1.Text = "Width:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(elipseRadio);
            groupBox1.Controls.Add(rectRadio);
            groupBox1.Controls.Add(lineRadio);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.Highlight;
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 129);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Shapes";
            // 
            // elipseRadio
            // 
            elipseRadio.AutoSize = true;
            elipseRadio.Font = new Font("Segoe UI", 9F);
            elipseRadio.ForeColor = SystemColors.Desktop;
            elipseRadio.Location = new Point(22, 86);
            elipseRadio.Name = "elipseRadio";
            elipseRadio.Size = new Size(73, 24);
            elipseRadio.TabIndex = 2;
            elipseRadio.Text = "Ellipse";
            elipseRadio.UseVisualStyleBackColor = true;
            // 
            // rectRadio
            // 
            rectRadio.AutoSize = true;
            rectRadio.Font = new Font("Segoe UI", 9F);
            rectRadio.ForeColor = SystemColors.Desktop;
            rectRadio.Location = new Point(22, 56);
            rectRadio.Name = "rectRadio";
            rectRadio.Size = new Size(96, 24);
            rectRadio.TabIndex = 1;
            rectRadio.Text = "Rectangle";
            rectRadio.UseVisualStyleBackColor = true;
            // 
            // lineRadio
            // 
            lineRadio.AutoSize = true;
            lineRadio.Checked = true;
            lineRadio.Font = new Font("Segoe UI", 9F);
            lineRadio.ForeColor = SystemColors.Desktop;
            lineRadio.Location = new Point(22, 26);
            lineRadio.Name = "lineRadio";
            lineRadio.Size = new Size(57, 24);
            lineRadio.TabIndex = 0;
            lineRadio.TabStop = true;
            lineRadio.Text = "Line";
            lineRadio.UseVisualStyleBackColor = true;
            // 
            // panelDraw
            // 
            panelDraw.Dock = DockStyle.Fill;
            panelDraw.Location = new Point(281, 0);
            panelDraw.Name = "panelDraw";
            panelDraw.Size = new Size(519, 843);
            panelDraw.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 843);
            Controls.Add(panelDraw);
            Controls.Add(panelMenu);
            Name = "Form1";
            Text = "Form1";
            panelMenu.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)penWidth).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private NumericUpDown penWidth;
        private Label label1;
        private RadioButton elipseRadio;
        private RadioButton rectRadio;
        private RadioButton lineRadio;
        private Button colorButton;
        private RadioButton linearRadio;
        private RadioButton textureRadio;
        private RadioButton hatchRadio;
        private RadioButton solidRadio;
        private Panel panelDraw;
    }
}
