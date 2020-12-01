using System;
using System.Collections.Generic;
using System.Text;
using DoAnNam2.Entities;
using System.IO;

namespace DoAnNam2.DataAccessLayer
{
    class DonviDAL:IDonviDAL
    {

        private string txtfile = "Data/Donvi.txt";

        public List<Donvi> GetAllDonvi()
        {
            List<Donvi> list = new List<Donvi>();
            StreamReader fread = File.OpenText(txtfile);
            string s = fread.ReadLine();
            while (s != null)
            {
                if (s != "")
                {
                    string[] a = s.Split('#');
                    list.Add(new Donvi(a[0], a[1] ));
                }
                s = fread.ReadLine();
            }
            fread.Close();
            return list;
        }

        public void ThemDonvi(Donvi dv)
        {
            string maDV = "DV" + DateTime.Now.ToString("yyMMddhhmmss");
            StreamWriter fwrite = File.AppendText(txtfile);
            fwrite.WriteLine();
            fwrite.WriteLine(dv.MaDV + "#" + dv.TenDV );
            fwrite.Close();
        }

        public void Update(List<Donvi> list)
        {
            StreamWriter fwrite = File.CreateText(txtfile);
            for (int i = 0; i < list.Count; ++i)
                fwrite.WriteLine(list[i].MaDV + "#" + list[i].TenDV );
            fwrite.Close();
        }
    }
}

