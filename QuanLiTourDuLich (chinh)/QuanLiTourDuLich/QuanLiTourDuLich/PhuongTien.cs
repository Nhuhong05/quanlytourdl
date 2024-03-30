using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiTourDuLich
{
    internal class PhuongTien : Connectdata
    {
        public string MaPhuongTien, TenPhuongTien;
        public string maphuongtien { get { return MaPhuongTien; } set { MaPhuongTien = value; } }
        public string tenphuongtien { get { return TenPhuongTien; } set { TenPhuongTien = value; } }

        public PhuongTien(string maPhuongTien, string tenPhuongTien)
        {
            MaPhuongTien = maPhuongTien;
            TenPhuongTien = tenPhuongTien;
        }

        public PhuongTien()
        {
            MaPhuongTien = TenPhuongTien = "";
        }
        public void ThucThi(string CauLenh_ThucThi)
        {
            Comm = new SqlCommand(CauLenh_ThucThi, Conn);
            Comm.ExecuteNonQuery();
        }

        public void Insert_pt()
        {
            ThucThi("insert into PhuongTien values(N'" + MaPhuongTien + "',N'" + TenPhuongTien  + "')");
        }

        public void Update_pt()
        {
            ThucThi("UPDATE PhuongTien SET TenPhuongTien = N'" + TenPhuongTien + "' WHERE MaPhuongTien = N'" + MaPhuongTien + "'");


        }
        public void Delete_pt()
        {
            ThucThi("delete PhuongTien where MaPhuongTien='" + MaPhuongTien + "'");

        }
    }
}
