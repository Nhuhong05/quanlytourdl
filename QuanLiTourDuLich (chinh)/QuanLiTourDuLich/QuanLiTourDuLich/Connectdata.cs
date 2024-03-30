using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace QuanLiTourDuLich
{
    public class Connectdata
    {
        public SqlConnection Conn = new SqlConnection();
        public SqlCommand Comm = new SqlCommand();
        public void Conect_QLT()
        {
            Conn = new SqlConnection("Data Source=DESKTOP-9TDF5CQ\\S;Initial Catalog=QuanLiAppDuLich;Integrated Security=True");
            Conn.Open();
        }

        public DataTable layDL(string chonban)
        {
            // datatable tạo ra 1 bản rỗng 
            DataTable dataTable = new DataTable();
            // lệnh chọn dữ liệu 
            Comm = new SqlCommand(chonban, Conn);
            // sqldataadapter lấy cmd
            SqlDataAdapter adapter = new SqlDataAdapter(Comm);

            //adapter truyền dữ liệu vào datatbale 
            adapter.Fill(dataTable);

            return dataTable;

            // tạo 1 bảng  trống  -> chọn bản trong sql -> sao chép dữ liệu -> truyền dữ liệu ->return
        }
        public DataTable LayDL(string CauLenhTruyVan)
        {
            DataTable DT_Ta = new DataTable();
            Comm = new SqlCommand(CauLenhTruyVan, Conn);
            SqlDataAdapter DT_Ap = new SqlDataAdapter(Comm);
            DT_Ap.Fill(DT_Ta);
            return DT_Ta;
        }
        public void Update(string CauLenhCapNhat)
        {
            Comm = new SqlCommand(CauLenhCapNhat, Conn);
            Comm.ExecuteNonQuery();
        }


    }
}