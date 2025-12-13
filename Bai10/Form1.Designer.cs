namespace Bai10
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
            endCap = new ComboBox();
            startCap = new ComboBox();
            dashCap = new ComboBox();
            lineJoin = new ComboBox();
            lineWidth = new ComboBox();
            dashStyle = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panelDraw = new Panel();
            panelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BorderStyle = BorderStyle.FixedSingle;
            panelMenu.Controls.Add(endCap);
            panelMenu.Controls.Add(startCap);
            panelMenu.Controls.Add(dashCap);
            panelMenu.Controls.Add(lineJoin);
            panelMenu.Controls.Add(lineWidth);
            panelMenu.Controls.Add(dashStyle);
            panelMenu.Controls.Add(label6);
            panelMenu.Controls.Add(label5);
            panelMenu.Controls.Add(label4);
            panelMenu.Controls.Add(label3);
            panelMenu.Controls.Add(label2);
            panelMenu.Controls.Add(label1);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(275, 450);
            panelMenu.TabIndex = 0;
            // 
            // endCap
            // 
            endCap.FormattingEnabled = true;
            endCap.Location = new Point(98, 278);
            endCap.Name = "endCap";
            endCap.Size = new Size(151, 28);
            endCap.TabIndex = 11;
            // 
            // startCap
            // 
            startCap.FormattingEnabled = true;
            startCap.Location = new Point(98, 224);
            startCap.Name = "startCap";
            startCap.Size = new Size(151, 28);
            startCap.TabIndex = 10;
            // 
            // dashCap
            // 
            dashCap.FormattingEnabled = true;
            dashCap.Location = new Point(98, 172);
            dashCap.Name = "dashCap";
            dashCap.Size = new Size(151, 28);
            dashCap.TabIndex = 9;
            // 
            // lineJoin
            // 
            lineJoin.FormattingEnabled = true;
            lineJoin.Location = new Point(98, 124);
            lineJoin.Name = "lineJoin";
            lineJoin.Size = new Size(151, 28);
            lineJoin.TabIndex = 8;
            // 
            // lineWidth
            // 
            lineWidth.FormattingEnabled = true;
            lineWidth.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24" });
            lineWidth.Location = new Point(98, 78);
            lineWidth.Name = "lineWidth";
            lineWidth.Size = new Size(151, 28);
            lineWidth.TabIndex = 7;
            // 
            // dashStyle
            // 
            dashStyle.FormattingEnabled = true;
            dashStyle.Location = new Point(98, 32);
            dashStyle.Name = "dashStyle";
            dashStyle.Size = new Size(151, 28);
            dashStyle.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(11, 281);
            label6.Name = "label6";
            label6.Size = new Size(67, 20);
            label6.TabIndex = 5;
            label6.Text = "End Cap:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 224);
            label5.Name = "label5";
            label5.Size = new Size(73, 20);
            label5.TabIndex = 4;
            label5.Text = "Start Cap:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 172);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 3;
            label4.Text = "Dash Cap:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 124);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 2;
            label3.Text = "Line Join:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 78);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 1;
            label2.Text = "Width:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 32);
            label1.Name = "label1";
            label1.Size = new Size(81, 20);
            label1.TabIndex = 0;
            label1.Text = "Dash Style:";
            // 
            // panelDraw
            // 
            panelDraw.Dock = DockStyle.Fill;
            panelDraw.Location = new Point(275, 0);
            panelDraw.Name = "panelDraw";
            panelDraw.Size = new Size(525, 450);
            panelDraw.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelDraw);
            Controls.Add(panelMenu);
            Name = "Form1";
            Text = "Form1";
            panelMenu.ResumeLayout(false);
            panelMenu.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private ComboBox endCap;
        private ComboBox startCap;
        private ComboBox dashCap;
        private ComboBox lineJoin;
        private ComboBox lineWidth;
        private ComboBox dashStyle;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panelDraw;
    }
}
