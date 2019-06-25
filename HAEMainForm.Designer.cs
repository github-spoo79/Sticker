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
            this.components = new System.ComponentModel.Container();
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
            this.lblSearch = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdoTitleContents = new System.Windows.Forms.RadioButton();
            this.rdoContents = new System.Windows.Forms.RadioButton();
            this.rdoTitle = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menu2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menu1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlCaption.SuspendLayout();
            this.pnlFormTitle.SuspendLayout();
            this.tpnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.tpnlFormBtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBtnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBtnExpand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBtnHide)).BeginInit();
            this.tblSticker.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
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
            this.pnlCaption.Size = new System.Drawing.Size(698, 24);
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
            this.pnlFormTitle.Size = new System.Drawing.Size(602, 24);
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
            this.lblFormTitle.Size = new System.Drawing.Size(602, 24);
            this.lblFormTitle.TabIndex = 0;
            this.lblFormTitle.Text = "Sticker Main";
            this.lblFormTitle.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
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
            this.tpnlFormBtn.Location = new System.Drawing.Point(626, 0);
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
            this.tblSticker.Size = new System.Drawing.Size(702, 254);
            this.tblSticker.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 2F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 225F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 2F));
            this.tableLayoutPanel1.Controls.Add(this.lblSearch, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 27);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(698, 224);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSearch.ForeColor = System.Drawing.Color.White;
            this.lblSearch.Image = global::HAESticker.Properties.Resources.btnColor;
            this.lblSearch.Location = new System.Drawing.Point(551, 64);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(68, 26);
            this.lblSearch.TabIndex = 4;
            this.lblSearch.Text = "검색";
            this.lblSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSearch.Click += new System.EventHandler(this.lblSearch_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.dataGridView1, 4);
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(5, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(688, 128);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdoTitleContents);
            this.panel1.Controls.Add(this.rdoContents);
            this.panel1.Controls.Add(this.rdoTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(2, 64);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 26);
            this.panel1.TabIndex = 1;
            // 
            // rdoTitleContents
            // 
            this.rdoTitleContents.AutoSize = true;
            this.rdoTitleContents.Location = new System.Drawing.Point(134, 7);
            this.rdoTitleContents.Name = "rdoTitleContents";
            this.rdoTitleContents.Size = new System.Drawing.Size(77, 16);
            this.rdoTitleContents.TabIndex = 2;
            this.rdoTitleContents.Text = "제목+내용";
            this.rdoTitleContents.UseVisualStyleBackColor = true;
            // 
            // rdoContents
            // 
            this.rdoContents.AutoSize = true;
            this.rdoContents.Location = new System.Drawing.Point(67, 7);
            this.rdoContents.Name = "rdoContents";
            this.rdoContents.Size = new System.Drawing.Size(47, 16);
            this.rdoContents.TabIndex = 1;
            this.rdoContents.Text = "내용";
            this.rdoContents.UseVisualStyleBackColor = true;
            // 
            // rdoTitle
            // 
            this.rdoTitle.AutoSize = true;
            this.rdoTitle.Checked = true;
            this.rdoTitle.Location = new System.Drawing.Point(3, 7);
            this.rdoTitle.Name = "rdoTitle";
            this.rdoTitle.Size = new System.Drawing.Size(47, 16);
            this.rdoTitle.TabIndex = 0;
            this.rdoTitle.TabStop = true;
            this.rdoTitle.Text = "제목";
            this.rdoTitle.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(230, 67);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(315, 21);
            this.textBox1.TabIndex = 2;
            // 
            // panel2
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel2, 4);
            this.panel2.Controls.Add(this.tableLayoutPanel2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(2, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(694, 64);
            this.panel2.TabIndex = 6;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label4, 3, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(694, 64);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "새메모";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(67, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 64);
            this.label2.TabIndex = 1;
            this.label2.Text = "모두펼치기/접기";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 36);
            this.label3.TabIndex = 2;
            this.label3.Text = "모두숨기기/보이기";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(195, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 64);
            this.label4.TabIndex = 3;
            this.label4.Text = "좌측/우측\r\n정렬하기";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu1,
            this.menu2});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(111, 48);
            // 
            // menu2
            // 
            this.menu2.Name = "menu2";
            this.menu2.Size = new System.Drawing.Size(110, 22);
            this.menu2.Text = "종료";
            // 
            // menu1
            // 
            this.menu1.Name = "menu1";
            this.menu1.Size = new System.Drawing.Size(110, 22);
            this.menu1.Text = "새메모";
            // 
            // HAEMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(91)))), ((int)(((byte)(157)))));
            this.ClientSize = new System.Drawing.Size(704, 256);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.tblSticker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HAEMainForm";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.Text = "Sticker Main";
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
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdoTitleContents;
        private System.Windows.Forms.RadioButton rdoContents;
        private System.Windows.Forms.RadioButton rdoTitle;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menu2;
        private System.Windows.Forms.ToolStripMenuItem menu1;
    }
}

