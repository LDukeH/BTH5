namespace Bai04
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
            toolStrip1 = new ToolStrip();
            toolStripLabel1 = new ToolStripLabel();
            fontToolStrip = new ToolStripComboBox();
            toolStripLabel2 = new ToolStripLabel();
            sizeToolStrip = new ToolStripComboBox();
            toolStrip2 = new ToolStrip();
            boldButton = new ToolStripButton();
            toolStripLabel3 = new ToolStripLabel();
            italicButton = new ToolStripButton();
            toolStripLabel4 = new ToolStripLabel();
            underlineButton = new ToolStripButton();
            toolStripLabel5 = new ToolStripLabel();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripLabel6 = new ToolStripLabel();
            colorButton = new ToolStripButton();
            groupBox1 = new GroupBox();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            panel1 = new Panel();
            mainText = new Label();
            toolStrip1.SuspendLayout();
            toolStrip2.SuspendLayout();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripLabel1, fontToolStrip, toolStripLabel2, sizeToolStrip });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 28);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(38, 25);
            toolStripLabel1.Text = "Font";
            // 
            // fontToolStrip
            // 
            fontToolStrip.Name = "fontToolStrip";
            fontToolStrip.Size = new Size(121, 28);
            // 
            // toolStripLabel2
            // 
            toolStripLabel2.Name = "toolStripLabel2";
            toolStripLabel2.Size = new Size(36, 25);
            toolStripLabel2.Text = "Size";
            // 
            // sizeToolStrip
            // 
            sizeToolStrip.Name = "sizeToolStrip";
            sizeToolStrip.Size = new Size(121, 28);
            // 
            // toolStrip2
            // 
            toolStrip2.ImageScalingSize = new Size(20, 20);
            toolStrip2.Items.AddRange(new ToolStripItem[] { boldButton, toolStripLabel3, italicButton, toolStripLabel4, underlineButton, toolStripLabel5, toolStripSeparator1, toolStripLabel6, colorButton });
            toolStrip2.Location = new Point(0, 28);
            toolStrip2.Name = "toolStrip2";
            toolStrip2.Size = new Size(800, 31);
            toolStrip2.TabIndex = 1;
            toolStrip2.Text = "toolStrip2";
            // 
            // boldButton
            // 
            boldButton.BackColor = SystemColors.ControlDark;
            boldButton.CheckOnClick = true;
            boldButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            boldButton.ImageTransparentColor = Color.Magenta;
            boldButton.Name = "boldButton";
            boldButton.Size = new Size(29, 28);
            boldButton.Text = "boldCheck";
            boldButton.Click += boldButton_Click;
            // 
            // toolStripLabel3
            // 
            toolStripLabel3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            toolStripLabel3.Name = "toolStripLabel3";
            toolStripLabel3.Size = new Size(25, 28);
            toolStripLabel3.Text = "B";
            // 
            // italicButton
            // 
            italicButton.BackColor = SystemColors.ControlDark;
            italicButton.CheckOnClick = true;
            italicButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            italicButton.ImageTransparentColor = Color.Magenta;
            italicButton.Name = "italicButton";
            italicButton.Size = new Size(29, 28);
            italicButton.Text = "toolStripButton2";
            italicButton.Click += italicButton_Click;
            // 
            // toolStripLabel4
            // 
            toolStripLabel4.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            toolStripLabel4.Name = "toolStripLabel4";
            toolStripLabel4.Size = new Size(17, 28);
            toolStripLabel4.Text = "I";
            // 
            // underlineButton
            // 
            underlineButton.BackColor = SystemColors.ControlDark;
            underlineButton.CheckOnClick = true;
            underlineButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            underlineButton.ImageTransparentColor = Color.Magenta;
            underlineButton.Name = "underlineButton";
            underlineButton.Size = new Size(29, 28);
            underlineButton.Text = "U";
            underlineButton.Click += underlineButton_Click;
            // 
            // toolStripLabel5
            // 
            toolStripLabel5.Font = new Font("Segoe UI Light", 12F, FontStyle.Underline, GraphicsUnit.Point, 0);
            toolStripLabel5.Name = "toolStripLabel5";
            toolStripLabel5.Size = new Size(25, 28);
            toolStripLabel5.Text = "U";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 31);
            // 
            // toolStripLabel6
            // 
            toolStripLabel6.Name = "toolStripLabel6";
            toolStripLabel6.Size = new Size(45, 28);
            toolStripLabel6.Text = "Color";
            // 
            // colorButton
            // 
            colorButton.BackColor = SystemColors.ActiveCaptionText;
            colorButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            colorButton.ImageTransparentColor = Color.Magenta;
            colorButton.Name = "colorButton";
            colorButton.Size = new Size(29, 28);
            colorButton.Text = "toolStripButton4";
            colorButton.Click += colorButton_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(12, 72);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 125);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Alignment";
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(19, 86);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(65, 24);
            radioButton3.TabIndex = 8;
            radioButton3.TabStop = true;
            radioButton3.Text = "Right";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(19, 56);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(73, 24);
            radioButton2.TabIndex = 7;
            radioButton2.TabStop = true;
            radioButton2.Text = "Center";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(19, 26);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(55, 24);
            radioButton1.TabIndex = 6;
            radioButton1.TabStop = true;
            radioButton1.Text = "Left";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(mainText);
            panel1.Location = new Point(12, 217);
            panel1.Name = "panel1";
            panel1.Size = new Size(738, 221);
            panel1.TabIndex = 7;
            // 
            // mainText
            // 
            mainText.Dock = DockStyle.Fill;
            mainText.Location = new Point(0, 0);
            mainText.Name = "mainText";
            mainText.Size = new Size(738, 221);
            mainText.TabIndex = 1;
            mainText.Text = "Hello";
            mainText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Controls.Add(toolStrip2);
            Controls.Add(toolStrip1);
            Name = "Form1";
            Text = "  ";
            Load += Form1_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            toolStrip2.ResumeLayout(false);
            toolStrip2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripLabel toolStripLabel1;
        private ToolStripComboBox fontToolStrip;
        private ToolStripLabel toolStripLabel2;
        private ToolStripComboBox sizeToolStrip;
        private ToolStrip toolStrip2;
        private ToolStripButton boldButton;
        private ToolStripLabel toolStripLabel3;
        private ToolStripButton italicButton;
        private ToolStripLabel toolStripLabel4;
        private ToolStripButton underlineButton;
        private ToolStripLabel toolStripLabel5;
        private ToolStripLabel toolStripLabel6;
        private ToolStripButton colorButton;
        private ToolStripSeparator toolStripSeparator1;
        private GroupBox groupBox1;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Panel panel1;
        private Label mainText;
    }
}
