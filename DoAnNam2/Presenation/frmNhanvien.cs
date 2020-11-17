using System;
using System.Collections.Generic;
using System.Text;
using DoAnNam2.Bussiness;
using DoAnNam2.Data;

namespace DoAnNam2.Presenation
{
    class frmNhanvien
    {
        public class FrmNhanvien
        {
            private INhanvienBLL nvDLL = new NhanvienBLL();
            public void Nhap()
            {
                Console.Clear();
                Console.WriteLine("NHAP THONG TIN SAN PHAM");
                Nhanvien nv = new Nhanvien();
                Console.Write("Nhap ten san pham:"); sp.TenSanPham = Console.ReadLine();
                Console.Write("Nhap gia san pham:"); sp.DonGia = int.Parse(Console.ReadLine());
                nvDLL.ThemSanPham(nv);
            }
            public void Hien()
            {
                Console.Clear();
                Console.WriteLine("HIEN THI THONG TIN NHAN VIEN");
                List<Nhanvien> list = nvDLL.GetAllSanPham();
                foreach (var sp in list)
                    Console.WriteLine(sp.MaSanPham + "\t" + sp.TenSanPham + "\t" + sp.DonGia);
            }
            
            public void Menu()
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("QUAN LY THONG TIN SAN PHAM");
                    Console.WriteLine(" F1.Nhap san pham ");
                    Console.WriteLine(" F2.Sua san pham ");
                    Console.WriteLine(" F3.Xoa san pham ");
                    Console.WriteLine(" F4.Hien danh sach ");
                    Console.WriteLine(" F5.Kim kiem ");
                    Console.WriteLine(" F6.Back ");
                    ConsoleKeyInfo kt = Console.ReadKey();
                    switch (kt.Key)
                    {
                        case ConsoleKey.F1:
                            Nhap();
                            Hien();
                            Console.WriteLine("Nhap phim bat ky de tiep tuc...");
                            Console.ReadKey();
                            break;
                        case ConsoleKey.F4:
                            Hien();
                            Console.WriteLine("Nhap phim bat ky de tiep tuc...");
                            Console.ReadKey();
                            break;
                        case ConsoleKey.F2:
                            Sua();
                            Hien();
                            Console.WriteLine("Nhap phim bat ky de tiep tuc...");
                            Console.ReadKey();
                            break;
                        case ConsoleKey.F6:
                            Program.Menu();
                            break;
                    }
                } while (true);
            }
        }
    }

}
}
