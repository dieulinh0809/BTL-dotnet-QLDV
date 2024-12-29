using fTrangchu;
using QuanLyDV;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLR
{
    public partial class QLRap : Form
    {
        public static string LoaiTK;
        public QLRap()
        {
            InitializeComponent();
        }
        private void PhanQuyen(string LoaiTK)
        {
            if (LoaiTK == "QLR")
            {
                lblKH.Enabled = false;
                lblNS.Enabled = false;
                lblTK.Enabled = false;
                lblVe.Enabled = false;
                lblPhim.Enabled = false;


            }
            else if (LoaiTK == "QLNS")
            {
                lblKH.Enabled = false;
                lblRap.Enabled = false;
                lblTK.Enabled = false;
                lblVe.Enabled = false;
                lblPhim.Enabled = false;


            }
            else if (LoaiTK == "QLP")
            {
                lblKH.Enabled = false;
                lblRap.Enabled = false;
                lblTK.Enabled = false;
                lblVe.Enabled = false;
                lblNS.Enabled = false;


            }
            else if (LoaiTK == "QLV")
            {
                lblKH.Enabled = false;
                lblRap.Enabled = false;
                lblTK.Enabled = false;
                lblPhim.Enabled = false;
                lblNS.Enabled = false;

            }
            else
            {
                return;
            }
        }
        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không ? ",
                "Hộp Thoại ", MessageBoxButtons.YesNo, MessageBoxIcon.Question
                );
            if (result == DialogResult.Yes)
            {
                Application.Exit();


            }
        }
        //Chuoi Ket Noi 
        string str = @"Data Source=DESKTOP-RT4JUIV\SQLEXPRESS;Initial Catalog=CGV05;Integrated Security=True;Encrypt=False "
