using System;
using System.Collections.Generic;
using System.Text;
using DoAnNam2.Bussiness.Interface;

namespace DoAnNam2.Bussiness
{
    public class NhanvienBLL : INhanvienBLL
    {
        private ISanPhamDAL hsDA = new SanPhamDAL();
        //Thực thi các yêu cầu
        public List<SanPham> GetAllSanPham()
        {
            return hsDA.GetAllSanPham();
        }
        public void ThemSanPham(SanPham sp)
        {
            if (!string.IsNullOrEmpty(sp.TenSanPham))
            {
                //Tiến hành chuẩn hóa dữ liệu nếu cần
                hsDA.ThemSanPham(sp);
            }
            else
                throw new Exception("Du lieu sai");
        }

        public void XoaSanPham(string masanpham)
        {
            int i;
            List<SanPham> list = GetAllSanPham();
            for (i = 0; i < list.Count; ++i)
                if (list[i].MaSanPham == masanpham) break;
            if (i < list.Count)
            {
                list.RemoveAt(i);
                hsDA.Update(list);
            }
            else
                throw new Exception("Khong ton tai ma nay");
        }
        public void SuaSanPham(SanPham sp)
        {
            int i;
            List<SanPham> list = GetAllSanPham();
            for (i = 0; i < list.Count; ++i)
                if (list[i].MaSanPham == sp.MaSanPham) break;
            if (i < list.Count)
            {
                list.RemoveAt(i);
                list.Add(sp);
                hsDA.Update(list);
            }
            else
                throw new Exception("Khong ton tai hs nay");
        }
        public List<SanPham> TimSanPham(SanPham sp)
        {
            List<SanPham> list = GetAllSanPham();
            List<SanPham> kq = new List<SanPham>();
            if (string.IsNullOrEmpty(sp.MaSanPham) &&
                string.IsNullOrEmpty(sp.TenSanPham) &&
                sp.DonGia == 0)
            {
                kq = list;
            }
            //Tim theo ten sp
            if (!string.IsNullOrEmpty(sp.TenSanPham))
            {
                for (int i = 0; i < list.Count; ++i)
                    if (list[i].TenSanPham.IndexOf(sp.TenSanPham) >= 0)
                    {
                        kq.Add(new SanPham(list[i]));
                    }
            }

            //Tim theo gia
            else if (sp.DonGia > 0)
            {
                for (int i = 0; i < list.Count; ++i)
                    if (list[i].DonGia == sp.DonGia)
                    {
                        kq.Add(new SanPham(list[i]));
                    }
            }
            else kq = null;
            return kq;
        }
    }
}