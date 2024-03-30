using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiTourDuLich
{
    internal class Diemdulich :Loaitour
    {
        public string MaDiem,DiemDen,Anh;
        public string madiem { get { return MaDiem; } set { MaDiem = value; } }
        public string diemden { get { return DiemDen; } set { DiemDen = value; } }
        public string anh { get { return Anh; } set { Anh = value; } }


        public Diemdulich(string maLoaiTour, string maDiem,string anh, string diemDen)
        {
            MaLoaiTour = maLoaiTour;
            MaDiem = maDiem;
            DiemDen = diemDen;
            Anh = anh;
        }

        public Diemdulich()
        {
           
        }
        


        public void Insert_ddl()
        {
            ThucThi("insert into DiemDuLich values(N'" + MaDiem + "',N'" + DiemDen +"',N'" + MaLoaiTour +"',N'"+Anh+ "')");
        }




        //public void Update_ddl()
        //{
        //    ThucThi("update DiemDuLich set DiemDen =N'" + DiemDen + "' ,MaLoaiTour=N'" + MaLoaiTour+"',Anh=N'" +Anh+  "'  Where MaDiem N='" + MaDiem +  "'");

        //}
        public void Update_ddl()
        {
            ThucThi("UPDATE DiemDuLich SET DiemDen = N'" + DiemDen + "', MaLoaiTour = N'" + MaLoaiTour + "', Anh = N'" + Anh + "' WHERE MaDiem = N'" + MaDiem + "'");
        }


        public void Delete_ddl()
        {
            ThucThi("delete DiemDuLich where MaDiem='" + MaDiem + "'");

        }
    }
}

