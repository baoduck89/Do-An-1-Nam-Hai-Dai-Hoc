using System;
using System.Collections.Generic;
using System.Text;
using DoAnNam2.Entities;

namespace DoAnNam2.BussinessLayer
{
    public interface IDonviBLL
    {
        //List<Donvi> GetAllDonvi();       
        void SuaDonVi(Donvi dv);
        List<Donvi> TimDonVi(Donvi dv);       
        void ThemDonvi(Donvi dv);
        void XoaDonvi(string madv);
        List<Donvi> GetAllDonvi();
    }
}
