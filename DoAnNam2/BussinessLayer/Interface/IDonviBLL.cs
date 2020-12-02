using System;
using System.Collections.Generic;
using System.Text;
using DoAnNam2.Entities;

namespace DoAnNam2.BussinessLayer
{
    public interface IDonviBLL
    {
        List<Donvi> GetAllDonvi();
        void ThemDonVi(Donvi dv);
        void XoaDonVi(string madonvi);
        void SuaDonVi(Donvi dv);
        List<Donvi> TimDonVi(Donvi dv);
        List<Donvi> GetAllDonvi();
    }
}
