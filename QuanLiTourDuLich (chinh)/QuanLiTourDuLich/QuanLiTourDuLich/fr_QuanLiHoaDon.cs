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
    public partial class fr_QuanLiHoaDon : Form
    {
        public fr_QuanLiHoaDon()
        {
            InitializeComponent();
        }
        public Connectdata con = new Connectdata();
        private HoaDon hd = new HoaDon();
        public DataTable tbl_hd = new DataTable();
        
        private void DoDL_Vaolvdkh()
        {
            liv_hd.Items.Clear();
            for (int i = 0; i < tbl_hd.Rows.Count; i++)
            {
                int tmp = i + 1;
                ListViewItem item = liv_hd.Items.Add(tmp.ToString());
                for (int j = 0; j < tbl_hd.Columns.Count; j++)
                {
                    item.SubItems.Add(tbl_hd.Rows[i][j].ToString());

                }
            }
        }
        private void fr_QuanLiHoaDon_Load(object sender, EventArgs e)
        {
            hd.Conect_QLT();
            tbl_hd = hd.LayDL("Select * from HoaDon");
            DoDL_Vaolvdkh();
        }
        
        private void liv_hd_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                fr_XemChiTietHoaDon ct = new fr_XemChiTietHoaDon();
                ct.txtSHD.Text = liv_hd.SelectedItems[0].SubItems[1].Text;
                ct.txtTenNV.Text = liv_hd.SelectedItems[0].SubItems[2].Text;

                ct.txtTenKH.Text = liv_hd.SelectedItems[0].SubItems[3].Text;
                ct.txtGiaTour.Text = liv_hd.SelectedItems[0].SubItems[4].Text;


                ct.txtTenTour.Text = liv_hd.SelectedItems[0].SubItems[5].Text;
                ct.txtNgayLapHD.Text = liv_hd.SelectedItems[0].SubItems[6].Text;
                ct.txtsl.Text= liv_hd.SelectedItems[0].SubItems[8].Text;
                ct.TopMost = true;
                ct.Show();
            }
            catch (Exception)
            {

                return;
            }
        }

        private void liv_hd_MouseClick(object sender, MouseEventArgs e)
        {
            //fr_XemChiTietHoaDon ct = new fr_XemChiTietHoaDon();
            //ct.txtSHD = 
            //ct.txtTenKH =
            //ct.txtTenTour =
            //ct.txtNgayLapHD =
            //ct.txtTenNV = 
            //ct.txtGiaTour =
            //ct.Show();
        }

        private void liv_hd_Click(object sender, EventArgs e)
        {
            
        }

        private void labelXemCTHD_Click(object sender, EventArgs e)
        {

        }
    }
}
