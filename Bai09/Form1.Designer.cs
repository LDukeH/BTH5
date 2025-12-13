namespace Bai09
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
            drawingBox = new ComboBox();
            drawingPanel = new Panel();
            SuspendLayout();
            // 
            // drawingBox
            // 
            drawingBox.FormattingEnabled = true;
            drawingBox.Location = new Point(12, 12);
            drawingBox.Name = "drawingBox";
            drawingBox.Size = new Size(151, 28);
            drawingBox.TabIndex = 0;
            // 
            // drawingPanel
            // 
            drawingPanel.Location = new Point(12, 46);
            drawingPanel.Name = "drawingPanel";
            drawingPanel.Size = new Size(547, 333);
            drawingPanel.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(drawingPanel);
            Controls.Add(drawingBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ComboBox drawingBox;
        private Panel drawingPanel;
    }
}
