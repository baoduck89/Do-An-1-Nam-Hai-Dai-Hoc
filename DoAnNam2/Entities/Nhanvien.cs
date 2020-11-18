using System;
using System.Collections.Generic;
using System.Text;

namespace DoAnNam2.Entities
{
     public class Nhanvien
    {
        string manv;
        string tennv, gioitinh;
        DateTime ngaysinh, ngayvaolv;
        private Nhanvien nhanvien;

        public Nhanvien()
        {
        }

        public Nhanvien(Nhanvien nhanvien)
        {
            this.nhanvien = nhanvien;
        }

        public Nhanvien(string manv, string tennv, string gioitinh, DateTime ngaysinh, DateTime ngayvaolv)
        {
            this.manv = Manv;
            this.tennv = Tennv;
            this.gioitinh = Gioitinh;
            this.ngaysinh = Ngaysinh;
            this.ngayvaolv = Ngayvaolv;
        }

        public string Manv { get => manv; set => manv = value; }
        public string Tennv { get => tennv; set => tennv = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }
        public DateTime Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public DateTime Ngayvaolv { get => ngayvaolv; set => ngayvaolv = value; }
    }
}
