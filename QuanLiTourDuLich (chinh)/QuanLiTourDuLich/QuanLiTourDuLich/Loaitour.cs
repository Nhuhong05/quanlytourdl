using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiTourDuLich
{
    internal class Loaitour : Connectdata
    {
        public string MaLoaiTour, TenLoaiTour;
        public string maloaitour { get { return MaLoaiTour; } set { MaLoaiTour = value; } }
        public string tenloaitour { get { return TenLoaiTour; } set { TenLoaiTour = value; } }

        public Loaitour(string maLoaiTour, string tenLoaiTour)
        {
            MaLoaiTour = maLoaiTour;
            TenLoaiTour = tenLoaiTour;
        }

        public Loaitour()
        {
            MaLoaiTour = TenLoaiTour = "";
        }

        public void ThucThi(string CauLenh_ThucThi)
        {
            Comm = new SqlCommand(CauLenh_ThucThi, Conn);
            Comm.ExecuteNonQuery();
        }

        public void Insert_lt()
        {
            ThucThi("insert into LoaiTour values(N'" + MaLoaiTour + "',N'" + TenLoaiTour + "')");
        }




        public void Update_lt()
        {
            ThucThi("update  LoaiTour set TenLoaiTour =N'" +  TenLoaiTour + "'  Where MaLoaiTour='" + MaLoaiTour + "'");

        }

        public void Delete_lt()
        {
            ThucThi("delete  LoaiTour where MaLoaiTour='" + MaLoaiTour + "'");

        }
    }

}
