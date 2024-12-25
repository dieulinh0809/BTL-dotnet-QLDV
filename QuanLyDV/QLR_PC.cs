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
    public partial class QLR_PC : Form
    {
        public QLR_PC()
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
        //Ham Hien Thi Danh Sach 
        SqlDataAdapter adapter = null;
        DataSet ds = null;
        private void HienDS()
        {
            MoKN();
            string query = @"
                    SELECT 
                 PhongChieu.PC_id,
                 PhongChieu.PC_name,
                Rap.R_name
            FROM    
                PhongChieu
           INNER JOIN Rap ON PhongChieu.R_id = Rap.R_id 
 
             where  Rap.R_id='" + maRap + "'";
            adapter = new SqlDataAdapter(query, con);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(adapter);
            ds = new DataSet();
            adapter.Fill(ds, "HienThi");
            dgvPC.DataSource = ds.Tables["HienThi"];

        }
        DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
        private void QLR_PC_Load(object sender, EventArgs e)
        {
            LayTenRap();
            HienDS();
            if (buttonColumn.Name != "btnColumn")
            {

                buttonColumn.HeaderText = "Chức Năng ";
                buttonColumn.Text = "Quản Lý Ghế ";
                buttonColumn.Name = "btnColumn";
                buttonColumn.UseColumnTextForButtonValue = true;
                dgvPC.Columns.Add(buttonColumn);
            }

        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string timKiem = txtTimKiem.Text.Trim();
            TimKiem(timKiem);
            if (timKiem == "")
            {
                QLR_PC_Load(sender, e);
            }
        }
        //Cac Ham Tim Kiem 
        private void TimKiem(string timKiem)
        {
            MoKN();
            string query = @"
                    SELECT 
                 PhongChieu.PC_id,
                 PhongChieu.PC_name,
                Rap.R_name
            FROM    
                LichChieu
           INNER JOIN Rap ON PhongChieu.R_id = Rap.R_id 
 
               where Rap.R_id='" + maRap + "'and ( PC_id like  '%" + timKiem + "%' or PC_name = '" + timKiem + "')";

            adapter = new SqlDataAdapter(query, con);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder();
            ds = new DataSet();
            adapter.Fill(ds, "TimKiem ");
            dgvPC.DataSource = ds.Tables["TimKiem "];
        }
        private void btnTK_Click(object sender, EventArgs e)
        {
            string timKiem = txtTimKiem.Text.Trim();
            TimKiem(timKiem);
        }

        private void dgvPC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != dgvPC.Rows.Count - 1 && e.RowIndex >= 0)
            {
                if (e.ColumnIndex != dgvPC.Columns["btnColumn"].Index)
                {


                    DataRow row = ds.Tables["HienThi"].Rows[e.RowIndex];
                    txtMaPC.Text = row["PC_id"].ToString().Trim();
                    txtTenPC.Text = row["PC_name"].ToString().Trim();
                    txtTenRap.Text = row["R_name"].ToString().Trim();
                    //txtMaRap.ReadOnly = true;

                }
                else
                {

                    string maPC = dgvPC.Rows[e.RowIndex].Cells[0].Value.ToString();
                    QLGhe form1 = new QLGhe();
                    form1.maPC = maPC;
                    this.Hide();
                    form1.ShowDialog();
                    this.Show();
                }

            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaPC.Text.Trim() == "" || txtTenPC.Text.Trim() == "" || txtTenRap.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin !");
                return;
            }


            string checkquery = "select count  (*) from PhongChieu where PC_id = '" + txtMaPC.Text.Trim() + "'";
            using (SqlCommand cmd1 = new SqlCommand(checkquery, con))
            {
                int kq = (int)cmd1.ExecuteScalar();
                if (kq > 0)
                {
                    MessageBox.Show("Mã PC đã tồn tại , vui lòng nhập mã khác ! ");
                    return;
                }
            }
            string query = @"insert into PhongChieu (PC_id, PC_name,R_id) values (@PC_id, @PC_name,@R_id)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@PC_id", txtMaPC.Text.Trim());
            cmd.Parameters.AddWithValue("@PC_name", txtTenPC.Text.Trim());
            cmd.Parameters.AddWithValue("@R_id", maRap);

            int kq1 = cmd.ExecuteNonQuery();
            if (kq1 > 0)
            {
                MessageBox.Show("Thêm Dữ Liệu Thành Công ! ");
                XoaDLForm();
                QLR_PC_Load(sender, e);

            }
            else
            {
                MessageBox.Show("Thêm Dữ Liệu Không Thành Công ! ");

            }

        }
        private void XoaDLForm()
        {
            txtMaPC.Clear();
            txtTenPC.Clear();
            txtTenRap.Clear();

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaPC.Text.Trim() == "" || txtTenPC.Text.Trim() == "" || txtTenRap.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin !");
                return;
            }
            string query = @"Update  PhongChieu set  PC_name = @PC_name,R_id = @R_id where  PC_id = @PC_id";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@PC_id", txtMaPC.Text.Trim());
            cmd.Parameters.AddWithValue("@PC_name", txtTenPC.Text.Trim());
            cmd.Parameters.AddWithValue("@R_id", maRap);




            int kq1 = cmd.ExecuteNonQuery();
            if (kq1 < 0)
            {
                MessageBox.Show("Sửa Dữ Liệu Thành Công ! ");
                XoaDLForm();
                QLR_PC_Load(sender, e);

            }
            else
            {
                MessageBox.Show("Sửa Dữ Liệu Không Thành Công ! ");
                XoaDLForm();
                QLR_PC_Load(sender, e);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaPC.Text.Trim() == "" || txtTenPC.Text.Trim() == "" || txtTenRap.Text.Trim() == "")

            {
                MessageBox.Show("Vui lòng chọn Phòng Chiếu   cần Xóa  ");
                return;
            }
            DialogResult hoi = MessageBox.Show("Bạn có chắc chắn muốn xóa không ? ", "Hỏi ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (hoi == DialogResult.Yes)
            {
                MoKN();
                //Xóa rạp 
                string queryXoaNV = "Delete from  Ghe  where  PC_id = '" + txtMaPC.Text.Trim() + "' ";
                SqlCommand cmd1 = new SqlCommand(queryXoaNV, con);

                string query = "Delete from   PhongChieu   where  PC_id = '" + txtMaPC.Text.Trim() + "' ";
                SqlCommand cmd = new SqlCommand(query, con);



                int kq = cmd.ExecuteNonQuery();
                if (kq > 0)
                {
                    MessageBox.Show("Xóa  Dữ Liệu Thành Công !");
                    QLR_PC_Load(sender, e);

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
            QLRap form1 = new QLRap();
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

        }

        private void lblPhim_Click(object sender, EventArgs e)
        {

        }

        private void blBCTK_Click(object sender, EventArgs e)
        {

        }
    }
}