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
    public partial class fr_LOGIN : Form
    {
        public fr_LOGIN()
        {
            InitializeComponent();
        }

        //private void txtTK_Click(object sender, EventArgs e)
        //{
        //    panelTK.ForeColor = Color.FromArgb(192, 64, 0);
        //}

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
            buttonDangNhap.BackColor = Color.FromArgb(192, 64, 0);
        }
    }
}
