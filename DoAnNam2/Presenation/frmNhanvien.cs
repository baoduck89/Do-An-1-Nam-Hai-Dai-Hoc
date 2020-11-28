using System;
using System.Collections.Generic;
using System.Text;
using DoAnNam2.BussinessLayer;
using DoAnNam2.DataAccessLayer;
using DoAnNam2.Entities;

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
                Console.WriteLine("NHAP THONG TIN NHAN VIEN");
                Nhanvien nv = new Nhanvien();
                Console.Write("Nhap ma nhan vien:"); nv.Manv = Console.ReadLine();
                Console.Write("Nhap ten nhan vien:"); nv.Tennv = Console.ReadLine();
                Console.Write("Nhap ngay sinh:"); nv.Ngaysinh = DateTime.Parse(Console.ReadLine());
                Console.Write("Nhap gioi tinh:"); nv.Gioitinh = Console.ReadLine();
                Console.Write("Nhap ngay vao lam viec:"); nv.Ngayvaolv = DateTime.Parse(Console.ReadLine());
                nvDLL.ThemNhanVien(nv);
            }
            public void Hien()
            {
                Console.Clear();
                Console.WriteLine("HIEN THI THONG TIN NHAN VIEN");
                List<Nhanvien> list = nvDLL.GetAllNhanvien();
                foreach (var nv in list)
                    Console.WriteLine(nv.Manv + "\t" + nv.Tennv + "\t" + nv.Ngaysinh + "\t" + nv.Gioitinh + "\t" + nv.Ngayvaolv);
            }
            public void Sua()
            {
                Console.Clear();
                Console.WriteLine("SUA THONG TIN NHAN VIEN");
                List<Nhanvien> list = nvDLL.GetAllNhanvien();
                string Tensua;
                Console.Write("NHAP TEN NHAN VIEN CAN SUA:");
                Tensua = Console.ReadLine();
                int i = 0;
                for (i = 0; i < list.Count; ++i)
                {
                    if (list[i].Tennv == Tensua)
                    {
                        if (i < list.Count)
                        {
                            Nhanvien nv = new Nhanvien(list[i]);
                            Console.Write("Nhap ten moi :");
                            string ten = Console.ReadLine();
                            if (!string.IsNullOrEmpty(ten)) nv.Tennv = ten;
                            Console.Write("Nhap ma nhan vien moi:");
                            string ma = Console.ReadLine();
                            if (!string.IsNullOrEmpty(ten)) nv.Manv = ma;
                            Console.Write("Nhap ngay sinh:");
                            DateTime ngay = DateTime.Parse(Console.ReadLine());

                        }
                    }
                    else
                    {
                        Console.WriteLine("khong ton tai ten nhan vien nay");
                    }
                }
            }

            public void Menu()
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("QUAN LY THONG TIN NHAN VIEN");
                    Console.WriteLine(" F1.Nhap nhan vien ");
                    Console.WriteLine(" F2.Sua nhan vien ");
                    Console.WriteLine(" F3.Xoa nhan vien");
                    Console.WriteLine(" F4.Hien danh sach ");
                    Console.WriteLine(" F5.Tim kiem ");
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

        internal void Menu()
        {
            throw new NotImplementedException();
        }
    }
}

        