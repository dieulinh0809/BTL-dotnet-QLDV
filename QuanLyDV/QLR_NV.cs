using fTrangchu;
using QLR;
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

namespace QuanLyDV
{
    public partial class QLR_NV : Form
    {
        public static string LoaiTK;
        public QLR_NV()
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
        private void btnTK_Click(object sender, EventArgs e)
        {
            string timKiem = txtTimKiem.Text.Trim();
            TimKiem(timKiem);
        }
        private void TimKiem(string timKiem)
        {
            MoKN();

            string query = @"
        SELECT 
            NhanVien.NV_id,
            NhanVien.TenNV,
            NhanVien.GioiTinh,
            NhanVien.CCCD,
            NhanVien.DiaChi,
            NhanVien.birthday,
            NhanVien.SDT,
            ChucVu.tenCV,
            Rap.R_name
        FROM 
            NhanVien
        INNER JOIN ChucVu ON NhanVien.idCV = ChucVu.idCV
        INNER JOIN Rap ON NhanVien.R_id = Rap.R_id
        WHERE 
            Rap.R_id = @maRap 
            AND (
                 NhanVien.NV_id LIKE '%' + @timKiem + '%'  or
                NhanVien.TenNV LIKE '%' + @timKiem + '%' 
                OR ChucVu.tenCV LIKE '%' + @timKiem + '%' 
                OR NhanVien.GioiTinh  LIKE '%' + @timKiem + '%' 
                OR NhanVien.SDT LIKE '%' + @timKiem + '%' 
                
            )";

            using (SqlCommand command = new SqlCommand(query, con))
            {
                command.Parameters.AddWithValue("@maRap", maRap);
                command.Parameters.AddWithValue("@timKiem", timKiem);

                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "TimKiem");
                    dgvNVR.DataSource = ds.Tables["TimKiem"];
                }
            }

