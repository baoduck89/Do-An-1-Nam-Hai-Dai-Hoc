using System;
using System.Collections.Generic;
using System.Text;

namespace DoAnNam2.Entities
{
     public class Thannhan
    {
        string manv;
        string tenTN, gioitinh;
        DateTime ngaysinh;
        public Thannhan()
        {

        }
        public Thannhan(string manv,string tenTN,  string gioitinh,DateTime ngaysinh)
        {
            this.manv = manv;
            this.tenTN = tenTN;
            this.gioitinh = gioitinh;
            this.ngaysinh = ngaysinh;
        }
        public string maNV { get => manv;set=>manv=value }
        public string TenTN { get => tenTN; set => tenTN = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }
        public DateTime Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        

    }
}
