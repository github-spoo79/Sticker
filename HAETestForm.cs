using HAESticker.VO;
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
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(230, 242, 250);
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
            HAESQLiteQuery haeSQLiteQuery = new HAESQLiteQuery();
            ////20190618141000
            //HAESQLiteVO vo = new HAESQLiteVO();
            //vo.set("form_id", "20190618141000");
            //DataTable dt = haeSQLiteQuery.getStickerInfoByFormId(vo);
            //DataTable dt = haeSQLiteQuery.getStickerInfo(null);

            //dataGridView1.DataSource = dt;

            //HAESQLiteHelper sqlite = new HAESQLiteHelper();

            //string sql = "select * from sticker";
            //DataTable dt = sqlite.selectData(sql);
            //dataGridView1.DataSource = dt;

            DataTable dt = haeSQLiteQuery.getStickerInfo(null);
            dataGridView1.DataSource = dt;

            for (int idx = 0; idx < dt.Rows.Count; idx++)
            {
                DataRow dr = dt.Rows[idx];
                StickerVO stickerVO = new StickerVO();
                stickerVO.IudFlag = "U";
                stickerVO.FormId = Convert.ToString(dr["form_id"]);
                stickerVO.PosX = Convert.ToInt32(dr["pos_x"]);
                stickerVO.PosY = Convert.ToInt32(dr["pos_y"]);
                stickerVO.FormWidth = Convert.ToInt32(dr["form_width"]);
                stickerVO.FormHeight = Convert.ToInt32(dr["form_height"]);
                stickerVO.FormOpacity = Convert.ToInt32(dr["form_opacity"]);
                stickerVO.Title = Convert.ToString(dr["title"]);
                stickerVO.Contents = Convert.ToString(dr["contents"]);
                stickerVO.FoldYn = Convert.ToString(dr["fold_yn"]);

                HAEForm h = new HAEForm(stickerVO);
                h.StartPosition = FormStartPosition.Manual;
                h.Location = new Point(stickerVO.PosX, stickerVO.PosY);
                h.Show();
                h.Focus();
            }
        }

        private void dataGridView1_RowDefaultCellStyleChanged(object sender, DataGridViewRowEventArgs e)
        {
            //Console.WriteLine("!");
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            //int x = dataGridView1.Rows[].Cells[0].ContentBounds.X;
            //int y = dataGridView1.Rows[e.RowIndex].Cells[0].ContentBounds.Y;
            //int width = dataGridView1.Rows[e.RowIndex].Cells[dataGridView1.ColumnCount].ContentBounds.Right - dataGridView1.Rows[e.RowIndex].Cells[dataGridView1.ColumnCount].ContentBounds.Left;
            //int height = dataGridView1.Rows[e.RowIndex].Cells[dataGridView1.ColumnCount].ContentBounds.Height;

            //Brush brush = new SolidBrush(Color.FromArgb(70, 94, 104)); //
            //Rectangle rect = new Rectangle(0, 0, 0, 0);
            //Pen pen = new Pen(brush, 2F);

            //rect = new Rectangle(x, y, width, height);
            //e.Graphics.DrawRectangle(pen, rect);

            //Console.WriteLine("!");
            //dataGridView1.e
        }

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            //int x1 = 0;
            //int y1 = 0;
            //int x2 = 0;
            //int y2 = 0;
            ////if (dataGridView1."].Index == e.ColumnIndex && e.RowIndex >= 0)
            //if(e.RowIndex > 0)
            //{
            //    if (dataGridView1.Rows[e.RowIndex].Selected)
            //    {
            //        //if(e.ColumnIndex == 0)
            //        //{
            //        //    x1 = e.CellBounds.X;
            //        //    y1 = e.CellBounds.Y;
            //        //}

            //        //if(e.ColumnIndex == dataGridView1.Columns.Count - 1)
            //        //{
            //        //    x2 = e.CellBounds.X + e.CellBounds.Width;
            //        //    y2 = e.CellBounds.Height;
            //        //}

            //        //Brush gridBrush = new SolidBrush(this.dataGridView1.GridColor);
            //        //e.Graphics.DrawRectangle(Pens.Blue, newRect);

            //        using (Brush gridBrush = new SolidBrush(this.dataGridView1.GridColor), backColorBrush = new SolidBrush(e.CellStyle.BackColor))
            //        {
            //            using (Pen gridLinePen = new Pen(gridBrush))
            //            {
            //                //if (e.ColumnIndex == 0)
            //                //{
            //                //    x1 = e.CellBounds.X;
            //                //    y1 = e.CellBounds.Y;
            //                //    // Erase the cell.
            //                //    //e.Graphics.FillRectangle(backColorBrush, e.CellBounds);
            //                //    // Draw the grid lines (only the right and bottom lines;
            //                //    // DataGridView takes care of the others).                            
            //                //    //e.Graphics.DrawLine(gridLinePen, e.CellBounds.Left,
            //                //    //    e.CellBounds.Bottom - 1, e.CellBounds.Right - 1,
            //                //    //    e.CellBounds.Bottom - 1);
            //                //    //e.Graphics.DrawLine(gridLinePen, e.CellBounds.Right - 1,
            //                //    //    e.CellBounds.Top, e.CellBounds.Right - 1,
            //                //    //    e.CellBounds.Bottom);
            //                //    // Draw the inset highlight box.
            //                //    //e.Graphics.DrawRectangle(Pens.Blue, newRect);
            //                //    // Draw the text content of the cell, ignoring alignment.
            //                //    //if (e.Value != null)
            //                //    //{
            //                //    //    e.Graphics.DrawString((String)e.Value, e.CellStyle.Font,
            //                //    //        Brushes.Crimson, e.CellBounds.X + 2,
            //                //    //        e.CellBounds.Y + 2, StringFormat.GenericDefault);
            //                //    //}                                
            //                //}
            //                Rectangle newRect = new Rectangle(e.CellBounds.X + 1, e.CellBounds.Y + 1, e.CellBounds.X + e.CellBounds.Width - 1, e.CellBounds.Height - 1);
            //                e.Graphics.DrawRectangle(Pens.Blue, newRect);
            //                e.Handled = true;
            //            }
            //        }
            //    }                
            //}
        }

        private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {
            //DataGridView.HitTestInfo hit = dataGridView1.HitTest(e.X, e.Y);

            //Brush brush = new SolidBrush(Color.FromArgb(70, 94, 104));
            //Rectangle rect = new Rectangle(0, 0, 0, 0);
            //Pen pen = new Pen(brush, 2F);

            //PaintEventArgs e = new PaintEventArgs();

            //rect = new Rectangle(hit.ColumnX, hit.RowY, 100, 100);
            
            ////e.Graphics.DrawRectangle(pen, rect);
        }

        private void dataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            
        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            int posLeft = e.RowBounds.Left + 2;
            int posTop = e.RowBounds.Top + 2;

            Rectangle rowBounds = new Rectangle(
                     e.RowBounds.Left + 2
                   , e.RowBounds.Top + 2
                   , dataGridView1.Columns.GetColumnsWidth(DataGridViewElementStates.Visible) - this.dataGridView1.HorizontalScrollingOffset - 2
                   , e.RowBounds.Height - 3);

            if (this.dataGridView1.CurrentCellAddress.Y == e.RowIndex)
            {
                // Paint the focus rectangle.
                Pen pen = new Pen(Color.DarkRed);
                e.Graphics.DrawRectangle(pen, rowBounds);
                //e.DrawFocus(rowBounds, true);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {            
            StickerVO stickerVO = new StickerVO();
            stickerVO.IudFlag = "I";
            stickerVO.FormId = DateTime.Now.ToString("yyyyMMddhhmmss");
            stickerVO.Title = "새메모";
            stickerVO.FormWidth = 200;
            stickerVO.FormHeight = 200;
            stickerVO.FormOpacity = 100;
            HAEForm h = new HAEForm(stickerVO);
            h.Show();
            h.Focus();
        }

        private void HAETestForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
