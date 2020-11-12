using System;
using System.Collections.Generic;
using System.Text;

namespace DoAnNam2.Data.DTO
{

    public interface INhanvienDAL
    {
        List<Nhanvien> GetAllSanPham();
        void ThemSanPham(Nhanvien nvs);
        void Update(List<Nhanvien> list);
    }
}
