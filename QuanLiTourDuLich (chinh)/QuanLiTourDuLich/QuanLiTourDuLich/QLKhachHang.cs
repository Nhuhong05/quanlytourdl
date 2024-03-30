using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiTourDuLich
{
    internal class QLKhachHang :Connectdata
    {
        public string MaKH, TenKH,TaiKhoanKhachHang,MatKhauKhachHang,SDT, Email,DiaChi;

        public QLKhachHang()
        {
            MaKH = TenKH = SDT = Email = DiaChi = TaiKhoanKhachHang=MatKhauKhachHang= "";
        }

        public string makh { get { return MaKH; } set { MaKH = value; } }
        public string tenkh { get { return TenKH; } set { TenKH = value; } }
        public string sdt { get { return SDT; } set { SDT = value; } }
        public string email { get { return Email; } set { Email = value; } }
        public string diachi { get { return DiaChi; } set { DiaChi = value; } }
        public string taikhoankhachhang { get { return TaiKhoanKhachHang; } set { TaiKhoanKhachHang = value; } }
        public string matkhaukhachhang { get { return MatKhauKhachHang; } set { MatKhauKhachHang = value; } }


        public QLKhachHang(string maKH, string tenKH, string taiKhoanKhachHang, string matKhauKhachHang, string sDT, string email, string diaChi)
        {
            MaKH = maKH;
            TenKH = tenKH;
            TaiKhoanKhachHang = taiKhoanKhachHang;
            MatKhauKhachHang = matKhauKhachHang;
            SDT = sDT;
            Email = email;
            DiaChi = diaChi;
        }

        public void ThucThi(string CauLenh_ThucThi)
        {
            Comm = new SqlCommand(CauLenh_ThucThi, Conn);
            Comm.ExecuteNonQuery();
        }

        public void Insert_kh()
        {
            ThucThi("insert into KhachHang values(N'" + MaKH + "',N'" + TenKH + "',N'" + TaiKhoanKhachHang + "',N'" + MatKhauKhachHang + "' ,N'" + SDT + "',N'" + Email + "',N'" + DiaChi + "')");
        }




        public void Update_kh()
        {
            ThucThi("UPDATE KhachHang SET TenKhachHang = N'" + TenKH + "', TaiKhoanKhachHang = N'" + TaiKhoanKhachHang + "',MatKhauKhachHang=N'" + MatKhauKhachHang + "',SDT=N'" +SDT+ "',Email=N'"  +Email+ "',DiaChi =N'"+ DiaChi    + "' WHERE MaKH = N'" + MaKH + "'");

        }

        public void Delete_kh()
        {
            ThucThi("delete KhachHang where MaKH='" + MaKH + "'");

        }
    }
}

