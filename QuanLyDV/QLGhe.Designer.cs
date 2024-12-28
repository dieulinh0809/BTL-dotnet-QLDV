namespace QuanLyDV
{
    partial class QLGhe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QLGhe));
            this.dgvLCR = new System.Windows.Forms.DataGridView();
            this.PC_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTK = new System.Windows.Forms.Button();
            this.txtMaG = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtMaPhong = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTenRap = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPhim = new System.Windows.Forms.Label();
            this.blBCTK = new System.Windows.Forms.Label();
            this.lblVe = new System.Windows.Forms.Label();
            this.lblTK = new System.Windows.Forms.Label();
            this.lblNS = new System.Windows.Forms.Label();
            this.lblKH = new System.Windows.Forms.Label();
            this.lblRap = new System.Windows.Forms.Label();
            this.blTC = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLCR)).BeginInit();
            this.panel6.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvLCR
            // 
            this.dgvLCR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLCR.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PC_id,
            this.idG,
            this.status});
            this.dgvLCR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLCR.Location = new System.Drawing.Point(4, 19);
            this.dgvLCR.Margin = new System.Windows.Forms.Padding(4);
            this.dgvLCR.Name = "dgvLCR";
            this.dgvLCR.RowHeadersWidth = 51;
            this.dgvLCR.Size = new System.Drawing.Size(1215, 574);
            this.dgvLCR.TabIndex = 0;
            this.dgvLCR.UseWaitCursor = true;
            this.dgvLCR.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLCR_CellClick);
            // 
            // PC_id
            // 
            this.PC_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PC_id.DataPropertyName = "PC_id";
            this.PC_id.HeaderText = "Mã Phòng Chiếu ";
            this.PC_id.MinimumWidth = 6;
            this.PC_id.Name = "PC_id";
            // 
            // idG
            // 
            this.idG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idG.DataPropertyName = "idG";
            this.idG.HeaderText = "Mã Ghế";
            this.idG.MinimumWidth = 6;
            this.idG.Name = "idG";
            // 
            // status
            // 
            this.status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.status.DataPropertyName = "status";
            this.status.HeaderText = "Ghi Chú ";
            this.status.MinimumWidth = 6;
            this.status.Name = "status";
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(7, 542);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(113, 44);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm ";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.UseWaitCursor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(264, 542);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(113, 44);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.UseWaitCursor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(135, 542);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(113, 44);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa ";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.UseWaitCursor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGhiChu.Location = new System.Drawing.Point(135, 337);
            this.txtGhiChu.Margin = new System.Windows.Forms.Padding(4);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(203, 26);
            this.txtGhiChu.TabIndex = 9;
            this.txtGhiChu.UseWaitCursor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(31, 341);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(80, 20);
            this.label16.TabIndex = 8;
            this.label16.Text = "Ghi Chú :";
            this.label16.UseWaitCursor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(20, 263);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(99, 20);
            this.label15.TabIndex = 6;
            this.label15.Text = "Mã Phòng  :";
            this.label15.UseWaitCursor = true;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(299, 54);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(209, 26);
            this.txtTimKiem.TabIndex = 6;
            this.txtTimKiem.UseWaitCursor = true;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // btnTK
            // 
            this.btnTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTK.Image = ((System.Drawing.Image)(resources.GetObject("btnTK.Image")));
            this.btnTK.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnTK.Location = new System.Drawing.Point(563, 43);
            this.btnTK.Margin = new System.Windows.Forms.Padding(4);
            this.btnTK.Name = "btnTK";
            this.btnTK.Size = new System.Drawing.Size(59, 58);
            this.btnTK.TabIndex = 7;
            this.btnTK.UseVisualStyleBackColor = true;
            this.btnTK.UseWaitCursor = true;
            this.btnTK.Click += new System.EventHandler(this.btnTK_Click);
            // 
            // txtMaG
            // 
            this.txtMaG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaG.Location = new System.Drawing.Point(135, 182);
            this.txtMaG.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaG.Name = "txtMaG";
            this.txtMaG.Size = new System.Drawing.Size(203, 26);
            this.txtMaG.TabIndex = 5;
            this.txtMaG.UseWaitCursor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(144, 62);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 20);
            this.label13.TabIndex = 5;
            this.label13.Text = "Tìm Kiếm  ";
            this.label13.UseWaitCursor = true;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.groupBox3);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(1246, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(5);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(389, 660);
            this.panel6.TabIndex = 1;
            this.panel6.UseWaitCursor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnXoa);
            this.groupBox3.Controls.Add(this.btnThem);
            this.groupBox3.Controls.Add(this.btnSua);
            this.groupBox3.Controls.Add(this.txtGhiChu);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.txtMaPhong);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.txtMaG);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(389, 660);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chi Tiết ";
            this.groupBox3.UseWaitCursor = true;
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPhong.Location = new System.Drawing.Point(135, 260);
            this.txtMaPhong.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.Size = new System.Drawing.Size(203, 26);
            this.txtMaPhong.TabIndex = 7;
            this.txtMaPhong.UseWaitCursor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(36, 188);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(93, 20);
            this.label14.TabIndex = 4;
            this.label14.Text = "Mã Ghế   : ";
            this.label14.UseWaitCursor = true;
            // 
            // panel4
            // 
            this.panel4.AutoSize = true;
            this.panel4.Controls.Add(this.groupBox2);
            this.panel4.Controls.Add(this.groupBox1);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 144);
            this.panel4.Margin = new System.Windows.Forms.Padding(5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1635, 660);
            this.panel4.TabIndex = 19;
            this.panel4.UseWaitCursor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvLCR);
            this.groupBox2.Location = new System.Drawing.Point(0, 132);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1223, 597);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách";
            this.groupBox2.UseWaitCursor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTimKiem);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.btnTK);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1224, 123);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm Kiếm ";
            this.groupBox1.UseWaitCursor = true;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(4, 106);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1184, 123);
            this.panel5.TabIndex = 2;
            this.panel5.UseWaitCursor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label11);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 804);
            this.panel3.Margin = new System.Windows.Forms.Padding(5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1635, 59);
            this.panel3.TabIndex = 18;
            this.panel3.UseWaitCursor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(27, 20);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(288, 16);
            this.label11.TabIndex = 0;
            this.label11.Text = "Công Ty TNHH 3 thành viên | Phiên Bản 01LXH ";
            this.label11.UseWaitCursor = true;
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Image = ((System.Drawing.Image)(resources.GetObject("btnDangXuat.Image")));
            this.btnDangXuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangXuat.Location = new System.Drawing.Point(1387, 2);
            this.btnDangXuat.Margin = new System.Windows.Forms.Padding(4);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(148, 44);
            this.btnDangXuat.TabIndex = 10;
            this.btnDangXuat.Text = "Đăng Xuất ";
            this.btnDangXuat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDangXuat.UseVisualStyleBackColor = true;
            this.btnDangXuat.UseWaitCursor = true;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.lblTenRap);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 47);
            this.panel2.Margin = new System.Windows.Forms.Padding(5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1635, 97);
            this.panel2.TabIndex = 17;
            this.panel2.UseWaitCursor = true;
            // 
            // lblTenRap
            // 
            this.lblTenRap.AutoSize = true;
            this.lblTenRap.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenRap.Location = new System.Drawing.Point(808, 32);
            this.lblTenRap.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTenRap.Name = "lblTenRap";
            this.lblTenRap.Size = new System.Drawing.Size(185, 39);
            this.lblTenRap.TabIndex = 1;
            this.lblTenRap.Text = "Tên   Rạp ";
            this.lblTenRap.UseWaitCursor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(516, 32);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(261, 39);
            this.label10.TabIndex = 0;
            this.label10.Text = "Quản Lý Ghế - ";
            this.label10.UseWaitCursor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1193, 17);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 16);
            this.label9.TabIndex = 9;
            this.label9.Text = "Xin Chào Admin ";
            this.label9.UseWaitCursor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblPhim);
            this.panel1.Controls.Add(this.blBCTK);
            this.panel1.Controls.Add(this.lblVe);
            this.panel1.Controls.Add(this.lblTK);
            this.panel1.Controls.Add(this.lblNS);
            this.panel1.Controls.Add(this.lblKH);
            this.panel1.Controls.Add(this.lblRap);
            this.panel1.Controls.Add(this.blTC);
            this.panel1.Controls.Add(this.btnDangXuat);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1635, 47);
            this.panel1.TabIndex = 16;
            this.panel1.UseWaitCursor = true;
            // 
            // lblPhim
            // 
            this.lblPhim.AutoSize = true;
            this.lblPhim.Location = new System.Drawing.Point(741, 17);
            this.lblPhim.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPhim.Name = "lblPhim";
            this.lblPhim.Size = new System.Drawing.Size(40, 16);
            this.lblPhim.TabIndex = 18;
            this.lblPhim.Text = "Phim ";
            this.lblPhim.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblPhim.UseWaitCursor = true;
            this.lblPhim.Click += new System.EventHandler(this.lblPhim_Click);
            // 
            // blBCTK
            // 
            this.blBCTK.AutoSize = true;
            this.blBCTK.Location = new System.Drawing.Point(837, 17);
            this.blBCTK.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.blBCTK.Name = "blBCTK";
            this.blBCTK.Size = new System.Drawing.Size(131, 16);
            this.blBCTK.TabIndex = 17;
            this.blBCTK.Text = "Báo Cáo - Thống Kê ";
            this.blBCTK.UseWaitCursor = true;
            this.blBCTK.Click += new System.EventHandler(this.blBCTK_Click);
            // 
            // lblVe
            // 
            this.lblVe.AutoSize = true;
            this.lblVe.Location = new System.Drawing.Point(667, 18);
            this.lblVe.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblVe.Name = "lblVe";
            this.lblVe.Size = new System.Drawing.Size(24, 16);
            this.lblVe.TabIndex = 16;
            this.lblVe.Text = "Vé";
            this.lblVe.UseWaitCursor = true;
            this.lblVe.Click += new System.EventHandler(this.lblVe_Click);
            // 
            // lblTK
            // 
            this.lblTK.AutoSize = true;
            this.lblTK.Location = new System.Drawing.Point(529, 17);
            this.lblTK.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTK.Name = "lblTK";
            this.lblTK.Size = new System.Drawing.Size(71, 16);
            this.lblTK.TabIndex = 15;
            this.lblTK.Text = "Tài Khoản ";
            this.lblTK.UseWaitCursor = true;
            this.lblTK.Click += new System.EventHandler(this.lblTK_Click);
            // 
            // lblNS
            // 
            this.lblNS.AutoSize = true;
            this.lblNS.Location = new System.Drawing.Point(405, 17);
            this.lblNS.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNS.Name = "lblNS";
            this.lblNS.Size = new System.Drawing.Size(61, 16);
            this.lblNS.TabIndex = 14;
            this.lblNS.Text = "Nhân Sự ";
            this.lblNS.UseWaitCursor = true;
            this.lblNS.Click += new System.EventHandler(this.lblNS_Click);
            // 
            // lblKH
            // 
            this.lblKH.AutoSize = true;
            this.lblKH.Location = new System.Drawing.Point(252, 17);
            this.lblKH.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblKH.Name = "lblKH";
            this.lblKH.Size = new System.Drawing.Size(83, 16);
            this.lblKH.TabIndex = 13;
            this.lblKH.Text = "Khách Hàng ";
            this.lblKH.UseWaitCursor = true;
            this.lblKH.Click += new System.EventHandler(this.lblKH_Click);
            // 
            // lblRap
            // 
            this.lblRap.AutoSize = true;
            this.lblRap.Location = new System.Drawing.Point(161, 17);
            this.lblRap.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblRap.Name = "lblRap";
            this.lblRap.Size = new System.Drawing.Size(36, 16);
            this.lblRap.TabIndex = 12;
            this.lblRap.Text = "Rạp ";
            this.lblRap.UseWaitCursor = true;
            this.lblRap.Click += new System.EventHandler(this.lblRap_Click);
            // 
            // blTC
            // 
            this.blTC.AutoSize = true;
            this.blTC.Location = new System.Drawing.Point(23, 17);
            this.blTC.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.blTC.Name = "blTC";
            this.blTC.Size = new System.Drawing.Size(72, 16);
            this.blTC.TabIndex = 11;
            this.blTC.Text = "Trang Chủ ";
            this.blTC.UseWaitCursor = true;
            this.blTC.Click += new System.EventHandler(this.blTC_Click);
            // 
            // QLGhe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1635, 863);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "QLGhe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QLGhe";
            this.Load += new System.EventHandler(this.lblRap_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLCR)).EndInit();
            this.panel6.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvLCR;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTK;
        private System.Windows.Forms.TextBox txtMaG;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtMaPhong;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTenRap;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PC_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn idG;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.Label lblPhim;
        private System.Windows.Forms.Label blBCTK;
        private System.Windows.Forms.Label lblVe;
        private System.Windows.Forms.Label lblTK;
        private System.Windows.Forms.Label lblNS;
        private System.Windows.Forms.Label lblKH;
        private System.Windows.Forms.Label lblRap;
        private System.Windows.Forms.Label blTC;
    }
}