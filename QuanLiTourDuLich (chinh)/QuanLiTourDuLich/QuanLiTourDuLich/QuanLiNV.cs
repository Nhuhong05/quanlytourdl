using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace QuanLiTourDuLich
{
    internal class QuanLiNV :QLTour
    {

        public string TenHuongDanVien, NgaySinh, SDT, CMND, NgayVaoLam;
      // public string mahdv { get { return MaHuongDanVien; } set { MaHuongDanVien = value; } }
        public string tenhdv { get { return TenHuongDanVien; } set { TenHuongDanVien = value; } }
        public string ngaysinh { get { return NgaySinh; } set { NgaySinh = value; } }
        public string sdt { get { return SDT; } set { SDT = value; } }
        public string cmnd { get { return CMND; } set { CMND = value; } }
        public string ngayvl { get { return NgayVaoLam; } set { NgayVaoLam = value; } }
        public QuanLiNV()
        {
           
        }

        public QuanLiNV(string tenHuongDanVien,string mahuongdanvien, string ngaySinh, string sDT, string cMND, string ngayVaoLam)
        {
            TenHuongDanVien = tenHuongDanVien;
            NgaySinh = ngaySinh;
            SDT = sDT;
            CMND = cMND;
            NgayVaoLam = ngayVaoLam;
            MaHuongDanVien = mahuongdanvien;
        }

       

        public void Insert_hdv()
        {
            ThucThi("insert into HuongDanVien values(N'" + MaHuongDanVien + "',N'" + TenHuongDanVien + "',N'" + SDT + "' ,N'" + DateTime.Parse(NgaySinh) + "',N'" + CMND + "',N'" +DateTime.Parse(NgayVaoLam) + "')");
        }




        public void Update_hdv()
        {
            ThucThi("UPDATE HuongDanVien SET TenHuongDanVien = N'" + TenHuongDanVien + "', SDT='"+SDT+"', NgaySinh= N'" + DateTime.Parse(NgaySinh) + "',[CMND/CCCD]=N'" + CMND + "',NgayVaoLam=N'" + DateTime.Parse(NgayVaoLam) + "' WHERE MaHuongDanVien = N'" + MaHuongDanVien + "'");

        }

        public void Delete_hdv()
        {
            ThucThi("delete HuongDanVien where MaHuongDanVien='" + MaHuongDanVien + "'");

        }
    }
}