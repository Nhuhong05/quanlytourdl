using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiTourDuLich
{
    internal class Thanhvien : QLKhachHang
    {
        public string MaThanhVien, HoTen, GioiTinh,NgaySinh,Tuoi;

       

        public string mathanhvien { get { return MaThanhVien; } set { MaThanhVien = value; } }
        public string hoten { get { return HoTen; } set { HoTen = value; } }
        public string ngaysinh { get { return NgaySinh; } set { NgaySinh = value; } }
        public string gioitinh { get { return GioiTinh; } set { GioiTinh = value; } }
        public string tuoi { get { return Tuoi; } set { Tuoi = value; } }

        public Thanhvien(string maThanhVien, string hoTen,string maKH, string gioiTinh, string ngaySinh, string tuoi)
        {
            MaThanhVien = maThanhVien;
            HoTen = hoTen;
            GioiTinh = gioiTinh;
            NgaySinh = ngaySinh;
            Tuoi = tuoi;
            MaKH = maKH;
        }

        public Thanhvien()
        {
        }
    }
}
