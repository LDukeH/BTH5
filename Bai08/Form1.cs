using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Bai08
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer timer1;
        private DateTime hienTai;
        private int x0, y0;
        private int banKinh;
        private Pen pVien, pKimS, pKimM, pKimH;
        private Brush bSo, bTam;

        public Form1()
        {
            InitializeComponent();

            this.DoubleBuffered = true; // Giam do giat khi cap nhat giao dien

            timer1 = new System.Windows.Forms.Timer();
            timer1.Interval = 1000;
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start();

            this.BackColor = Color.Black;
            this.Text = "Form1";

            pVien = new Pen(Color.White, 2);
            pKimS = new Pen(Color.White, 2);
            pKimM = new Pen(Color.White, 4);
            pKimH = new Pen(Color.White, 6);
            bSo = new SolidBrush(Color.White);
            bTam = new SolidBrush(Color.White);

            //Tinh toan toa do tam va ban kinh
            x0 = this.ClientSize.Width / 2;
            y0 = this.ClientSize.Height / 2;
            banKinh = Math.Min(this.ClientSize.Width, this.ClientSize.Height) / 2 - 30;
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            this.Invalidate(); // Ve lai form
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            hienTai = DateTime.Now;
            this.Invalidate(); // Ve lai form
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;

            for (int i = 0; i < 60; i++)
            {
                double goc = i * 6 * Math.PI / 180;
                int rDot;
                int size;
                if (i % 5 == 0)
                {
                    //Cac cham gio
                    rDot = banKinh - 10;
                    size = 12;
                }
                else
                {
                    //Cac cham phut
                    rDot = banKinh - 5;
                    size = 4;
                }

                int xDot = x0 + (int)(rDot * Math.Sin(goc));
                int yDot = y0 - (int)(rDot * Math.Cos(goc));

                if (i % 5 == 0)
                {
                    g.FillEllipse(bSo, xDot - size / 2, yDot - size / 2, size, size);
                }
                else
                {
                    g.FillEllipse(bTam, xDot - size / 2, yDot - size / 2, size, size);
                }
            }

            // Ve kim dong ho
            VeKim(g, hienTai.Second, 60, banKinh - 30, pKimS); // Kim giay
            VeKim(g, hienTai.Minute + (double)hienTai.Second / 60, 60, banKinh - 50, pKimM); // Kim phut
            VeKim(g, hienTai.Hour % 12 + (double)hienTai.Minute / 60, 12, banKinh - 80, pKimH); // Kim gio
        }

        // Ham ve kim dong ho
        private void VeKim(Graphics g, double giaTri, int tongSo, int doDai, Pen butVe)
        {
            double goc = giaTri * (360 / tongSo) * Math.PI / 180; // Góc theo radian
            int x = x0 + (int)(doDai * Math.Sin(goc));
            int y = y0 - (int)(doDai * Math.Cos(goc));
            g.DrawLine(butVe, x0, y0, x, y);
        }
    }
}