﻿using DoAnNam2.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DoAnNam2.Data.DTO
{

    public interface INhanvienDAL
    {
        List<Nhanvien> GetAllNhanvien();
        void ThemNhanvien(Nhanvien nvs);
        void Update(List<Nhanvien> list);
    }
}
