using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiTourDuLich
{
    public partial class fr_QuanLiDichVu : Form
    {
        public fr_QuanLiDichVu()
        {
            InitializeComponent();
        }
        public Connectdata con = new Connectdata();
        private PhuongTien pt = new PhuongTien();
        private Diemdulich ddl = new Diemdulich();
        private DiemDi dkh = new DiemDi();


        public DataTable tbl_dichvu = new DataTable();
        private void AnBT_CapNhat()
        {
            btnThemdkh.Enabled = false;
            btnSuadkh.Enabled = false;
            btnXoadkh.Enabled = false;

            btnThemDuLich.Enabled = false;
            btnSuaDL.Enabled = false;
            btnXoaDL.Enabled = false;
        }
        private void HienBT_CapNhat()
        {
            btnThemdkh.Enabled = true;
            btnSuadkh.Enabled = true;
            btnXoadkh.Enabled = true;

            btnThemDuLich.Enabled = true;
            btnSuaDL.Enabled = true;
            btnXoaDL.Enabled = true;
        }
        private void GuiGiaTriThuocTinh_NV()
        {
           
            dkh.madiemkhoihanh = txtMDKH.Text;
            dkh.tendiemkhoihanh = txtTenDKH.Text;
            dkh.MaLoaiTour = cmbLoaiTour.Text;

            ddl.madiem = txtMDDL.Text;
            ddl.diemden = txtDiemDen.Text;
            ddl.MaLoaiTour = cmbLTour.Text;
            ddl.anh = txtanh.Text;


            pt.maphuongtien = txtMPT.Text;
            pt.tenphuongtien = txtTenPT.Text;



        }
        private void Trong_dkh()
        {
            txtMDKH.Text = "";
            txtTenDKH.Text = "";
            cmbLoaiTour.Text = "";
        }
        private void Trong_ddl()
        {
            txtMDDL.Text = "";
            txtDiemDen.Text = "";
            cmbLTour.Text = "";
            txtanh.Text = "";

        }
        private void Trong_pt()
        {
            txtMPT.Text = "";
            txtTenPT.Text = "";

        }


        private void DoDL_Vaolvddl()
        { 
            liv_ddl.Items.Clear();
            for (int i = 0; i < tbl_dichvu.Rows.Count; i++)
            {
                int tmp = i + 1;
                ListViewItem item = liv_ddl.Items.Add(tmp.ToString());
                for (int j = 0; j < tbl_dichvu.Columns.Count; j++)
                {
                    item.SubItems.Add(tbl_dichvu.Rows[i][j].ToString());

                }
            }
        }
        private void DoDL_Vaolvdkh()
        {
            liv_dkh.Items.Clear();
            for (int i = 0; i < tbl_dichvu.Rows.Count; i++)
            {
                int tmp = i + 1;
                ListViewItem item = liv_dkh.Items.Add(tmp.ToString());
                for (int j = 0; j < tbl_dichvu.Columns.Count; j++)
                {
                    item.SubItems.Add(tbl_dichvu.Rows[i][j].ToString());

                }
            }
        }

        private void DoDL_Vaolvpt()
        {
            liv_pt.Items.Clear();
            for (int i = 0; i < tbl_dichvu.Rows.Count; i++)
            {
                int tmp = i + 1;
                ListViewItem item = liv_pt.Items.Add(tmp.ToString());
                for (int j = 0; j < tbl_dichvu.Columns.Count; j++)
                {
                    item.SubItems.Add(tbl_dichvu.Rows[i][j].ToString());

                }
            }
        }
        // thêm sửa xóa điểm khở hanh
        private void btnThemdkh_Click(object sender, EventArgs e)
        {
                tbl_dichvu = dkh.LayDL("select * from DiemDi where MaDiemKhoiHanh =N'" + txtMDKH.Text + "'");


            if (tbl_dichvu.Rows.Count > 0)
            {
                MessageBox.Show("Vui lòng chọn mã điểm khởi hành khác");
            }
            else
            {
                
                GuiGiaTriThuocTinh_NV();

                dkh.Insert_dkh();
                MessageBox.Show("Thêm thành công");
                fr_QuanLiDichVu_Load(sender, e);
                AnBT_CapNhat();
            }
            
        }
        private void btnSuadkh_Click(object sender, EventArgs e)
        {
            try
            {
                GuiGiaTriThuocTinh_NV();
                    dkh.Update_dkh();
                    AnBT_CapNhat();
                    MessageBox.Show("Cập nhật thành công");
                    fr_QuanLiDichVu_Load(sender, e);
                    Trong_dkh();
                    
            }
            catch (Exception err)
            {
                MessageBox.Show("Cập nhật không thành công" + err.Message);
                return;
            }
        }
        private void btnXoadkh_Click(object sender, EventArgs e)
        {
            try
            {
                //lvKH.Items.Remove(lvKH.SelectedItems[0]);
                GuiGiaTriThuocTinh_NV();
                dkh.Delete_dkh();
                MessageBox.Show("Xóa thành công");
                fr_QuanLiDichVu_Load(sender, e);
                AnBT_CapNhat();
            }
            catch (Exception)
            {
                MessageBox.Show("Không thể xóa. Vui lòng liên hệ nhà cung cấp để biết thêm thông tin");
                return;
            }
        }

        private void fr_QuanLiDichVu_Load(object sender, EventArgs e)
        {
            //  dổ dữ liệu vào ddiemr khởi hành
            dkh.Conect_QLT();
            tbl_dichvu = dkh.LayDL("Select * from DiemDi");
            DoDL_Vaolvdkh();
            DataTable tbl_CB = dkh.LayDL("select * from LoaiTour ");
            cmbLoaiTour.Items.Clear();

            for (int i = 0; i < tbl_CB.Rows.Count; i++)
            {
                cmbLoaiTour.Items.Add(tbl_CB.Rows[i][0].ToString());
            }

            // đổ dữ liệu vào điểm du lich

            ddl.Conect_QLT();
            tbl_dichvu = ddl.LayDL("Select * from DiemDuLich");
            DoDL_Vaolvddl();
            DataTable tbl_lt = ddl.LayDL("select * from LoaiTour ");
            cmbLTour.Items.Clear();

            for (int i = 0; i < tbl_CB.Rows.Count; i++)
            {
                cmbLTour.Items.Add(tbl_CB.Rows[i][0].ToString());
            }
            // đổ dữ liệu vào phương tiện

            pt.Conect_QLT();
            tbl_dichvu = pt.LayDL("Select * from PhuongTien");
            DoDL_Vaolvpt();
        }

        private void liv_dkh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (liv_dkh.SelectedItems.Count > 0)
            {
                txtMDKH.Text = liv_dkh.SelectedItems[0].SubItems[1].Text;
                txtTenDKH.Text = liv_dkh.SelectedItems[0].SubItems[2].Text;
                cmbLoaiTour.Text = liv_dkh.SelectedItems[0].SubItems[3].Text;
                HienBT_CapNhat();

            }
        }

        private void liv_pt_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (liv_pt.SelectedItems.Count > 0)
            {
                txtMPT.Text = liv_pt.SelectedItems[0].SubItems[1].Text;
                txtTenPT.Text = liv_pt.SelectedItems[0].SubItems[2].Text;
               
                HienBT_CapNhat();

            }
        }

        private void liv_ddl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (liv_ddl.SelectedItems.Count > 0)
            {

                txtMDDL.Text = liv_ddl.SelectedItems[0].SubItems[1].Text;
                txtDiemDen.Text = liv_ddl.SelectedItems[0].SubItems[2].Text;
                cmbLTour.Text = liv_ddl.SelectedItems[0].SubItems[3].Text;
                txtanh.Text = liv_ddl.SelectedItems[0].SubItems[4].Text;

                HienBT_CapNhat();

            }
        }

        private void txtMDKH_TextChanged(object sender, EventArgs e)
        {
            if(txtMDKH.Text=="" || txtTenDKH.Text == "" || cmbLoaiTour.Text == "")
            {
                AnBT_CapNhat();
            }
            else
            {
                HienBT_CapNhat();
            }
        }

      

        private void butReset_Click(object sender, EventArgs e)
        {
            Trong_dkh();
        }

        private void butResetDL_Click(object sender, EventArgs e)
        {
            Trong_ddl();

        }
        //thêm điểm du lịch
        private void btnThemDuLich_Click(object sender, EventArgs e)
        {
                
            
            tbl_dichvu = ddl.LayDL("select * from DiemDuLich where MaDiem =N'" + txtMDDL.Text + "'");


            if (tbl_dichvu.Rows.Count > 0)
            {
                MessageBox.Show("Vui lòng chọn mã điểm đến khác");
            }
            else
            {
                
                GuiGiaTriThuocTinh_NV();

                ddl.Insert_ddl();
                MessageBox.Show("Thêm thành công");
                fr_QuanLiDichVu_Load(sender, e);
                AnBT_CapNhat();
            }
           
        }
        // swar diem du lich
        private void btnSuaDL_Click(object sender, EventArgs e)
        {
            try
            {
          

                    GuiGiaTriThuocTinh_NV();
                    ddl.Update_ddl();
                    AnBT_CapNhat();
                    MessageBox.Show("Cập nhật thành công");
                    fr_QuanLiDichVu_Load(sender, e);

                Trong_ddl();

            }
            catch (Exception err)
            {
                MessageBox.Show("Cập nhật không thành công" + err.Message);
                return;
            }
        }
        //xoa diem du lich
        private void btnXoaDL_Click(object sender, EventArgs e)
        {
            try
            {
                GuiGiaTriThuocTinh_NV();
                ddl.Delete_ddl();
                MessageBox.Show("Xóa thành công");
                fr_QuanLiDichVu_Load(sender, e);
                AnBT_CapNhat();
            }
            catch (Exception)
            {
                MessageBox.Show("Không thể xóa. Vui lòng liên hệ nhà cung cấp để biết thêm thông tin");
                return;
            }
        }
        //thêm phương tiện
        private void butThemPT_Click(object sender, EventArgs e)
        {
            tbl_dichvu = pt.LayDL("select * from PhuongTien where MaPhuongTien =N'" + txtMPT.Text + "'");


            if (tbl_dichvu.Rows.Count > 0)
            {
                MessageBox.Show("Vui lòng chọn mã điểm đến khác");
            }
            else
            {

                GuiGiaTriThuocTinh_NV();

                pt.Insert_pt();
                MessageBox.Show("Thêm thành công");
                fr_QuanLiDichVu_Load(sender, e);
                AnBT_CapNhat();
            }
        }
        private void butSuaPT_Click(object sender, EventArgs e)
        {
            try
            {
              

                    GuiGiaTriThuocTinh_NV();
                    pt.Update_pt();
                    AnBT_CapNhat();
                    MessageBox.Show("Cập nhật thành công");
                    fr_QuanLiDichVu_Load(sender, e);

                Trong_dkh();

            }
            catch (Exception err)
            {
                MessageBox.Show("Cập nhật không thành công" + err.Message);
                return;
            }
        }

        private void butResetPT_Click(object sender, EventArgs e)
        {
            Trong_pt();
        }

        private void txtMDDL_TextChanged(object sender, EventArgs e)
        {
            if (txtMDDL.Text == "" || txtDiemDen.Text=="" || txtanh.Text==""|| cmbLTour.Text=="")
            {
                AnBT_CapNhat();
            }
            else
            {
                HienBT_CapNhat();
            }
        }
        // xóa phuong tien
        private void butXoaPT_Click(object sender, EventArgs e)
        {
            try
            {
                GuiGiaTriThuocTinh_NV();
                pt.Delete_pt();
                MessageBox.Show("Xóa thành công");
                fr_QuanLiDichVu_Load(sender, e);
                AnBT_CapNhat();
            }
            catch (Exception )
            {
                MessageBox.Show("Không thể xóa. Vui lòng liên hệ nhà cung cấp để biết thêm thông tin");
                return;
            }
        }

        private void txtMPT_TextChanged(object sender, EventArgs e)
        {
            if(txtMPT.Text=="" || txtTenPT.Text=="")
            {
                AnBT_CapNhat();
            }
            else
            {
                HienBT_CapNhat();
            }

        }

        private void groupDiemKhoiHanh_Enter(object sender, EventArgs e)
        {

        }

        private void groupPhuongTien_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
