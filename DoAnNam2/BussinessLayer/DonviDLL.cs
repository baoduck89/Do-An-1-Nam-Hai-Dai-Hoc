using System;
using System.Collections.Generic;
using System.Text;
using DoAnNam2.Entities;
using DoAnNam2.DataAccessLayer;


namespace DoAnNam2.BussinessLayer
{
    public class DonviBLL: IDonviBLL
    {
        private IDonviDAL dvd = new DonviDAL();
        //Thực thi các yêu cầu
        public List<Donvi> GetAllDonvi()
        {
            return dvd.GetAllDonvi();
        }
        public void ThemDonvi(Donvi dv)
        {
            if (!string.IsNullOrEmpty(dv.TenDV))
            {
                //Tiến hành chuẩn hóa dữ liệu nếu cần
                dvd.ThemDonvi(dv);
            }
            else
                throw new Exception("Du lieu sai");
        }

        public void XoaDonvi(string maDonvi)
        {
            int i;
            List<Donvi> list = GetAllDonvi();
            for (i = 0; i < list.Count; ++i)
                if (list[i].MaDV == maDonvi) break;
            if (i < list.Count)
            {
                list.RemoveAt(i);
                dvd.Update(list);
            }
            else
                throw new Exception("Khong ton tai ma nay");
        }
        public void SuaDonvi(Donvi dv)
        {
            int i;
            List<Donvi> list = GetAllDonvi();
            for (i = 0; i < list.Count; ++i)
                if (list[i].MaDV == dv.MaDV) break;
            if (i < list.Count)
            {
                list.RemoveAt(i);
                list.Add(dv);
                dvd.Update(list);
            }
            else
                throw new Exception("Khong ton tai hs nay");
        }
        public List<Donvi> TimDonvi(Donvi dv)
        {
            List<Donvi> list = GetAllDonvi();
            List<Donvi> kq = new List<Donvi>();
            if (string.IsNullOrEmpty(dv.MaDV) &&
                string.IsNullOrEmpty(dv.TenDV))

            {
                kq = list;
            }
            //Tim theo ten nv
            if (!string.IsNullOrEmpty(dv.TenDV))
            {
                for (int i = 0; i < list.Count; ++i)
                    if (list[i].TenDV.IndexOf(dv.TenDV) >= 0)
                    {
                        kq.Add(new Donvi(list[i]));
                    }
            }
            return kq;

        }
        public List<Donvi> GetAllDonvi()
        {
            throw new NotImplementedException();
        }
    }

}