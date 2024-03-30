using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace QuanLiTourDuLich
{
    public partial class fr_QuanLiKhachHang : Form
    {
        public fr_QuanLiKhachHang()
        {
            InitializeComponent();
        }
        public Connectdata con =new Connectdata();
        private QLKhachHang kh = new QLKhachHang();
        public DataTable tbl_kh = new DataTable();
        private void AnBT_CapNhat()
        {
            butTTKH_Luu.Enabled = false;
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
           
        }
        private void HienBT_CapNhat()
        {
            butTTKH_Luu.Enabled = true;
            btnsua.Enabled = true;
            btnxoa.Enabled = true;
           
        }
        private void GuiGiaTriThuocTinh_NV()
        {
            kh.makh = txtMKH.Text;
            kh.tenkh = txthvt.Text;
            kh.sdt = txtSDT.Text;
            kh.email = txtemail.Text;
            kh.diachi = txtdc.Text;
            kh.taikhoankhachhang = txttentk.Text; 
            kh.matkhaukhachhang = txtmk.Text; 





        }
        private void TrongTxt()
        {
            txtMKH.Text = "";
            txthvt.Text = "";
            txtmk.Text = "";
            txttentk.Text = "";
            txtSDT.Text = "";
            txtemail.Text = "";
            txtdc.Text = "";
        }
        private void DoDL_Vaolvdkh()
        {
            liv_kh.Items.Clear();
            for (int i = 0; i < tbl_kh.Rows.Count; i++)
            {
                int tmp = i + 1;
                ListViewItem item = liv_kh.Items.Add(tmp.ToString());
                for (int j = 0; j < tbl_kh.Columns.Count; j++)
                {
                    item.SubItems.Add(tbl_kh.Rows[i][j].ToString());

                }
            }
        }

        private void fr_QuanLiKhachHang_Load(object sender, EventArgs e)
        {
            kh.Conect_QLT();
            tbl_kh = kh.LayDL("Select * from KhachHang");
            DoDL_Vaolvdkh();
        }

        private void butTTKH_Luu_Click(object sender, EventArgs e)
        {
            tbl_kh = kh.LayDL("select * from KhachHang where MaKH =N'" +" "+ txtMKH.Text + "'");


            if (tbl_kh.Rows.Count > 0)
            {
                MessageBox.Show("Vui lòng chọn mã Khách hàng khác");
            }
            else
            {

                GuiGiaTriThuocTinh_NV();

                kh.Insert_kh();
                MessageBox.Show(txtMKH.Text+" "+ "Thêm thành công");
                fr_QuanLiKhachHang_Load(sender, e);
                AnBT_CapNhat();
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            try
            {
                GuiGiaTriThuocTinh_NV();
                kh.Update_kh();
                AnBT_CapNhat();
                MessageBox.Show("Cập nhật thành công");
                fr_QuanLiKhachHang_Load(sender, e);
                TrongTxt();

            }
            catch (Exception err)
            {
                MessageBox.Show("Cập nhật không thành công" + err.Message);
                return;
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {

            try
            {
                //lvKH.Items.Remove(lvKH.SelectedItems[0]);
                GuiGiaTriThuocTinh_NV(); 
                kh.Delete_kh();
                MessageBox.Show("Xóa thành công nhan vien có mã"+" " +txtMKH.Text);
                fr_QuanLiKhachHang_Load(sender, e);

                AnBT_CapNhat();
            }
            catch (Exception err)
            {
                MessageBox.Show("Không thể xóa. Vui lòng liên hệ nhà cung cấp để biết thêm thông tin" + err.Message);
                return;
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void liv_kh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (liv_kh.SelectedItems.Count > 0)
            {
                txtMKH.Text = liv_kh.SelectedItems[0].SubItems[1].Text;
                txthvt.Text = liv_kh.SelectedItems[0].SubItems[2].Text;
                txttentk.Text = liv_kh.SelectedItems[0].SubItems[3].Text;
                txtmk.Text = liv_kh.SelectedItems[0].SubItems[4].Text;
                txtSDT.Text = liv_kh.SelectedItems[0].SubItems[5].Text;
                txtemail.Text = liv_kh.SelectedItems[0].SubItems[6].Text;
                txtdc.Text = liv_kh.SelectedItems[0].SubItems[7].Text;
                
                HienBT_CapNhat();

            }
        }

        private void groupBoxThongTinKhachHang_Enter(object sender, EventArgs e)
        {

        }
    }

}