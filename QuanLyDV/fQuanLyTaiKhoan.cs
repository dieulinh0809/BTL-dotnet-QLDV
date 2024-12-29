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

namespace fTrangchu
{
    public partial class fQuanLyTaiKhoan : Form
    {
        SqlConnection connection;
        SqlCommand command;
        String str = @"Data Source=DESKTOP-RT4JUIV\SQLEXPRESS;Initial Catalog=CGV05;Integrated Security=True;Encrypt=False "; SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from TaiKhoan";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        public fQuanLyTaiKhoan()
        {
            InitializeComponent();
        }

        private void txtIdTK_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdTK.ReadOnly = true;
            int x;
            x = dataGridView1.CurrentRow.Index;
            txtIdTK.Text = dataGridView1.Rows[x].Cells[0].Value.ToString();
            txtLoaiTK.Text = dataGridView1.Rows[x].Cells[1].Value.ToString();
            txttenTK.Text = dataGridView1.Rows[x].Cells[2].Value.ToString();
            txtpass.Text = dataGridView1.Rows[x].Cells[3].Value.ToString();
            txtpoint.Text = dataGridView1.Rows[x].Cells[4].Value.ToString();
            txttrangThai.Text = dataGridView1.Rows[x].Cells[5].Value.ToString();
        }

        private void fQuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "insert into TaiKhoan values('" + txtIdTK.Text + "','" + txtLoaiTK.Text + "','" + txttenTK.Text + "','" + txtpass.Text + "','" + txtpoint.Text + "','" + txttrangThai.Text + "') ";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "update TaiKhoan set LoaiTK = '" + txtLoaiTK.Text + "', tenTK = '" + txttenTK.Text + "', pass = '" + txtpass.Text + "', point = '" + txtpoint.Text + "', trangThai = '" + txttrangThai.Text + "' where NV_id = '" + txtIdTK.Text + "' ";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "delete from TaiKhoan where KH_id= '" + txtIdTK.Text + "' ";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void btnKhoitao_Click(object sender, EventArgs e)
        {
            txtIdTK.Text = "";
            txtLoaiTK.Text = "";
            txttenTK.Text = "";
            txtpass.Text = "";
            txtpoint.Text = "";
            txttrangThai.Text = "";

        }

        private void lblKH_Click(object sender, EventArgs e)
        {

        }

        private void lblVe_Click(object sender, EventArgs e)
        {

        }

        private void lblTK_Click(object sender, EventArgs e)
        {

        }

        private void lblNS_Click(object sender, EventArgs e)
        {

        }

        private void lblPhim_Click(object sender, EventArgs e)
        {

        }

        private void lblRap_Click(object sender, EventArgs e)
        {

        }

        private void blTC_Click(object sender, EventArgs e)
        {

        }
    }
}
