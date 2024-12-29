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
    public partial class fQuanLyPhim : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=DESKTOP-RT4JUIV\SQLEXPRESS;Initial Catalog=CGV05;Integrated Security=True;Encrypt=False ";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from Phim";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dtgDanhSachPhim.DataSource = table;
        }

        public fQuanLyPhim()
        {
            InitializeComponent();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fQuanLyPhim_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtM_id.ReadOnly = true;
            int p;
            p = dtgDanhSachPhim.CurrentRow.Index;
            txtM_id.Text = dtgDanhSachPhim.Rows[p].Cells[0].Value.ToString();
            txtM_name.Text = dtgDanhSachPhim.Rows[p].Cells[0].Value.ToString();
            txtM_trailer.Text = dtgDanhSachPhim.Rows[p].Cells[0].Value.ToString();
            txtM_length.Text = dtgDanhSachPhim.Rows[p].Cells[0].Value.ToString();
            txtidLP.Text = dtgDanhSachPhim.Rows[p].Cells[0].Value.ToString();
            txttrangthai.Text = dtgDanhSachPhim.Rows[p].Cells[0].Value.ToString();
            txtDaoDien.Text = dtgDanhSachPhim.Rows[p].Cells[0].Value.ToString();
            txtDienVien.Text = dtgDanhSachPhim.Rows[p].Cells[0].Value.ToString();
            dtKhoiChieu.Text = dtgDanhSachPhim.Rows[p].Cells[0].Value.ToString();
            txtMoTa.Text = dtgDanhSachPhim.Rows[p].Cells[0].Value.ToString();
            txtNgonNgu.Text = dtgDanhSachPhim.Rows[p].Cells[0].Value.ToString();

        }

        private void btnKhoitao_Click(object sender, EventArgs e)
        {
            txtM_id.Text = "";
            txtM_name.Text = "";
            txtM_trailer.Text = "";
            txtM_length.Text = "";
            txtidLP.Text = "";
            txttrangthai.Text = "";
            txtDaoDien.Text = "";
            txtDienVien.Text = "";
            dtKhoiChieu.Text = "";
            txtMoTa.Text = "";
            txtNgonNgu.Text = "";


        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "insert into Phim values('" + txtM_id.Text + "','" + txtM_name.Text + "','" + txtM_trailer.Text + "','" + txtM_length.Text + "','" + txtidLP.Text + "','" + txttrangthai.Text + "','" + txtDaoDien.Text + "','" + txtDienVien.Text + "','" + dtKhoiChieu.Text + "','"+txtMoTa+"','"+txtNgonNgu+"') ";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "update Phim set M_name = '" + txtM_name.Text + "', M_trailer = '" + txtM_trailer.Text + "', M_length = '" + txtM_length.Text + "', idLp = '" + txtidLP.Text + "', trangthai = '" + txttrangthai.Text + "',DaoDien = '" + txtDaoDien.Text + "', DienVien = '" + txtDienVien.Text + "', KhoiChieu '"+dtKhoiChieu.Text+"', MoTa = '"+txtMoTa.Text+"', NgonNgu = '"+txtNgonNgu.Text+"' where NV_id = '" + txtM_id.Text + "' ";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "delete from Phim where KH_id= '" + txtM_id.Text + "' ";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void nhânSựToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void khuyếnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void phimToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void báoCáoThốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void blTC_Click(object sender, EventArgs e)
        {

        }

        private void lblRap_Click(object sender, EventArgs e)
        {

        }

        private void lblKH_Click(object sender, EventArgs e)
        {

        }

        private void lblNS_Click(object sender, EventArgs e)
        {

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
    }
}
