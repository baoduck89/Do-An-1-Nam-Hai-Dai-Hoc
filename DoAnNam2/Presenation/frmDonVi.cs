using System;
using System.Collections.Generic;
using System.Text;
using DoAnNam2.BussinessLayer;
using DoAnNam2.DataAccessLayer;
using DoAnNam2.Entities;


namespace DoAnNam2.Presenation
{
    public class FrmDonvi
    {
        private IDonviBLL DV = new DonviBLL();
        public void Nhap()
        {
            Console.Clear();
            Console.SetCursorPosition(25, 5); Console.WriteLine("-----------------------------------------------------------------------------");
            Console.SetCursorPosition(25, 6); Console.WriteLine("|                        Them thong tin don vi                               |");
            Console.SetCursorPosition(25, 7); Console.WriteLine("|----------------------------------------------------------------------------|");
            Console.SetCursorPosition(25, 19); Console.WriteLine("----------------------------------------------------------------------------");
            Donvi dv = new Donvi();
            Console.SetCursorPosition(27, 8); Console.Write("Nhap ma don vi:"); dv.MaDV = Console.ReadLine();
            Console.SetCursorPosition(27, 10); Console.Write("Nhap ten don vi:"); dv.TenDV = Console.ReadLine();
            DV.ThemDonvi(dv);
        }
        public void Hien()
        {
            Console.Clear();
            Console.SetCursorPosition(9, 5); Console.WriteLine("---------------------------------------------------------------------------------------------------------");
            Console.SetCursorPosition(9, 6); Console.WriteLine("|                                        Hien thong tin don vi                                       |");
            Console.SetCursorPosition(9, 7); Console.WriteLine("|-------------------------------------------------------------------------------------------------------|");
            Console.SetCursorPosition(9, 8); Console.WriteLine("|                        Ma don vi                    |                  Ten don vi                     |  ");
            Console.SetCursorPosition(9, 9); Console.WriteLine("|-----------------------------------------------------|-------------------------------------------------|");
            List<Donvi> list = DV.GetAllDonvi();
            foreach (var dv in list)
                Console.WriteLine("\t" + "\t" + "\t" + "\t" + "\t" + "|" + dv.MaDV + "|" + "\t" + "\t" + "\t" + "\t" + "\t" + "\t" + dv.TenDV + "|");
        }
        public void Sua()
        {
            Console.Clear();
            Console.SetCursorPosition(25, 5); Console.WriteLine("-----------------------------------------------------------------------------");
            Console.SetCursorPosition(25, 6); Console.WriteLine("|                          Sua thong tin don vi                             |");
            Console.SetCursorPosition(25, 7); Console.WriteLine("|---------------------------------------------------------------------------|");
            Console.SetCursorPosition(25, 20); Console.WriteLine("-----------------------------------------------------------------------------");
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
                        Console.SetCursorPosition(27, 17); ; Console.Write("Nhap ten moi :");
                        string ten = Console.ReadLine();
                        if (!string.IsNullOrEmpty(ten)) dv.TenDV = ten;
                        Console.SetCursorPosition(27, 17); Console.Write("Nhap ma  moi:");
                        string ma = Console.ReadLine();
                        if (!string.IsNullOrEmpty(ten)) dv.MaDV = ma;
                        DV.SuaDonVi(dv);
                    }
                }
                else
                {
                    Console.SetCursorPosition(27, 17); Console.WriteLine("khong ton tai ten don vi nay");
                }
            }
        }
        public void Xoa()
        {
            Console.Clear();
            Console.SetCursorPosition(25, 5); Console.WriteLine("-----------------------------------------------------------------------------");
            Console.SetCursorPosition(25, 6); Console.WriteLine("|                           Xoa thong tin don vi                             |");
            Console.SetCursorPosition(25, 7); Console.WriteLine("|----------------------------------------------------------------------------|");
            Console.SetCursorPosition(25, 15); Console.WriteLine("-----------------------------------------------------------------------------");
            List<Donvi> list = DV.GetAllDonvi();
            string Maxoa;
            Console.SetCursorPosition(27, 17); Console.Write("Nhap ma don vi can xoa:");
            Maxoa = Console.ReadLine();
            int i;
            for (i = 0; i < list.Count; ++i)
                if (list[i].MaDV == Maxoa) break;
            if (i < list.Count)
            {
                Console.SetCursorPosition(27, 17); Console.Write("Xoa thanh cong.....");
                DV.XoaDonvi(Maxoa);
                Console.ReadKey();
            }
            else
            {
                Console.SetCursorPosition(27, 17); Console.Write("Khong ton tai ma don vi nay!");
                Console.ReadKey();
            }
        }
        public void Tim()
        {
            Console.Clear();
            Console.SetCursorPosition(9, 5); Console.WriteLine("--------------------------------------------------------------------------------------------------------");
            Console.SetCursorPosition(9, 6); Console.WriteLine("|                                Tim kiem thong tin don vi                                              |");
            Console.SetCursorPosition(9, 7); Console.WriteLine("|-------------------------------------------------------------------------------------------------------|");
            IDonviBLL sp = new DonviBLL();
            List<Donvi> list = sp.TimDonVi(new Donvi());
            string makhach;
            Console.SetCursorPosition(27, 17); Console.Write("Nhap ma don vi can tim:");
            makhach = Console.ReadLine();
            int i;
            for (i = 0; i < list.Count; ++i)
                if (makhach == list[i].MaDV) break;
            if (i < list.Count)
            {
                Console.SetCursorPosition(9, 5); Console.WriteLine("---------------------------------------------------------------------------------------------------------");
                Console.SetCursorPosition(9, 6); Console.WriteLine("|                                        Hien thong tin don vi                                       |");
                Console.SetCursorPosition(9, 7); Console.WriteLine("|-------------------------------------------------------------------------------------------------------|");
                Console.SetCursorPosition(9, 8); Console.WriteLine("|                        Ma don vi                    |                  Ten don vi                     |  ");
                Console.SetCursorPosition(9, 9); Console.WriteLine("|-----------------------------------------------------|-------------------------------------------------|");
                Console.WriteLine("\t" + "\t" + "\t" + "\t" + "\t" + "|" + list[i].MaDV + "|" + "\t" + "\t" + "\t" + "\t" + "\t" + "\t" + list[i].TenDV + "|");
                Console.SetCursorPosition(9, 14); Console.WriteLine("-------------------------------------------------------------------------------------------------------------");
                Console.SetCursorPosition(9, 15); Console.Write(" Nhap phim bat ki de tiep tuc");
                Console.ReadKey();
            }
            else
            {
                Console.SetCursorPosition(9, 11); Console.Write("  Khong ton tai ma don vi nay....");
                Console.SetCursorPosition(9, 15); Console.WriteLine("---------------------------------------------------------------------------------------------------------------");
                Console.SetCursorPosition(47, 11);
                Console.ReadKey();
            }
        }
        public void Menudv()
        {
            do
            {
                Console.Clear();
                Console.SetCursorPosition(20, 5); Console.Write("-----------------------------------------------------------------------------");
                Console.SetCursorPosition(20, 6); Console.Write("|                              Quan Li Nhan Su                              |");
                Console.SetCursorPosition(20, 7); Console.Write("|---------------------------------------------------------------------------|");
                Console.SetCursorPosition(20, 8); Console.Write("|                          QUAN LI THONG TIN DON VI                         |");
                Console.SetCursorPosition(20, 9); Console.Write("|---------------------------------------------------------------------------|");
                Console.SetCursorPosition(20, 10); Console.Write("|     1    |            Them thong tin don vi                              |");
                Console.SetCursorPosition(20, 11); Console.Write("|----------|---------------------------------------------------------------|");
                Console.SetCursorPosition(20, 12); Console.Write("|     2    |           Sua thong tin don vi                                |");
                Console.SetCursorPosition(20, 13); Console.Write("|----------|---------------------------------------------------------------|");
                Console.SetCursorPosition(20, 14); Console.Write("|     3    |            Xoa thong tin don vi                               |");
                Console.SetCursorPosition(20, 15); Console.Write("|----------|---------------------------------------------------------------|");
                Console.SetCursorPosition(20, 16); Console.Write("|     4    |           Hien thong tin don vi                               |");
                Console.SetCursorPosition(20, 17); Console.Write("|----------|---------------------------------------------------------------|");
                Console.SetCursorPosition(20, 18); Console.Write("|     5    |            Tim kiem thong tin don vi                          |");
                Console.SetCursorPosition(20, 19); Console.Write("|----------|---------------------------------------------------------------|");
                Console.SetCursorPosition(20, 20); Console.Write("|     6    |             Quay lai                                          |");
                Console.SetCursorPosition(20, 21); Console.Write("|----------|---------------------------------------------------------------|");
                Console.SetCursorPosition(20, 22); Console.Write("|  Moi ban chon lai chuc nang :                                            |");
                Console.SetCursorPosition(20, 23); Console.Write("|--------------------------------------------------------------------------|");
                Console.SetCursorPosition(48, 22);
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

