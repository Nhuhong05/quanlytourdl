namespace QuanLiTourDuLich
{
    partial class fr_QuanLiHoaDon
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
            this.labelXemCTHD = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.liv_hd = new System.Windows.Forms.ListView();
            this.stt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_mhd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_tennv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_tekh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_nlhd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_Thanhtien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_tentoyur = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelXemCTHD
            // 
            this.labelXemCTHD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelXemCTHD.AutoSize = true;
            this.labelXemCTHD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelXemCTHD.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelXemCTHD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.labelXemCTHD.Location = new System.Drawing.Point(504, 52);
            this.labelXemCTHD.Name = "labelXemCTHD";
            this.labelXemCTHD.Size = new System.Drawing.Size(327, 37);
            this.labelXemCTHD.TabIndex = 0;
            this.labelXemCTHD.Text = "Xem Chi Tiết Hóa Đơn";
            this.labelXemCTHD.Click += new System.EventHandler(this.labelXemCTHD_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(232)))), ((int)(((byte)(185)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 139);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1208, 700);
            this.dataGridView1.TabIndex = 5;
            // 
            // liv_hd
            // 
            this.liv_hd.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.stt,
            this.cl_mhd,
            this.cl_tennv,
            this.cl_tekh,
            this.cl_nlhd,
            this.cl_Thanhtien,
            this.cl_tentoyur,
            this.columnHeader1});
            this.liv_hd.FullRowSelect = true;
            this.liv_hd.GridLines = true;
            this.liv_hd.HideSelection = false;
            this.liv_hd.Location = new System.Drawing.Point(48, 156);
            this.liv_hd.Name = "liv_hd";
            this.liv_hd.Size = new System.Drawing.Size(1172, 666);
            this.liv_hd.TabIndex = 6;
            this.liv_hd.UseCompatibleStateImageBehavior = false;
            this.liv_hd.View = System.Windows.Forms.View.Details;
            this.liv_hd.SelectedIndexChanged += new System.EventHandler(this.liv_hd_SelectedIndexChanged);
            this.liv_hd.Click += new System.EventHandler(this.liv_hd_Click);
            this.liv_hd.MouseClick += new System.Windows.Forms.MouseEventHandler(this.liv_hd_MouseClick);
            // 
            // stt
            // 
            this.stt.Text = "STT";
            // 
            // cl_mhd
            // 
            this.cl_mhd.Text = "Mã Hóa Đơn";
            this.cl_mhd.Width = 100;
            // 
            // cl_tennv
            // 
            this.cl_tennv.Text = "Tên Hướng Dẫn Viên";
            this.cl_tennv.Width = 260;
            // 
            // cl_tekh
            // 
            this.cl_tekh.Text = "Mã Khách Hàng";
            this.cl_tekh.Width = 260;
            // 
            // cl_nlhd
            // 
            this.cl_nlhd.Text = "Thành Tiền";
            this.cl_nlhd.Width = 100;
            // 
            // cl_Thanhtien
            // 
            this.cl_Thanhtien.Text = "Mã Tour";
            this.cl_Thanhtien.Width = 130;
            // 
            // cl_tentoyur
            // 
            this.cl_tentoyur.Text = "Ngày Lập Hóa Đơn";
            this.cl_tentoyur.Width = 200;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "soluong";
            // 
            // fr_QuanLiHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(227)))));
            this.ClientSize = new System.Drawing.Size(1262, 861);
            this.Controls.Add(this.liv_hd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelXemCTHD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "fr_QuanLiHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fr_QuanLiHoaDon";
            this.Load += new System.EventHandler(this.fr_QuanLiHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelXemCTHD;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ListView liv_hd;
        private System.Windows.Forms.ColumnHeader cl_mhd;
        private System.Windows.Forms.ColumnHeader cl_tennv;
        private System.Windows.Forms.ColumnHeader cl_tekh;
        private System.Windows.Forms.ColumnHeader cl_nlhd;
        private System.Windows.Forms.ColumnHeader cl_Thanhtien;
        private System.Windows.Forms.ColumnHeader cl_tentoyur;
        private System.Windows.Forms.ColumnHeader stt;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}