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
    public partial class QLR_LC : Form
    {
        public QLR_LC()
        {
            InitializeComponent();
        }
        public static string LoaiTK;
        private void PhanQuyen(string LoaiTK)
        {
            if (LoaiTK == "QLR")
            {
                lblKH.Enabled = false;
                lblNS.Enabled = false;
                lblTK.Enabled = false;
                lblVe.Enabled = false;
                lblPhim.Enabled = false;
                blBCTK.Enabled = false;

            }
            else if (LoaiTK == "QLNS")
            {
                lblKH.Enabled = false;
                lblRap.Enabled = false;
                lblTK.Enabled = false;
                lblVe.Enabled = false;
                lblPhim.Enabled = false;
                blBCTK.Enabled = false;
            }
            else if (LoaiTK == "QLP")
            {
                lblKH.Enabled = false;
                lblRap.Enabled = false;
                lblTK.Enabled = false;
                lblVe.Enabled = false;
                lblNS.Enabled = false;
                blBCTK.Enabled = false;
            }
            else if (LoaiTK == "QLV")
            {
                lblKH.Enabled = false;
                lblRap.Enabled = false;
                lblTK.Enabled = false;
                lblPhim.Enabled = false;
                lblNS.Enabled = false;
                blBCTK.Enabled = false;
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
        public string maRap;
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
        SqlDataAdapter adapter = null;
        DataSet ds = null;
        private void HienDS()
        {
            MoKN();
            string query = @"
                      SELECT 
    LichChieu.idLC,  PhongChieu.PC_id,
    Rap.R_name,Phim.M_id, LichChieu.ngayChieu , 
    LichChieu.soVe

FROM    
   LichChieu
INNER JOIN Phim ON LichChieu.M_id =Phim.M_id
INNER JOIN Rap ON LichChieu.R_id = Rap.R_id  
Inner join  PhongChieu ON LichChieu.PC_id = PhongChieu.PC_id
             where  Rap.R_id='" + maRap + "'";
            adapter = new SqlDataAdapter(query, con);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(adapter);
            ds = new DataSet();
            adapter.Fill(ds, "HienThi");
            dgvLCR.DataSource = ds.Tables["HienThi"];

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void QLR_LC_Load(object sender, EventArgs e)
        {
            LayTenRap();
            HienDS();
            PhanQuyen(LoaiTK);
        }

        private void dgvNVR_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string timKiem = txtTimKiem.Text.Trim();
            TimKiem(timKiem);
            if (timKiem == "")
            {
                QLR_LC_Load(sender, e);
            }
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            string timKiem = txtTimKiem.Text.Trim();
            TimKiem(timKiem);
        }
        private void TimKiem(string timKiem)
        {

            string query = @"
                                         SELECT 
    LichChieu.idLC,  PhongChieu.PC_id,
    Rap.R_name,Phim.M_id, LichChieu.ngayChieu,
  
    LichChieu.soVe

FROM    
   LichChieu
INNER JOIN Phim ON LichChieu.M_id =Phim.M_id
INNER JOIN Rap ON LichChieu.R_id = Rap.R_id  
Inner join  PhongChieu ON LichChieu.PC_id = PhongChieu.PC_id
 
               where Rap.R_id='" + maRap + "'and ( idLC like  '%" + timKiem + "%' or  PC_name = '" + timKiem + "' or  M_name = '" + timKiem + "')";

            adapter = new SqlDataAdapter(query, con);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder();
            ds = new DataSet();
            adapter.Fill(ds, "TimKiem ");
            dgvLCR.DataSource = ds.Tables["TimKiem "];
        }

        private void dgvLCR_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string ngaySinh = dtpNgayChieu.Value.Month + "/" + dtpNgayChieu.Value.Day + "/" + dtpNgayChieu.Value.Year;
            if (e.RowIndex != dgvLCR.Rows.Count - 1 && e.RowIndex >= 0)
            {



                DataRow row = ds.Tables["HienThi"].Rows[e.RowIndex];
                txtMaLC.Text = row["idLC"].ToString().Trim();
                txtTenPC.Text = row["PC_id"].ToString().Trim();
                txtTenRap.Text = row["R_name"].ToString().Trim();
                txtTenPhim.Text = row["M_id"].ToString().Trim();
                dtpNgayChieu.Text = row["ngayChieu"].ToString().Trim();
                txtSoVe.Text = row["soVe"].ToString().Trim();

            }
        }
        private void XoaDLForm()
        {
            txtSoVe.Clear();
            txtMaLC.Clear();
            txtTenPC.Clear();
            txtTenRap.Clear();
            txtTenPhim.Clear();
            
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            string ngayChieu = dtpNgayChieu.Value.Month + "/" + dtpNgayChieu.Value.Day + "/" + dtpNgayChieu.Value.Year;
            if (txtMaLC.Text.Trim() == "" || txtTenPC.Text.Trim() == "" || txtTenRap.Text.Trim() == "" || txtTenPhim.Text.Trim() == "" || txtSoVe.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            string checkquery = "select count(*) from LichChieu where idLC = '" + txtMaLC.Text.Trim() + "'";
            using (SqlCommand cmd1 = new SqlCommand(checkquery, con))
            {
                int kq = (int)cmd1.ExecuteScalar();
                if (kq > 0)
                {
                    MessageBox.Show("Mã LC đã tồn tại, vui lòng nhập mã khác!");
                    return;
                }
            }

            string query = @"INSERT INTO LichChieu (idLC, PC_id,M_id, R_id, ngayChieu , soVe)
                   VALUES (@idLC, @PC_id,@M_id, @r_id, @ngayChieu , @soVe)";
            int soVe;
            int.TryParse(txtSoVe.Text.Trim(), out soVe);
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@idLC", txtMaLC.Text.Trim());
            cmd.Parameters.AddWithValue("@PC_id", txtTenPC.Text.Trim());
             cmd.Parameters.AddWithValue("@M_id", txtTenPhim.Text.Trim());
            cmd.Parameters.AddWithValue("@r_id", maRap);
            
            cmd.Parameters.AddWithValue("@ngayChieu", ngayChieu);
         
            cmd.Parameters.AddWithValue("@soVe",soVe);

            int kq1 = cmd.ExecuteNonQuery();

            if (kq1 > 0)
            {
                MessageBox.Show("Thêm Dữ Liệu Thành Công!");
                XoaDLForm();
                HienDS();
            }
            else
            {
                MessageBox.Show("Thêm Dữ Liệu Không Thành Công!");
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            string ngayChieu = dtpNgayChieu.Value.Month + "/" + dtpNgayChieu.Value.Day + "/" + dtpNgayChieu.Value.Year;
            if (txtMaLC.Text.Trim() == "" || txtTenPC.Text.Trim() == "" || txtTenRap.Text.Trim() == "" || txtTenPhim.Text.Trim() == "" || txtSoVe.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn dữ liệu để sửa!");
                return;
            }
 

            string query = @"UPDATE LichChieu
                       SET PC_id = @PC_id,
                           M_id = @M_id,
                           r_id = @r_id,
                           ngayChieu = @ngayChieu,
                           soVe = @soVe
                       WHERE idLC = @idLC";
            int soVe;
            int.TryParse(txtSoVe.Text.Trim(), out soVe);
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@idLC", txtMaLC.Text.Trim());
            cmd.Parameters.AddWithValue("@PC_id", txtTenPC.Text.Trim());
            cmd.Parameters.AddWithValue("@M_id", txtTenPhim.Text.Trim());
            cmd.Parameters.AddWithValue("@r_id", maRap);

            cmd.Parameters.AddWithValue("@ngayChieu", ngayChieu);

            cmd.Parameters.AddWithValue("@soVe", soVe);

            int kq1 = cmd.ExecuteNonQuery();

            if (kq1 > 0)
            {
                MessageBox.Show("Sửa Dữ Liệu Thành Công!");
                XoaDLForm();
                HienDS();
            }
            else
            {
                MessageBox.Show("Sửa  Dữ Liệu Không Thành Công!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaLC.Text.Trim() == ""  )

            {
                MessageBox.Show("Vui lòng chọn Lịch Chiếu  cần Xóa ");
                return;
            }
            DialogResult hoi = MessageBox.Show("Bạn có chắc chắn muốn xóa không ? ", "Hỏi ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (hoi == DialogResult.Yes)
            {
                MoKN();
             
                 

                string query = "Delete from   LichChieu   where  idLC = '" + txtMaLC.Text.Trim() + "' ";
                SqlCommand cmd = new SqlCommand(query, con);



                int kq = cmd.ExecuteNonQuery();
                if (kq > 0)
                {
                    MessageBox.Show("Xóa  Dữ Liệu Thành Công !");
                    QLR_LC_Load(sender, e);

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

        }

        private void lblRap_Click(object sender, EventArgs e)
        {
            QLRap  form1 = new QLRap();
            this.Hide();
            form1.ShowDialog();
            this.Show();
        }

        private void lblKH_Click(object sender, EventArgs e)
        {

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

        }

        private void blBCTK_Click(object sender, EventArgs e)
        {

        }
    }
    }
