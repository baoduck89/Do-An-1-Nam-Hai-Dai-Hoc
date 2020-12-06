using System;
using System.Collections.Generic;
using System.Text;

namespace DoAnNam2.Entities
{
     public class Thannhan
    {
        string matn;
        string tenTN, gioitinh;
        DateTime ngaysinh;
        private Thannhan thannhan;

        public Thannhan()
        {

        }

        public Thannhan(Thannhan thannhan)
        {
            this.thannhan = thannhan;
        }

        public Thannhan(string manv,string tenTN,  string gioitinh,DateTime ngaysinh)
        {
            this.matn = manv;
            this.tenTN = tenTN;
            this.gioitinh = gioitinh;
            this.ngaysinh = ngaysinh;
        }
        public string maTN { get => matn; set => matn = value; }
        public string TenTN { get => tenTN; set => tenTN = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }
        public DateTime Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        

    }
}
