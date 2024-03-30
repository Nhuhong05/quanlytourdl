using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiTourDuLich
{
    internal class QLTour :Connectdata
    {
        public string MaTour, TenTour, SoCho, NgayDi, NgayKetThuc, Poster,Gia, MaPhuongTien, MaDiem, MaDiemKhoiHanh, MaLoaiTour, MaLichTrinh, MaKhachSan, MaHuongDanVien;

        public QLTour()
        {
            MaTour = TenTour = SoCho = NgayDi = NgayKetThuc= Gia= Poster = MaPhuongTien = MaDiem= MaDiemKhoiHanh= MaLoaiTour = MaLichTrinh= MaKhachSan= MaHuongDanVien = "";
        }

        public string matour { get { return MaTour; } set { MaTour = value; } }
        public string tentour { get { return TenTour; } set { TenTour = value; } }
        public string socho { get { return SoCho; } set { SoCho = value; } }
        public string ngaydi { get { return NgayDi; } set { NgayDi = value; } }
        public string ngayketthuc { get { return NgayKetThuc; } set { NgayKetThuc = value; } }
        public string gia { get { return Gia; } set { Gia = value; } }
        public string mahuongdanvien { get { return MaHuongDanVien; } set { MaHuongDanVien = value; } }

        public string poster { get { return Poster; } set { Poster = value; } }

        public string maphuongtien { get { return MaPhuongTien; } set { MaPhuongTien = value; } }
        public string madiem { get { return MaDiem; } set { MaDiem = value; } }
        public string madiemkhoihanh { get { return MaDiemKhoiHanh; } set { MaDiemKhoiHanh = value; } }
        public string maloailour { get { return MaLoaiTour; } set { MaLoaiTour = value; } }
        public string malichtrinh { get { return MaLichTrinh; } set { MaLichTrinh = value; } }
        public string makhachsan { get { return MaKhachSan; } set { MaKhachSan = value; } }

        public QLTour(string maTour, string tenTour, string soCho, string ngayDi, string ngayKetThuc, string poster, string gia, string maPhuongTien, string maDiem, string maDiemKhoiHanh, string maLoaiTour, string maLichTrinh, string maKhachSan, string maHuongDanVien, string maloailour)
        {
            MaTour = maTour;
            TenTour = tenTour;
            SoCho = soCho;
            NgayDi = ngayDi;
            NgayKetThuc = ngayKetThuc;
            Poster = poster;
            Gia = gia;
            MaPhuongTien = maPhuongTien;
            MaDiem = maDiem;
            MaDiemKhoiHanh = maDiemKhoiHanh;
            MaLoaiTour = maLoaiTour;
            MaLichTrinh = maLichTrinh;
            MaKhachSan = maKhachSan;
            MaHuongDanVien = maHuongDanVien;
            
        }

        public void ThucThi(string CauLenh_ThucThi)
        {
            Comm = new SqlCommand(CauLenh_ThucThi, Conn);
            Comm.ExecuteNonQuery();
        }

        public void Insert_t()
        {
            ThucThi("insert into Tour values(N'" + MaTour + "',N'" + TenTour + "' ,N'" + SoCho  +"',N'" + DateTime.Parse(NgayDi) + "',N'" + DateTime.Parse(NgayKetThuc) + "',N'" + float.Parse(Gia) + "',N'" + Poster + "',N'" + MaPhuongTien + "',N'"+MaDiem+ "',N'" + MaDiemKhoiHanh + "',N'"+ MaLoaiTour + "',N'"+ MaLichTrinh + "',N'"+ MaKhachSan + "',N'"+ MaHuongDanVien + "')");
        }


        public void Update_t()
        {
            ThucThi("UPDATE Tour SET TenTour = N'" + TenTour + "',SoCho=N'" + SoCho + "',NgayDi=N'" + DateTime.Parse(NgayDi) + "',NgayKetThuc=N'" + DateTime.Parse(NgayKetThuc) + "',Gia=N'" + Gia + "',Poster=N'" + Poster + "',MaPhuongTien=N'" + MaPhuongTien +"',MaDiem=N'" +MaDiem+ "',MaDiemKhoiHanh=N'"+MaDiemKhoiHanh+"',MaLoaiTour=N'"+MaLoaiTour+ "',MaLichTrinh=N'"+MaLichTrinh+ "',MaKhachSan=N'"+MaKhachSan+ "',MaHuongDanVien=N'" + MaHuongDanVien +   "'  Where MaTour='" + MaTour + "'");

        }

        public void Delete_t()
        {
            ThucThi("delete Tour where MaTour='" + MaTour + "'");

        }
    }
}
