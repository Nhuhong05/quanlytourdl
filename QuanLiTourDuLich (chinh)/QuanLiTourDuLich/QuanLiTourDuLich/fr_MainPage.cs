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
    public partial class fr_MainPage : Form
    {
        public static fr_MainPage frmTG = null;
       
        public fr_MainPage()
        {
           
            InitializeComponent();
            

        }
        public Connectdata con = new Connectdata();
        private QLTour tour = new QLTour();
        public DataTable tbl_tour = new DataTable();
        private void panelBody_Paint(object sender, PaintEventArgs e)
        {

        }
        public void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;// mất mấy nút xung quanh
            childForm.Dock = DockStyle.Fill;
            panelBody.Controls.Add(childForm);
            panelBody.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void fr_MainPage_Load(object sender, EventArgs e)
        {
            
        }
        private Form currentFormChild;
       

        private void buttonQLDichVu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fr_QuanLiDichVu());

        }

        private void buttonQLKH_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fr_QuanLiKhachHang());
            

        }

        private void buttonQLNV_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fr_QuanLiNhanVien());

        }

        private void buttonQLHoaDon_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fr_QuanLiHoaDon());
            

        }

        private void buttonQLTour_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fr_QuanLiTour());

        }

       

        private void buttonDatCho_Click(object sender, EventArgs e)
        {
            
            OpenChildForm(new trangchu());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fr_XemChiTietHoaDon());

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void buttonTour_Click(object sender, EventArgs e)
        {
            this.Hide();
            fr_LOGIN frmDang = new fr_LOGIN();
            frmDang.Show();
        }
    }
}
