using System;
using System.Collections.Generic;
using System.Text;
using DoAnNam2.BussinessLayer;
using DoAnNam2.DataAccessLayer;
using DoAnNam2.Entities;


namespace DoAnNam2.Presenation
{
    public class frmNhanvien
    {


        public INhanvienBLL nvDLL = new NhanvienBLL();
        public void Nhap()
        {
            Console.Clear();
            Console.SetCursorPosition(25, 5); Console.WriteLine("-----------------------------------------------------------------------------");
            Console.SetCursorPosition(25, 6); Console.WriteLine("|                        Them thong tin nhan vien                            |");
            Console.SetCursorPosition(25, 7); Console.WriteLine("|----------------------------------------------------------------------------|");
            Console.SetCursorPosition(25, 19); Console.WriteLine("----------------------------------------------------------------------------");
            Nhanvien nv = new Nhanvien();
            Console.SetCursorPosition(27, 9); Console.Write("Nhap ma nhan vien:"); nv.Manv = Console.ReadLine();
            Console.SetCursorPosition(27, 10); Console.Write("Nhap ten nhan vien:"); nv.Tennv = Console.ReadLine();
            Console.SetCursorPosition(27, 11); Console.Write("Nhap SDT:"); nv.SDT = nv.SDT = Console.ReadLine();
            Console.SetCursorPosition(27, 12); Console.Write("Nhap gioi tinh:"); nv.Gioitinh = Console.ReadLine();
            Console.SetCursorPosition(27, 13); Console.Write("Nhap  so ngay lam viec:"); nv.SNLV = int.Parse(Console.ReadLine());
            Console.SetCursorPosition(27, 14); Console.Write("Nhap he so luong:"); nv.HSL = double.Parse(Console.ReadLine());
            nvDLL.ThemNhanVien(nv);
        }
        public void Hien()
        {
            Console.Clear();
            Console.WriteLine("HIEN THI THONG TIN NHAN VIEN");
            List<Nhanvien> list = nvDLL.GetAllNhanvien();
            Console.SetCursorPosition(9, 5); Console.WriteLine("---------------------------------------------------------------------------------------------------------");
            Console.SetCursorPosition(9, 6); Console.WriteLine("|                                        Hien thong tin nhan vien                                       |");
            Console.SetCursorPosition(9, 7); Console.WriteLine("|-------------|----------------------|-----------------|--------------------|--------------|------------|");
            Console.SetCursorPosition(9, 8); Console.WriteLine("| Ma nhan vien|    Ten nhan vien     |    Gioi tinh    |     Ngay sinh      |   He so luong|  Tien luong |");
            Console.SetCursorPosition(9, 9); Console.WriteLine("|-------------|----------------------|-----------------|--------------------|--------------|-------------|");
            foreach (var nv in list)
                Console.WriteLine("\t |" + nv.Manv + "\t |   " + nv.Tennv + "\t |           |  " + nv.SNLV + "\t |  " + nv.HSL + nv.Tinhluong + "\t | ");
            Console.Write("          Nhan phim bat ki de tiep tuc...");
        }
        public void Sua()
        {
            Console.Clear();
            Console.SetCursorPosition(25, 5); Console.WriteLine("-----------------------------------------------------------------------------");
            Console.SetCursorPosition(25, 6); Console.WriteLine("|                          Sua thong tin nhan vien                          |");
            Console.SetCursorPosition(25, 7); Console.WriteLine("|---------------------------------------------------------------------------|");
            Console.SetCursorPosition(25, 20); Console.WriteLine("-----------------------------------------------------------------------------");
            List<Nhanvien> list = nvDLL.GetAllNhanvien();
            string Tensua;
            Console.SetCursorPosition(27, 9); Console.Write("NHAP TEN NHAN VIEN CAN SUA:");
            Tensua = Console.ReadLine();
            int i = 0;
            for (i = 0; i < list.Count; ++i)
            {
                if (list[i].Tennv == Tensua)
                {
                    if (i < list.Count)
                    {
                        Nhanvien nv = new Nhanvien(list[i]);
                        Console.SetCursorPosition(27, 17); Console.Write("Nhap ten moi :");
                        string ten = Console.ReadLine();
                        if (!string.IsNullOrEmpty(ten)) nv.Tennv = ten;
                        Console.SetCursorPosition(27, 17); Console.Write("Nhap ma nhan vien moi:");
                        string ma = Console.ReadLine();
                        if (!string.IsNullOrEmpty(ten)) nv.Manv = ma;
                        Console.SetCursorPosition(27, 15); Console.Write("Nhap so dien thoai moi :");
                        string sdt = Console.ReadLine();
                        if (!string.IsNullOrEmpty(sdt)) nv.SDT = sdt;
                        Console.SetCursorPosition(27, 17); Console.Write("Nhap so ngay lam viec moi :");
                        int songay = int.Parse(Console.ReadLine());
                        if (songay > 0 && songay <= 30) nv.SNLV = songay;
                        nvDLL.SuaNhanVien(nv);
                    }
                }
                else
                {
                    Console.SetCursorPosition(27, 17); Console.WriteLine("khong ton tai ten nhan vien nay");
                    break;
                }
            }
        }
        public void Xoa()
        {
            Console.Clear();
            Console.SetCursorPosition(25, 5); Console.WriteLine("-----------------------------------------------------------------------------");
            Console.SetCursorPosition(25, 6); Console.WriteLine("|                           Xoa thong tin nhan vien                          |");
            Console.SetCursorPosition(25, 7); Console.WriteLine("|----------------------------------------------------------------------------|");
            Console.SetCursorPosition(25, 15); Console.WriteLine("-----------------------------------------------------------------------------");
            List<Nhanvien> list = nvDLL.GetAllNhanvien();
            string Maxoa;
            Console.SetCursorPosition(27, 17); Console.Write("Nhap ma nhan vien can xoa:");
            Maxoa = Console.ReadLine();
            int i;
            for (i = 0; i < list.Count; ++i)
                if (list[i].Manv == Maxoa) break;
            if (i < list.Count)
            {
                Console.SetCursorPosition(27, 17); Console.Write("Xoa thanh cong.....");
                nvDLL.XoaNhanVien(Maxoa);
                Console.ReadKey();
            }
            else
            {
                Console.SetCursorPosition(27, 17); Console.Write("Khong ton tai ma nhan vien nay!");
                Console.ReadKey();
            }
        }
        public void Tim()
        {
            Console.Clear();
            Console.SetCursorPosition(9, 5); Console.WriteLine("--------------------------------------------------------------------------------------------------------");
            Console.SetCursorPosition(9, 6); Console.WriteLine("|                                Tim kiem thong tin nhan vien                                           |");
            Console.SetCursorPosition(9, 7); Console.WriteLine("|-------------------------------------------------------------------------------------------------------|");
            INhanvienBLL sp = new NhanvienBLL();
            List<Nhanvien> list = sp.TimNhanVien(new Nhanvien());
            string makhach;
            Console.SetCursorPosition(27, 17); Console.Write("Nhap ma nhan vien can tim:");
            makhach = Console.ReadLine();
            int i;
            for (i = 0; i < list.Count; ++i)
                if (makhach == list[i].Manv) break;
            if (i < list.Count)
            {
                Console.SetCursorPosition(9, 9); Console.WriteLine("|                                     Thong tin nhan vien                                            |");
                Console.SetCursorPosition(9, 10); Console.WriteLine("-------------------------------------------------------------------------------------------------------");
                Console.SetCursorPosition(9, 11); Console.WriteLine("║ Ma nhan vien |    Ten nhan vien      |    Gioi tinh   |      Ngay sinh   |    He so luong   |  Tien luong|");
                Console.SetCursorPosition(9, 12); Console.WriteLine("-----------------------------------------------------------------------------------------------------------");
                Console.SetCursorPosition(9, 13); Console.WriteLine("| " + list[i].Manv + "\t |   " + list[i].Tennv + "|  \t" + list[i].SNLV + "\t |  " + list[i].HSL + list[i].Tinhluong + "\t | ");
                Console.SetCursorPosition(9, 14); Console.WriteLine("-------------------------------------------------------------------------------------------------------------");
                Console.SetCursorPosition(9, 15); Console.Write(" Nhap phim bat ki de tiep tuc");
                Console.ReadKey();
            }
            else
            {
                Console.SetCursorPosition(9, 11); Console.Write("  Khong ton tai ma nhan vien nay....");
                Console.SetCursorPosition(9, 15); Console.WriteLine("---------------------------------------------------------------------------------------------------------------");
                Console.SetCursorPosition(47, 11);
                Console.ReadKey();
            }
        }
        public void Menunv()
        {
            do
            {
                Console.Clear();
                Console.SetCursorPosition(20, 5); Console.Write("-----------------------------------------------------------------------------");
                Console.SetCursorPosition(20, 6); Console.Write("|                              Quan Li Nhan Su                              |");
                Console.SetCursorPosition(20, 7); Console.Write("|---------------------------------------------------------------------------|");
                Console.SetCursorPosition(20, 8); Console.Write("|                          QUAN LI THONG TIN NHAN VIEN                      |");
                Console.SetCursorPosition(20, 9); Console.Write("|---------------------------------------------------------------------------|");
                Console.SetCursorPosition(20, 10); Console.Write("|     1    |            Them thong tin nhan vien                           |");
                Console.SetCursorPosition(20, 11); Console.Write("|----------|--------------------------------------------------------------- |");
                Console.SetCursorPosition(20, 12); Console.Write("|     2    |           Sua thong tin nhan vien                              |");
                Console.SetCursorPosition(20, 13); Console.Write("|----------|----------------------------------------------------------------|");
                Console.SetCursorPosition(20, 14); Console.Write("|     3    |            Xoa thong tin nhan vien                             |");
                Console.SetCursorPosition(20, 15); Console.Write("|----------|----------------------------------------------------------------|");
                Console.SetCursorPosition(20, 16); Console.Write("|     4    |           Hien thong tin nhan vien                             |");
                Console.SetCursorPosition(20, 17); Console.Write("|----------|----------------------------------------------------------------|");
                Console.SetCursorPosition(20, 18); Console.Write("|     5    |            Tim kiem thong tin nhan vien                        |");
                Console.SetCursorPosition(20, 19); Console.Write("|----------|----------------------------------------------------------------|");
                Console.SetCursorPosition(20, 20); Console.Write("|     6    |             Quay lai                                           |");
                Console.SetCursorPosition(20, 21); Console.Write("|----------|----------------------------------------------------------------|");
                Console.SetCursorPosition(20, 22); Console.Write("|  Moi ban chon lai chuc nang :                                             |");
                Console.SetCursorPosition(20, 23); Console.Write("|---------------------------------------------------------------------------|");
                Console.SetCursorPosition(52, 22);
                ConsoleKeyInfo kt = Console.ReadKey();
                switch (kt.KeyChar)
                {
                    case '1':
                        Nhap();
                        Hien();
                        Console.ReadKey();
                        break;
                    case '2':
                        Sua();
                        Hien();
                        Console.ReadKey();
                        break;
                    case '3':
                        Xoa();
                        Hien();
                        Console.ReadKey();
                        break;
                    case '4':
                        Hien();
                        Console.ReadKey();
                        break;
                    case '5':
                        Tim();
                        Hien();
                        Console.ReadKey();
                        break;
                    case '6':
                        Menu t = new Menu();
                        t.frm();
                        break;
                }
            } while (true);
        }
    }
}

