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
    public partial class HAEForm : Form
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
        private Size previousFoldingSize;
        private Point offset;
        private bool maximizied = false;
        private bool holding = false;
        private bool folding = false;

        private int MINIMUM_WIDTH = 300;
        private int MINIMUM_HEIGHT = 26;

        private int DEFAULT_WIDTH = 300;
        private int DEFAULT_HEIGHT = 200;
        
        private double OPACITY_RATE = 0.01;

        public StickerVO stickerVO;

        private HAEMainForm haeMainForm;

        HAESQLiteQuery haeSQLiteQuery = new HAESQLiteQuery();

        public HAEForm()
        {
            InitializeComponent();

            initEventHandler();
        }

        public HAEForm(StickerVO vo)
        {
            InitializeComponent();

            stickerVO = vo;

            initEventHandler();
        }

        public HAEForm(StickerVO vo, HAEMainForm form)
        {
            InitializeComponent();

            stickerVO = vo;

            haeMainForm = form;

            initEventHandler();
        }


        private void initSticker()
        {
            Width = stickerVO.FormWidth;
            Height = stickerVO.FormHeight;
            lblFormTitle.Text = stickerVO.Title;
            rtbContents.Text = stickerVO.Contents;
            tbarOpacity.Value = stickerVO.FormOpacity;
            previousFoldingSize.Width = stickerVO.FormPrevWidth;
            previousFoldingSize.Height = stickerVO.FormPrevHeight;
            if(stickerVO.FoldYn == "Y") { folding = true; }

            tbarOpacity.redrawTrackBall();
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

            tbarOpacity.redrawTrackBall();
        }

        private void pbBtnClose_Click(object sender, EventArgs e)
        {
            haeMainForm.removeSticker(stickerVO.FormId);
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
            tbarOpacity.redrawTrackBall();
        }

        private void pbBtnHide_Click(object sender, EventArgs e)
        {
            //최소화 버튼은 테스트 해보니 불 필요해 보임, 이보다 폰트 변경 기능을 적용하는게 나을 듯
            //this.WindowState = FormWindowState.Minimized;
            //tbarOpacity.redrawTrackBall();
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
            this.Cursor = Cursors.Default;
            if (holding)
            {
                pbLogo.Image = Properties.Resources.btnHoldingHover;
            }
            else
            {
                pbLogo.Image = Properties.Resources.btnHolderHover;
            }
        }

        private void pbLogo_MouseClick(object sender, MouseEventArgs e)
        {
            if (holding)
            {
                pbLogo.Image = Properties.Resources.btnHolder;
                holding = false;
            }
            else
            {
                pbLogo.Image = Properties.Resources.btnHolding;
                holding = true;
            }
        }

        private void pbLogo_MouseLeave(object sender, EventArgs e)
        {
            if (holding)
            {
                pbLogo.Image = Properties.Resources.btnHolding;
            }
            else
            {
                pbLogo.Image = Properties.Resources.btnHolder;
            }
        }

        private void lblFormTitle_Click(object sender, EventArgs e)
        {
        }

        private void lblFormTitle_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                if (folding)
                {
                    //this.Width = previousFoldingSize.Width;
                    this.Height = previousFoldingSize.Height;
                    folding = false;
                }
                else
                {
                    previousFoldingSize = this.Size;
                    //this.Width = MINIMUM_WIDTH;
                    this.Height = MINIMUM_HEIGHT;
                    folding = true;
                }
            }
            else
            {
                HAETitlePopup titlePopup = new HAETitlePopup();
                titlePopup.Title = lblFormTitle.Text.ToString();
                if(titlePopup.ShowDialog() == DialogResult.OK)
                {
                    lblFormTitle.Text = titlePopup.title;
                }
            }
        }
        
        private void tbOpacity_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void tbarOpacity_MouseLeave(object sender, EventArgs e)
        {
        }

        private void tbarOpacity_ValueChanged(object sender, EventArgs e)
        {
            this.Opacity = tbarOpacity.Value * OPACITY_RATE;
        }

        private void pbTrash_Click(object sender, EventArgs e)
        {

        }

        private void pbTrash_MouseDown(object sender, MouseEventArgs e)
        {
            HAEFormPopup popup = new HAEFormPopup();
            popup.ShowDialog();
        }

        private void pbTrash_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
            pbTrash.Image = Properties.Resources.btnTrashHover;
        }

        private void pbTrash_MouseLeave(object sender, EventArgs e)
        {
            pbTrash.Image = Properties.Resources.btnTrash;
        }

        private void tbarOpacity_ValueChangeEvent(object sender, EventArgs e)
        {
            this.Opacity = tbarOpacity.Value * OPACITY_RATE;
        }

        private void HAEForm_Activated(object sender, EventArgs e)
        {            
        }

        private void HAEForm_Deactivate(object sender, EventArgs e)
        {
        }

        private void HAEForm_Load(object sender, EventArgs e)
        {
            initSticker();
        }

        public void saveStickerInfo()
        {
            switch (stickerVO.IudFlag)
            {
                case "I":
                    insertStickerInfo();
                    break;
                case "U":
                    updateStickerInfo();
                    break;
            }
        }

        private void insertStickerInfo()
        {
            /*
            INSERT INTO sticker(form_id, pos_x, pos_y, form_width
            , form_height, prev_form_width, prev_form_height
            , form_opacity, title, contents_rft, contents
            , hidden_yn, fold_yn, rgst_dt, updt_dt)
            VALUES(@form_id, @pos_x, @pos_y, @form_width
            , @form_height, @prev_form_width, @prev_form_height
            , @form_opacity, @title, @contents_rtf, @contents
            , @hidden_yn, @fold_yn, @rgst_dt, @updt_dt)
            */
            HAESQLiteVO vo = new HAESQLiteVO();
            vo.set("form_id", stickerVO.FormId);
            vo.set("pos_x", this.Location.X);
            vo.set("pos_y", this.Location.Y);
            vo.set("form_width", this.Width);
            vo.set("form_height", this.Height);
            vo.set("prev_form_width", this.Width);
            vo.set("prev_form_height", this.Height);
            vo.set("form_opacity", tbarOpacity.Value);
            vo.set("title", lblFormTitle.Text);
            vo.set("contents", rtbContents.Text);
            vo.set("contents_rtf", rtbContents.Text);
            vo.set("fold_yn", "N");
            vo.set("hidden_yn", "N");
            vo.set("rgst_dt", DateTime.Today.ToLongDateString());
            vo.set("updt_dt", DateTime.Today.ToLongDateString());

            if (haeSQLiteQuery.insertStickerInfo(vo) > 0)
            {
                stickerVO.IudFlag = "U";
            }
        }

        private void updateStickerInfo()
        {
            /*
            UPDATE sticker
            SET pos_x = @pos_x
            , pos_y = @pos_y
            , form_width = @form_width
            , form_height = @form_height
            , prev_form_width = @prev_form_width
            , prev_form_height = @prev_form_height
            , form_opacity = @form_opacity
            , title = @title
            , contents_rft = @contents_rft
            , contents = @contents
            , hidden_yn = @hidden_yn
            , fold_yn = @fold_yn
            , updt_dt = @updt_dt
            WHERE form_id = @form_id
            */
            HAESQLiteVO vo = new HAESQLiteVO();
            vo.set("form_id", stickerVO.FormId);
            vo.set("pos_x", this.Location.X);
            vo.set("pos_y", this.Location.Y);
            vo.set("form_width", this.Width);
            vo.set("form_height", this.Height);
            vo.set("prev_form_width", this.Width);
            vo.set("prev_form_height", previousFoldingSize.Height);
            vo.set("form_opacity", tbarOpacity.Value);
            vo.set("title", lblFormTitle.Text);
            vo.set("contents", rtbContents.Text);
            vo.set("contents_rtf", rtbContents.Text);
            vo.set("fold_yn", (folding)? "Y":"N");
            vo.set("hidden_yn", "N");
            vo.set("updt_dt", DateTime.Today.ToLongDateString());
            haeSQLiteQuery.updateStickerInfo(vo);
        }
    }
}
