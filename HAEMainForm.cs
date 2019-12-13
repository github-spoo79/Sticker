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
    public partial class HAEMainForm : Form
    {
        private bool dragging;
        private bool resizing;
        private bool resizingUp;
        private bool resizingDown;
        private bool resizingLeft;
        private bool resizingRight;
        private int border = 4;
        private Size previousSize;
        private Point previousLocation ;
        //private Size previousFoldingSize;
        private Point offset;
        private bool maximizied = false;
        private bool holding = false;
        private bool folding = false;
        //private int MINIMUM_WIDTH = 300;
        private int MINIMUM_HEIGHT = 26;        

        List<HAEForm> haeFormList = new List<HAEForm>();
        
        HAESQLiteQuery haeSQLiteQuery = new HAESQLiteQuery();

        public HAEMainForm()
        {
            InitializeComponent();

            initEventHandler();
        }

        private void initEventHandler()
        {
            tblSticker.MouseDown += HAEForm_MouseDown;
            tblSticker.MouseUp += HAEForm_MouseUp;
            tblSticker.MouseMove += HAEForm_MouseMove;

            pnlCaption.MouseDown += HAEForm_MouseDown;
            pnlCaption.MouseUp += HAEForm_MouseUp;
            pnlCaption.MouseMove += HAEForm_MouseMove;

            lblFormTitle.MouseDown += HAEForm_MouseDown;
            lblFormTitle.MouseUp += HAEForm_MouseUp;
            lblFormTitle.MouseMove += HAEForm_MouseMove;
        }

        private DataTable getStickerInfo()
        {
            DataTable dt = haeSQLiteQuery.getStickerInfo(null);
            return dt;
        }

        private void openSticker()
        {
            DataTable dt = getStickerInfo();
            for (int idx = 0; idx < dt.Rows.Count; idx++)
            {
                DataRow dr = dt.Rows[idx];
                //이미 List<HAEForm>에 등록된 sticker는 다시 화면에 띄위지 않는다.
                if (findOpenedSticker(Convert.ToString(dr["form_id"])))
                {
                }
                else
                {
                    StickerVO stickerVO = new StickerVO();
                    stickerVO.IudFlag = "U";
                    stickerVO.FormId = Convert.ToString(dr["form_id"]);
                    stickerVO.PosX = Convert.ToInt32(dr["pos_x"]);
                    stickerVO.PosY = Convert.ToInt32(dr["pos_y"]);
                    stickerVO.FormWidth = Convert.ToInt32(dr["form_width"]);
                    stickerVO.FormHeight = Convert.ToInt32(dr["form_height"]);
                    stickerVO.FormOpacity = Convert.ToInt32(dr["form_opacity"]);
                    stickerVO.FormPrevWidth = Convert.ToInt32(dr["prev_form_width"]);
                    stickerVO.FormPrevHeight = Convert.ToInt32(dr["prev_form_height"]);
                    stickerVO.Title = Convert.ToString(dr["title"]);
                    stickerVO.Contents = Convert.ToString(dr["contents"]);
                    stickerVO.FoldYn = Convert.ToString(dr["fold_yn"]);

                    HAEForm h = new HAEForm(stickerVO, this);
                    //중복된 sticker를 다시 발행하지 않기 위해 List<HAEForm>에 등록
                    haeFormList.Add(h);
                    h.StartPosition = FormStartPosition.Manual;
                    h.Location = new Point(stickerVO.PosX, stickerVO.PosY);
                    h.Show();
                    h.Focus();
                }
            }
        }

        private bool findOpenedSticker(string formId)
        {
            bool result = false;
            for(int idx = 0; idx < haeFormList.Count; idx++)
            {
                HAEForm h = haeFormList[idx] as HAEForm;
                if(h.stickerVO.FormId == formId)
                {
                    result = true;
                    break;
                }
            }
            return result;
        }

        private void HAEForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (holding)
            {
                return;
            }

            dragging = true;
            offset = e.Location;
            if (resizing)
            {
                previousSize = this.Size;
                previousLocation = this.Location;
            }
        }

        private void HAEForm_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
            resizing = false;
            resizingUp = false;
            resizingDown = false;
            resizingLeft = false;
            resizingRight = false;
        }

        private void HAEForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                if (resizing)
                {
                    Point currentScreenPos = PointToScreen(e.Location);
                    if (resizingLeft)
                    {
                        if (resizingUp)
                        {
                            this.Width = previousLocation.X + previousSize.Width - currentScreenPos.X + offset.X;
                            this.Height = previousLocation.Y + previousSize.Height - currentScreenPos.Y + offset.Y;
                            this.Location = new Point(previousLocation.X + previousSize.Width - this.Width, previousLocation.Y + previousSize.Height - this.Height);
                        }
                        else if (resizingDown)
                        {
                            this.Width = previousLocation.X + previousSize.Width - currentScreenPos.X + offset.X;
                            this.Height = currentScreenPos.Y - previousLocation.Y + previousSize.Height - offset.Y;
                            this.Location = new Point(previousLocation.X + previousSize.Width - this.Width, previousLocation.Y);
                        }
                        else
                        {
                            this.Width = previousLocation.X + previousSize.Width - currentScreenPos.X + offset.X;
                            this.Location = new Point(previousLocation.X + previousSize.Width - this.Width, previousLocation.Y);
                        }
                    }
                    else if (resizingRight)
                    {
                        if (resizingUp)
                        {
                            this.Width = currentScreenPos.X - previousLocation.X + previousSize.Width - offset.X;
                            this.Height = previousLocation.Y + previousSize.Height - currentScreenPos.Y + offset.Y;
                            this.Location = new Point(previousLocation.X, previousLocation.Y + previousSize.Height - this.Height);
                        }
                        else if (resizingDown)
                        {
                            this.Width = currentScreenPos.X - previousLocation.X + previousSize.Width - offset.X;
                            this.Height = currentScreenPos.Y - previousLocation.Y + previousSize.Height - offset.Y;
                        }
                        else
                        {
                            this.Width = currentScreenPos.X - previousLocation.X + previousSize.Width - offset.X;
                        }
                    }
                    else if (resizingUp)
                    {
                        //최소 높이 이하로 Form Size를 줄이는 것 방지
                        if(previousLocation.Y + previousSize.Height - currentScreenPos.Y + offset.Y >= MINIMUM_HEIGHT)
                        {
                            this.Height = previousLocation.Y + previousSize.Height - currentScreenPos.Y + offset.Y;
                        }                        
                        this.Location = new Point(previousLocation.X, previousLocation.Y + previousSize.Height - this.Height);
                    }
                    else if (resizingDown)
                    {
                        //최소 높이 이하로 Form Size를 줄이는 것 방지
                        if (currentScreenPos.Y - previousLocation.Y + previousSize.Height - offset.Y >= MINIMUM_HEIGHT)
                        {
                            this.Height = currentScreenPos.Y - previousLocation.Y + previousSize.Height - offset.Y;
                        }
                    }
                }
                else
                {
                    Point currentScreenPos = PointToScreen(e.Location);
                    Location = new Point(currentScreenPos.X - offset.X, currentScreenPos.Y - offset.Y);
                }
            }
            else
            {
                if (e.X <= border)
                {
                    resizing = true;
                    resizingUp = false;
                    resizingDown = false;
                    resizingLeft = true;
                    resizingRight = false;

                    if (e.Y <= border)
                    {
                        this.Cursor = Cursors.SizeNWSE;
                        resizingUp = true;
                    }
                    else if (e.Y >= this.Height - border)
                    {
                        this.Cursor = Cursors.SizeNESW;
                        resizingDown = true;
                    }
                    else
                    {
                        this.Cursor = Cursors.SizeWE;
                    }
                }
                else if (e.X >= this.Width - border)
                {
                    resizing = true;
                    resizingUp = false;
                    resizingDown = false;
                    resizingLeft = false;
                    resizingRight = true;

                    if (e.Y <= border)
                    {
                        this.Cursor = Cursors.SizeNESW;
                        resizingUp = true;
                    }
                    else if (e.Y >= this.Height - border)
                    {
                        this.Cursor = Cursors.SizeNWSE;
                        resizingDown = true;
                    }
                    else
                    {
                        this.Cursor = Cursors.SizeWE;
                    }
                }
                else if (e.Y <= border)
                {
                    resizing = true;
                    resizingUp = true;
                    resizingLeft = false;
                    resizingRight = false;
                    this.Cursor = Cursors.SizeNS;
                }
                else if (e.Y >= this.Height - border)
                {
                    resizing = true;
                    resizingDown = true;
                    resizingLeft = false;
                    resizingRight = false;
                    this.Cursor = Cursors.SizeNS;
                }
                else
                {
                    this.Cursor = Cursors.Default;
                    resizing = false;
                    resizingUp = false;
                    resizingDown = false;
                    resizingLeft = false;
                    resizingRight = false;
                }
            }
        }

        private void pbBtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbBtnExpand_Click(object sender, EventArgs e)
        {
            if (maximizied)
            {
                this.WindowState = FormWindowState.Normal;
                pbBtnExpand.Image = Properties.Resources.btnExpand;
                maximizied = false;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                pbBtnExpand.Image = Properties.Resources.btnOriginal;
                maximizied = true;
            }
        }

        private void pbBtnHide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pbBtnClose_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
            pbBtnClose.Image = Properties.Resources.btnCloseHover;
        }

        private void pbBtnClose_MouseLeave(object sender, EventArgs e)
        {
            pbBtnClose.Image = Properties.Resources.btnClose;
        }

        private void pbBtnExpand_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
            if (maximizied)
            {
                pbBtnExpand.Image = Properties.Resources.btnOriginalHover;
            }
            else
            {
                pbBtnExpand.Image = Properties.Resources.btnExpandHover;
            }
        }

        private void pbBtnExpand_MouseLeave(object sender, EventArgs e)
        {
            if (maximizied)
            {
                pbBtnExpand.Image = Properties.Resources.btnOriginal;
            }
            else
            {
                pbBtnExpand.Image = Properties.Resources.btnExpand;
            }
        }

        private void pbBtnHide_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
            pbBtnHide.Image = Properties.Resources.btnHideHover;
        }

        private void pbBtnHide_MouseLeave(object sender, EventArgs e)
        {
            pbBtnHide.Image = Properties.Resources.btnHide;
        }

        private void pbLogo_MouseHover(object sender, EventArgs e)
        {
        }

        private void HAEForm_Load(object sender, EventArgs e)
        {
        }

        private void lblSearch_Click(object sender, EventArgs e)
        {
            openSticker();
        }

        private void HAEMainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            saveTotSticker();
        }

        private void saveTotSticker()
        {
            for(int idx = 0; idx < haeFormList.Count; idx++)
            {
                HAEForm h = haeFormList[idx] as HAEForm;
                h.saveStickerInfo();
            }
        }

        public void removeSticker(string formId)
        {
            for (int idx = haeFormList.Count - 1; idx >= 0; idx--)
            {
                HAEForm h = haeFormList[idx] as HAEForm;
                if (h.stickerVO.FormId == formId)
                {
                    haeFormList.Remove(h);
                }
            }
        }

        private void openNewSticker()
        {
            StickerVO stickerVO = new StickerVO();
            stickerVO.IudFlag = "I";
            stickerVO.FormId = DateTime.Now.ToString("yyyyMMddhhmmss");
            stickerVO.Title = "새메모";
            stickerVO.FormWidth = 200;
            stickerVO.FormHeight = 200;
            stickerVO.FormOpacity = 100;
            HAEForm h = new HAEForm(stickerVO, this);
            haeFormList.Add(h);
            h.StartPosition = FormStartPosition.CenterScreen;
            h.Location = new Point(stickerVO.PosX, stickerVO.PosY);
            h.Show();
            h.Focus();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            openNewSticker();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblFoldAndUnfold_Click(object sender, EventArgs e)
        {
            for (int idx = 0; idx < haeFormList.Count; idx++)
            {
                HAEForm h = haeFormList[idx] as HAEForm;
                folding = !folding;
                h.stickerVO.FoldYn = (folding)?"Y":"N";
                h.foldAndUnfoldSticker(folding);
            }
        }
    }
}
