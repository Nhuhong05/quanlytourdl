using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLiTourDuLich
{
    public partial class fr_LOGIN : Form
    {
       // fr_LOGIN FRMDN = null;
        private Connectdata Con = new Connectdata();
      //  fr_MainPage start = new fr_MainPage();
        private int demsolandnsai = 0;

        public fr_LOGIN()
        {
            InitializeComponent();
           // FRMDN = this;
        }
       
        private void fr_LOGIN_Load(object sender, EventArgs e)
        {

        }

        private void labelThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtMK_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTK_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTK_Click(object sender, EventArgs e)
        {
            txtTK.Clear();
            //picTK.BackgroundImage = Properties.Resources.envelope2;
            panelTK.BackColor = Color.FromArgb(192, 64, 0);
            txtTK.ForeColor = Color.FromArgb(192, 64, 0);

            //picMK.BackgroundImage = Properties.Resources._lock;
            panelMK.BackColor = Color.FromArgb(249, 170, 120);
            txtMK.ForeColor = Color.FromArgb(249, 170, 120);
        }

        private void txtMK_Click(object sender, EventArgs e)
        {
            txtMK.Clear();
            txtMK.PasswordChar = '*';
            //picMK.BackgroundImage = Properties.Resources.lock1;
            panelMK.BackColor = Color.FromArgb(192, 64, 0);
            txtTK.ForeColor = Color.FromArgb(192, 64, 0);

            //picTK.BackgroundImage = Properties.Resources.envelope;
            panelTK.BackColor = Color.FromArgb(249, 170, 120);
            txtTK.ForeColor = Color.FromArgb(249, 170, 120);
        }

        private void buttonDangNhap_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (txtTK.Text == "")
            {
                errorProvider1.SetError(txtTK, "bạn chưa nhập tên dăng nhập");
            }
            else if (txtMK.Text == "")
            {
                errorProvider1.SetError(txtMK, "bạn chưa nhập mật khẩu");
            }
            else
            {
                Con.Conect_QLT();
                DataTable tbl_DSTK = new DataTable();
                tbl_DSTK = Con.LayDL("select * from Admin where TaiKhoanAdmin='" + txtTK.Text + "' and MatKhauAdmin='" +txtMK.Text + "'");
                if (tbl_DSTK.Rows.Count > 0)
                {
                    DataTable tbl_GV = Con.LayDL("select * from Admin where MaAdmin='" + tbl_DSTK.Rows[0][2].ToString() + "'");
                    //  MessageBox.Show("Xin chào bạn " + tbl_GV.Rows[0][1].ToString() + " đến với VIVUTRAVEL");
                    this.Hide();
                    fr_MainPage main = new fr_MainPage();
                    
                    main.Show();

                }
                else
                {
                    MessageBox.Show("Sai tên hoặc mật khẩu!!", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    demsolandnsai++;
                    if (demsolandnsai == 5)
                    {
                        MessageBox.Show("Bạn đã nhập sai 5 lần (vui lòng chờ sau 5 phút)", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                        buttonDangNhap.Enabled = false;
                        timer1.Enabled = true;
                        demsolandnsai = 0;
                    }
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            demsolandnsai++;
            if (demsolandnsai == 5)
            {
                buttonDangNhap.Enabled = true;
                timer1.Enabled = false;
                demsolandnsai = 0;
            }
        }
    }
}