﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyDV
{
    public partial class QLVe : Form
    {
        public QLVe()
        {
            InitializeComponent();
        }
        string strCon = @"Data Source=DESKTOP-240NOH8\SQLEXPRESS01;Initial Catalog=CGV05;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
        SqlConnection sqlCon = null;

        DataSet ds = null;
        SqlDataAdapter adapter = null;

        //Hàm mở kết nối
        private void MoKetNoi()
        {
            if( sqlCon== null) sqlCon = new SqlConnection(strCon);
            if (sqlCon.State== ConnectionState.Closed) sqlCon.Open();
        }
           
        //Hamd hiển thị danh sách
        private void HienThiDS()
        {
            MoKetNoi();

            //Lenh truy van
            string sql = "select * from Ve";
            adapter = new SqlDataAdapter(sql, sqlCon);

            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

            ds = new DataSet();
            adapter.Fill(ds, "Ve");
            dgvVe.DataSource = ds.Tables["Ve"];
        }
                private void dgvVe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void QLVe_Load(object sender, EventArgs e)
        {
            HienThiDS();
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn thực sự muốn thoát chứ???",
                "Đăng xuất ",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == DialogResult.Yes) Close();
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            // Lay du lieu tim kiem
            string idVe = txtTimKiem.Text.Trim();
            TimKiem(idVe);
        }

        private void TimKiem(string idVe)
        {
            MoKetNoi();

            //Lenh truy van
            string sql = "select * from Ve where idVe='" + idVe + "'";
            adapter = new SqlDataAdapter(sql, sqlCon);

            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

            ds = new DataSet();
            adapter.Fill(ds, "TimKiem");
            dgvVe.DataSource = ds.Tables["TimKiem"];
            XoaDuLieu();
        }

        int chucNang = 0;
        private void btnThem_Click(object sender, EventArgs e)
        {
            chucNang = 1;
            if (chucNang == 1)
            {
                ThemTT();
            }

        }
        //Ham xoa du lieu
        private void XoaDuLieu()
        {
            txtGia.Clear();
            txtMaG.Clear();
            txtMaKH.Clear();
            txtMaLC.Clear();
            txtMaPC.Clear();
            txtMaVe.Clear();
            txtMa.Clear();
            txtTimKiem.Clear();
        }
        private void ThemTT()
        {

            MoKetNoi();
            DataRow row = ds.Tables["Ve"].NewRow();

            row["PC_id"] = txtMaPC.Text.Trim();
            row["idVe"] = txtMaVe.Text.Trim();
            row["idG"] = txtMaG.Text.Trim();
            row["idLC"] = txtMaLC.Text.Trim();
            row["gia"] = txtGia.Text.Trim();
            row["KH_id"] = txtMaKH.Text.Trim();
            row["M_id"] = txtMa.Text.Trim();

            ds.Tables["Ve"].Rows.Add(row);
            int kq = adapter.Update(ds.Tables["Ve"]);
            if (kq > 0)
            {
                HienThiDS();
                MessageBox.Show("Thêm thành công ");
                XoaDuLieu();
            }
            else
            {
                MessageBox.Show("Thêm không  thành công ");
                XoaDuLieu();
            }
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            chucNang = 2;
            if (chucNang == 2)
            {
                SuaTT();
            }

        }
        private void SuaTT()
        {
            if (vt == -1) return;
            MoKetNoi();

            DataRow row = ds.Tables["Ve"].Rows[vt];
            row.BeginEdit();
            row["PC_id"] = txtMaPC.Text.Trim();
            row["idVe"] = txtMaVe.Text.Trim();
            row["idG"] = txtMaG.Text.Trim();
            row["idLC"] = txtMaLC.Text.Trim();
            row["gia"] = txtGia.Text.Trim();
            row["KH_id"] = txtMaKH.Text.Trim();
            row["M_id"] = txtMa.Text.Trim();
            row.EndEdit();

            int kq = adapter.Update(ds.Tables["Ve"]);
            if (kq > 0)
            {
                HienThiDS();
                MessageBox.Show("chỉnh sửa thành công ");
                XoaDuLieu();
            }
            else
            {
                MessageBox.Show("chỉnh sửa  không  thành công ");
                XoaDuLieu();
            }

        }

        int vt = -1;
        private void dgvVe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vt = e.RowIndex;
            if (vt == -1) return;

            DataRow row = ds.Tables["Ve"].Rows[vt];
            txtGia.Text = row["gia"].ToString().Trim();
            txtMa.Text = row["M_id"].ToString().Trim();
            txtMaG.Text = row["idG"].ToString().Trim();
            txtMaKH.Text = row["KH_id"].ToString().Trim();
            txtMaLC.Text = row["idLC"].ToString().Trim();
            txtMaPC.Text = row["PC_id"].ToString().Trim();
            txtMaVe.Text = row["idVe"].ToString().Trim();

            btnSua.Enabled = true;
            btnXoa.Enabled = true;

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (vt == -1) return;
            DialogResult result = MessageBox.Show("Bạn xác định xóa  hay không?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Xoa();
            }
            else
            {
                btnXoa.Enabled = false;
            }
        }
        private void Xoa()
        {
            if (vt == -1) return;
            MoKetNoi();
            DataRow row = ds.Tables["Ve"].Rows[vt];
            row.Delete();
            int kq = adapter.Update(ds.Tables["Ve"]);
            if (kq > 0)
            {
                MessageBox.Show("Xóa sinh viên thành công!");
                HienThiDS();
            }
            else
            {
                MessageBox.Show("Xóa sinh viên không thành công!");
            }
            XoaDuLieu();
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

        }
    }
}
