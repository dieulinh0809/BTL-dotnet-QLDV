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

        private void QLR_PC_Load(object sender, EventArgs e)
        {
            LayTenRap();
            HienDS();
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.HeaderText = "Chức Năng ";
            buttonColumn.Text = "Quản Lý Ghế ";
            buttonColumn.Name = "btnColumn";
            buttonColumn.UseColumnTextForButtonValue = true;
            dgvPC.Columns.Add(buttonColumn);
        }
    }
}
