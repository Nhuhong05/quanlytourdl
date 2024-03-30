using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiTourDuLich
{
    internal class DiemDi :Loaitour
    {
        public string MaDiemKhoiHanh, TenDiemKhoiHanh;

        public DiemDi()
        {
        }

        public string madiemkhoihanh { get { return MaDiemKhoiHanh; } set { MaDiemKhoiHanh = value; } }
        public string tendiemkhoihanh { get { return TenDiemKhoiHanh; } set { TenDiemKhoiHanh = value; } }

        public DiemDi(string maDiemKhoiHanh, string tenDiemKhoiHanh,string maLoaiTour)
        {
            MaDiemKhoiHanh = maDiemKhoiHanh;
            TenDiemKhoiHanh = tenDiemKhoiHanh;
            MaLoaiTour = maLoaiTour;
        }

        public void Insert_dkh()
        {
            ThucThi("insert into DiemDi values(N'" + MaDiemKhoiHanh + "',N'" + TenDiemKhoiHanh + "',N'" + MaLoaiTour + "')");
        }




        //public void Update_dkh()
        //{
        //    ThucThi("update DiemDi set TenDiemKhoiHanh =N'" + TenDiemKhoiHanh + "', MaLoaiTour=N'" + MaLoaiTour + "'  Where MaDiemKhoiHanh N='" + MaDiemKhoiHanh + "'");

        //}
        public void Update_dkh()
        {
            ThucThi("UPDATE DiemDi SET TenDiemKhoiHanh = N'" + TenDiemKhoiHanh + "', MaLoaiTour = N'" + MaLoaiTour + "' WHERE MaDiemKhoiHanh = N'" + MaDiemKhoiHanh + "'");
        }

        public void Delete_dkh()
        {
            ThucThi("delete DiemDi where MaDiemKhoiHanh='" + MaDiemKhoiHanh + "'");

        }
    }
}
