using DoAnNam2.Entities;
using System;
using System.Collections.Generic;
using DoAnNam2.BussinessLayer;
using System.Text;

namespace DoAnNam2.BussinessLayer
{
    public interface IThannhanBLL
    {
        List<Thannhan> GetAllThannhan();
        void ThemThannhan(Thannhan tn);
        void XoaThannhan(string maTN);
        void SuaThannhanh(Thannhan tn);
        List<Thannhan> TimThannhan(Thannhan tn);       
    }
}

   
