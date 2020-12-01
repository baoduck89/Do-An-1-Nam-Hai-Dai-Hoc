using System;
using System.Collections.Generic;
using System.Text;

namespace DoAnNam2.Entities
{
     public class Nhanvien
    {
        string manv;
        string tennv, gioitinh;
        DateTime ngaysinh;
        double luong;
        private Nhanvien nhanvien;

        public Nhanvien()
        {
        }

        public Nhanvien(Nhanvien nhanvien)
        {
            this.nhanvien = nhanvien;
        }

        public Nhanvien(string manv, string tennv, string gioitinh, DateTime ngaysinh, double Luong)
        {
            this.manv = Manv;
            this.tennv = Tennv;
            this.gioitinh = Gioitinh;
            this.ngaysinh = Ngaysinh;
            this.luong = luong;
        }

        public string Manv { get => manv; set => manv = value; }
        public string Tennv { get => tennv; set => tennv = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }
        public DateTime Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public double Luong { get => luong; set => luong = value; }

        internal static List<Nhanvien> TimNhanVien(Nhanvien nhanvien)
        {
            throw new NotImplementedException();
        }
    }
}
