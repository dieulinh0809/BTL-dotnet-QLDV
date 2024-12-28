﻿using QuanLyDV;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fTrangchu
{
    public partial class fTrangChu : Form
    {
        public fTrangChu()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void thôngTinCáNhânToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            fQuanLyKhachHang fQLKH = new fQuanLyKhachHang();
            fQLKH.ShowDialog();
            fQLKH = null;
            this.Show();
        }

        private void btnDangxuat_Click(object sender, EventArgs e)
        {

        }


        private void movesidepanel(Button btn)
        {
            panelslide.Top = btn.Top;
            panelslide.Height = btn.Height;

        }

        private void addUC(UserControl uc)
        {
            panelcenter.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panelcenter.Controls.Clear();
            panelcenter.Controls.Add(uc);
        }


        private void btn2d_Click(object sender, EventArgs e)
        {
            movesidepanel(btn2d);
            UCphim2d uCphim2D = new UCphim2d();
            addUC(uCphim2D);
        }

        private void btn3d_Click(object sender, EventArgs e)
        {
            movesidepanel(btn3d);
            UCphim3d uCphim3D = new UCphim3d();
            addUC(uCphim3D);
        }

        private void panelcenter_Paint(object sender, PaintEventArgs e)
        {

        }

        private void nhânSựToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLyNS  fQLNV = new QuanLyNS();
            fQLNV.ShowDialog();
            fQLNV = null;
            this.Show();
        }

        private void phimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            fQuanLyPhim fQLP = new fQuanLyPhim();
            fQLP.ShowDialog();
            fQLP = null;
            this.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void fTrangChu_Load(object sender, EventArgs e)
        {

        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
