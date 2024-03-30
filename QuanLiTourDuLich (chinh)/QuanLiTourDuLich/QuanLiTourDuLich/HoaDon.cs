using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiTourDuLich
{
    internal class HoaDon :QLKhachHang
    {
        public string MaHD,TenHDV, ThanhTien,MaTour,NgayLapHD;

        public HoaDon()
        {
            
        }

        public string mahd { get { return MaHD; } set { MaHD = value; } }
        public string tenhdv { get { return TenHDV; } set { TenHDV = value; } }
        public string ngaylaphd { get { return NgayLapHD; } set { NgayLapHD = value; } }
        public string thanhtien { get { return ThanhTien; } set { ThanhTien = value; } }
        public string matour { get { return MaTour; } set { MaTour = value; } }

        public HoaDon(string maHD, string maKH,string tenHDV, string thanhTien, string maTour, string ngayLapHD)
        {
            MaHD = maHD;
            TenHDV = tenHDV;
            ThanhTien = thanhTien;
            MaTour = maTour;
            NgayLapHD = ngayLapHD;
            MaKH = maKH;
        }
       
    }
}
