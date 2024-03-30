using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiTourDuLich
{
    public static class HashHelper
    {
        public static string GetMd5Hash(string input)
        {
            using (MD5 md5Hash = MD5.Create())
            {
                // Chuyển đổi chuỗi đầu vào thành một mảng byte và tính toán hàm băm.
                byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

                // Tạo một StringBuilder mới để thu thập các byte
                // và tạo một chuỗi.
                StringBuilder sBuilder = new StringBuilder();

                // Lặp qua từng byte của dữ liệu đã băm
                // và định dạng mỗi cái dưới dạng chuỗi thập lục phân.
                for (int i = 0; i < data.Length; i++)
                {
                    sBuilder.Append(data[i].ToString("x2"));
                }

                // Trả về chuỗi thập lục phân.
                return sBuilder.ToString();
            }
        }

        public static bool VerifyMd5Hash(string input, string hash)
        {
            // Hash the input.
            string hashOfInput = GetMd5Hash(input);

            // Tạo một StringComparer để so sánh các giá trị băm.
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;

            if (0 == comparer.Compare(hashOfInput, hash))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
