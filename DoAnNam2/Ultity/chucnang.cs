using System;
using System.Collections.Generic;
using System.Text;
using DoAnNam2.Bussiness;
using DoAnNam2.Data.DTO;
using DoAnNam2.Data;
namespace DoAnNam2.Ultity
{
    class chucnang
    {
        NhanvienBLL nv = new NhanvienBLL();  
            public void menu()
            {
                Console.WriteLine("1.Xem danh sach san pham");
                Console.WriteLine("2.Them danh sach san pham");
                Console.WriteLine("3.Xoa danh sach san pham");
                Console.WriteLine("4.Tim kiem danh sach san pham");
                Console.WriteLine("5.Tinh tien luong");
                string ht = Console.ReadLine();
                Console.Clear();
                if (ht == "1")
                {
                    hienthi();
                }
                if (ht == "2")
                {
                    them();
                }

            }
            public void them()
            {
                Console.WriteLine("_________MỜI BẠN NHẬP THÔNG TIN _________");
                Console.Write("Nhap ma nhan vien: ");
                int manv = int.Parse(Console.ReadLine());
                Console.Write("Nhap ten nhanvien: ");
                string tennv = Console.ReadLine();
                Console.Write("Nhap gioi tinh: ");
                string gioitinh = Console.ReadLine();
                Console.Write("Nhap ngay sinh: ");
                DateTime ngaysinh = DateTime.Parse(Console.ReadLine());
                Console.Write("Ngay vao lam viec: ");
                DateTime ngayvaolv = DateTime.Parse(Console.ReadLine());

                Nhanvien nv1 = new Nhanvien(manv,tennv,gioitinh,ngaysinh,ngayvaolv);
                nv.add(nv1);
                hienthi();
            }
            public void hienthi()
            {
                Console.WriteLine("Danh sach san pham");
                nv.hienthi();
                Console.WriteLine("An phim bat ki de quay lai");
                Console.ReadKey();
                Console.Clear();
                menu();
            }
        }
    }

