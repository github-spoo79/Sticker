namespace HAESticker
{
    partial class HAEMainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlCaption = new System.Windows.Forms.Panel();
            this.pnlFormTitle = new System.Windows.Forms.Panel();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.tpnlLogo = new System.Windows.Forms.TableLayoutPanel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.tpnlFormBtn = new System.Windows.Forms.TableLayoutPanel();
            this.pbBtnClose = new System.Windows.Forms.PictureBox();
            this.pbBtnExpand = new System.Windows.Forms.PictureBox();
            this.pbBtnHide = new System.Windows.Forms.PictureBox();
            this.tblSticker = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlCaption.SuspendLayout();
            this.pnlFormTitle.SuspendLayout();
            this.tpnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.tpnlFormBtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBtnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBtnExpand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBtnHide)).BeginInit();
            this.tblSticker.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCaption
            // 
            this.pnlCaption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(91)))), ((int)(((byte)(157)))));
            this.pnlCaption.Controls.Add(this.pnlFormTitle);
            this.pnlCaption.Controls.Add(this.tpnlLogo);
            this.pnlCaption.Controls.Add(this.tpnlFormBtn);
            this.pnlCaption.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCaption.Location = new System.Drawing.Point(2, 0);
            this.pnlCaption.Margin = new System.Windows.Forms.Padding(0);
            this.pnlCaption.Name = "pnlCaption";
            this.pnlCaption.Size = new System.Drawing.Size(920, 24);
            this.pnlCaption.TabIndex = 0;
            // 
            // pnlFormTitle
            // 
            this.pnlFormTitle.AutoSize = true;
            this.pnlFormTitle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlFormTitle.Controls.Add(this.lblFormTitle);
            this.pnlFormTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFormTitle.Location = new System.Drawing.Point(24, 0);
            this.pnlFormTitle.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.pnlFormTitle.Name = "pnlFormTitle";
            this.pnlFormTitle.Size = new System.Drawing.Size(824, 24);
            this.pnlFormTitle.TabIndex = 3;
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFormTitle.ForeColor = System.Drawing.Color.White;
            this.lblFormTitle.Location = new System.Drawing.Point(0, 0);
            this.lblFormTitle.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Padding = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.lblFormTitle.Size = new System.Drawing.Size(824, 24);
            this.lblFormTitle.TabIndex = 0;
            this.lblFormTitle.Text = "Sticker Main";
            this.lblFormTitle.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lblFormTitle.Click += new System.EventHandler(this.lblFormTitle_Click);
            this.lblFormTitle.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lblFormTitle_MouseDoubleClick);
            // 
            // tpnlLogo
            // 
            this.tpnlLogo.ColumnCount = 1;
            this.tpnlLogo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tpnlLogo.Controls.Add(this.pbLogo, 0, 0);
            this.tpnlLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.tpnlLogo.Location = new System.Drawing.Point(0, 0);
            this.tpnlLogo.Margin = new System.Windows.Forms.Padding(0);
            this.tpnlLogo.Name = "tpnlLogo";
            this.tpnlLogo.RowCount = 1;
            this.tpnlLogo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpnlLogo.Size = new System.Drawing.Size(24, 24);
            this.tpnlLogo.TabIndex = 2;
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::HAESticker.Properties.Resources.btnHolder;
            this.pbLogo.Location = new System.Drawing.Point(0, 0);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(0);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(24, 24);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbLogo.TabIndex = 2;
            this.pbLogo.TabStop = false;
            this.pbLogo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbLogo_MouseClick);
            this.pbLogo.MouseLeave += new System.EventHandler(this.pbLogo_MouseLeave);
            this.pbLogo.MouseHover += new System.EventHandler(this.pbLogo_MouseHover);
            // 
            // tpnlFormBtn
            // 
            this.tpnlFormBtn.ColumnCount = 3;
            this.tpnlFormBtn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tpnlFormBtn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tpnlFormBtn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tpnlFormBtn.Controls.Add(this.pbBtnClose, 2, 0);
            this.tpnlFormBtn.Controls.Add(this.pbBtnExpand, 1, 0);
            this.tpnlFormBtn.Controls.Add(this.pbBtnHide, 0, 0);
            this.tpnlFormBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.tpnlFormBtn.Location = new System.Drawing.Point(848, 0);
            this.tpnlFormBtn.Margin = new System.Windows.Forms.Padding(0);
            this.tpnlFormBtn.Name = "tpnlFormBtn";
            this.tpnlFormBtn.RowCount = 1;
            this.tpnlFormBtn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpnlFormBtn.Size = new System.Drawing.Size(72, 24);
            this.tpnlFormBtn.TabIndex = 1;
            // 
            // pbBtnClose
            // 
            this.pbBtnClose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbBtnClose.Image = global::HAESticker.Properties.Resources.btnClose;
            this.pbBtnClose.InitialImage = null;
            this.pbBtnClose.Location = new System.Drawing.Point(48, 0);
            this.pbBtnClose.Margin = new System.Windows.Forms.Padding(0);
            this.pbBtnClose.Name = "pbBtnClose";
            this.pbBtnClose.Size = new System.Drawing.Size(24, 24);
            this.pbBtnClose.TabIndex = 0;
            this.pbBtnClose.TabStop = false;
            this.pbBtnClose.Click += new System.EventHandler(this.pbBtnClose_Click);
            this.pbBtnClose.MouseLeave += new System.EventHandler(this.pbBtnClose_MouseLeave);
            this.pbBtnClose.MouseHover += new System.EventHandler(this.pbBtnClose_MouseHover);
            // 
            // pbBtnExpand
            // 
            this.pbBtnExpand.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbBtnExpand.Image = global::HAESticker.Properties.Resources.btnExpand;
            this.pbBtnExpand.Location = new System.Drawing.Point(24, 0);
            this.pbBtnExpand.Margin = new System.Windows.Forms.Padding(0);
            this.pbBtnExpand.Name = "pbBtnExpand";
            this.pbBtnExpand.Size = new System.Drawing.Size(24, 24);
            this.pbBtnExpand.TabIndex = 1;
            this.pbBtnExpand.TabStop = false;
            this.pbBtnExpand.Click += new System.EventHandler(this.pbBtnExpand_Click);
            this.pbBtnExpand.MouseLeave += new System.EventHandler(this.pbBtnExpand_MouseLeave);
            this.pbBtnExpand.MouseHover += new System.EventHandler(this.pbBtnExpand_MouseHover);
            // 
            // pbBtnHide
            // 
            this.pbBtnHide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbBtnHide.Image = global::HAESticker.Properties.Resources.btnHide;
            this.pbBtnHide.Location = new System.Drawing.Point(0, 0);
            this.pbBtnHide.Margin = new System.Windows.Forms.Padding(0);
            this.pbBtnHide.Name = "pbBtnHide";
            this.pbBtnHide.Size = new System.Drawing.Size(24, 24);
            this.pbBtnHide.TabIndex = 2;
            this.pbBtnHide.TabStop = false;
            this.pbBtnHide.Click += new System.EventHandler(this.pbBtnHide_Click);
            this.pbBtnHide.MouseLeave += new System.EventHandler(this.pbBtnHide_MouseLeave);
            this.pbBtnHide.MouseHover += new System.EventHandler(this.pbBtnHide_MouseHover);
            // 
            // tblSticker
            // 
            this.tblSticker.BackColor = System.Drawing.Color.White;
            this.tblSticker.ColumnCount = 3;
            this.tblSticker.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 2F));
            this.tblSticker.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblSticker.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 2F));
            this.tblSticker.Controls.Add(this.pnlCaption, 1, 0);
            this.tblSticker.Controls.Add(this.tableLayoutPanel1, 1, 1);
            this.tblSticker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblSticker.Location = new System.Drawing.Point(1, 1);
            this.tblSticker.Margin = new System.Windows.Forms.Padding(0);
            this.tblSticker.Name = "tblSticker";
            this.tblSticker.RowCount = 2;
            this.tblSticker.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tblSticker.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblSticker.Size = new System.Drawing.Size(924, 398);
            this.tblSticker.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 2F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 2F));
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 27);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(920, 368);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // HAEMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(91)))), ((int)(((byte)(157)))));
            this.ClientSize = new System.Drawing.Size(926, 400);
            this.Controls.Add(this.tblSticker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HAEMainForm";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.ShowInTaskbar = false;
            this.Text = "Form1";
            this.TopMost = true;
            this.Activated += new System.EventHandler(this.HAEForm_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HAEMainForm_FormClosing);
            this.Load += new System.EventHandler(this.HAEForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HAEForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HAEForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.HAEForm_MouseUp);
            this.pnlCaption.ResumeLayout(false);
            this.pnlCaption.PerformLayout();
            this.pnlFormTitle.ResumeLayout(false);
            this.tpnlLogo.ResumeLayout(false);
            this.tpnlLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.tpnlFormBtn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbBtnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBtnExpand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBtnHide)).EndInit();
            this.tblSticker.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlCaption;
        private System.Windows.Forms.TableLayoutPanel tpnlFormBtn;
        private System.Windows.Forms.PictureBox pbBtnClose;
        private System.Windows.Forms.PictureBox pbBtnExpand;
        private System.Windows.Forms.PictureBox pbBtnHide;
        private System.Windows.Forms.TableLayoutPanel tpnlLogo;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Panel pnlFormTitle;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.TableLayoutPanel tblSticker;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

