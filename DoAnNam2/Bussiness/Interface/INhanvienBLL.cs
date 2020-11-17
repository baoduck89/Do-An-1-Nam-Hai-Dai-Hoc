using System;
using System.Collections.Generic;
using System.Text;
using DoAnNam2.Entities;

namespace DoAnNam2.Bussiness.Interface
{

    public interface ISanPhamBLL
    {
        List<Nhanvien> GetAllNhanvien();
        void ThemSanPham(Nhanvien nv);
        void XoaSanPham(string manv);
        void SuaSanPham(Nhanvien nv);
        List<Nhanvien> TimSanPham(Nhanvien nv);
    }
}
