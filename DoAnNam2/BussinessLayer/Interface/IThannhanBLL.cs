using DoAnNam2.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DoAnNam2.BussinessLayer.Interface
{
    public interface IThannhanBLL
    {
        List<Thannhan> GetAllThannhan();
        void ThemThannhan(Thannhan tn);
        void XoaThannhan(string maTN);
        void SuaThannhanh(Thannhan tn);
        List<Thannhan> TimThannhan(Thannhan nv);
        List<Thannhan> GetAllThannhan();
    }
}

   
