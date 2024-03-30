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

namespace QuanLiTourDuLich
{
    public partial class fr_QuanLiTour : Form
    {
        public fr_QuanLiTour()
        {
            InitializeComponent();
        }
        public Connectdata con = new Connectdata();
        private QLTour tour = new QLTour();
        public DataTable tbl_tour = new DataTable();
        
        private void AnBT_CapNhat()
        {
            btn_Them.Enabled = false;
            btn_Sua.Enabled = false;
            btn_Xoa.Enabled = false;
        }
        private void HienBT_CapNhat()
        {
            btn_Them.Enabled = true;
            btn_Sua.Enabled = true;
            btn_Xoa.Enabled = true;
        }
        private void GuiGiaTriThuocTinh_NV()
        {
            tour.matour = txtMaTour.Text;
            tour.tentour = txtTenTour.Text;

            tour.mahuongdanvien = txtHDV.Text;
            tour.socho = domainUpDown1.Text;
            tour.ngaydi=dateTimeNgayDi.Text;
            tour.ngayketthuc = dateTimeNgayKT.Text;
           
            tour.gia = txtGiaTour.Text;


            tour.madiemkhoihanh = cmbDiemKhoiHanh.Text;
            tour.madiem = cmbDiemDen.Text;
            tour.poster = txtpo.Text;
            tour.maphuongtien = cmbPhuongTien.Text;
            tour.makhachsan = cmbKS.Text;
            tour.malichtrinh = cmblt.Text;
            tour.MaLoaiTour =cmbLoaiTour.Text;
        }
        private void TrongTxt()
        {
            txtMaTour.Text = "";
            txtTenTour.Text = "";
            txtHDV.Text = "";
            domainUpDown1.Text = "";
            dateTimeNgayDi.Text = "";
            dateTimeNgayDi.Text = ""; // DateTime.Now.ToShortDateString();
            txtGiaTour.Text = "";
            cmbPhuongTien.Text= "";
            cmbLoaiTour.Text = "";
            cmbDiemDen.Text = "";
            cmbDiemKhoiHanh.Text = "";
            cmbKS.Text = "";
            txtpo.Text = "";
            cmblt.Text = "";
            

        }
        private void DoDL_VaoTour(DataTable tbl_all, ListView dt_all)
        {
            dt_all.Items.Clear();
            for (int i = 0; i < tbl_all.Rows.Count; i++)
            {
                int tmp = i + 1;
                ListViewItem item = dt_all.Items.Add(tmp.ToString());
                for (int j = 0; j < tbl_all.Columns.Count; j++)
                {
                    item.SubItems.Add(tbl_all.Rows[i][j].ToString());

                }
            }
        }
        private void fr_QuanLiTour_Load(object sender, EventArgs e)
        {
            tour.Conect_QLT();
            tbl_tour = tour.LayDL("Select * from Tour");
            DoDL_VaoTour(tbl_tour,listview_tour);
            DataTable tbl_CB = tour.LayDL("select * from LoaiTour ");
            cmb_timloaitour.Items.Clear();
            DataTable tbl_pt = tour.LayDL("select * from PhuongTien ");
            cmbPhuongTien.Items.Clear();

            DataTable tbl_ks = tour.LayDL("select * from KhachSan ");
            cmbKS.Items.Clear();

            DataTable tbl_dkh = tour.LayDL("select * from DiemDi ");
            cmbDiemKhoiHanh.Items.Clear();

            DataTable tbl_dd = tour.LayDL("select * from DiemDuLich ");
            cmbDiemDen.Items.Clear();

            DataTable tbl_lichtrinh = tour.LayDL("select * from LichTrinh");
            cmblt.Items.Clear();

            DataTable tbl_socho = tour.LayDL("select * from Tour ");
            domainUpDown1.Items.Clear();
            for (int i = 0; i < tbl_CB.Rows.Count; i++)
            {
                cmbLoaiTour.Items.Add(tbl_CB.Rows[i][0].ToString());
                cmb_timloaitour.Items.Add(tbl_CB.Rows[i][1].ToString());
                cmbPhuongTien.Items.Add(tbl_pt.Rows[i][0].ToString());
                cmbKS.Items.Add(tbl_ks.Rows[i][0].ToString());

                cmbDiemDen.Items.Add(tbl_dd.Rows[i][0].ToString());
                cmbDiemKhoiHanh.Items.Add(tbl_dkh.Rows[i][0].ToString());
               cmblt.Items.Add(tbl_lichtrinh.Rows[i][0].ToString());

               



            }



        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            tbl_tour = tour.LayDL("select * from Tour where MaTour =N'" + txtMaTour.Text + "'");


            if (tbl_tour.Rows.Count > 0)
            {
                MessageBox.Show("Vui lòng chọn mã điểm khởi hành khác");
            }
            else
            {

                GuiGiaTriThuocTinh_NV();

                tour.Insert_t();
                MessageBox.Show("Thêm thành công");
                fr_QuanLiTour_Load(sender, e);
                AnBT_CapNhat();
            }
          
        }
        
       


