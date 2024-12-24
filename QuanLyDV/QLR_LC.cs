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
    LichChieu.idLC,  PhongChieu.PC_name,
    Rap.R_name,Phim.M_name, LichChieu.ngayChieu,
    LichChieu.gioBD ,LichChieu.thoiLuong,
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
    LichChieu.idLC,  PhongChieu.PC_name,
    Rap.R_name,Phim.M_name, LichChieu.ngayChieu,
    LichChieu.gioBD ,LichChieu.thoiLuong,
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
    }
}
