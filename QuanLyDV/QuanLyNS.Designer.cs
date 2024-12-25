namespace QuanLyDV
{
    partial class QuanLyNS
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLyNS));
            this.tenCV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbSoatVe = new System.Windows.Forms.CheckBox();
            this.cbThuNgan = new System.Windows.Forms.CheckBox();
            this.cbQuanLy = new System.Windows.Forms.CheckBox();
            this.txtNoiLamViec = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.Diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.cbNam = new System.Windows.Forms.CheckBox();
            this.cbNu = new System.Windows.Forms.CheckBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtCCCD = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.CCCD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.R_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPhim = new System.Windows.Forms.Label();
            this.blBCTK = new System.Windows.Forms.Label();
            this.lblVe = new System.Windows.Forms.Label();
            this.lblTK = new System.Windows.Forms.Label();
            this.lblNS = new System.Windows.Forms.Label();
            this.lblKH = new System.Windows.Forms.Label();
            this.lblRap = new System.Windows.Forms.Label();
            this.blTC = new System.Windows.Forms.Label();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTK = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvNVR = new System.Windows.Forms.DataGridView();
            this.NV_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel6.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNVR)).BeginInit();
            this.SuspendLayout();
            // 
            // tenCV
            // 
            this.tenCV.DataPropertyName = "tenCV";
            this.tenCV.HeaderText = "Chức Vụ ";
            this.tenCV.Name = "tenCV";
            // 
            // birthday
            // 
            this.birthday.DataPropertyName = "birthday";
            this.birthday.HeaderText = "Ngày Sinh ";
            this.birthday.Name = "birthday";
            // 
            // cbSoatVe
            // 
            this.cbSoatVe.AutoSize = true;
            this.cbSoatVe.Location = new System.Drawing.Point(109, 499);
            this.cbSoatVe.Name = "cbSoatVe";
            this.cbSoatVe.Size = new System.Drawing.Size(64, 17);
            this.cbSoatVe.TabIndex = 35;
            this.cbSoatVe.Text = "Soát Vé";
            this.cbSoatVe.UseVisualStyleBackColor = true;
            this.cbSoatVe.UseWaitCursor = true;
            this.cbSoatVe.CheckedChanged += new System.EventHandler(this.cbSoatVe_CheckedChanged);
            // 
            // cbThuNgan
            // 
            this.cbThuNgan.AutoSize = true;
            this.cbThuNgan.Location = new System.Drawing.Point(201, 462);
            this.cbThuNgan.Name = "cbThuNgan";
            this.cbThuNgan.Size = new System.Drawing.Size(77, 17);
            this.cbThuNgan.TabIndex = 34;
            this.cbThuNgan.Text = "Thu Ngân ";
            this.cbThuNgan.UseVisualStyleBackColor = true;
            this.cbThuNgan.UseWaitCursor = true;
            this.cbThuNgan.CheckedChanged += new System.EventHandler(this.cbThuNgan_CheckedChanged);
            // 
            // cbQuanLy
            // 
            this.cbQuanLy.AutoSize = true;
            this.cbQuanLy.Location = new System.Drawing.Point(109, 463);
            this.cbQuanLy.Name = "cbQuanLy";
            this.cbQuanLy.Size = new System.Drawing.Size(69, 17);
            this.cbQuanLy.TabIndex = 33;
            this.cbQuanLy.Text = "Quản Lý ";
            this.cbQuanLy.UseVisualStyleBackColor = true;
            this.cbQuanLy.UseWaitCursor = true;
            this.cbQuanLy.CheckedChanged += new System.EventHandler(this.cbQuanLy_CheckedChanged);
            // 
            // txtNoiLamViec
            // 
            this.txtNoiLamViec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoiLamViec.Location = new System.Drawing.Point(114, 533);
            this.txtNoiLamViec.Name = "txtNoiLamViec";
            this.txtNoiLamViec.Size = new System.Drawing.Size(153, 22);
            this.txtNoiLamViec.TabIndex = 32;
            this.txtNoiLamViec.UseWaitCursor = true;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(11, 536);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(105, 16);
            this.label21.TabIndex = 31;
            this.label21.Text = "Nơi Làm Việc    : ";
            this.label21.UseWaitCursor = true;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(24, 463);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(71, 16);
            this.label20.TabIndex = 29;
            this.label20.Text = "Chức Vụ   : ";
            this.label20.UseWaitCursor = true;
            // 
            // Diachi
            // 
            this.Diachi.DataPropertyName = "Diachi";
            this.Diachi.HeaderText = "Địa Chỉ ";
            this.Diachi.Name = "Diachi";
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "SDT";
            this.SDT.Name = "SDT";
            // 
            // txtSDT
            // 
            this.txtSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.Location = new System.Drawing.Point(106, 409);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(153, 22);
            this.txtSDT.TabIndex = 28;
            this.txtSDT.UseWaitCursor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(34, 415);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(50, 16);
            this.label18.TabIndex = 27;
            this.label18.Text = "SDT   : ";
            this.label18.UseWaitCursor = true;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(109, 357);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(150, 20);
            this.dtpNgaySinh.TabIndex = 26;
            this.dtpNgaySinh.UseWaitCursor = true;
            // 
            // cbNam
            // 
            this.cbNam.AutoSize = true;
            this.cbNam.Location = new System.Drawing.Point(204, 214);
            this.cbNam.Name = "cbNam";
            this.cbNam.Size = new System.Drawing.Size(48, 17);
            this.cbNam.TabIndex = 25;
            this.cbNam.Text = "Nam";
            this.cbNam.UseVisualStyleBackColor = true;
            this.cbNam.UseWaitCursor = true;
            this.cbNam.CheckedChanged += new System.EventHandler(this.cbNam_CheckedChanged);
            // 
            // cbNu
            // 
            this.cbNu.AutoSize = true;
            this.cbNu.Location = new System.Drawing.Point(109, 214);
            this.cbNu.Name = "cbNu";
            this.cbNu.Size = new System.Drawing.Size(40, 17);
            this.cbNu.TabIndex = 24;
            this.cbNu.Text = "Nữ";
            this.cbNu.UseVisualStyleBackColor = true;
            this.cbNu.UseWaitCursor = true;
            this.cbNu.CheckedChanged += new System.EventHandler(this.cbNu_CheckedChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(11, 361);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(81, 16);
            this.label17.TabIndex = 22;
            this.label17.Text = "Ngày Sinh  : ";
            this.label17.UseWaitCursor = true;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Location = new System.Drawing.Point(109, 307);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(153, 22);
            this.txtDiaChi.TabIndex = 21;
            this.txtDiaChi.UseWaitCursor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(27, 312);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(61, 16);
            this.label16.TabIndex = 20;
            this.label16.Text = "Địa Chỉ  : ";
            this.label16.UseWaitCursor = true;
            // 
            // txtCCCD
            // 
            this.txtCCCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCCCD.Location = new System.Drawing.Point(109, 258);
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.Size = new System.Drawing.Size(153, 22);
            this.txtCCCD.TabIndex = 19;
            this.txtCCCD.UseWaitCursor = true;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(27, 263);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(56, 16);
            this.label19.TabIndex = 18;
            this.label19.Text = "CCCD  : ";
            this.label19.UseWaitCursor = true;
            // 
            // txtTenNV
            // 
            this.txtTenNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNV.Location = new System.Drawing.Point(109, 168);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(153, 22);
            this.txtTenNV.TabIndex = 9;
            this.txtTenNV.UseWaitCursor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(27, 173);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 16);
            this.label15.TabIndex = 8;
            this.label15.Text = "Tên  NV : ";
            this.label15.UseWaitCursor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(20, 214);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 16);
            this.label12.TabIndex = 6;
            this.label12.Text = "Giới  Tính : ";
            this.label12.UseWaitCursor = true;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.Location = new System.Drawing.Point(109, 125);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(153, 22);
            this.txtMaNV.TabIndex = 5;
            this.txtMaNV.UseWaitCursor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(27, 130);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 16);
            this.label14.TabIndex = 4;
            this.label14.Text = "Mã NV : ";
            this.label14.UseWaitCursor = true;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.groupBox3);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(902, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(292, 768);
            this.panel6.TabIndex = 1;
            this.panel6.UseWaitCursor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbSoatVe);
            this.groupBox3.Controls.Add(this.cbThuNgan);
            this.groupBox3.Controls.Add(this.cbQuanLy);
            this.groupBox3.Controls.Add(this.txtNoiLamViec);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.txtSDT);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.dtpNgaySinh);
            this.groupBox3.Controls.Add(this.cbNam);
            this.groupBox3.Controls.Add(this.cbNu);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.txtDiaChi);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.txtCCCD);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.txtTenNV);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.btnThem);
            this.groupBox3.Controls.Add(this.btnSua);
            this.groupBox3.Controls.Add(this.btnXoa);
            this.groupBox3.Controls.Add(this.txtMaNV);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(292, 768);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chi Tiết ";
            this.groupBox3.UseWaitCursor = true;
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(0, 604);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(85, 36);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm ";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.UseWaitCursor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(96, 604);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(85, 36);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa ";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.UseWaitCursor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(201, 604);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(85, 36);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.UseWaitCursor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // CCCD
            // 
            this.CCCD.DataPropertyName = "CCCD";
            this.CCCD.HeaderText = "CCCD";
            this.CCCD.Name = "CCCD";
            // 
            // R_name
            // 
            this.R_name.DataPropertyName = "R_name";
            this.R_name.HeaderText = "Nơi Làm Việc";
            this.R_name.Name = "R_name";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label11);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 720);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1194, 48);
            this.panel3.TabIndex = 10;
            this.panel3.UseWaitCursor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 16);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(239, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Công Ty TNHH 3 thành viên | Phiên Bản 01LXH ";
            this.label11.UseWaitCursor = true;
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "Giới Tính ";
            this.GioiTinh.Name = "GioiTinh";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
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
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1194, 38);
            this.panel1.TabIndex = 8;
            this.panel1.UseWaitCursor = true;
            // 
            // lblPhim
            // 
            this.lblPhim.AutoSize = true;
            this.lblPhim.Location = new System.Drawing.Point(556, 14);
            this.lblPhim.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhim.Name = "lblPhim";
            this.lblPhim.Size = new System.Drawing.Size(33, 13);
            this.lblPhim.TabIndex = 18;
            this.lblPhim.Text = "Phim ";
            this.lblPhim.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblPhim.UseWaitCursor = true;
            this.lblPhim.Click += new System.EventHandler(this.lblPhim_Click);
            // 
            // blBCTK
            // 
            this.blBCTK.AutoSize = true;
            this.blBCTK.Location = new System.Drawing.Point(628, 14);
            this.blBCTK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.blBCTK.Name = "blBCTK";
            this.blBCTK.Size = new System.Drawing.Size(107, 13);
            this.blBCTK.TabIndex = 17;
            this.blBCTK.Text = "Báo Cáo - Thống Kê ";
            this.blBCTK.UseWaitCursor = true;
            this.blBCTK.Click += new System.EventHandler(this.blBCTK_Click);
            // 
            // lblVe
            // 
            this.lblVe.AutoSize = true;
            this.lblVe.Location = new System.Drawing.Point(500, 15);
            this.lblVe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVe.Name = "lblVe";
            this.lblVe.Size = new System.Drawing.Size(20, 13);
            this.lblVe.TabIndex = 16;
            this.lblVe.Text = "Vé";
            this.lblVe.UseWaitCursor = true;
            this.lblVe.Click += new System.EventHandler(this.lblVe_Click);
            // 
            // lblTK
            // 
            this.lblTK.AutoSize = true;
            this.lblTK.Location = new System.Drawing.Point(397, 14);
            this.lblTK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTK.Name = "lblTK";
            this.lblTK.Size = new System.Drawing.Size(59, 13);
            this.lblTK.TabIndex = 15;
            this.lblTK.Text = "Tài Khoản ";
            this.lblTK.UseWaitCursor = true;
            this.lblTK.Click += new System.EventHandler(this.lblTK_Click);
            // 
            // lblNS
            // 
            this.lblNS.AutoSize = true;
            this.lblNS.Location = new System.Drawing.Point(304, 14);
            this.lblNS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNS.Name = "lblNS";
            this.lblNS.Size = new System.Drawing.Size(52, 13);
            this.lblNS.TabIndex = 14;
            this.lblNS.Text = "Nhân Sự ";
            this.lblNS.UseWaitCursor = true;
            this.lblNS.Click += new System.EventHandler(this.lblNS_Click);
            // 
            // lblKH
            // 
            this.lblKH.AutoSize = true;
            this.lblKH.Location = new System.Drawing.Point(189, 14);
            this.lblKH.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKH.Name = "lblKH";
            this.lblKH.Size = new System.Drawing.Size(70, 13);
            this.lblKH.TabIndex = 13;
            this.lblKH.Text = "Khách Hàng ";
            this.lblKH.UseWaitCursor = true;
            this.lblKH.Click += new System.EventHandler(this.lblKH_Click);
            // 
            // lblRap
            // 
            this.lblRap.AutoSize = true;
            this.lblRap.Location = new System.Drawing.Point(121, 14);
            this.lblRap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRap.Name = "lblRap";
            this.lblRap.Size = new System.Drawing.Size(30, 13);
            this.lblRap.TabIndex = 12;
            this.lblRap.Text = "Rạp ";
            this.lblRap.UseWaitCursor = true;
            this.lblRap.Click += new System.EventHandler(this.lblRap_Click);
            // 
            // blTC
            // 
            this.blTC.AutoSize = true;
            this.blTC.Location = new System.Drawing.Point(17, 14);
            this.blTC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.blTC.Name = "blTC";
            this.blTC.Size = new System.Drawing.Size(60, 13);
            this.blTC.TabIndex = 11;
            this.blTC.Text = "Trang Chủ ";
            this.blTC.UseWaitCursor = true;
            this.blTC.Click += new System.EventHandler(this.blTC_Click);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Image = ((System.Drawing.Image)(resources.GetObject("btnDangXuat.Image")));
            this.btnDangXuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangXuat.Location = new System.Drawing.Point(1040, 2);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(111, 36);
            this.btnDangXuat.TabIndex = 10;
            this.btnDangXuat.Text = "Đăng Xuất ";
            this.btnDangXuat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDangXuat.UseVisualStyleBackColor = true;
            this.btnDangXuat.UseWaitCursor = true;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(895, 14);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Xin Chào Admin ";
            this.label9.UseWaitCursor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 38);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1194, 79);
            this.panel2.TabIndex = 9;
            this.panel2.UseWaitCursor = true;
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(3, 86);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(888, 100);
            this.panel5.TabIndex = 2;
            this.panel5.UseWaitCursor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(376, 21);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(290, 31);
            this.label10.TabIndex = 0;
            this.label10.Text = "Quản Lý Nhân Viên   ";
            this.label10.UseWaitCursor = true;
            // 
            // panel4
            // 
            this.panel4.AutoSize = true;
            this.panel4.Controls.Add(this.groupBox1);
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1194, 768);
            this.panel4.TabIndex = 11;
            this.panel4.UseWaitCursor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTK);
            this.groupBox1.Controls.Add(this.txtTimKiem);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Location = new System.Drawing.Point(3, 130);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(885, 80);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm Kiếm ";
            this.groupBox1.UseWaitCursor = true;
            // 
            // btnTK
            // 
            this.btnTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTK.Image = ((System.Drawing.Image)(resources.GetObject("btnTK.Image")));
            this.btnTK.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnTK.Location = new System.Drawing.Point(414, 13);
            this.btnTK.Name = "btnTK";
            this.btnTK.Size = new System.Drawing.Size(44, 47);
            this.btnTK.TabIndex = 7;
            this.btnTK.UseVisualStyleBackColor = true;
            this.btnTK.UseWaitCursor = true;
            this.btnTK.Click += new System.EventHandler(this.btnTK_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(232, 25);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(158, 22);
            this.txtTimKiem.TabIndex = 6;
            this.txtTimKiem.UseWaitCursor = true;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(147, 28);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 16);
            this.label13.TabIndex = 5;
            this.label13.Text = "Tìm Kiếm  ";
            this.label13.UseWaitCursor = true;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.groupBox2);
            this.panel7.Location = new System.Drawing.Point(3, 209);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(888, 443);
            this.panel7.TabIndex = 2;
            this.panel7.UseWaitCursor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvNVR);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(888, 443);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách";
            this.groupBox2.UseWaitCursor = true;
            // 
            // dgvNVR
            // 
            this.dgvNVR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNVR.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NV_id,
            this.TenNV,
            this.GioiTinh,
            this.CCCD,
            this.Diachi,
            this.birthday,
            this.SDT,
            this.tenCV,
            this.R_name});
            this.dgvNVR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNVR.Location = new System.Drawing.Point(3, 16);
            this.dgvNVR.Name = "dgvNVR";
            this.dgvNVR.Size = new System.Drawing.Size(882, 424);
            this.dgvNVR.TabIndex = 0;
            this.dgvNVR.UseWaitCursor = true;
            this.dgvNVR.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNVR_CellClick);
            this.dgvNVR.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNVR_CellContentClick);
            // 
            // NV_id
            // 
            this.NV_id.DataPropertyName = "NV_id";
            this.NV_id.HeaderText = "Mã Nhân Viên ";
            this.NV_id.Name = "NV_id";
            this.NV_id.ReadOnly = true;
            // 
            // TenNV
            // 
            this.TenNV.DataPropertyName = "TenNV";
            this.TenNV.HeaderText = "Tên Nhân Viên ";
            this.TenNV.Name = "TenNV";
            // 
            // QuanLyNS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 768);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "QuanLyNS";
            this.Text = "QuanLyNS";
            this.panel6.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNVR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn tenCV;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthday;
        private System.Windows.Forms.CheckBox cbSoatVe;
        private System.Windows.Forms.CheckBox cbThuNgan;
        private System.Windows.Forms.CheckBox cbQuanLy;
        private System.Windows.Forms.TextBox txtNoiLamViec;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.CheckBox cbNam;
        private System.Windows.Forms.CheckBox cbNu;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtCCCD;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCCD;
        private System.Windows.Forms.DataGridViewTextBoxColumn R_name;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTK;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvNVR;
        private System.Windows.Forms.DataGridViewTextBoxColumn NV_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNV;
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