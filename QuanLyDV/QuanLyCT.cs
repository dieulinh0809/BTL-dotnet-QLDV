using QuanLyDV;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLR
{
    public partial class QuanLyCT : Form
    {
        public static string LoaiTK;
        public QuanLyCT( )
        {
            InitializeComponent();
        }
        private void PhanQuyen(string LoaiTK)
        {
            if (LoaiTK=="QLR")
            {
                lblKH.Enabled = false;
                lblNS.Enabled = false;
                lblTK.Enabled = false;
                lblVe.Enabled = false;
                lblPhim.Enabled = false;
                blBCTK.Enabled = false;
                
            }else if (LoaiTK == "QLNS")
            {
                lblKH.Enabled = false;
                lblRap.Enabled = false;
                lblTK.Enabled = false;
                lblVe.Enabled = false;
                lblPhim.Enabled = false;
                blBCTK.Enabled = false;
            }else if (LoaiTK == "QLP")
            {
                lblKH.Enabled = false;
                lblRap.Enabled = false;
                lblTK.Enabled = false;
                lblVe.Enabled = false;
                lblNS.Enabled = false;
                blBCTK.Enabled = false;
            }else if (LoaiTK== "QLV")
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
        private void QuanLy_Load(object sender, EventArgs e)
        {
            LayTenRap();
            PhanQuyen(LoaiTK);
            
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
        }
            private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không ? ",
                "Hộp Thoại ", MessageBoxButtons.YesNo, MessageBoxIcon.Question
                );
            if (result == DialogResult.Yes)
            {
                Application.Exit();

                Close();
                 

            }
        }

        private void btnNV_Click(object sender, EventArgs e)
        {
            QLR_NV form1 = new QLR_NV();
            form1.maRap = maRap;
            this.Hide();
            form1.ShowDialog();
            this.Show();
        }

        private void btnPC_Click(object sender, EventArgs e)
        {
            QLR_PC form1 = new QLR_PC();
            form1.maRap = maRap;
            this.Hide();
            form1.ShowDialog();
            this.Show();
        }

        private void btnLC_Click(object sender, EventArgs e)
        {
            QLR_LC form1 = new QLR_LC();
            form1.maRap = maRap;
            this.Hide();
            form1.ShowDialog();
            this.Show();
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
