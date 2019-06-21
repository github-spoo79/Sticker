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
    public partial class HAETitlePopup : Form
    {
        public string title = string.Empty;

        public string Title
        {
            get { return this.title; }
            set { title = value; }
        }

        public HAETitlePopup()
        {
            InitializeComponent();
        }

        private void lblOK_MouseHover(object sender, EventArgs e)
        {
            lblOK.Image = Properties.Resources.btnColorHover;
        }

        private void lblOK_MouseLeave(object sender, EventArgs e)
        {
            lblOK.Image = Properties.Resources.btnColor;
        }

        private void lblOK_MouseDown(object sender, MouseEventArgs e)
        {
            this.title = txtTitle.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void lblCancel_MouseHover(object sender, EventArgs e)
        {
            lblCancel.Image = Properties.Resources.btnColorHover;
        }

        private void lblCancel_MouseLeave(object sender, EventArgs e)
        {
            lblCancel.Image = Properties.Resources.btnColor;
        }

        private void lblCancel_MouseDown(object sender, MouseEventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void pbBtnClose_MouseHover(object sender, EventArgs e)
        {
            pbBtnClose.Image = Properties.Resources.btnCloseHover;
        }

        private void pbBtnClose_MouseLeave(object sender, EventArgs e)
        {
            pbBtnClose.Image = Properties.Resources.btnClose;
        }

        private void pbBtnClose_MouseDown(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void HAETitlePopup_Load(object sender, EventArgs e)
        {
            txtTitle.Text = title;
            txtTitle.Focus();
        }
    }
}
