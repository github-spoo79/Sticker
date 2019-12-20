namespace HAESticker
{
    partial class HAETitlePopup
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlFormPopupBtn = new System.Windows.Forms.TableLayoutPanel();
            this.pbBtnClose = new System.Windows.Forms.PictureBox();
            this.pnlFormPopupBody = new System.Windows.Forms.Panel();
            this.tblFormPopupBody = new System.Windows.Forms.TableLayoutPanel();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.pnlPopupBottom = new System.Windows.Forms.Panel();
            this.tblBottomBtn = new System.Windows.Forms.TableLayoutPanel();
            this.lblOK = new System.Windows.Forms.Label();
            this.lblCancel = new System.Windows.Forms.Label();
            this.tblFormPopup.SuspendLayout();
            this.pnlFormPopupTitl.SuspendLayout();
            this.pnlFormPopupBtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBtnClose)).BeginInit();
            this.pnlFormPopupBody.SuspendLayout();
            this.tblFormPopupBody.SuspendLayout();
            this.pnlPopupBottom.SuspendLayout();
            this.tblBottomBtn.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblFormPopup
            // 
            this.tblFormPopup.BackColor = System.Drawing.SystemColors.ActiveBorder;
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
            this.tblFormPopup.Size = new System.Drawing.Size(250, 90);
            this.tblFormPopup.TabIndex = 0;
            // 
            // pnlFormPopupTitl
            // 
            this.pnlFormPopupTitl.BackColor = System.Drawing.Color.Transparent;
            this.pnlFormPopupTitl.Controls.Add(this.lblTitle);
            this.pnlFormPopupTitl.Controls.Add(this.pnlFormPopupBtn);
            this.pnlFormPopupTitl.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFormPopupTitl.Location = new System.Drawing.Point(2, 0);
            this.pnlFormPopupTitl.Margin = new System.Windows.Forms.Padding(0);
            this.pnlFormPopupTitl.Name = "pnlFormPopupTitl";
            this.pnlFormPopupTitl.Size = new System.Drawing.Size(246, 24);
            this.pnlFormPopupTitl.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.MaximumSize = new System.Drawing.Size(240, 24);
            this.lblTitle.MinimumSize = new System.Drawing.Size(120, 24);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(120, 24);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "타이틀 입력";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlFormPopupBtn
            // 
            this.pnlFormPopupBtn.ColumnCount = 1;
            this.pnlFormPopupBtn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.pnlFormPopupBtn.Controls.Add(this.pbBtnClose, 0, 0);
            this.pnlFormPopupBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlFormPopupBtn.Location = new System.Drawing.Point(222, 0);
            this.pnlFormPopupBtn.Margin = new System.Windows.Forms.Padding(0);
            this.pnlFormPopupBtn.Name = "pnlFormPopupBtn";
            this.pnlFormPopupBtn.RowCount = 1;
            this.pnlFormPopupBtn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlFormPopupBtn.Size = new System.Drawing.Size(24, 24);
            this.pnlFormPopupBtn.TabIndex = 1;
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
            // pnlFormPopupBody
            // 
            this.pnlFormPopupBody.BackColor = System.Drawing.Color.White;
            this.pnlFormPopupBody.Controls.Add(this.tblFormPopupBody);
            this.pnlFormPopupBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFormPopupBody.Location = new System.Drawing.Point(2, 24);
            this.pnlFormPopupBody.Margin = new System.Windows.Forms.Padding(0);
            this.pnlFormPopupBody.Name = "pnlFormPopupBody";
            this.pnlFormPopupBody.Size = new System.Drawing.Size(246, 28);
            this.pnlFormPopupBody.TabIndex = 2;
            // 
            // tblFormPopupBody
            // 
            this.tblFormPopupBody.ColumnCount = 2;
            this.tblFormPopupBody.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tblFormPopupBody.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblFormPopupBody.Controls.Add(this.txtTitle, 0, 0);
            this.tblFormPopupBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblFormPopupBody.Location = new System.Drawing.Point(0, 0);
            this.tblFormPopupBody.Name = "tblFormPopupBody";
            this.tblFormPopupBody.RowCount = 1;
            this.tblFormPopupBody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblFormPopupBody.Size = new System.Drawing.Size(246, 28);
            this.tblFormPopupBody.TabIndex = 0;
            // 
            // txtTitle
            // 
            this.tblFormPopupBody.SetColumnSpan(this.txtTitle, 2);
            this.txtTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTitle.Location = new System.Drawing.Point(3, 3);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(240, 21);
            this.txtTitle.TabIndex = 0;
            // 
            // pnlPopupBottom
            // 
            this.pnlPopupBottom.BackColor = System.Drawing.Color.White;
            this.pnlPopupBottom.Controls.Add(this.tblBottomBtn);
            this.pnlPopupBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPopupBottom.Location = new System.Drawing.Point(2, 52);
            this.pnlPopupBottom.Margin = new System.Windows.Forms.Padding(0);
            this.pnlPopupBottom.Name = "pnlPopupBottom";
            this.pnlPopupBottom.Size = new System.Drawing.Size(246, 36);
            this.pnlPopupBottom.TabIndex = 3;
            // 
            // tblBottomBtn
            // 
            this.tblBottomBtn.ColumnCount = 4;
            this.tblBottomBtn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblBottomBtn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tblBottomBtn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tblBottomBtn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblBottomBtn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblBottomBtn.Controls.Add(this.lblOK, 1, 1);
            this.tblBottomBtn.Controls.Add(this.lblCancel, 2, 1);
            this.tblBottomBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblBottomBtn.Location = new System.Drawing.Point(0, 0);
            this.tblBottomBtn.Name = "tblBottomBtn";
            this.tblBottomBtn.RowCount = 3;
            this.tblBottomBtn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tblBottomBtn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblBottomBtn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tblBottomBtn.Size = new System.Drawing.Size(246, 36);
            this.tblBottomBtn.TabIndex = 0;
            // 
            // lblOK
            // 
            this.lblOK.AutoSize = true;
            this.lblOK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOK.ForeColor = System.Drawing.Color.White;
            this.lblOK.Image = global::HAESticker.Properties.Resources.btnColor;
            this.lblOK.Location = new System.Drawing.Point(46, 5);
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
            this.lblCancel.Location = new System.Drawing.Point(126, 5);
            this.lblCancel.Name = "lblCancel";
            this.lblCancel.Size = new System.Drawing.Size(74, 26);
            this.lblCancel.TabIndex = 1;
            this.lblCancel.Text = "취소";
            this.lblCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCancel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblCancel_MouseDown);
            this.lblCancel.MouseLeave += new System.EventHandler(this.lblCancel_MouseLeave);
            this.lblCancel.MouseHover += new System.EventHandler(this.lblCancel_MouseHover);
            // 
            // HAETitlePopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 90);
            this.Controls.Add(this.tblFormPopup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HAETitlePopup";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "HAEFormPopup";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.HAETitlePopup_Load);
            this.tblFormPopup.ResumeLayout(false);
            this.pnlFormPopupTitl.ResumeLayout(false);
            this.pnlFormPopupTitl.PerformLayout();
            this.pnlFormPopupBtn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbBtnClose)).EndInit();
            this.pnlFormPopupBody.ResumeLayout(false);
            this.tblFormPopupBody.ResumeLayout(false);
            this.tblFormPopupBody.PerformLayout();
            this.pnlPopupBottom.ResumeLayout(false);
            this.tblBottomBtn.ResumeLayout(false);
            this.tblBottomBtn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblFormPopup;
        private System.Windows.Forms.Panel pnlFormPopupTitl;
        private System.Windows.Forms.TableLayoutPanel pnlFormPopupBtn;
        private System.Windows.Forms.PictureBox pbBtnClose;
        private System.Windows.Forms.Panel pnlFormPopupBody;
        private System.Windows.Forms.TableLayoutPanel tblFormPopupBody;
        private System.Windows.Forms.Panel pnlPopupBottom;
        private System.Windows.Forms.TableLayoutPanel tblBottomBtn;
        private System.Windows.Forms.Label lblOK;
        private System.Windows.Forms.Label lblCancel;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtTitle;
    }
}