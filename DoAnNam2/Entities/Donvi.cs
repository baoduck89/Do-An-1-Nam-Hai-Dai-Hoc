using System;
using System.Collections.Generic;
using System.Text;

namespace DoAnNam2.Entities
{
    public class Donvi
    {
        string maDV;
        string tenDV;


        public Donvi(string maDV, string tenDV)
        {
            this.maDV = maDV;
            this.tenDV = tenDV;
        }
        public Donvi(Donvi dv)
        {

        }

        public Donvi()
        {
        }

        public string MaDV
        {
            get { return maDV; }
            set
            {
                if (!string.IsNullOrEmpty(value) && value.Length <= 4)
                    maDV = value;
            }
        }
        public string TenDV
        {
            get { return tenDV; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    tenDV = value;
            }
        }


    }
}




