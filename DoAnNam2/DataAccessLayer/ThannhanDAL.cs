using System;
using System.Collections.Generic;
using System.Text;
using DoAnNam2.Entities;
using System.IO;

namespace DoAnNam2.DataAccessLayer
{
    class ThannhanDAL : IThannhanDAL
    {

        private string txtfile = "Data/Thannhan.txt";

        public List<Thannhan> GetAllThannhan()
        {
            List<Thannhan> list = new List<Thannhan>();
            StreamReader fread = File.OpenText(txtfile);
            string s = fread.ReadLine();
            while (s != null)
            {
                if (s != "")
                {
                    string[] a = s.Split('#');
                    list.Add(new Thannhan(a[0], a[1], a[2], DateTime.Parse(a[3])));
                }
                s = fread.ReadLine();
            }
            fread.Close();
            return list;
        }

        public void ThemThannhan(Thannhan tn)
        {
            string manv = "NV" + DateTime.Now.ToString("yyMMddhhmmss");
            StreamWriter fwrite = File.AppendText(txtfile);
            fwrite.WriteLine();
            fwrite.WriteLine(tn.maNV + "#" + tn.TenTN + "#" + tn.Gioitinh + "#" + tn.Ngaysinh);
            fwrite.Close();
        }

        public void Update(List<Thannhan> list)
        {
            StreamWriter fwrite = File.CreateText(txtfile);
            for (int i = 0; i < list.Count; ++i)
                fwrite.WriteLine(list[i].maNV + "#" + list[i].TenTN + "#" + list[i].Gioitinh + "#" + list[i].Ngaysinh );
            fwrite.Close();
        }
    }
}

