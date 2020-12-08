using System;
using System.Collections.Generic;
using System.Text;


namespace DoAnNam2.Entities
{
    public class Nhanvien
    {
        private string manv;
        private string tennv, gioitinh;
        private DateTime ngaysinh;
        private double snlv;
        private double hsl=500000;
        private Nhanvien nhanvien;

        public Nhanvien()
        {
        }

        public Nhanvien(Nhanvien nhanvien)
        {
            this.nhanvien = nhanvien;
        }

        public Nhanvien(string manv, string tennv, string gioitinh, DateTime ngaysinh, double snlv)
        {
            this.manv = Manv;
            this.tennv = Tennv;
            this.gioitinh = Gioitinh;
            this.ngaysinh = Ngaysinh;           
            this.snlv = SNLV;
        }

        public string Manv { get => manv; set => manv = value; }
        public string Tennv { get => tennv; set => tennv = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }
        public DateTime Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public double SNLV { get => SNLV; set => SNLV = value; }
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
            get { return SNLV * HSL; }
        }

        internal static List<Nhanvien> TimNhanVien(Nhanvien nhanvien)
        {
            throw new NotImplementedException();
        }
    }
}
