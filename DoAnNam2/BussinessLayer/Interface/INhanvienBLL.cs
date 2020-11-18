using System;
using System.Collections.Generic;
using System.Text;
using DoAnNam2.Entities;

namespace DoAnNam2.BussinessLayer
{

    public interface INhanvienBLL
    {
        List<Nhanvien> GetAllNhanvien();
        void ThemNhanVien(Nhanvien nv);
        void XoaNhanVien(string manv);
        void SuaNhanVien(Nhanvien nv);
        List<Nhanvien> TimNhanVien(Nhanvien nv);
        List<Nhanvien> GetAllNhanVien();
    }
}
