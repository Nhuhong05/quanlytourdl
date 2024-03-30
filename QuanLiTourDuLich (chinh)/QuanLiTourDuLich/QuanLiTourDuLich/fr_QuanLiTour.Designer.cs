namespace QuanLiTourDuLich
{
    partial class fr_QuanLiTour
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
            this.cmb_timloaitour = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.listview_tour = new System.Windows.Forms.ListView();
            this.clstt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmatour = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cltentour = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clsocho = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clngaydi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clngaykt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clgia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_anh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmadiem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmdkh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmapt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cllt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmalt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmks = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhdv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelNgayDi = new System.Windows.Forms.Label();
            this.labelNgayKT = new System.Windows.Forms.Label();
            this.labelLoaiTour = new System.Windows.Forms.Label();
            this.labelPhuongTien = new System.Windows.Forms.Label();
            this.labelDiemKhoiHanh = new System.Windows.Forms.Label();
            this.labelDiemDen = new System.Windows.Forms.Label();
            this.dateTimeNgayDi = new System.Windows.Forms.DateTimePicker();
            this.dateTimeNgayKT = new System.Windows.Forms.DateTimePicker();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.cmbLoaiTour = new System.Windows.Forms.ComboBox();
            this.cmbPhuongTien = new System.Windows.Forms.ComboBox();
            this.cmbDiemKhoiHanh = new System.Windows.Forms.ComboBox();
            this.cmbDiemDen = new System.Windows.Forms.ComboBox();
            this.labelKS = new System.Windows.Forms.Label();
            this.cmbKS = new System.Windows.Forms.ComboBox();
            this.labelGiaTour = new System.Windows.Forms.Label();
            this.txtGiaTour = new System.Windows.Forms.TextBox();
            this.labelMTour = new System.Windows.Forms.Label();
            this.txtMaTour = new System.Windows.Forms.TextBox();
            this.labelTenTour = new System.Windows.Forms.Label();
            this.txtTenTour = new System.Windows.Forms.TextBox();
            this.labelMoTa = new System.Windows.Forms.Label();
            this.btn_Them = new System.Windows.Forms.Button();
            this.txtHDV = new System.Windows.Forms.TextBox();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.labelSoCho = new System.Windows.Forms.Label();
            this.domainUpDown1 = new System.Windows.Forms.DomainUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.txtpo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmblt = new System.Windows.Forms.ComboBox();
            this.groupBoxQuanLiTour = new System.Windows.Forms.GroupBox();
            this.butReset = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonTimKiem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBoxQuanLiTour.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmb_timloaitour
            // 
            this.cmb_timloaitour.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cmb_timloaitour.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(96)))), ((int)(((byte)(42)))));
            this.cmb_timloaitour.FormattingEnabled = true;
            this.cmb_timloaitour.Location = new System.Drawing.Point(522, 18);
            this.cmb_timloaitour.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmb_timloaitour.Name = "cmb_timloaitour";
            this.cmb_timloaitour.Size = new System.Drawing.Size(260, 42);
            this.cmb_timloaitour.TabIndex = 19;
            this.cmb_timloaitour.Text = "Tour trong nước";
            this.cmb_timloaitour.SelectedIndexChanged += new System.EventHandler(this.cmb_timloaitour_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(232)))), ((int)(((byte)(185)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(456, 100);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(768, 379);
            this.dataGridView1.TabIndex = 21;
            // 
            // listview_tour
            // 
            this.listview_tour.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clstt,
            this.clmatour,
            this.cltentour,
            this.clsocho,
            this.clngaydi,
            this.clngaykt,
            this.clgia,
            this.cl_anh,
            this.clmadiem,
            this.clmdkh,
            this.clmapt,
            this.cllt,
            this.clmalt,
            this.clmks,
            this.clhdv});
            this.listview_tour.FullRowSelect = true;
            this.listview_tour.GridLines = true;
            this.listview_tour.HideSelection = false;
            this.listview_tour.Location = new System.Drawing.Point(471, 110);
            this.listview_tour.Name = "listview_tour";
            this.listview_tour.Size = new System.Drawing.Size(739, 358);
            this.listview_tour.TabIndex = 22;
            this.listview_tour.UseCompatibleStateImageBehavior = false;
            this.listview_tour.View = System.Windows.Forms.View.Details;
            this.listview_tour.SelectedIndexChanged += new System.EventHandler(this.listview_tour_SelectedIndexChanged);
            // 
            // clstt
            // 
            this.clstt.Text = "STT";
            // 
            // clmatour
            // 
            this.clmatour.Text = "Mã Tour";
            this.clmatour.Width = 100;
            // 
            // cltentour
            // 
            this.cltentour.Text = "Tên Tour";
            this.cltentour.Width = 100;
            // 
            // clsocho
            // 
            this.clsocho.Text = "Số Chỗ";
            this.clsocho.Width = 100;
            // 
            // clngaydi
            // 
            this.clngaydi.Text = "Ngày Đi";
            this.clngaydi.Width = 130;
            // 
            // clngaykt
            // 
            this.clngaykt.Text = "Ngày Kết Thúc";
            this.clngaykt.Width = 120;
            // 
            // clgia
            // 
            this.clgia.Text = "Gía";
            this.clgia.Width = 130;
            // 
            // cl_anh
            // 
            this.cl_anh.Text = "Poster";
            this.cl_anh.Width = 100;
            // 
            // clmadiem
            // 
            this.clmadiem.Text = "Mã Điểm";
            this.clmadiem.Width = 110;
            // 
            // clmdkh
            // 
            this.clmdkh.Text = "Mã Điểm Khởi Hành";
            this.clmdkh.Width = 180;
            // 
            // clmapt
            // 
            this.clmapt.Text = "Mã Phương Tiện";
            this.clmapt.Width = 100;
            // 
            // cllt
            // 
            this.cllt.Text = "Mã Loại Tour";
            this.cllt.Width = 100;
            // 
            // clmalt
            // 
            this.clmalt.Text = "Mã Lịch Trình";
            this.clmalt.Width = 100;
            // 
            // clmks
            // 
            this.clmks.Text = "Mã Khách Sạn";
            this.clmks.Width = 100;
            // 
            // clhdv
            // 
            this.clhdv.Text = "Mã Hướng Dẫn Viên";
            this.clhdv.Width = 130;
            // 
            // labelNgayDi
            // 
            this.labelNgayDi.AutoSize = true;
            this.labelNgayDi.Location = new System.Drawing.Point(8, 280);
            this.labelNgayDi.Name = "labelNgayDi";
            this.labelNgayDi.Size = new System.Drawing.Size(95, 25);
            this.labelNgayDi.TabIndex = 1;
            this.labelNgayDi.Text = "Ngày Đi";
            // 
            // labelNgayKT
            // 
            this.labelNgayKT.AutoSize = true;
            this.labelNgayKT.Location = new System.Drawing.Point(12, 344);
            this.labelNgayKT.Name = "labelNgayKT";
            this.labelNgayKT.Size = new System.Drawing.Size(167, 25);
            this.labelNgayKT.TabIndex = 2;
            this.labelNgayKT.Text = "Ngày Kết Thúc";
            // 
            // labelLoaiTour
            // 
            this.labelLoaiTour.AutoSize = true;
            this.labelLoaiTour.Location = new System.Drawing.Point(7, 474);
            this.labelLoaiTour.Name = "labelLoaiTour";
            this.labelLoaiTour.Size = new System.Drawing.Size(112, 25);
            this.labelLoaiTour.TabIndex = 3;
            this.labelLoaiTour.Text = "Loại Tour";
            // 
            // labelPhuongTien
            // 
            this.labelPhuongTien.AutoSize = true;
            this.labelPhuongTien.Location = new System.Drawing.Point(8, 541);
            this.labelPhuongTien.Name = "labelPhuongTien";
            this.labelPhuongTien.Size = new System.Drawing.Size(145, 25);
            this.labelPhuongTien.TabIndex = 4;
            this.labelPhuongTien.Text = "Phương Tiện";
            // 
            // labelDiemKhoiHanh
            // 
            this.labelDiemKhoiHanh.AutoSize = true;
            this.labelDiemKhoiHanh.Location = new System.Drawing.Point(8, 609);
            this.labelDiemKhoiHanh.Name = "labelDiemKhoiHanh";
            this.labelDiemKhoiHanh.Size = new System.Drawing.Size(181, 25);
            this.labelDiemKhoiHanh.TabIndex = 5;
            this.labelDiemKhoiHanh.Text = "Điểm Khởi Hành";
            // 
            // labelDiemDen
            // 
            this.labelDiemDen.AutoSize = true;
            this.labelDiemDen.Location = new System.Drawing.Point(8, 676);
            this.labelDiemDen.Name = "labelDiemDen";
            this.labelDiemDen.Size = new System.Drawing.Size(114, 25);
            this.labelDiemDen.TabIndex = 6;
            this.labelDiemDen.Text = "Điểm Đến";
            // 
            // dateTimeNgayDi
            // 
            this.dateTimeNgayDi.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.dateTimeNgayDi.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.dateTimeNgayDi.CalendarTitleBackColor = System.Drawing.Color.AntiqueWhite;
            this.dateTimeNgayDi.CalendarTrailingForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dateTimeNgayDi.Location = new System.Drawing.Point(13, 309);
            this.dateTimeNgayDi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimeNgayDi.Name = "dateTimeNgayDi";
            this.dateTimeNgayDi.Size = new System.Drawing.Size(390, 31);
            this.dateTimeNgayDi.TabIndex = 12;
            // 
            // dateTimeNgayKT
            // 
            this.dateTimeNgayKT.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.dateTimeNgayKT.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.dateTimeNgayKT.CalendarTitleBackColor = System.Drawing.Color.AntiqueWhite;
            this.dateTimeNgayKT.CalendarTrailingForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dateTimeNgayKT.Location = new System.Drawing.Point(13, 373);
            this.dateTimeNgayKT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimeNgayKT.Name = "dateTimeNgayKT";
            this.dateTimeNgayKT.Size = new System.Drawing.Size(389, 31);
            this.dateTimeNgayKT.TabIndex = 13;
            // 
            // btn_thoat
            // 
            this.btn_thoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_thoat.Location = new System.Drawing.Point(200, 1033);
            this.btn_thoat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(125, 45);
            this.btn_thoat.TabIndex = 15;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sua.Location = new System.Drawing.Point(43, 1036);
            this.btn_Sua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(125, 45);
            this.btn_Sua.TabIndex = 16;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // cmbLoaiTour
            // 
            this.cmbLoaiTour.FormattingEnabled = true;
            this.cmbLoaiTour.Location = new System.Drawing.Point(11, 502);
            this.cmbLoaiTour.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbLoaiTour.Name = "cmbLoaiTour";
            this.cmbLoaiTour.Size = new System.Drawing.Size(390, 33);
            this.cmbLoaiTour.TabIndex = 18;
            // 
            // cmbPhuongTien
            // 
            this.cmbPhuongTien.FormattingEnabled = true;
            this.cmbPhuongTien.Location = new System.Drawing.Point(11, 570);
            this.cmbPhuongTien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbPhuongTien.Name = "cmbPhuongTien";
            this.cmbPhuongTien.Size = new System.Drawing.Size(390, 33);
            this.cmbPhuongTien.TabIndex = 19;
            // 
            // cmbDiemKhoiHanh
            // 
            this.cmbDiemKhoiHanh.FormattingEnabled = true;
            this.cmbDiemKhoiHanh.Location = new System.Drawing.Point(11, 638);
            this.cmbDiemKhoiHanh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbDiemKhoiHanh.Name = "cmbDiemKhoiHanh";
            this.cmbDiemKhoiHanh.Size = new System.Drawing.Size(390, 33);
            this.cmbDiemKhoiHanh.TabIndex = 20;
            // 
            // cmbDiemDen
            // 
            this.cmbDiemDen.FormattingEnabled = true;
            this.cmbDiemDen.Location = new System.Drawing.Point(11, 705);
            this.cmbDiemDen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbDiemDen.Name = "cmbDiemDen";
            this.cmbDiemDen.Size = new System.Drawing.Size(390, 33);
            this.cmbDiemDen.TabIndex = 21;
            // 
            // labelKS
            // 
            this.labelKS.AutoSize = true;
            this.labelKS.Location = new System.Drawing.Point(8, 744);
            this.labelKS.Name = "labelKS";
            this.labelKS.Size = new System.Drawing.Size(126, 25);
            this.labelKS.TabIndex = 22;
            this.labelKS.Text = "Khách Sạn";
            // 
            // cmbKS
            // 
            this.cmbKS.FormattingEnabled = true;
            this.cmbKS.Location = new System.Drawing.Point(11, 772);
            this.cmbKS.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbKS.Name = "cmbKS";
            this.cmbKS.Size = new System.Drawing.Size(390, 33);
            this.cmbKS.TabIndex = 23;
            // 
            // labelGiaTour
            // 
            this.labelGiaTour.AutoSize = true;
            this.labelGiaTour.Location = new System.Drawing.Point(12, 880);
            this.labelGiaTour.Name = "labelGiaTour";
            this.labelGiaTour.Size = new System.Drawing.Size(103, 25);
            this.labelGiaTour.TabIndex = 24;
            this.labelGiaTour.Text = "Giá Tour";
            // 
            // txtGiaTour
            // 
            this.txtGiaTour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(212)))), ((int)(((byte)(149)))));
            this.txtGiaTour.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGiaTour.Location = new System.Drawing.Point(13, 909);
            this.txtGiaTour.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGiaTour.Name = "txtGiaTour";
            this.txtGiaTour.Size = new System.Drawing.Size(390, 24);
            this.txtGiaTour.TabIndex = 25;
            // 
            // labelMTour
            // 
            this.labelMTour.AutoSize = true;
            this.labelMTour.Location = new System.Drawing.Point(8, 35);
            this.labelMTour.Name = "labelMTour";
            this.labelMTour.Size = new System.Drawing.Size(99, 25);
            this.labelMTour.TabIndex = 28;
            this.labelMTour.Text = "Mã Tour";
            // 
            // txtMaTour
            // 
            this.txtMaTour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(212)))), ((int)(((byte)(149)))));
            this.txtMaTour.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaTour.Location = new System.Drawing.Point(11, 64);
            this.txtMaTour.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaTour.Name = "txtMaTour";
            this.txtMaTour.Size = new System.Drawing.Size(390, 24);
            this.txtMaTour.TabIndex = 29;
            // 
            // labelTenTour
            // 
            this.labelTenTour.AutoSize = true;
            this.labelTenTour.Location = new System.Drawing.Point(8, 92);
            this.labelTenTour.Name = "labelTenTour";
            this.labelTenTour.Size = new System.Drawing.Size(107, 25);
            this.labelTenTour.TabIndex = 30;
            this.labelTenTour.Text = "Tên Tour";
            // 
            // txtTenTour
            // 
            this.txtTenTour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(212)))), ((int)(((byte)(149)))));
            this.txtTenTour.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTenTour.Location = new System.Drawing.Point(12, 121);
            this.txtTenTour.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenTour.Name = "txtTenTour";
            this.txtTenTour.Size = new System.Drawing.Size(389, 24);
            this.txtTenTour.TabIndex = 31;
            // 
            // labelMoTa
            // 
            this.labelMoTa.AutoSize = true;
            this.labelMoTa.Location = new System.Drawing.Point(7, 159);
            this.labelMoTa.Name = "labelMoTa";
            this.labelMoTa.Size = new System.Drawing.Size(180, 25);
            this.labelMoTa.TabIndex = 32;
            this.labelMoTa.Text = "Hướng Dẫn viên";
            // 
            // btn_Them
            // 
            this.btn_Them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Them.Location = new System.Drawing.Point(43, 984);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(125, 45);
            this.btn_Them.TabIndex = 14;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // txtHDV
            // 
            this.txtHDV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(212)))), ((int)(((byte)(149)))));
            this.txtHDV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHDV.Location = new System.Drawing.Point(11, 188);
            this.txtHDV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtHDV.Name = "txtHDV";
            this.txtHDV.Size = new System.Drawing.Size(389, 24);
            this.txtHDV.TabIndex = 33;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Xoa.Location = new System.Drawing.Point(200, 983);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(125, 45);
            this.btn_Xoa.TabIndex = 17;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // labelSoCho
            // 
            this.labelSoCho.AutoSize = true;
            this.labelSoCho.Location = new System.Drawing.Point(7, 216);
            this.labelSoCho.Name = "labelSoCho";
            this.labelSoCho.Size = new System.Drawing.Size(85, 25);
            this.labelSoCho.TabIndex = 34;
            this.labelSoCho.Text = "Số chỗ";
            // 
            // domainUpDown1
            // 
            this.domainUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.domainUpDown1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(96)))), ((int)(((byte)(42)))));
            this.domainUpDown1.Location = new System.Drawing.Point(11, 245);
            this.domainUpDown1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.domainUpDown1.Name = "domainUpDown1";
            this.domainUpDown1.Size = new System.Drawing.Size(96, 31);
            this.domainUpDown1.TabIndex = 35;
            this.domainUpDown1.Text = "0";
            this.domainUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 408);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 25);
            this.label1.TabIndex = 36;
            this.label1.Text = "Poster";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtpo
            // 
            this.txtpo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(212)))), ((int)(((byte)(149)))));
            this.txtpo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtpo.Location = new System.Drawing.Point(10, 437);
            this.txtpo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtpo.Name = "txtpo";
            this.txtpo.Size = new System.Drawing.Size(389, 24);
            this.txtpo.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 814);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 25);
            this.label2.TabIndex = 40;
            this.label2.Text = "Mã Lịch Trình";
            // 
            // cmblt
            // 
            this.cmblt.FormattingEnabled = true;
            this.cmblt.Location = new System.Drawing.Point(13, 843);
            this.cmblt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmblt.Name = "cmblt";
            this.cmblt.Size = new System.Drawing.Size(390, 33);
            this.cmblt.TabIndex = 41;
            // 
            // groupBoxQuanLiTour
            // 
            this.groupBoxQuanLiTour.Controls.Add(this.butReset);
            this.groupBoxQuanLiTour.Controls.Add(this.panel1);
            this.groupBoxQuanLiTour.Controls.Add(this.cmblt);
            this.groupBoxQuanLiTour.Controls.Add(this.label2);
            this.groupBoxQuanLiTour.Controls.Add(this.txtpo);
            this.groupBoxQuanLiTour.Controls.Add(this.label1);
            this.groupBoxQuanLiTour.Controls.Add(this.domainUpDown1);
            this.groupBoxQuanLiTour.Controls.Add(this.labelSoCho);
            this.groupBoxQuanLiTour.Controls.Add(this.btn_Xoa);
            this.groupBoxQuanLiTour.Controls.Add(this.txtHDV);
            this.groupBoxQuanLiTour.Controls.Add(this.btn_Them);
            this.groupBoxQuanLiTour.Controls.Add(this.labelMoTa);
            this.groupBoxQuanLiTour.Controls.Add(this.txtTenTour);
            this.groupBoxQuanLiTour.Controls.Add(this.labelTenTour);
            this.groupBoxQuanLiTour.Controls.Add(this.txtMaTour);
            this.groupBoxQuanLiTour.Controls.Add(this.labelMTour);
            this.groupBoxQuanLiTour.Controls.Add(this.txtGiaTour);
            this.groupBoxQuanLiTour.Controls.Add(this.labelGiaTour);
            this.groupBoxQuanLiTour.Controls.Add(this.cmbKS);
            this.groupBoxQuanLiTour.Controls.Add(this.labelKS);
            this.groupBoxQuanLiTour.Controls.Add(this.cmbDiemDen);
            this.groupBoxQuanLiTour.Controls.Add(this.cmbDiemKhoiHanh);
            this.groupBoxQuanLiTour.Controls.Add(this.cmbPhuongTien);
            this.groupBoxQuanLiTour.Controls.Add(this.cmbLoaiTour);
            this.groupBoxQuanLiTour.Controls.Add(this.btn_Sua);
            this.groupBoxQuanLiTour.Controls.Add(this.btn_thoat);
            this.groupBoxQuanLiTour.Controls.Add(this.dateTimeNgayKT);
            this.groupBoxQuanLiTour.Controls.Add(this.dateTimeNgayDi);
            this.groupBoxQuanLiTour.Controls.Add(this.labelDiemDen);
            this.groupBoxQuanLiTour.Controls.Add(this.labelDiemKhoiHanh);
            this.groupBoxQuanLiTour.Controls.Add(this.labelPhuongTien);
            this.groupBoxQuanLiTour.Controls.Add(this.labelLoaiTour);
            this.groupBoxQuanLiTour.Controls.Add(this.labelNgayKT);
            this.groupBoxQuanLiTour.Controls.Add(this.labelNgayDi);
            this.groupBoxQuanLiTour.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBoxQuanLiTour.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.groupBoxQuanLiTour.Location = new System.Drawing.Point(23, 18);
            this.groupBoxQuanLiTour.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxQuanLiTour.Name = "groupBoxQuanLiTour";
            this.groupBoxQuanLiTour.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxQuanLiTour.Size = new System.Drawing.Size(416, 1088);
            this.groupBoxQuanLiTour.TabIndex = 1;
            this.groupBoxQuanLiTour.TabStop = false;
            this.groupBoxQuanLiTour.Text = "Thông tin Tour";
            // 
            // butReset
            // 
            this.butReset.Image = global::QuanLiTourDuLich.Properties.Resources.undo_arrow;
            this.butReset.Location = new System.Drawing.Point(338, 1015);
            this.butReset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.butReset.Name = "butReset";
            this.butReset.Size = new System.Drawing.Size(65, 65);
            this.butReset.TabIndex = 43;
            this.butReset.UseVisualStyleBackColor = true;
            this.butReset.Click += new System.EventHandler(this.butReset_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(422, 981);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 42;
            // 
            // buttonTimKiem
            // 
            this.buttonTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTimKiem.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTimKiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(96)))), ((int)(((byte)(42)))));
            this.buttonTimKiem.Image = global::QuanLiTourDuLich.Properties.Resources.search__1_;
            this.buttonTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonTimKiem.Location = new System.Drawing.Point(816, 18);
            this.buttonTimKiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonTimKiem.Name = "buttonTimKiem";
            this.buttonTimKiem.Size = new System.Drawing.Size(118, 42);
            this.buttonTimKiem.TabIndex = 20;
            this.buttonTimKiem.Text = "Tìm Tour";
            this.buttonTimKiem.UseVisualStyleBackColor = true;
            this.buttonTimKiem.Click += new System.EventHandler(this.buttonTimKiem_Click);
            // 
            // fr_QuanLiTour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(227)))));
            this.ClientSize = new System.Drawing.Size(1288, 936);
            this.Controls.Add(this.groupBoxQuanLiTour);
            this.Controls.Add(this.listview_tour);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonTimKiem);
            this.Controls.Add(this.cmb_timloaitour);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "fr_QuanLiTour";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fr_QuanLiTour";
            this.Load += new System.EventHandler(this.fr_QuanLiTour_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBoxQuanLiTour.ResumeLayout(false);
            this.groupBoxQuanLiTour.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cmb_timloaitour;
        private System.Windows.Forms.Button buttonTimKiem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ListView listview_tour;
        private System.Windows.Forms.ColumnHeader clstt;
        private System.Windows.Forms.ColumnHeader clmatour;
        private System.Windows.Forms.ColumnHeader cltentour;
        private System.Windows.Forms.ColumnHeader clhdv;
        private System.Windows.Forms.ColumnHeader clsocho;
        private System.Windows.Forms.ColumnHeader clngaydi;
        private System.Windows.Forms.ColumnHeader clngaykt;
        private System.Windows.Forms.ColumnHeader clgia;
        private System.Windows.Forms.ColumnHeader cl_anh;
        private System.Windows.Forms.ColumnHeader clmadiem;
        private System.Windows.Forms.ColumnHeader clmdkh;
        private System.Windows.Forms.ColumnHeader clmapt;
        private System.Windows.Forms.ColumnHeader cllt;
        private System.Windows.Forms.ColumnHeader clmalt;
        private System.Windows.Forms.ColumnHeader clmks;
        private System.Windows.Forms.Label labelNgayDi;
        private System.Windows.Forms.Label labelNgayKT;
        private System.Windows.Forms.Label labelLoaiTour;
        private System.Windows.Forms.Label labelPhuongTien;
        private System.Windows.Forms.Label labelDiemKhoiHanh;
        private System.Windows.Forms.Label labelDiemDen;
        private System.Windows.Forms.DateTimePicker dateTimeNgayDi;
        private System.Windows.Forms.DateTimePicker dateTimeNgayKT;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.ComboBox cmbLoaiTour;
        private System.Windows.Forms.ComboBox cmbPhuongTien;
        private System.Windows.Forms.ComboBox cmbDiemKhoiHanh;
        private System.Windows.Forms.ComboBox cmbDiemDen;
        private System.Windows.Forms.Label labelKS;
        private System.Windows.Forms.ComboBox cmbKS;
        private System.Windows.Forms.Label labelGiaTour;
        private System.Windows.Forms.TextBox txtGiaTour;
        private System.Windows.Forms.Label labelMTour;
        private System.Windows.Forms.TextBox txtMaTour;
        private System.Windows.Forms.Label labelTenTour;
        private System.Windows.Forms.TextBox txtTenTour;
        private System.Windows.Forms.Label labelMoTa;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.TextBox txtHDV;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Label labelSoCho;
        private System.Windows.Forms.DomainUpDown domainUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtpo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmblt;
        private System.Windows.Forms.GroupBox groupBoxQuanLiTour;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button butReset;
    }
}