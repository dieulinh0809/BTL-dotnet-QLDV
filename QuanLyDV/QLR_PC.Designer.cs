namespace QuanLyDV
{
    partial class QLR_PC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QLR_PC));
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvPC = new System.Windows.Forms.DataGridView();
            this.PC_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PC_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.R_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTK = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.txtTenRap = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtTenPC = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtMaPC = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblTenRap = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPhim = new System.Windows.Forms.Label();
            this.blBCTK = new System.Windows.Forms.Label();
            this.lblVe = new System.Windows.Forms.Label();
            this.lblTK = new System.Windows.Forms.Label();
            this.lblNS = new System.Windows.Forms.Label();
            this.lblKH = new System.Windows.Forms.Label();
            this.lblRap = new System.Windows.Forms.Label();
            this.blTC = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPC)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.AutoSize = true;
            this.panel4.Controls.Add(this.groupBox2);
            this.panel4.Controls.Add(this.groupBox1);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 117);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1131, 525);
            this.panel4.TabIndex = 11;
            this.panel4.UseWaitCursor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvPC);
            this.groupBox2.Location = new System.Drawing.Point(0, 109);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(841, 445);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách";
            this.groupBox2.UseWaitCursor = true;
            // 
            // dgvPC
            // 
            this.dgvPC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PC_id,
            this.PC_name,
            this.R_name});
            this.dgvPC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPC.Location = new System.Drawing.Point(3, 16);
            this.dgvPC.Name = "dgvPC";
            this.dgvPC.Size = new System.Drawing.Size(835, 426);
            this.dgvPC.TabIndex = 0;
            this.dgvPC.UseWaitCursor = true;
            this.dgvPC.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPC_CellClick);
            // 
            // PC_id
            // 
            this.PC_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PC_id.DataPropertyName = "PC_id";
            this.PC_id.HeaderText = "Mã Phòng Chiếu ";
            this.PC_id.MinimumWidth = 30;
            this.PC_id.Name = "PC_id";
            // 
            // PC_name
            // 
            this.PC_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PC_name.DataPropertyName = "PC_name";
            this.PC_name.HeaderText = "Tên Phòng Chiếu";
            this.PC_name.MinimumWidth = 30;
            this.PC_name.Name = "PC_name";
            // 
            // R_name
            // 
            this.R_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.R_name.DataPropertyName = "R_name";
            this.R_name.HeaderText = "Tên Rạp ";
            this.R_name.MinimumWidth = 30;
            this.R_name.Name = "R_name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTK);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtTimKiem);
            this.groupBox1.Location = new System.Drawing.Point(0, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(841, 100);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm Kiếm ";
            this.groupBox1.UseWaitCursor = true;
            // 
            // btnTK
            // 
            this.btnTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTK.Image = ((System.Drawing.Image)(resources.GetObject("btnTK.Image")));
            this.btnTK.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnTK.Location = new System.Drawing.Point(352, 19);
            this.btnTK.Name = "btnTK";
            this.btnTK.Size = new System.Drawing.Size(44, 47);
            this.btnTK.TabIndex = 7;
            this.btnTK.UseVisualStyleBackColor = true;
            this.btnTK.UseWaitCursor = true;
            this.btnTK.Click += new System.EventHandler(this.btnTK_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(74, 38);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 16);
            this.label13.TabIndex = 5;
            this.label13.Text = "Tìm Kiếm  ";
            this.label13.UseWaitCursor = true;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(155, 31);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(158, 22);
            this.txtTimKiem.TabIndex = 6;
            this.txtTimKiem.UseWaitCursor = true;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.groupBox3);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(839, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(292, 525);
            this.panel6.TabIndex = 1;
            this.panel6.UseWaitCursor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnThem);
            this.groupBox3.Controls.Add(this.btnSua);
            this.groupBox3.Controls.Add(this.btnXoa);
            this.groupBox3.Controls.Add(this.txtTenRap);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.txtTenPC);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.txtMaPC);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(292, 525);
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
            this.btnThem.Location = new System.Drawing.Point(6, 435);
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
            this.btnSua.Location = new System.Drawing.Point(101, 435);
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
            this.btnXoa.Location = new System.Drawing.Point(201, 435);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(85, 36);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.UseWaitCursor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // txtTenRap
            // 
            this.txtTenRap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenRap.Location = new System.Drawing.Point(110, 295);
            this.txtTenRap.Name = "txtTenRap";
            this.txtTenRap.Size = new System.Drawing.Size(153, 22);
            this.txtTenRap.TabIndex = 9;
            this.txtTenRap.UseWaitCursor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(36, 300);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(66, 16);
            this.label16.TabIndex = 8;
            this.label16.Text = "Tên Rạp :";
            this.label16.UseWaitCursor = true;
            // 
            // txtTenPC
            // 
            this.txtTenPC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenPC.Location = new System.Drawing.Point(110, 232);
            this.txtTenPC.Name = "txtTenPC";
            this.txtTenPC.Size = new System.Drawing.Size(153, 22);
            this.txtTenPC.TabIndex = 7;
            this.txtTenPC.UseWaitCursor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(36, 237);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(58, 16);
            this.label15.TabIndex = 6;
            this.label15.Text = "Tên PC :";
            this.label15.UseWaitCursor = true;
            // 
            // txtMaPC
            // 
            this.txtMaPC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPC.Location = new System.Drawing.Point(110, 169);
            this.txtMaPC.Name = "txtMaPC";
            this.txtMaPC.Size = new System.Drawing.Size(153, 22);
            this.txtMaPC.TabIndex = 5;
            this.txtMaPC.UseWaitCursor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(36, 174);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 16);
            this.label14.TabIndex = 4;
            this.label14.Text = "Mã PC  : ";
            this.label14.UseWaitCursor = true;
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Image = ((System.Drawing.Image)(resources.GetObject("btnDangXuat.Image")));
            this.btnDangXuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangXuat.Location = new System.Drawing.Point(1008, 2);
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
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(3, 86);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(888, 100);
            this.panel5.TabIndex = 2;
            this.panel5.UseWaitCursor = true;
            // 
            // lblTenRap
            // 
            this.lblTenRap.AutoSize = true;
            this.lblTenRap.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenRap.Location = new System.Drawing.Point(646, 26);
            this.lblTenRap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenRap.Name = "lblTenRap";
            this.lblTenRap.Size = new System.Drawing.Size(149, 31);
            this.lblTenRap.TabIndex = 1;
            this.lblTenRap.Text = "Tên   Rạp ";
            this.lblTenRap.UseWaitCursor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label11);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 642);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1131, 48);
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
            // panel2
            // 
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.lblTenRap);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 38);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1131, 79);
            this.panel2.TabIndex = 9;
            this.panel2.UseWaitCursor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(263, 26);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(375, 31);
            this.label10.TabIndex = 0;
            this.label10.Text = "Quản Lý Phòng Chiếu  Rạp ";
            this.label10.UseWaitCursor = true;
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
            this.panel1.Size = new System.Drawing.Size(1131, 38);
            this.panel1.TabIndex = 8;
            this.panel1.UseWaitCursor = true;
            // 
            // lblPhim
            // 
            this.lblPhim.AutoSize = true;
            this.lblPhim.Location = new System.Drawing.Point(552, 14);
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
            this.blBCTK.Location = new System.Drawing.Point(624, 14);
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
            this.lblVe.Location = new System.Drawing.Point(496, 15);
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
            this.lblTK.Location = new System.Drawing.Point(393, 14);
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
            this.lblNS.Location = new System.Drawing.Point(300, 14);
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
            this.lblKH.Location = new System.Drawing.Point(185, 14);
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
            this.lblRap.Location = new System.Drawing.Point(117, 14);
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
            this.blTC.Location = new System.Drawing.Point(13, 14);
            this.blTC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.blTC.Name = "blTC";
            this.blTC.Size = new System.Drawing.Size(60, 13);
            this.blTC.TabIndex = 11;
            this.blTC.Text = "Trang Chủ ";
            this.blTC.UseWaitCursor = true;
            this.blTC.Click += new System.EventHandler(this.blTC_Click);
            // 
            // QLR_PC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 690);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "QLR_PC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QLR_PC";
            this.Load += new System.EventHandler(this.QLR_PC_Load);
            this.panel4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPC)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnTK;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dgvPC;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox txtTenRap;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtTenPC;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtMaPC;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblTenRap;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PC_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn PC_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn R_name;
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