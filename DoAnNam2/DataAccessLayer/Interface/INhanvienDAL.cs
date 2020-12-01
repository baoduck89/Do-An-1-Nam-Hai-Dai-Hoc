using DoAnNam2.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DoAnNam2.DataAccessLayer
{

    public interface INhanvienDAL
    {
        List<Nhanvien> GetAllNhanvien();
        void ThemNhanvien(Nhanvien nv);
        void Update(List<Nhanvien> list);
    }
}
