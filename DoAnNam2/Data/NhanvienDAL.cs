using System;
using System.Collections.Generic;
using System.Text;
using DoAnNam2.Entities;
using System.IO;

namespace DoAnNam2.Data
{
    class NhanvienDAL
    {
        class NhanvienDAL : INhanvienDAL
        {
            //Xác định đường dẫn của tệp dữ liệu SanPham.txt
            private string txtfile = "Data/Nhanvien.txt";
            //Lấy toàn bộ dữ liệu có trong file SanPham.txt đưa vào một danh sách 
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
                        list.Add(new Nhanvien(int.Parse(a[0]), a[1], a[2], DateTime.Parse(a[3]), DateTime.Parse(a[4])));
                    }
                    s = fread.ReadLine();
                }
                fread.Close();
                return list;
            }
            //Chèn một bản ghi học sinh vào tệp
            public void ThemNhanvien(Nhanvien nv)
            {
                string manv = "NV" + DateTime.Now.ToString("yyMMddhhmmss");
                StreamWriter fwrite = File.AppendText(txtfile);
                fwrite.WriteLine();
                fwrite.WriteLine(nv.Manv + "#" + nv.Tennv + "#" + nv.Gioitinh + "#" + nv.Ngaysinh + "#" + nv.Ngayvaolv);
                fwrite.Close();
            }
            //Cập nhật lại danh sách vào tệp        
            public void Update(List<Nhanvien> list)
            {
                StreamWriter fwrite = File.CreateText(txtfile);
                for (int i = 0; i < list.Count; ++i)
                    fwrite.WriteLine(list[i].Manv + "#" + list[i].Tennv + "#" + list[i].Gioitinh + "#" + list[i].Ngaysinh + "#" + list[i].Ngayvaolv);
                fwrite.Close();
            }
        }
    }
}
