using System;
using System.Collections.Generic;
using System.Text;
using DoAnNam2.Data.DTO;
using DoAnNam2.Data;

namespace DoAnNam2.Bussiness
{
    class NhanvienBLL
    {
            NhanvienDAL sp = new NhanvienDAL();
            List<Nhanvien> nhanviens;
            public void hienthi()
            {
                nhanviens = sp.docTep();
                foreach (Nhanvien nv in nhanviens)
                {
                Console.WriteLine(nv.Manv + "\t" + nv.Tennv + "\t" + nv.Gioitinh +
                    "\t" + nv.Ngaysinh + "\t" + nv.Ngayvaolv);
            }
            }
            public void add(Nhanvien tmp)
            {
                NhanvienDAL vien = new NhanvienDAL();
                nhanviens = vien.docTep();
                nhanviens.Add(tmp);
                sp.ghitep(nhanviens);
            }
        }
}
