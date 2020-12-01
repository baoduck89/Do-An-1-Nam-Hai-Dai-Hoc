using System;
using System.Collections.Generic;
using System.Text;

namespace DoAnNam2.Entities
{
    public class Donvi
    {
        string maDV;
        string tenDV;
        public Donvi()
        {

        }
        public Donvi(string maDV, string tenDV)
        {
            this.maDV = maDV;
            this.tenDV = tenDV;
        }
        public string MaDV { get => maDV; set => maDV = value; }
        public string TenDV { get => tenDV; set => tenDV = value; }
        
    }
}
    
    
    

    