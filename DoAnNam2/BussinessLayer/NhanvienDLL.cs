using System;
using System.Collections.Generic;
using System.Text;
using DoAnNam2.Entities;
using DoAnNam2.DataAccessLayer;


namespace DoAnNam2.BussinessLayer
{
    public class NhanvienBLL : INhanvienBLL
    {
        private INhanvienDAL nvB = new NhanvienDAL();
        //Thực thi các yêu cầu
        public List<Nhanvien> GetAllNhanvien()
        {
            return nvB.GetAllNhanvien();
        }
        public void ThemNhanVien(Nhanvien nv)
        {
            if (!string.IsNullOrEmpty(nv.Tennv))
            {
                //Tiến hành chuẩn hóa dữ liệu nếu cần
                nvB.ThemNhanvien(nv);
            }
            else
                throw new Exception("Du lieu sai");
        }

        public void XoaNhanVien(string manhanvien)
        {
            int i;
            List<Nhanvien> list = GetAllNhanvien();
            for (i = 0; i < list.Count; ++i)
                if (list[i].Manv == manhanvien) break;
            if (i < list.Count)
            {
                list.RemoveAt(i);
                nvB.Update(list);
            }
            else
                throw new Exception("Khong ton tai ma nay");
        }
        public void SuaNhanVien(Nhanvien nv)
        {
            int i;
            List<Nhanvien> list = GetAllNhanvien();
            for (i = 0; i < list.Count; ++i)
                if (list[i].Manv == nv.Manv) break;
            if (i < list.Count)
            {
                list.RemoveAt(i);
                list.Add(nv);
                nvB.Update(list);
            }
            else
                throw new Exception("Khong ton tai hs nay");
        }
        //public List<Nhanvien> TimNhanVien(Nhanvien nv)
        //{
        //    List<Nhanvien> list = GetAllNhanvien();
        //    List<Nhanvien> kq = new List<Nhanvien>();
        //    if (string.IsNullOrEmpty(nv.Manv) &&
        //        string.IsNullOrEmpty(nv.Tennv))

        //    {
        //        kq = list;
        //    }
        //    //Tim theo ten nv
        //    if (!string.IsNullOrEmpty(nv.Tennv))
        //    {
        //        for (int i = 0; i < list.Count; ++i)
        //            if (list[i].Tennv.IndexOf(nv.Tennv) >= 0)
        //            {
        //                kq.Add(new Nhanvien(list[i]));
        //            }
        //    }

        //}

        public List<Nhanvien> GetAllNhanVien()
        {
            throw new NotImplementedException();
        }

        List<Nhanvien> INhanvienBLL.TimNhanVien(Nhanvien nv)
        {
            throw new NotImplementedException();
        }
    }
}