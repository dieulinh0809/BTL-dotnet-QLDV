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
        public QLR_NV()
        {
            InitializeComponent();
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
                Close();
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
 
             where  Rap.R_id='" + maRap+"'";
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

        }
    }
     
    
}