            DongKN();
        }
        public string maRap;
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
        private void LayTenRap()
        {
            MoKN();
            string query = @"select * from Rap where R_id ='" + maRap + "'";
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                SqlDataReader sqlDataReader = cmd.ExecuteReader();
                if (sqlDataReader.Read())
                {
                    lblTenRap.Text = sqlDataReader["R_name"].ToString();
                }

            }
            DongKN();
        }

        //Ham Hien Thi Danh Sach 
        SqlDataAdapter adapter = null;
        DataSet ds = null;
        private void HienDS()
        {
            MoKN();
            string query = @"
                    SELECT 
                NhanVien.NV_id,
                NhanVien.TenNV, 
                NhanVien.GioiTinh,
                NhanVien.CCCD,
                NhanVien.DiaChi,
                NhanVien.birthday,
                NhanVien.SDT,
                ChucVu.tenCV,
                Rap.R_name
            FROM    
                NhanVien
            INNER JOIN ChucVu ON NhanVien.idCV = ChucVu.idCV
            INNER JOIN Rap ON NhanVien.R_id = Rap.R_id  
 
             where  Rap.R_id='" + maRap + "'";
            adapter = new SqlDataAdapter(query, con);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(adapter);
            ds = new DataSet();
            adapter.Fill(ds, "HienThi");
            dgvNVR.DataSource = ds.Tables["HienThi"];

        }

        private void QLR_NV_Load(object sender, EventArgs e)
        {
            LayTenRap();
            HienDS();
            PhanQuyen(LoaiTK);
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string timKiem = txtTimKiem.Text.Trim();
            TimKiem(timKiem);
            if (timKiem == "")
            {
                QLR_NV_Load(sender, e);
            }
        }

        private void dgvNVR_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvNVR_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != dgvNVR.Rows.Count - 1 && e.RowIndex >= 0)
            {
                DataRow row = ds.Tables["HienThi"].Rows[e.RowIndex];
                txtMaNV.Text = row["NV_id"].ToString().Trim();
                txtTenNV.Text = row["TenNV"].ToString().Trim();
                cbNu.Checked = row["GioiTinh"].ToString().Trim().ToLower() == "nữ";
                cbNam.Checked = !cbNu.Checked;
                txtCCCD.Text = row["CCCD"].ToString().Trim();
                txtDiaChi.Text = row["diaChi"].ToString().Trim();
                txtSDT.Text = row["SDT"].ToString().Trim();
                txtNoiLamViec.Text = row["R_name"].ToString().Trim();
                switch (row["tenCV"].ToString().Trim())
                {
                    case "Quản lý":
                        cbQuanLy.Checked = true;
                        cbSoatVe.Checked = false;
                        cbThuNgan.Checked = false;
                        break;
                    case "Soát vé":
                        cbQuanLy.Checked = false;
                        cbSoatVe.Checked = true;
                        cbThuNgan.Checked = false;
                        break;
                    default:
                        cbQuanLy.Checked = false;
                        cbSoatVe.Checked = false;
                        cbThuNgan.Checked = true;
                        break;
                }
                string a = row["birthday"].ToString().Trim().Split(' ')[0];
                string[] ns = a.Split('/');
                dtpNgaySinh.Value = new DateTime(int.Parse(ns[2]), int.Parse(ns[0]), int.Parse(ns[1]));
            }
        }
        private void XoaDLForm()
        {
            txtMaNV.Clear();
            txtTenNV.Clear();
            txtCCCD.Clear();
            txtSDT.Clear();
            txtDiaChi.Clear();
            txtNoiLamViec.Clear();
            cbSoatVe.Checked = false;
            cbQuanLy.Checked = false;
            cbThuNgan.Checked = false;
            cbNam.Checked = false;
            cbNu.Checked = false;
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text.Trim() == "" || txtTenNV.Text.Trim() == "" || txtCCCD.Text.Trim() == "" || txtNoiLamViec.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin !");
                return;
            }

            MoKN();
            string query = "INSERT INTO NhanVien (\r\n    NV_id,\r\n    TenNV,\r\n    GioiTinh,\r\n    CCCD,\r\n    diaChi,\r\n    birthday,\r\n    SDT,\r\n    idCV,\r\n    R_id\r\n)\r\nVALUES (\r\n    @NV_id,\r\n    @TenNV,\r\n    @GioiTinh,\r\n    @CCCD,\r\n    @diaChi,\r\n    @birthday,\r\n    @SDT,\r\n    @idCV,\r\n    @R_id\r\n)";
             string gioiTinh="";
            string ngaySinh = dtpNgaySinh.Value.Month + "/" + dtpNgaySinh.Value.Day + "/" + dtpNgaySinh.Value.Year;

            if (cbNu.Checked)
            {
                gioiTinh = "Nữ";
            }
            if (cbNam.Checked)
            {
                gioiTinh = "Nam";
            }
            string idCV="";
            if (cbQuanLy.Checked)
            {
                idCV = "cv01";
            }else if (cbThuNgan.Checked)
            {
                idCV = "cv02";
            }
            else if (cbSoatVe.Checked)
            {
                idCV = "cv03";
            }
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@NV_id", txtMaNV.Text.Trim());
            cmd.Parameters.AddWithValue("@TenNV", txtTenNV.Text.Trim());
            cmd.Parameters.AddWithValue("@GioiTinh", gioiTinh  );
            cmd.Parameters.AddWithValue("@CCCD", txtCCCD.Text.Trim());
            cmd.Parameters.AddWithValue("@diaChi", txtDiaChi.Text.Trim());
            cmd.Parameters.AddWithValue("@birthday",  ngaySinh);
            cmd.Parameters.AddWithValue("@SDT", txtSDT.Text.Trim());
            cmd.Parameters.AddWithValue("@idCV", idCV);
            cmd.Parameters.AddWithValue("@R_id",  maRap );
             
            string checkQuery = "SELECT COUNT(*) FROM NhanVien WHERE NV_id = '" + txtMaNV.Text.Trim() + "'";

            using (SqlCommand check = new SqlCommand(checkQuery, con))
            {

                int count = (int)check.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("Mã NV đã tồn tại. Vui lòng nhập mã khác.");
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
            if (txtMaNV.Text.Trim() == "" || txtTenNV.Text.Trim() == "" || txtCCCD.Text.Trim() == "" || txtNoiLamViec.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần Sửa !");
                return;
            }

            MoKN();
            string query = @"
        UPDATE NhanVien
        SET 
            TenNV = @TenNV,
            GioiTinh = @GioiTinh,
            CCCD = @CCCD,
            diaChi = @diaChi,
            birthday = @birthday,
            SDT = @SDT,
            idCV = @idCV,
            R_id = @R_id
        WHERE NV_id = @NV_id";
            string gioiTinh = "";
            string ngaySinh = dtpNgaySinh.Value.Month + "/" + dtpNgaySinh.Value.Day + "/" + dtpNgaySinh.Value.Year;

            if (cbNu.Checked )
            {
                gioiTinh = "Nữ";
            }
            if (cbNam.Checked  )
            {
                gioiTinh = "Nam";
            }
            string idCV = "";
            if (cbQuanLy.Checked )
            {
                idCV = "cv01";
            }
            else if (cbThuNgan.Checked  )
            {
                idCV = "cv02";
            }
            else if (cbSoatVe.Checked )
            {
                idCV = "cv03";
            }
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@NV_id", txtMaNV.Text.Trim());
            cmd.Parameters.AddWithValue("@TenNV", txtTenNV.Text.Trim());
            cmd.Parameters.AddWithValue("@GioiTinh", gioiTinh);
            cmd.Parameters.AddWithValue("@CCCD", txtCCCD.Text.Trim());
            cmd.Parameters.AddWithValue("@diaChi", txtDiaChi.Text.Trim());
            cmd.Parameters.AddWithValue("@birthday", ngaySinh);
            cmd.Parameters.AddWithValue("@SDT", txtSDT.Text.Trim());
            cmd.Parameters.AddWithValue("@idCV", idCV);
            cmd.Parameters.AddWithValue("@R_id", maRap);

             
            int kq = cmd.ExecuteNonQuery();
            if (kq > 0)
            {
                MessageBox.Show("Sủa Dữ Liệu Thành Công !");
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
            if (txtMaNV.Text.Trim() == "" || txtTenNV.Text.Trim() == "" || txtCCCD.Text.Trim() == "" || txtNoiLamViec.Text.Trim() == "")

            {
                MessageBox.Show("Vui lòng chọn Nhân Viên  cần Xóa  ");
                return;
            }
            DialogResult hoi = MessageBox.Show("Bạn có chắc chắn muốn xóa không ? ", "Hỏi ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (hoi == DialogResult.Yes)
            {
                MoKN();
                //Xóa rạp 
                string queryXoaNV = "Delete from  NV_TK  where  NV_id = '" + txtMaNV.Text.Trim() + "' ";
                SqlCommand cmd1 = new SqlCommand(queryXoaNV, con);
                
                string query = "Delete from   NhanVien   where  NV_id = '" + txtMaNV.Text.Trim() + "' ";
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

        private void cbNu_CheckedChanged(object sender, EventArgs e)
        {
             
            cbNam.Checked = false;
        }

        private void cbNam_CheckedChanged(object sender, EventArgs e)
        {
            cbNu.Checked = false;
        }

        private void cbQuanLy_CheckedChanged(object sender, EventArgs e)
        {
            cbThuNgan.Checked = false;
            cbSoatVe.Checked = false;
        }

        private void cbThuNgan_CheckedChanged(object sender, EventArgs e)
        {
            cbSoatVe.Checked = false;
            cbQuanLy.Checked = false;
        }

        private void cbSoatVe_CheckedChanged(object sender, EventArgs e)
        {
            cbThuNgan.Checked = false;
            cbQuanLy.Checked = false;
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

