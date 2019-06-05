using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HAESticker
{
    public partial class HAETrackBar : UserControl
    {
        bool dragging = false;
        int trackLineY = 8;
        int val = 50;
        Point offset = new Point();
        Color trackColor = Color.LightGray;

        public event EventHandler ValueChangeEvent;

        public int Value
        {
            get { return val; }
            set
            {
                if (val == 0)
                {
                    val = 1;
                }                    
                val = value;
            }
        }

        public HAETrackBar()
        {
            InitializeComponent();

            initEventHandler();
        }

        private void initEventHandler()
        {
            pbTrackBall.MouseDown += pbTrackBall_MouseDown;
            pbTrackBall.MouseHover += pbTrackBall_MouseHover;
            pbTrackBall.MouseLeave += pbTrackBall_MouseLeave;
            pbTrackBall.MouseMove += pbTrackBall_MouseMove;
            pbTrackBall.MouseUp += pbTrackBall_MouseUp;
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
            this.Cursor = Cursors.Default;
            pbTrackBall.Image = Properties.Resources.btnTrackBallHover;
        }

        private void pbTrackBall_MouseLeave(object sender, EventArgs e)
        {
            pbTrackBall.Image = Properties.Resources.btnTrackBall;
        }

        private void pbTrackBall_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dragging = true;
                offset = PointToScreen(e.Location);
            }
        }

        private void pbTrackBall_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
            ValueChangeEvent(this.Value, new EventArgs());
        }

        private void pbTrackBall_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Point trackBallPos = new Point(pbTrackBall.Location.X + (currentScreenPos.X - offset.X), 0);
                if (trackBallPos.X >= 0 && trackBallPos.X <= this.Width - pbTrackBall.Width)
                {
                    pbTrackBall.Location = new Point(pbTrackBall.Location.X + (currentScreenPos.X - offset.X), 0);
                    drawTrackBall();

                    this.Value = (pbTrackBall.Location.X * 100) / (this.Width - pbTrackBall.Width);
                }
            }
        }

        private void HAETrackBar_Paint(object sender, PaintEventArgs e)
        {
            drawTrackBall();
        }
    }
}
