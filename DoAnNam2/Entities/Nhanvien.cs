using System;
using System.Collections.Generic;
using System.Text;


namespace DoAnNam2.Entities
{
    public class Nhanvien
    {
        private string manv;
        private string tennv, gioitinh;
        private string sodienthoai;
        private int snlv;
        private double hsl;
        private double tinhluong;


        public Nhanvien()
        {
        }


        public string Manv
        {
            get { return manv; }
            set
            {
                if (!string.IsNullOrEmpty(value) && value.Length <= 4)
                    manv = value;
            }
        }
        public string Tennv
        {
            get { return tennv; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    tennv = value;
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
        public string SDT
        {
            get { return sodienthoai; }
            set
            {
                if (!string.IsNullOrEmpty(value) && value.Length == 10)
                    sodienthoai = value;
            }
        }
        public int SNLV
        {
            get { return snlv; }
            set
            {
                if (value > 0 && value <= 31)
                    snlv = value;
            }
        }
        public double HSL
        {
            get { return hsl; }
            set
            {
                if (value > 0)
                    hsl = value;
            }
        }
        public double Tinhluong
        {
            get { return SNLV * hsl; }
        }
        public Nhanvien(Nhanvien nv)
        {
            this.Manv = nv.Manv;
            this.tennv = nv.Tennv;
            this.gioitinh = nv.Gioitinh;
            this.SDT = nv.SDT;
            this.snlv = nv.SNLV;
            this.hsl = nv.hsl;
            this.tinhluong = nv.tinhluong;
        }


        public Nhanvien(string Manv, string Tennv, string Gioitinh, string SDT, int SNLV, double hsl, double tinhluong)
        {
            this.Manv = Manv;
            this.Tennv = Tennv;
            this.Gioitinh = Gioitinh;
            this.SDT = SDT;
            this.SNLV = SNLV;
            this.hsl = hsl;
            this.tinhluong = tinhluong;
        }

    }
}