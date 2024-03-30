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
    public partial class fr_QuanLiNhanVien : Form
    {
        public fr_QuanLiNhanVien()
        {
            InitializeComponent();
        }
        private QuanLiNV nv = new QuanLiNV();
        public DataTable tbl_nv = new DataTable();
        private void AnBT_CapNhat()
        {
            butTTNV_Them.Enabled = false;
            butTTNV_Sua.Enabled = false;
            butTTNV_Xoa.Enabled = false;
        }
        private void HienBT_CapNhat()
        {
            butTTNV_Them.Enabled = true;
            butTTNV_Sua.Enabled = true;
            butTTNV_Xoa.Enabled = true;
        }
        private void GuiGiaTriThuocTinh_NV()
        {
            nv.mahuongdanvien = txtMNV.Text;
            nv.tenhdv = txtHvTNV.Text;

            nv.ngaysinh =dateTimeNgaySinhNV.Text;
            nv.sdt = txtSDTNV.Text;
            nv.cmnd = txtCMNDNV.Text;
            nv.ngayvl = dateTimeNgayVaoLamNV.Text;


        }
        private void TrongTxt()
        {
            txtMNV.Text = "";
            txtHvTNV.Text = "";
            dateTimeNgaySinhNV.Text = "";
            txtSDTNV.Text = "";
            txtCMNDNV.Text = "";
            dateTimeNgayVaoLamNV.Text = "";
        }
        private void DoDL_Vaolvdkh()
        {
            liv_nv.Items.Clear();
            for (int i = 0; i < tbl_nv.Rows.Count; i++)
            {
                int tmp = i + 1;
                ListViewItem item = liv_nv.Items.Add(tmp.ToString());
                for (int j = 0; j < tbl_nv.Columns.Count; j++)
                {
                    item.SubItems.Add(tbl_nv.Rows[i][j].ToString());

                }
            }
        }


        private void dataQuanLiNV_Click(object sender, EventArgs e)
        {

        }

        private void fr_QuanLiNhanVien_Load(object sender, EventArgs e)
        {
            nv.Conect_QLT();
            tbl_nv = nv.LayDL("Select * from HuongDanVien");
            DoDL_Vaolvdkh();
        }

        private void butTTNV_Them_Click(object sender, EventArgs e)
        {
            tbl_nv = nv.LayDL("select * from HuongDanVien where MaHuongDanVien =N'"  + txtMNV.Text + "'");


            if (tbl_nv.Rows.Count > 0)
            {
                MessageBox.Show("Vui lòng chọn mã Khách hàng khác");
            }
            else
            {
                GuiGiaTriThuocTinh_NV();

                nv.Insert_hdv();
                MessageBox.Show(txtMNV.Text + " " + "Thêm thành công");
                fr_QuanLiNhanVien_Load(sender, e);
                AnBT_CapNhat();
            }
        }

        private void liv_nv_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (liv_nv.SelectedItems.Count > 0)
            {
                txtMNV.Text = liv_nv.SelectedItems[0].SubItems[1].Text;
                txtHvTNV.Text = liv_nv.SelectedItems[0].SubItems[2].Text;
                txtSDTNV.Text = liv_nv.SelectedItems[0].SubItems[3].Text;
                dateTimeNgaySinhNV.Text = liv_nv.SelectedItems[0].SubItems[4].Text;
                txtCMNDNV.Text = liv_nv.SelectedItems[0].SubItems[5].Text;
                dateTimeNgayVaoLamNV.Text = liv_nv.SelectedItems[0].SubItems[6].Text;
               HienBT_CapNhat();

            }
        }

        private void butTTNV_Sua_Click(object sender, EventArgs e)
        {
            try
            {
                GuiGiaTriThuocTinh_NV();
                nv.Update_hdv();
                AnBT_CapNhat();
                MessageBox.Show("Cập nhật thành công");
                fr_QuanLiNhanVien_Load(sender, e);

                TrongTxt();

            }
            catch (Exception err)
            {
                MessageBox.Show("Cập nhật không thành công" + err.Message);
                return;
            }
        }

        private void butTTNV_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                //lvKH.Items.Remove(lvKH.SelectedItems[0]);
                GuiGiaTriThuocTinh_NV();
                nv.Delete_hdv();
                MessageBox.Show("Xóa thành công nhan vien có mã" + " " + txtMNV.Text);
                fr_QuanLiNhanVien_Load(sender, e);


                AnBT_CapNhat();
            }
            catch (Exception err)
            {
                MessageBox.Show("Không thể xóa. Vui lòng liên hệ nhà cung cấp để biết thêm thông tin" + err.Message);
                return;
            }
        }
    }
}

       

        