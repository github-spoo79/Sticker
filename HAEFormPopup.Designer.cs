namespace HAESticker
{
    partial class HAEFormPopup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tblFormPopup = new System.Windows.Forms.TableLayoutPanel();
            this.pnlFormPopupTitl = new System.Windows.Forms.Panel();
            this.pnlFormPopupBtn = new System.Windows.Forms.TableLayoutPanel();
            this.pnlFormPopupBody = new System.Windows.Forms.Panel();
            this.tblFormPopupBody = new System.Windows.Forms.TableLayoutPanel();
            this.lblPopupMsg = new System.Windows.Forms.Label();
            this.pnlPopupBottom = new System.Windows.Forms.Panel();
            this.tblBottomBtn = new System.Windows.Forms.TableLayoutPanel();
            this.pbBtnClose = new System.Windows.Forms.PictureBox();
            this.pbNoti = new System.Windows.Forms.PictureBox();
            this.lblOK = new System.Windows.Forms.Label();
            this.lblCancel = new System.Windows.Forms.Label();
            this.tblFormPopup.SuspendLayout();
            this.pnlFormPopupTitl.SuspendLayout();
            this.pnlFormPopupBtn.SuspendLayout();
            this.pnlFormPopupBody.SuspendLayout();
            this.tblFormPopupBody.SuspendLayout();
            this.pnlPopupBottom.SuspendLayout();
            this.tblBottomBtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBtnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNoti)).BeginInit();
            this.SuspendLayout();
            // 
            // tblFormPopup
            // 
            this.tblFormPopup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(91)))), ((int)(((byte)(157)))));
            this.tblFormPopup.ColumnCount = 3;
            this.tblFormPopup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 2F));
            this.tblFormPopup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblFormPopup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 2F));
            this.tblFormPopup.Controls.Add(this.pnlFormPopupTitl, 1, 0);
            this.tblFormPopup.Controls.Add(this.pnlFormPopupBody, 1, 1);
            this.tblFormPopup.Controls.Add(this.pnlPopupBottom, 1, 2);
            this.tblFormPopup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblFormPopup.Location = new System.Drawing.Point(0, 0);
            this.tblFormPopup.Name = "tblFormPopup";
            this.tblFormPopup.RowCount = 4;
            this.tblFormPopup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tblFormPopup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblFormPopup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tblFormPopup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2F));
            this.tblFormPopup.Size = new System.Drawing.Size(300, 140);
            this.tblFormPopup.TabIndex = 0;
            this.tblFormPopup.Paint += new System.Windows.Forms.PaintEventHandler(this.tblFormPopup_Paint);
            // 
            // pnlFormPopupTitl
            // 
            this.pnlFormPopupTitl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(91)))), ((int)(((byte)(157)))));
            this.pnlFormPopupTitl.Controls.Add(this.pnlFormPopupBtn);
            this.pnlFormPopupTitl.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFormPopupTitl.Location = new System.Drawing.Point(2, 0);
            this.pnlFormPopupTitl.Margin = new System.Windows.Forms.Padding(0);
            this.pnlFormPopupTitl.Name = "pnlFormPopupTitl";
            this.pnlFormPopupTitl.Size = new System.Drawing.Size(296, 24);
            this.pnlFormPopupTitl.TabIndex = 1;
            // 
            // pnlFormPopupBtn
            // 
            this.pnlFormPopupBtn.ColumnCount = 1;
            this.pnlFormPopupBtn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.pnlFormPopupBtn.Controls.Add(this.pbBtnClose, 0, 0);
            this.pnlFormPopupBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlFormPopupBtn.Location = new System.Drawing.Point(272, 0);
            this.pnlFormPopupBtn.Margin = new System.Windows.Forms.Padding(0);
            this.pnlFormPopupBtn.Name = "pnlFormPopupBtn";
            this.pnlFormPopupBtn.RowCount = 1;
            this.pnlFormPopupBtn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlFormPopupBtn.Size = new System.Drawing.Size(24, 24);
            this.pnlFormPopupBtn.TabIndex = 1;
            // 
            // pnlFormPopupBody
            // 
            this.pnlFormPopupBody.BackColor = System.Drawing.Color.White;
            this.pnlFormPopupBody.Controls.Add(this.tblFormPopupBody);
            this.pnlFormPopupBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFormPopupBody.Location = new System.Drawing.Point(2, 24);
            this.pnlFormPopupBody.Margin = new System.Windows.Forms.Padding(0);
            this.pnlFormPopupBody.Name = "pnlFormPopupBody";
            this.pnlFormPopupBody.Size = new System.Drawing.Size(296, 78);
            this.pnlFormPopupBody.TabIndex = 2;
            // 
            // tblFormPopupBody
            // 
            this.tblFormPopupBody.ColumnCount = 2;
            this.tblFormPopupBody.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tblFormPopupBody.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblFormPopupBody.Controls.Add(this.pbNoti, 0, 0);
            this.tblFormPopupBody.Controls.Add(this.lblPopupMsg, 1, 0);
            this.tblFormPopupBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblFormPopupBody.Location = new System.Drawing.Point(0, 0);
            this.tblFormPopupBody.Name = "tblFormPopupBody";
            this.tblFormPopupBody.RowCount = 1;
            this.tblFormPopupBody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblFormPopupBody.Size = new System.Drawing.Size(296, 78);
            this.tblFormPopupBody.TabIndex = 0;
            // 
            // lblPopupMsg
            // 
            this.lblPopupMsg.AutoSize = true;
            this.lblPopupMsg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPopupMsg.Location = new System.Drawing.Point(67, 0);
            this.lblPopupMsg.Name = "lblPopupMsg";
            this.lblPopupMsg.Size = new System.Drawing.Size(226, 78);
            this.lblPopupMsg.TabIndex = 1;
            this.lblPopupMsg.Text = "메모를 삭제하시겠습니까?";
            this.lblPopupMsg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlPopupBottom
            // 
            this.pnlPopupBottom.BackColor = System.Drawing.Color.White;
            this.pnlPopupBottom.Controls.Add(this.tblBottomBtn);
            this.pnlPopupBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPopupBottom.Location = new System.Drawing.Point(2, 102);
            this.pnlPopupBottom.Margin = new System.Windows.Forms.Padding(0);
            this.pnlPopupBottom.Name = "pnlPopupBottom";
            this.pnlPopupBottom.Size = new System.Drawing.Size(296, 36);
            this.pnlPopupBottom.TabIndex = 3;
            // 
            // tblBottomBtn
            // 
            this.tblBottomBtn.ColumnCount = 5;
            this.tblBottomBtn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblBottomBtn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tblBottomBtn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 6F));
            this.tblBottomBtn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tblBottomBtn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblBottomBtn.Controls.Add(this.lblOK, 1, 1);
            this.tblBottomBtn.Controls.Add(this.lblCancel, 3, 1);
            this.tblBottomBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblBottomBtn.Location = new System.Drawing.Point(0, 0);
            this.tblBottomBtn.Name = "tblBottomBtn";
            this.tblBottomBtn.RowCount = 3;
            this.tblBottomBtn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tblBottomBtn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblBottomBtn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tblBottomBtn.Size = new System.Drawing.Size(296, 36);
            this.tblBottomBtn.TabIndex = 0;
            // 
            // pbBtnClose
            // 
            this.pbBtnClose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbBtnClose.Image = global::HAESticker.Properties.Resources.btnClose;
            this.pbBtnClose.Location = new System.Drawing.Point(0, 0);
            this.pbBtnClose.Margin = new System.Windows.Forms.Padding(0);
            this.pbBtnClose.Name = "pbBtnClose";
            this.pbBtnClose.Size = new System.Drawing.Size(24, 24);
            this.pbBtnClose.TabIndex = 0;
            this.pbBtnClose.TabStop = false;
            this.pbBtnClose.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbBtnClose_MouseDown);
            this.pbBtnClose.MouseLeave += new System.EventHandler(this.pbBtnClose_MouseLeave);
            this.pbBtnClose.MouseHover += new System.EventHandler(this.pbBtnClose_MouseHover);
            // 
            // pbNoti
            // 
            this.pbNoti.BackgroundImage = global::HAESticker.Properties.Resources.notiAsk;
            this.pbNoti.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbNoti.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbNoti.Location = new System.Drawing.Point(0, 0);
            this.pbNoti.Margin = new System.Windows.Forms.Padding(0);
            this.pbNoti.Name = "pbNoti";
            this.pbNoti.Size = new System.Drawing.Size(64, 78);
            this.pbNoti.TabIndex = 0;
            this.pbNoti.TabStop = false;
            // 
            // lblOK
            // 
            this.lblOK.AutoSize = true;
            this.lblOK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOK.ForeColor = System.Drawing.Color.White;
            this.lblOK.Image = global::HAESticker.Properties.Resources.btnColor;
            this.lblOK.Location = new System.Drawing.Point(68, 5);
            this.lblOK.Name = "lblOK";
            this.lblOK.Size = new System.Drawing.Size(74, 26);
            this.lblOK.TabIndex = 0;
            this.lblOK.Text = "확인";
            this.lblOK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblOK.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblOK_MouseDown);
            this.lblOK.MouseLeave += new System.EventHandler(this.lblOK_MouseLeave);
            this.lblOK.MouseHover += new System.EventHandler(this.lblOK_MouseHover);
            // 
            // lblCancel
            // 
            this.lblCancel.AutoSize = true;
            this.lblCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCancel.ForeColor = System.Drawing.Color.White;
            this.lblCancel.Image = global::HAESticker.Properties.Resources.btnColor;
            this.lblCancel.Location = new System.Drawing.Point(154, 5);
            this.lblCancel.Name = "lblCancel";
            this.lblCancel.Size = new System.Drawing.Size(74, 26);
            this.lblCancel.TabIndex = 1;
            this.lblCancel.Text = "취소";
            this.lblCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCancel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblCancel_MouseDown);
            this.lblCancel.MouseLeave += new System.EventHandler(this.lblCancel_MouseLeave);
            this.lblCancel.MouseHover += new System.EventHandler(this.lblCancel_MouseHover);
            // 
            // HAEFormPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 140);
            this.Controls.Add(this.tblFormPopup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HAEFormPopup";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "HAEFormPopup";
            this.tblFormPopup.ResumeLayout(false);
            this.pnlFormPopupTitl.ResumeLayout(false);
            this.pnlFormPopupBtn.ResumeLayout(false);
            this.pnlFormPopupBody.ResumeLayout(false);
            this.tblFormPopupBody.ResumeLayout(false);
            this.tblFormPopupBody.PerformLayout();
            this.pnlPopupBottom.ResumeLayout(false);
            this.tblBottomBtn.ResumeLayout(false);
            this.tblBottomBtn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBtnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNoti)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblFormPopup;
        private System.Windows.Forms.Panel pnlFormPopupTitl;
        private System.Windows.Forms.TableLayoutPanel pnlFormPopupBtn;
        private System.Windows.Forms.PictureBox pbBtnClose;
        private System.Windows.Forms.Panel pnlFormPopupBody;
        private System.Windows.Forms.TableLayoutPanel tblFormPopupBody;
        private System.Windows.Forms.PictureBox pbNoti;
        private System.Windows.Forms.Label lblPopupMsg;
        private System.Windows.Forms.Panel pnlPopupBottom;
        private System.Windows.Forms.TableLayoutPanel tblBottomBtn;
        private System.Windows.Forms.Label lblOK;
        private System.Windows.Forms.Label lblCancel;
    }
}