        private void listview_tour_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listview_tour.SelectedItems.Count > 0)
            {
                txtMaTour.Text = listview_tour.SelectedItems[0].SubItems[1].Text;

                txtTenTour.Text = listview_tour.SelectedItems[0].SubItems[2].Text;

                domainUpDown1.Text = listview_tour.SelectedItems[0].SubItems[3].Text;
                dateTimeNgayDi.Text = listview_tour.SelectedItems[0].SubItems[4].Text;
                dateTimeNgayKT.Text = listview_tour.SelectedItems[0].SubItems[5].Text;

               
                txtGiaTour.Text = listview_tour.SelectedItems[0].SubItems[6].Text;
                txtpo.Text = listview_tour.SelectedItems[0].SubItems[7].Text;

                cmbPhuongTien.Text = listview_tour.SelectedItems[0].SubItems[8].Text;
               
                cmbDiemDen.Text = listview_tour.SelectedItems[0].SubItems[9].Text;
                cmbDiemKhoiHanh.Text = listview_tour.SelectedItems[0].SubItems[10].Text;
                cmbLoaiTour.Text = listview_tour.SelectedItems[0].SubItems[11].Text;
                cmblt.Text= listview_tour.SelectedItems[0].SubItems[12].Text;
                cmbKS.Text = listview_tour.SelectedItems[0].SubItems[13].Text;
                txtHDV.Text = listview_tour.SelectedItems[0].SubItems[14].Text;
                HienBT_CapNhat();


            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                //lvKH.Items.Remove(lvKH.SelectedItems[0]);
                GuiGiaTriThuocTinh_NV();
                tour.Delete_t();
                MessageBox.Show("Xóa thành công");
                fr_QuanLiTour_Load(sender, e);

                AnBT_CapNhat();
            }
            catch (Exception)
            {
                MessageBox.Show("Không thể xóa. Vui lòng liên hệ nhà cung cấp để biết thêm thông tin");
                return;
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            try
            {
                GuiGiaTriThuocTinh_NV();
                tour.Update_t();
                AnBT_CapNhat();
                MessageBox.Show("Cập nhật thành công");
                fr_QuanLiTour_Load(sender, e);


                TrongTxt();

            }
            catch (Exception err)
            {
                MessageBox.Show("Cập nhật không thành công" + err.Message);
                return;
            }
        }

      

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butReset_Click(object sender, EventArgs e)
        {
            TrongTxt();
        }

        private void cmb_timloaitour_SelectedIndexChanged(object sender, EventArgs e)
        {
            string TenLoaiTour = cmb_timloaitour.SelectedItem.ToString();
            tbl_tour = tour.LayDL("Select * from LoaiTour where TenLoaiTour =N'" + cmb_timloaitour.SelectedItem.ToString()+ "'");
            DataTable tbl_LoaiTour = tour.LayDL("Select * from Tour Where MaLoaiTour='" + tbl_tour.Rows[0][0].ToString() +"'");
            DoDL_VaoTour(tbl_LoaiTour, listview_tour);
        }

        private void buttonTimKiem_Click(object sender, EventArgs e) { 
        

            
        }
    }
}

  

