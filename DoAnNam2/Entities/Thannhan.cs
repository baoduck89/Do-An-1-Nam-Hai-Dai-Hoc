using System;
using System.Collections.Generic;
using System.Text;

namespace DoAnNam2.Entities
{
    public class Thannhan
    {
        string matn;
        string tenTN, gioitinh;

        public Thannhan()
        {
        }

        public Thannhan(Thannhan tn)
        {

        }

        public Thannhan(string matn, string tenTN, string gioitinh)
        {
            this.matn = matn;
            this.tenTN = tenTN;
            this.gioitinh = gioitinh;

        }
        public string TenTN
        {
            get { return tenTN; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    tenTN = value;
            }
        }
        public string Gioitinh
        {
            get { return gioitinh; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    gioitinh = value;
            }
        }
        public string maTN
        {
            get { return matn; }
            set
            {
                if (!string.IsNullOrEmpty(value) && value.Length <= 4)
                    matn = value;
            }
        }
    }
}