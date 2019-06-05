using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HAESticker
{
    public partial class HAETestForm : Form
    {
        bool dragging = false;
        int trackBallX = 0;
        int trackLineY = 8;
        Point offset = new Point();
        Color trackColor = Color.LightGray;

        public HAETestForm()
        {
            InitializeComponent();
            pbTrackBall.Location = new Point(trackBallX, 0);
            drawTrackBall();
        }

        private void drawTrackBall()
        {
            using (var cg = this.CreateGraphics())
            {
                cg.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                Pen trackLine = new Pen(trackColor, 2);
                cg.DrawLine(trackLine, 0, trackLineY, this.Width, trackLineY);
            }
        }

        private void pbTrackBall_MouseHover(object sender, EventArgs e)
        {
            pbTrackBall.Image = Properties.Resources.btnTrackBallHover;
        }

        private void pbTrackBall_MouseLeave(object sender, EventArgs e)
        {
            pbTrackBall.Image = Properties.Resources.btnTrackBall;
        }

        private void pbTrackBall_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                dragging = true;
                offset = PointToScreen(e.Location);
            }
        }

        private void pbTrackBall_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void pbTrackBall_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Point trackBallPos = new Point(pbTrackBall.Location.X + (currentScreenPos.X - offset.X), 0);
                if (trackBallPos.X >= 0 && trackBallPos.X <= this.Width - (pbTrackBall.Width * 2))
                {
                    pbTrackBall.Location = new Point(pbTrackBall.Location.X + (currentScreenPos.X - offset.X), 0);
                    //lblX.Text = "this.Width :=" + this.Width;
                    //lblY.Text = "trackBallPos.X :=" + trackBallPos.X;
                    //lblOffSet.Text = "trackBall.Width :=" + pbTrackBall.Width;
                    drawTrackBall();
                }
            }
        }

        private void HAETestForm_Paint(object sender, PaintEventArgs e)
        {
            drawTrackBall();
        }
    }
}
