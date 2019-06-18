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
        private string formId;
        private int posX;
        private int posY;
        private int formWidth;
        private int formHeight;
        private int formPrevWidth;
        private int formPrevHeight;
        private int formOpacity;
        private string title;
        private string contents;
        private string delYn;
        private string delDt;
        private string hiddenYn;
        private string foldYn;
        private string rgstDt;
        private string updtDt;

        public string FormId
        {
            get { return formId; }
            set { formId = value; }
        }

        public int PosX
        {
            get { return posX; }
            set { posX = value; }
        }

        public int PosY
        {
            get { return posY; }
            set { posY = value; }
        }

        public int FormWidth
        {
            get { return formWidth; }
            set { formWidth = value; }
        }

        public int FormHeight
        {
            get { return formHeight; }
            set { formHeight = value; }
        }

        public int FormPrevWidth
        {
            get { return formPrevWidth; }
            set { formPrevWidth = value; }
        }

        public int FormPrevHeight
        {
            get { return formPrevHeight; }
            set { formPrevHeight = value; }
        }

        public int FormOpacity
        {
            get { return formOpacity; }
            set { formOpacity = value; }
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Contents
        {
            get { return contents; }
            set { contents = value; }
        }

        public string DelYn
        {
            get { return delYn; }
            set { delYn = value; }
        }

        public string DelDt
        {
            get { return delDt; }
            set { delDt = value; }
        }

        public string HiddenYn
        {
            get { return hiddenYn; }
            set { hiddenYn = value; }
        }

        public string FoldYn
        {
            get { return foldYn; }
            set { foldYn = value; }
        }

        public string RgstDt
        {
            get { return rgstDt; }
            set { rgstDt = value; }
        }

        public string UpdtDt
        {
            get { return updtDt; }
            set { updtDt = value; }
        }

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
        private double OPACITY_RATE = 0.01;

        public HAEForm()
        {
            InitializeComponent();
            
            initEventHandler();
        }

        private void initSticker()
        {
            this.Width = this.formWidth;
            this.Height = this.formHeight;
            lblFormTitle.Text = this.Title;
            rtbContents.Text = this.Contents;
            tbarOpacity.Value = this.formOpacity;

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
            this.WindowState = FormWindowState.Minimized;
            tbarOpacity.redrawTrackBall();
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
                    this.Width = previousFoldingSize.Width;
                    this.Height = previousFoldingSize.Height;
                    folding = false;
                }
                else
                {
                    previousFoldingSize = this.Size;
                    this.Width = MINIMUM_WIDTH;
                    this.Height = MINIMUM_HEIGHT;
                    folding = true;
                }
            }
            else
            {
                HAETitlePopup titlePopup = new HAETitlePopup();
                titlePopup.ShowDialog();
            }
        }

        private void richTextBox1_MouseDown(object sender, MouseEventArgs e)
        {

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
    }
}
