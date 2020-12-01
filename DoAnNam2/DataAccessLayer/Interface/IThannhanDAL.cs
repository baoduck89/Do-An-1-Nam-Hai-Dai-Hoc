using DoAnNam2.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DoAnNam2.DataAccessLayer
{

    public interface IThannhanDAL
    {
        List<Thannhan> GetAllThannhan();
        void ThemThannhan(Thannhan tn);
        void Update(List<Thannhan> list);
    }
}
