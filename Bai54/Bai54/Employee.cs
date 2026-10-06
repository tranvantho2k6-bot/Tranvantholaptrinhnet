using System;

namespace Bai54
{
    public class Employee
    {
        public string MaNV { get; set; }
        public string HoTen { get; set; }
        public string ChucVu { get; set; }
        public DateTime NgayVaoLam { get; set; }

        public Employee(
            string maNV,
            string hoTen,
            string chucVu,
            DateTime ngayVaoLam)
        {
            MaNV = maNV;
            HoTen = hoTen;
            ChucVu = chucVu;
            NgayVaoLam = ngayVaoLam;
        }
    }
}