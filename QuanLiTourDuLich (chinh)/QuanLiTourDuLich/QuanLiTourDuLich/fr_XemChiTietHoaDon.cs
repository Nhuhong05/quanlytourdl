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
    public partial class fr_XemChiTietHoaDon : Form
    {
        fr_QuanLiHoaDon hd = new fr_QuanLiHoaDon();
        public fr_XemChiTietHoaDon()
        {
            InitializeComponent();
        }
        public Connectdata con = new Connectdata();
        private Thanhvien tv = new Thanhvien();
        public DataTable tbl_tv = new DataTable();

        private void DoDL_Vaochitiethd()
        {
            lvchitiethd.Items.Clear();
            for (int i = 0; i < tbl_tv.Rows.Count; i++)
            {
                int tmp = i + 1;
                ListViewItem item = lvchitiethd.Items.Add(tmp.ToString());
                for (int j = 0; j < tbl_tv.Columns.Count; j++)
                {
                    item.SubItems.Add(tbl_tv.Rows[i][j].ToString());

                }
            }
        }

        private void fr_XemChiTietHoaDon_Load(object sender, EventArgs e)
        {
            tv.Conect_QLT();
            tbl_tv = tv.LayDL("Select * from ThongTinThanhVien");
            DoDL_Vaochitiethd();
        }

        private void labelX_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lvchitiethd_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvchitiethd.SelectedItems.Count > 0)
            {
                //txtMNV.Text = lvchitiethd.SelectedItems[0].SubItems[1].Text;
                //txtHvTNV.Text = lvchitiethd.SelectedItems[0].SubItems[2].Text;
                //txtSDTNV.Text = lvchitiethd.SelectedItems[0].SubItems[3].Text;
                //dateTimeNgaySinhNV.Text = lvchitiethd.SelectedItems[0].SubItems[4].Text;
                //txtCMNDNV.Text = lvchitiethd.SelectedItems[0].SubItems[5].Text;
                //dateTimeNgayVaoLamNV.Text = lvchitiethd.SelectedItems[0].SubItems[6].Text;
                

            }
        }

        private void txtSHD_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
        }
    }
}