;
        //Doi tuong ket noi 
        SqlConnection con = null;
        //Ham mo ket noi 
        private void MoKN()
        {
            if (con == null)
            {
                con = new SqlConnection(str);
            }
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }
        //Ham Dong Ket Noi 
        private void DongKN()
        {
            if (con != null && con.State == ConnectionState.Open)
            {
                con.Close();
            }

        }
        //Ham Hien Thi Danh Sach 
        SqlDataAdapter adapter = null;
        DataSet ds = null;
        private void HienDS()
        {
            MoKN();
            string query = @"select*from Rap";
            adapter = new SqlDataAdapter(query, con);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(adapter);
            ds = new DataSet();
            adapter.Fill(ds, "HienThi");
            dgvRap.DataSource = ds.Tables["HienThi"];

        }
        DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
        private void Form1_Load(object sender, EventArgs e)
        {
            HienDS();
            PhanQuyen(LoaiTK);


            if (buttonColumn.Name != "btnColumn")
            {

                buttonColumn.HeaderText = "Chức Năng ";
                buttonColumn.Text = "Quản Lý ";
                buttonColumn.Name = "btnColumn";
                buttonColumn.UseColumnTextForButtonValue = true;
                dgvRap.Columns.Add(buttonColumn);
            }

        }

        private void dgvRap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnTK_Click(object sender, EventArgs e)
        {

            string timKiem = txtTimKiem.Text.Trim();
            TimKiem(timKiem);

        }

        //Cac Ham Tim Kiem 
        private void TimKiem(string timKiem)
        {
            MoKN();
            string query = "select * from Rap where R_name like  '%" + timKiem + "%' or R_id = '" + timKiem + "'";
            adapter = new SqlDataAdapter(query, con);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder();
            ds = new DataSet();
            adapter.Fill(ds, "TimKiem ");
            dgvRap.DataSource = ds.Tables["TimKiem "];
        }
        private void timKiemTheoMa(string maRap)
        {


            MoKN();
            string query = "select * from Rap where R_id = '" + maRap + "'";
            adapter = new SqlDataAdapter(query, con);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder();
            ds = new DataSet();
            adapter.Fill(ds, "TimKiemTheoMa");
            dgvRap.DataSource = ds.Tables["TimKiemTheoMa"];

        }
        private void timKiemTheoTen(string tenRap)
        {
            MoKN();
            string query = "select * from Rap where R_name like  '%" + tenRap + "%'";
            adapter = new SqlDataAdapter(query, con);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder();
            ds = new DataSet();
            adapter.Fill(ds, "TimKiemTheoTen");
            dgvRap.DataSource = ds.Tables["TimKiemTheoTen"];
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string timKiem = txtTimKiem.Text.Trim();
            TimKiem(timKiem);
            if (timKiem == "")
            {
                Form1_Load(sender, e);
            }
        }

        private void dgvRap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != dgvRap.Rows.Count - 1 && e.RowIndex >= 0)
            {
                if (e.ColumnIndex != dgvRap.Columns["btnColumn"].Index  )
                {


                    DataRow row = ds.Tables["HienThi"].Rows[e.RowIndex];
                    txtMaRap.Text = row["R_id"].ToString().Trim();
                    txtTenRap.Text = row["R_name"].ToString().Trim();
                    txtViTri.Text = row["diaChi"].ToString().Trim();
                    //txtMaRap.ReadOnly = true;

                }
                else
                {

                    string maRap = dgvRap.Rows[e.RowIndex].Cells[0].Value.ToString();
                    QuanLyCT form1 = new QuanLyCT();
                    form1.maRap = maRap;
                    this.Hide();
                    form1.ShowDialog();
                    this.Show();
                }

            }
        }
        private void XoaDLForm()
        {
            txtMaRap.Clear();
            txtTenRap.Clear();
            txtViTri.Clear();
        }



        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaRap.Text.Trim() == "" || txtTenRap.Text.Trim() == "" || txtViTri.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin !");
                return;
            }

            MoKN();

            string query = "INSERT INTO Rap (R_id, R_name, diaChi) VALUES (@MaRap, @TenRap, @DiaChi)";

           
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@MaRap", txtMaRap.Text.Trim());
            cmd.Parameters.AddWithValue("@TenRap", txtTenRap.Text.Trim());
            cmd.Parameters.AddWithValue("@DiaChi", txtViTri.Text.Trim());

            string checkQuery = "SELECT COUNT(*) FROM Rap WHERE R_id = '" + txtMaRap.Text.Trim() + "'";

            using (SqlCommand check = new SqlCommand(checkQuery, con))
            {

                int count = (int)check.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("Mã rạp đã tồn tại. Vui lòng nhập mã khác.");
                    return;
                }
            }

            int kq = cmd.ExecuteNonQuery();
            if (kq > 0)
            {
                MessageBox.Show("Thêm Dữ Liệu Thành Công !");
                HienDS();
                XoaDLForm();
                return;
            }
            else
            {

                MessageBox.Show("Thêm Dữ Liệu Không  Thành Công !");
                return;
            }
            DongKN();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            if (txtMaRap.Text.Trim() == "" || txtTenRap.Text.Trim() == "" || txtViTri.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn rạp cần sửa ");
                return;
            }

            MoKN();

            string query = "UPDATE Rap SET R_name = @TenRap, diaChi = @DiaChi WHERE R_id = @MaRap";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@MaRap", txtMaRap.Text.Trim());
            cmd.Parameters.AddWithValue("@TenRap", txtTenRap.Text.Trim());
            cmd.Parameters.AddWithValue("@DiaChi", txtViTri.Text.Trim());



            int kq = cmd.ExecuteNonQuery();
            if (kq > 0)
            {
                MessageBox.Show("Sửa  Dữ Liệu Thành Công !");
                HienDS();
                XoaDLForm();
                return;
            }
            else
            {

                MessageBox.Show("Sửa Dữ Liệu Không  Thành Công !");
                return;
            }
            DongKN();

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaRap.Text.Trim() == "" || txtTenRap.Text.Trim() == "" || txtViTri.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn rạp cần Xóa  ");
                return;
            }
            DialogResult hoi = MessageBox.Show("Bạn có chắc chắn muốn xóa không ? ", "Hỏi ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (hoi == DialogResult.Yes)
            {
                MoKN();
                //Xóa rạp 
                string queryXoaNV = "Delete from  NhanVien  where  R_id = '" + txtMaRap.Text.Trim() + "' ";
                SqlCommand cmd1 = new SqlCommand(queryXoaNV, con);
                string queryXoaPC = "Delete from PhongChieu    where  R_id = '" + txtMaRap.Text.Trim() + "' ";
                SqlCommand cmd2 = new SqlCommand(queryXoaPC, con);
                    string queryVe = "Delete from Ve    where  R_id = '" + txtMaRap.Text.Trim() + "' ";
                SqlCommand cmd3 = new SqlCommand(queryVe, con);
                string query = "Delete from  Rap   where  R_id = '" + txtMaRap.Text.Trim() + "' " ;
                SqlCommand cmd = new SqlCommand(query, con);



                int kq = cmd.ExecuteNonQuery();
                if (kq > 0)
                {
                    MessageBox.Show("Xóa  Dữ Liệu Thành Công !");
                    HienDS();
                    XoaDLForm();
                    return;
                }
                else
                {

                    MessageBox.Show("Xóa Dữ Liệu Không  Thành Công !");
                    return;
                }
                DongKN();
            }
        }

        private void blTC_Click(object sender, EventArgs e)
        {
            fTrangChu form1 = new fTrangChu();
            this.Hide();
            form1.ShowDialog();
            this.Show();
        }

        private void lblRap_Click(object sender, EventArgs e)
        {
            QLRap form1 = new QLRap();
            this.Hide();
            form1.ShowDialog();
            this.Show();
        }

        private void lblKH_Click(object sender, EventArgs e)
        {
            fQuanLyKhachHang form1 = new fQuanLyKhachHang();
            this.Hide();
            form1.ShowDialog();
            this.Show();
        }

        private void lblNS_Click(object sender, EventArgs e)
        {
            QuanLyNS form1 = new QuanLyNS();
            this.Hide();
            form1.ShowDialog();
            this.Show();
        }

        private void lblTK_Click(object sender, EventArgs e)
        {
            fQuanLyTaiKhoan form1 = new fQuanLyTaiKhoan();
            this.Hide();
            form1.ShowDialog();
            this.Show();
        }

        private void lblVe_Click(object sender, EventArgs e)
        {
            QLVe form1 = new QLVe();
            this.Hide();
            form1.ShowDialog();
            this.Show();
        }

        private void lblPhim_Click(object sender, EventArgs e)
        {
            fQuanLyPhim form1 = new fQuanLyPhim();
            this.Hide();
            form1.ShowDialog();
            this.Show();
        }

        private void blBCTK_Click(object sender, EventArgs e)
        {

        }
    }
}
