using System;
using System.Collections.Generic;
using System.Text;

namespace DoAnNam2.Entities
{
     public class Tinhluong
    {
        private string MaTL;
        private int SoNgayLV;
        private double Thuong, LuongCoBan;
    }
   
    public Tinhluong(string MaTL,int SoNgayLV,double Thuong,double LuongCoBan)
    {
        this.MaTL = maTL;
        this.SoNgayLV = SoNgayLV;
    }
}
