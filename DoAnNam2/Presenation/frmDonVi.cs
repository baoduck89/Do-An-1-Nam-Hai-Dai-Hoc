using System;
using System.Collections.Generic;
using System.Text;
using DoAnNam2.BussinessLayer;
using DoAnNam2.DataAccessLayer;
using DoAnNam2.Entities;


namespace DoAnNam2.Presenation
{
    class frmDonvi
    {
        public class FrmDonvi
        {
            private IDonviBLL DV = new DonviBLL();
            public void Nhap()
            {
                Console.Clear();
                Console.WriteLine("NHAP THONG TIN NHAN VIEN");
                Donvi dv = new Donvi();
                Console.Write("Nhap ma don vi:"); dv.MaDV = Console.ReadLine();
                Console.Write("Nhap ten nhan vien:"); dv.TenDV = Console.ReadLine();
                DV.ThemDonvi(dv);
            }
            public void Hien()
            {
                Console.Clear();
                Console.WriteLine("HIEN THI THONG TIN NHAN VIEN");
                List<Donvi> list = DV.GetAllDonvi();
                foreach (var dv in list)
                    Console.WriteLine(dv.MaDV + "\t" + dv.TenDV);
            }
            public void Sua()
            {
                Console.Clear();
                Console.WriteLine("SUA THONG TIN DON VI");
                List<Donvi> list = DV.GetAllDonvi();
                string Tensua;
                Console.Write("NHAP TEN DON VI CAN SUA:");
                Tensua = Console.ReadLine();
                int i = 0;
                for (i = 0; i < list.Count; ++i)
                {
                    if (list[i].TenDV == Tensua)
                    {
                        if (i < list.Count)
                        {
                            Donvi dv = new Donvi(list[i]);
                            Console.Write("Nhap ten moi :");
                            string ten = Console.ReadLine();
                            if (!string.IsNullOrEmpty(ten)) dv.TenDV = ten;
                            Console.Write("Nhap ma  moi:");
                            string ma = Console.ReadLine();
                            if (!string.IsNullOrEmpty(ten)) dv.TenDV = ma;
                        }
                    }
                    else
                    {
                        Console.WriteLine("khong ton tai ten don vi nay");
                    }
                }
            }
            public void Xoa()
            {
                Console.Clear();
                Console.WriteLine("Xoa thong tin don vi");
                List<Donvi> list = DV.GetAllDonvi();
                string Maxoa;
                Console.Write("Nhap ma don vi can xoa:");
                Maxoa = Console.ReadLine();
                int i;
                for (i = 0; i < list.Count; ++i)
                    if (list[i].MaDV == Maxoa) break;
                if (i < list.Count)
                {
                    Console.Write("Xoa thanh cong.....");
                    DV.XoaDonvi(Maxoa);
                    Console.ReadKey();
                }
                else
                {
                    Console.Write("Khong ton tai ma nhan vien nay!");
                    Console.ReadKey();
                }
            }
            public void Tim()
            {
                Console.Clear();
                List<Donvi> list = Donvi.TimDonvi(new Donvi());
                string makhach;
                Console.Write("Nhap ma nhan vien can tim:");
                makhach = Console.ReadLine();
                for (int i = 0; i < list.Count; ++i)
                {
                    if (makhach == list[i].MaDV)
                        Console.WriteLine(list[i].MaDV + "\t" + list[i].TenDV);
                }
            }
            public void Menu1()
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("QUAN LY THONG TIN DON VI");
                    Console.WriteLine(" F1.Nhap don vi  ");
                    Console.WriteLine(" F2.Sua don vi ");
                    Console.WriteLine(" F3.Xoa don vi");
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
                        case ConsoleKey.F2:
                            Sua();
                            Hien();
                            Console.WriteLine("Nhap phim bat ky de tiep tuc...");
                            Console.ReadKey();
                            break;
                        case ConsoleKey.F3:
                            Xoa();
                            Hien();
                            Console.WriteLine("Nhan phim bat ki de tiep tuc");
                            Console.ReadKey();
                            break;
                        case ConsoleKey.F4:
                            Hien();
                            Console.WriteLine("Nhap phim bat ky de tiep tuc...");
                            Console.ReadKey();
                            break;
                        case ConsoleKey.F5:
                            Tim();
                            Console.WriteLine("Nhan phim bat ki de tiep tuc");
                            Console.ReadKey();
                            break;
                        case ConsoleKey.F6:
                            Program.Menu();
                            break;
                    }
                } while (true);
            }
        }

        internal void Menu2()
        {
            throw new NotImplementedException();
        }

        internal void Menu1()
        {
            throw new NotImplementedException();
        }
    }
}

