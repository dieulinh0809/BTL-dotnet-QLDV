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
    public partial class QLGhe : Form
    {
        public static string LoaiTK;
        public QLGhe()
        {
            InitializeComponent();
        }
        public string maPC;

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

        private void QLGhe_Load(object sender, EventArgs e)
        {
            LayTenPhong();
            HienDS();
            PhanQuyen(LoaiTK);
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
            string query = @"select * from PhongChieu where PC_id ='" + maPC + "'";
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                SqlDataReader sqlDataReader = cmd.ExecuteReader();
                if (sqlDataReader.Read())
                {
                    lblTenRap.Text = sqlDataReader["PC_name"].ToString();
                }

            }
            DongKN();
        }
        SqlDataAdapter adapter = null;
        DataSet ds = null;
        private void HienDS()
        {
            MoKN();
            string query = "select * from Ghe  where PC_id ='" + maPC + "'";
            adapter = new SqlDataAdapter(query, con);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(adapter);
            ds = new DataSet();
            adapter.Fill(ds, "Ghe");
            dgvLCR.DataSource = ds.Tables["Ghe"];

        }
        private void LayTenPhong()
        {
            MoKN();
            string query = @"select * from PhongChieu   where PC_id ='" + maPC + "'";

            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                SqlDataReader sqlDataReader = cmd.ExecuteReader();
                if (sqlDataReader.Read())
                {
                    lblTenRap.Text = sqlDataReader["PC_name"].ToString();
                }

            }
            DongKN();
        }
        private void btnTK_Click(object sender, EventArgs e)
        {
            string timKiem = txtTimKiem.Text.Trim();
            TimKiem(timKiem);
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string timKiem = txtTimKiem.Text.Trim();
            TimKiem(timKiem);
            if (timKiem == "")
            {
                QLGhe_Load(sender, e);
            }
        }
        private void TimKiem(string timKiem)
        {

            string query = "select * from Ghe  where PC_id ='" + maPC + "' and ( PC_id like  '%" + timKiem + "%' or idG = '" + timKiem + "')";


            adapter = new SqlDataAdapter(query, con);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder();
            ds = new DataSet();
            adapter.Fill(ds, "TimKiem ");
            dgvLCR.DataSource = ds.Tables["TimKiem "];
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không ? ",
               "Hộp Thoại ", MessageBoxButtons.YesNo, MessageBoxIcon.Question
               );
            if (result == DialogResult.Yes)
            {
                Close();


            }
        }

        private void dgvLCR_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vt = e.RowIndex;

            if (vt == -1 ) return;

          
                DataRow row = ds.Tables["Ghe"].Rows[e.RowIndex];
                txtMaG.Text = row["idG"].ToString().Trim();
                txtMaPhong.Text = row["PC_id"].ToString().Trim();
                txtGhiChu.Text = row["status"].ToString().Trim();

            
        }
        private void XoaDLForm()
        {
            txtMaG.Clear(); txtMaPhong.Clear() ; txtGhiChu.Clear() ;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (vt == -1) return;
            if (txtMaG.Text.Trim() == "" || txtMaPhong.Text.Trim() == ""  )

            {
                MessageBox.Show("Vui lòng chọn nhập đầy đủ thông tin !");
                return;
            }

            string checkQuery = "SELECT COUNT(*) FROM Ghe WHERE idG = '" + txtMaG.Text.Trim() + "'";

            using (SqlCommand check = new SqlCommand(checkQuery, con))
            {

                int count = (int)check.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("Mã Ghế đã tồn tại. Vui lòng nhập mã khác.");
                    return;
                }
            }
            DataRow row = ds.Tables["Ghe"].NewRow();
            row["idG"]=txtMaG.Text.Trim();
            row["PC_id"] = maPC;
            row["status"]=txtGhiChu.Text.Trim();
            ds.Tables["Ghe"].Rows.Add(row);
            int kq = adapter.Update(ds.Tables["Ghe"]);
           
            if (kq > 0)
            {
                MessageBox.Show("Thêm  Dữ Liệu Thành Công !");
                HienDS();
                XoaDLForm();
                return;
            }
            else
            {

                MessageBox.Show("Thêm  Dữ Liệu Không  Thành Công !");
                return;
            }
            DongKN();
        }

        int vt;

        private void btnSua_Click(object sender, EventArgs e)
        {
            
            
           
            if (vt == -1 ) return;
            if (txtMaG.Text.Trim() == "" || txtMaPhong.Text.Trim() == "")

            {
                MessageBox.Show("Vui lòng chọn Ghế cần sửa ! ");
                return;
            }
            //MessageBox.Show(vt.ToString());
            DataRow row = ds.Tables["Ghe"].Rows[vt];
            row.BeginEdit();
            row["idG"] = txtMaG.Text.Trim();
            row["PC_id"] = maPC;
            row["status"] = txtGhiChu.Text.Trim();
            row.EndEdit();
            int kq = adapter.Update(ds.Tables["Ghe"]);

            if (kq > 0)
            {
                MessageBox.Show("Sửa Dữ Liệu Thành Công !");
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
            if (txtMaG.Text.Trim() == "" || txtMaPhong.Text.Trim() == "")

            {
                MessageBox.Show("Vui lòng chọn Ghế cần xóa !");
                return;
            }
            if (vt == -1) return;
            DialogResult result = MessageBox.Show(
                "Bạn có thực sự muốn xóa ghế này hay không?",
                "Hộp thoại",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
                );
            if (result == DialogResult.Yes)
            {
                DataRow row = ds.Tables["Ghe"].Rows[vt];

                // xoa dong da chon
                row.Delete();

                // update vao csdl
                int kq = adapter.Update(ds.Tables["Ghe"]);

                // kiem tra ket qua
                if (kq > 0)
                {
                    MessageBox.Show("Xóa thành công!");
                    HienDS();

                    XoaDLForm();

                    
                }
                else
                {
                    MessageBox.Show("Xóa thất bại!");
                    return;
                }
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}