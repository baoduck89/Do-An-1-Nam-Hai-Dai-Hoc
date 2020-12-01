using DoAnNam2.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DoAnNam2.DataAccessLayer
{

    public interface IDonviDAL
    {
        List<Donvi> GetAllDonvi();
        void ThemDonvi(Donvi dv);
        void Update(List<Donvi> list);
    }
}
