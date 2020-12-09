using System;
using System.Collections.Generic;
using System.Text;
using DoAnNam2.Entities;
using System.IO;

namespace DoAnNam2.DataAccessLayer
{   
         class NhanvienDAL : INhanvienDAL
        {
            
            private string txtfile = "Data/Nhanvien.txt";
           
            public List<Nhanvien> GetAllNhanvien()
            {
                List<Nhanvien> list = new List<Nhanvien>();
                StreamReader fread = File.OpenText(txtfile);
                string s = fread.ReadLine();
                while (s != null)
                {
                    if (s != "")
                    {
                        string[] a = s.Split('#');
                        list.Add(new Nhanvien(a[0], a[1], a[2], DateTime.Parse(a[3]), double.Parse(a[4])));
                    }
                    s = fread.ReadLine();
                }
                fread.Close();
                return list;
            }
            
            public void ThemNhanvien(Nhanvien nv)
            {
                string manv = "NV" + DateTime.Now.ToString("yyMMddhhmmss");
                StreamWriter fwrite = File.AppendText(txtfile);
                fwrite.WriteLine();
                fwrite.WriteLine(nv.Manv + "#" + nv.Tennv + "#" + nv.Gioitinh + "#" + nv.Ngaysinh + "#" + nv.SNLV);
                fwrite.Close();
            }
                
            public void Update(List<Nhanvien> list)
            {
                StreamWriter fwrite = File.CreateText(txtfile);
                for (int i = 0; i < list.Count; ++i)
                    fwrite.WriteLine(list[i].Manv + "#" + list[i].Tennv + "#" + list[i].Gioitinh + "#" + list[i].Ngaysinh + "#" + list[i].SNLV);
                fwrite.Close();
            }
        }
    }

