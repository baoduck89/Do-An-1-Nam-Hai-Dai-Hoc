using System;
using System.Collections.Generic;
using System.Text;

namespace DoAnNam2.Entities
{
    public class Donvi
    {
        string maDV;
        string tenDV;
        private Donvi donvi;

        public Donvi()
        {

        }

        public Donvi(Donvi donvi)
        {
            this.donvi = donvi;
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
    
    
    

    