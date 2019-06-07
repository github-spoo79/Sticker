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
        private int border = 3;
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

        private void initEventHandler()
        {
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
                        this.Height = previousLocation.Y + previousSize.Height - currentScreenPos.Y + offset.Y;
                        this.Location = new Point(previousLocation.X, previousLocation.Y + previousSize.Height - this.Height);
                    }
                    else if (resizingDown)
                    {
                        this.Height = currentScreenPos.Y - previousLocation.Y + previousSize.Height - offset.Y;
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

        private void richTextBox1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void tbOpacity_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void tbOpacity_MouseLeave(object sender, EventArgs e)
        {
        }

        private void tbOpacity_ValueChanged(object sender, EventArgs e)
        {
            //this.Opacity = tbOpacity.Value * OPACITY_RATE;
        }

        private void pbTrash_Click(object sender, EventArgs e)
        {

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
    }
}
