using System;
using System.Collections.Generic;
using System.Text;
using DoAnNam2.Data.DTO;
using System.IO;

namespace DoAnNam2.Data
{
    class NhanvienDAL
    {
        private string fileName = "nhanvien.txt";
        private StreamReader sr;
        public NhanvienDAL()
        {
        }
        public List<Nhanvien> docTep()
        {
            sr = new StreamReader(fileName);
            List<Nhanvien> nhanviens = new List<Nhanvien>();
            string r;
            while ((r = sr.ReadLine())
                != null)
            {
                string[] tmp = r.Split('#');
                Nhanvien sanpham = new Nhanvien(int.Parse(tmp[0]), tmp[1], tmp[2], DateTime.Parse(tmp[3]), DateTime.Parse(tmp[4]));
                nhanviens.Add(sanpham);
            }
            sr.Close();
            return nhanviens;
        }
        public void ghitep(List<Nhanvien> nhanviens)
        {
            StreamWriter f = File.CreateText(fileName);
            foreach (Nhanvien nv in nhanviens)
            {
                f.WriteLine(nv.Manv + "#" + nv.Tennv + "#" + nv.Gioitinh + "#" + nv.Ngaysinh + "#" + nv.Ngayvaolv);
                f.Close();
            }
        }
    }
}

