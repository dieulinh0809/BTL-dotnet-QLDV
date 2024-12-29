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
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string id =  txtID.Text.Trim();
            string pass = txtPass.Text.Trim();
            if (id =="" || pass=="")
            {
                lblLoi.Text = "Vui lòng nhập đầy đủ thông tin ! ";
                lblLoi.Visible = true ;
            }
            else
            {
                Login(id,pass);
                
            }
        }

        //Chuoi Ket Noi 
        string str = @"Data Source=DESKTOP-RT4JUIV\SQLEXPRESS;Initial Catalog=CGV05;Integrated Security=True;Encrypt=False ";

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
        //Ham Dang NHap 
        private void Login(string id , string pass)
        {
            MoKN();
            string query = "SELECT pass FROM TaiKhoan WHERE idTK = @idTK";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@idTK", id);
            string storedPassword = cmd.ExecuteScalar() as string;
            if (storedPassword != null && pass.Trim() == storedPassword.Trim())
            {
                string q = @"select * from TaiKhoan where idTK ='" + id + "'";

                using (SqlCommand cmd1 = new SqlCommand(q, con))
                {
                    SqlDataReader sqlDataReader = cmd1.ExecuteReader();
                    if (sqlDataReader.Read())
                    {
                       string loaiTK  = sqlDataReader["LoaiTK"].ToString();
                        QLRap form1 = new QLRap();
                        this.Hide();
                        form1.ShowDialog();
                        this.Show();
                        QuanLyCT.LoaiTK=loaiTK;
                        QuanLyNS.LoaiTK=loaiTK;
                        QLRap.LoaiTK = loaiTK;
                        QLGhe.LoaiTK = loaiTK;
                        QLR_LC.LoaiTK = loaiTK;
                        QLR_NV.LoaiTK = loaiTK;
                        QLR_PC.LoaiTK = loaiTK;
                        fQuanLyKhachHang.LoaiTK= loaiTK;
                        fQuanLyPhim.LoaiTK = loaiTK;
                        fQuanLyTaiKhoan.LoaiTK = loaiTK;
                        fTrangChu.LoaiTK = loaiTK;

                    }

                }

               
            }
            else
            {
                lblLoi.Visible = true;
                if (storedPassword == null)
                {
                   lblLoi.Text = "User ID not found.";
                }
                else
                {
                    lblLoi.Text = "Invalid password.";
                }
            }
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

            lblLoi.Visible = false;
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            lblLoi.Visible = false;
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
