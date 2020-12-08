using System;
using System.Collections.Generic;
using System.Text;
using DoAnNam2.Entities;
using DoAnNam2.DataAccessLayer;


namespace DoAnNam2.BussinessLayer
{
    public class ThannhanBLL : IThannhanBLL
    {
        private IThannhanDAL tnn = new ThannhanDAL();
        //Thực thi các yêu cầu
        public List<Thannhan> GetAllThannhan()
        {
            return tnn.GetAllThannhan();
        }
        public void ThemThannhan(Thannhan tn)
        {
            if (!string.IsNullOrEmpty(tn.TenTN))
            {
                //Tiến hành chuẩn hóa dữ liệu nếu cần
                tnn.ThemThannhan(tn);
            }
            else
                throw new Exception("Du lieu sai");
        }

        public void XoaThannhan(string maThannhan)
        {
            int i;
            List<Thannhan> list = GetAllThannhan();
            for (i = 0; i < list.Count; ++i)
                if (list[i].maTN == maThannhan) break;
            if (i < list.Count)
            {
                list.RemoveAt(i);
                tnn.Update(list);
            }
            else
                throw new Exception("Khong ton tai ma nay");
        }
        public void SuaThannhan(Thannhan tn)
        {
            int i;
            List<Thannhan> list = GetAllThannhan();
            for (i = 0; i < list.Count; ++i)
                if (list[i].maTN == tn.maTN) break;
            if (i < list.Count)
            {
                list.RemoveAt(i);
                list.Add(tn);
                tnn.Update(list);
            }
            else
                throw new Exception("Khong ton tai hs nay");
        }
        public List<Thannhan> TimThannhan(Thannhan tn)
        {
            List<Thannhan> list = GetAllThannhan();
            List<Thannhan> kq = new List<Thannhan>();
            if (string.IsNullOrEmpty(tn.maTN) &&
                string.IsNullOrEmpty(tn.TenTN))

            {
                kq = list;
            }
            //Tim theo ten nv
            if (!string.IsNullOrEmpty(tn.TenTN))
            {
                for (int i = 0; i < list.Count; ++i)
                    if (list[i].TenTN.IndexOf(tn.TenTN) >= 0)
                    {
                        kq.Add(new Thannhan(list[i]));
                    }
            }
            return kq;

        }      

        public void SuaThannhanh(Thannhan tn)
        {
            throw new NotImplementedException();
        }
    }

}