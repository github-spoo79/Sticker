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

            DataTable dt = new DataTable();
            dt.Columns.Add("Column1", typeof(string));
            dt.Columns.Add("Column2", typeof(string));
            dt.Columns.Add("Column3", typeof(string));
            dt.Columns.Add("Column4", typeof(string));

            DataRow dr = dt.NewRow();
            dr["Column1"] = "A";
            dr["Column2"] = "B";
            dr["Column3"] = "C";
            dr["Column4"] = "D";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["Column1"] = "A";
            dr["Column2"] = "B";
            dr["Column3"] = "C";
            dr["Column4"] = "D";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["Column1"] = "A";
            dr["Column2"] = "B";
            dr["Column3"] = "C";
            dr["Column4"] = "D";
            dt.Rows.Add(dr);

            dataGridView1.DataSource = dt;
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

        private void dataGridView1_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.RowIndex > -1)
            {
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightBlue;
            }            
        }

        private void dataGridView1_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HAESQLiteHelper sqlite = new HAESQLiteHelper();

            string sql = "select * from sticker";
            DataTable dt = sqlite.selectData(sql);
            dataGridView1.DataSource = dt;

            for(int idx = 0; idx < dt.Rows.Count; idx++)
            {
                DataRow dr = dt.Rows[idx];
                HAEForm h = new HAEForm();
                h.FormId = Convert.ToString(dr["form_id"]);
                h.PosX = Convert.ToInt32(dr["pos_x"]);
                h.PosY = Convert.ToInt32(dr["pos_y"]);
                h.FormWidth = Convert.ToInt32(dr["form_width"]);
                h.FormHeight = Convert.ToInt32(dr["form_height"]);
                h.FormOpacity = Convert.ToInt32(dr["form_opacity"]);
                h.Title = Convert.ToString(dr["title"]);
                h.Contents = Convert.ToString(dr["contents"]);
                h.StartPosition = FormStartPosition.Manual;
                h.Location = new Point(h.PosX, h.PosY);
                h.Show();
                h.Focus();
            }
        }
    }
}
