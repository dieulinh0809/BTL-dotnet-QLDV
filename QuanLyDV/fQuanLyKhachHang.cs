using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Xml.Serialization;

namespace fTrangchu
{
    public partial class fQuanLyKhachHang : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=DESKTOP-RT4JUIV\SQLEXPRESS;Initial Catalog=CGV05;Integrated Security=True;Encrypt=False ";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from KhachHang";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        public fQuanLyKhachHang()
        {
            InitializeComponent();
        }

        private void thôngTinCáNhânToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void fQuanLyKhachHang_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdKh.ReadOnly = true;
            int i;
            i = dataGridView1.CurrentRow.Index;
            txtIdKh.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txtTenKh.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            cbGioiTinh.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            txtCccd.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            txtDiaChi.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            dtSinhNhat.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
            txtSdt.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "insert into KhachHang values('"+txtIdKh.Text+"','"+txtTenKh.Text+"','"+cbGioiTinh.Text+"','"+txtCccd.Text+"','"+txtDiaChi.Text+"','"+dtSinhNhat.Text+"','"+txtSdt.Text+"' ) ";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "delete from KhachHang where KH_id= '"+txtIdKh.Text+"' ";
            command.ExecuteNonQuery();
            loaddata() ;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "update KhachHang set TenKH = '"+txtTenKh.Text+"', GioiTinh = '"+cbGioiTinh.Text+"', CCCD = '"+txtCccd.Text+"', diaChi = '"+txtDiaChi.Text+"', birthday = '"+dtSinhNhat.Text+"', SDT = '"+txtSdt.Text+"' where KH_id = '"+txtIdKh.Text+"' ";
            command.ExecuteNonQuery();
            loaddata() ;
        }


        private void btnKhoitao_Click_1(object sender, EventArgs e)
        {
            txtIdKh.Text = "";
            txtTenKh.Text = "";
            cbGioiTinh.Text = "";
            txtCccd.Text = "";
            txtDiaChi.Text = "";
            dtSinhNhat.Text = "2/2/2222";
            txtSdt.Text = "";
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void phimToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnDangxuat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Chú ý!!!", "Bạn có thực sự muốn thoát?", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void nhânSựToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            fQuanLyNhanVien fQLNV = new fQuanLyNhanVien();
            fQLNV.ShowDialog();
            fQLNV = null;
            this.Show();
        }
    }
}
