using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fTrangchu
{
    public partial class UCphim2d : UserControl
    {
        public UCphim2d()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UCphim2d_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show
               (
                "Đạo diễn: Kenji Kamiyama \n" +
                "Diễn viên: Brian Cox, Gaia Wise, Luke Pasqualino, Miranda Otto,…\n" +
                "Thể loại: Hành Động, Hoạt Hình, Phiêu Lưu, Thần thoại\n" +
                "Khởi chiếu: 13/12/2024\n" +
                "Thời lượng: 135 phút\n" +
                "Ngôn ngữ: Tiêng Anh - Phụ đề Tiếng Việt",
                "Cuộc chiến của ROHIRRIM"

               );
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show
               (
                "Đạo diễn: Yōko Kuno, Nobuhiro Yamashita\n" +
                "Diễn viên: \n" +
                "Thể loại: Hoạt Hình\n" +
                "Khởi chiếu: 06/12/2024\n" +
                "Thời lượng: 94 phút\n" +
                "Ngôn ngữ: Tiếng Nhật - Phụ đề Tiếng Việt",
                "Mèo ma bê tha"

               );
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show
               (
                "Đạo diễn:Phạm Ngọc Lân \n" +
                "Diễn viên: NSND Minh Châu, Hoàng Hà, Hà Phương, Xuân An\n" +
                "Thể loại: Gia đình, Tâm Lý, Tình cảm\n" +
                "Khởi chiếu: 15/11/2024\n" +
                "Thời lượng: 91 phút 30 giây\n" +
                "Ngôn ngữ: Tiếng Việt - Phụ đề Tiếng Anh",
                "Cu li không bao giờ khóc"

               );
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show
               (
                "Đạo diễn: Barry Jenkins\n" +
                "Diễn viên: \n" +
                "Thể loại: Gia đình, Phiêu Lưu\n" +
                "Khởi chiếu: 18/12/2024\n" +
                "Thời lượng: 118 phút\n" +
                "Ngôn ngữ: Tiếng Anh với phụ đề tiếng Việt và lồng tiếng Việt",
                "Mufasa: vua sư tử"

               );
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show
               (
                "Đạo diễn: Jon M. Chu\n" +
                "Diễn viên: Cynthia Erivo, Ariana Grande, Jonathan Bailey\n" +
                "Thể loại: Nhạc kịch, Thần thoại, Tình cảm\n" +
                "Khởi chiếu: 22/11/2024\n" +
                "Thời lượng: 161 phút\n" +
                "Ngôn ngữ: Tiếng Anh với phụ đề tiếng Việt",
                "Wicked"

               );
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show
               (
                "Đạo diễn: David G. Derrick Jr.\n" +
                "Diễn viên: Auli‘i Cravalho, Dwayne Johnson, Rachel House, Temuera Morrison, Nicole Scherzinger, Hualālai Chung, David Fane, Rose Matafeo, Awhimai Fraser, Gerald Ramsey, Khaleesi Lambert-Tsuda\n" +
                "Thể loại: Hành Động, Hoạt Hình, Phiêu Lưu, Thần thoại\n" +
                "Khởi chiếu: 04/12/2024\n" +
                "Thời lượng: 99 phút\n" +
                "Ngôn ngữ: Tiếng Anh - Phụ đề Tiếng Việt; Lồng tiếng",
                "Hành trình của Moana 2"

               );
        }

        private void button7_Click(object sender, EventArgs e)
        {
           
            this.Hide();
            fQuanLyKhachHang fQLKH = new fQuanLyKhachHang();
            fQLKH.ShowDialog();
            fQLKH = null;
            this.Show();
        }
    }
}
