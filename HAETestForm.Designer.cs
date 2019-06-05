namespace HAESticker
{
    partial class HAETestForm
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
            this.lblX = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.lblOffSet = new System.Windows.Forms.Label();
            this.pbTrackBall = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbTrackBall)).BeginInit();
            this.SuspendLayout();
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(71, 92);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(21, 12);
            this.lblX.TabIndex = 1;
            this.lblX.Text = "X :";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(71, 53);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(21, 12);
            this.lblY.TabIndex = 2;
            this.lblY.Text = "Y :";
            // 
            // lblOffSet
            // 
            this.lblOffSet.AutoSize = true;
            this.lblOffSet.Location = new System.Drawing.Point(71, 128);
            this.lblOffSet.Name = "lblOffSet";
            this.lblOffSet.Size = new System.Drawing.Size(55, 12);
            this.lblOffSet.TabIndex = 3;
            this.lblOffSet.Text = "offset X :";
            // 
            // pbTrackBall
            // 
            this.pbTrackBall.Image = global::HAESticker.Properties.Resources.btnTrackBall;
            this.pbTrackBall.Location = new System.Drawing.Point(-1, 0);
            this.pbTrackBall.Margin = new System.Windows.Forms.Padding(0);
            this.pbTrackBall.Name = "pbTrackBall";
            this.pbTrackBall.Size = new System.Drawing.Size(8, 16);
            this.pbTrackBall.TabIndex = 0;
            this.pbTrackBall.TabStop = false;
            this.pbTrackBall.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbTrackBall_MouseDown);
            this.pbTrackBall.MouseLeave += new System.EventHandler(this.pbTrackBall_MouseLeave);
            this.pbTrackBall.MouseHover += new System.EventHandler(this.pbTrackBall_MouseHover);
            this.pbTrackBall.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbTrackBall_MouseMove);
            this.pbTrackBall.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbTrackBall_MouseUp);
            // 
            // HAETestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 149);
            this.Controls.Add(this.lblOffSet);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.pbTrackBall);
            this.Name = "HAETestForm";
            this.Text = "HAETestForm";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.HAETestForm_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pbTrackBall)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbTrackBall;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Label lblOffSet;
    }
}