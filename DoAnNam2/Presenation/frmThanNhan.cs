using System;
using System.Collections.Generic;
using System.Text;
using DoAnNam2.BussinessLayer.Interface;
using DoAnNam2.DataAccessLayer;
using DoAnNam2.Entities;


namespace DoAnNam2.Presenation
{
    public class FrmThannhan
    {
        public IThannhanBLL TN = new ThannhanBLL();
        public void Nhap()
        {
            Console.Clear();
            Console.SetCursorPosition(25, 5); Console.WriteLine("-----------------------------------------------------------------------------");
            Console.SetCursorPosition(25, 6); Console.WriteLine("|                        Them thong tin than nhan                            |");
            Console.SetCursorPosition(25, 7); Console.WriteLine("|----------------------------------------------------------------------------|");
            Console.SetCursorPosition(25, 19); Console.WriteLine("----------------------------------------------------------------------------");
            Thannhan tn = new Thannhan();
            Console.SetCursorPosition(27, 8); Console.Write("Nhap ma than nhan:"); tn.maTN = Console.ReadLine();
            Console.SetCursorPosition(27, 10); Console.Write("Nhap ten than nhan:"); tn.TenTN = Console.ReadLine();
            Console.SetCursorPosition(27, 12); Console.Write("Nhap gioi tinh:"); tn.Gioitinh = Console.ReadLine();
            TN.ThemThannhan(tn);
        }
        public void Hien()
        {
            Console.Clear();
            Console.WriteLine("HIEN THI THONG TIN THAN NHAN");
            List<Thannhan> list = TN.GetAllThannhan();
            Console.SetCursorPosition(9, 5); Console.WriteLine("------------------------------------------------------------------------------");
            Console.SetCursorPosition(9, 6); Console.WriteLine("|                                        Hien thong tin than nhan           | ");
            Console.SetCursorPosition(9, 7); Console.WriteLine("|----------------------|-------------------------------|--------------------|");
            Console.SetCursorPosition(9, 8); Console.WriteLine("| Ma than nhan         |    Ten than nhan              |       Gioi tinh    |");
            Console.SetCursorPosition(9, 9); Console.WriteLine("|----------------------|-------------------------------|--------------------|");
            foreach (var tn in list)
                Console.WriteLine("\t |" + tn.maTN + "\t |   " + tn.TenTN + "\t |           |  " + tn.Gioitinh + "\t |   ");
            Console.Write("          Nhan phim bat ki de tiep tuc...");
        }
        public void Sua()
        {
            Console.Clear();
            Console.SetCursorPosition(25, 5); Console.WriteLine("-----------------------------------------------------------------------------");
            Console.SetCursorPosition(25, 6); Console.WriteLine("|                          Sua thong tin than nhan                          |");
            Console.SetCursorPosition(25, 7); Console.WriteLine("|---------------------------------------------------------------------------|");
            Console.SetCursorPosition(25, 20); Console.WriteLine("-----------------------------------------------------------------------------");
            List<Thannhan> list = TN.GetAllThannhan();
            string Tensua;
            Console.SetCursorPosition(27, 9); Console.Write("NHAP TEN THAN NHAN CAN SUA:");
            Tensua = Console.ReadLine();
            int i = 0;
            for (i = 0; i < list.Count; ++i)
            {
                if (list[i].TenTN == Tensua)
                {
                    if (i < list.Count)
                    {
                        Thannhan tn = new Thannhan(list[i]);
                        Console.SetCursorPosition(27, 17); Console.Write("Nhap ten moi :");
                        string ten = Console.ReadLine();
                        if (!string.IsNullOrEmpty(ten)) tn.TenTN = ten;
                        Console.SetCursorPosition(27, 17); Console.Write("Nhap ma than nhan moi:");
                        string ma = Console.ReadLine();
                        if (!string.IsNullOrEmpty(ten)) tn.maTN = ma;
                        Console.SetCursorPosition(27, 17); Console.Write("Nhap gioi tinh :");
                        string GT = Console.ReadLine();
                        if (!string.IsNullOrEmpty(GT)) tn.Gioitinh = GT;
                        TN.SuaThannhan(tn);
                    }
                }
                else
                {
                    Console.SetCursorPosition(27, 17); Console.WriteLine("khong ton tai ten than nhan nay");
                }
            }
        }
        public void Xoa()
        {
            Console.Clear();
            Console.SetCursorPosition(25, 5); Console.WriteLine("-----------------------------------------------------------------------------");
            Console.SetCursorPosition(25, 6); Console.WriteLine("|                           Xoa thong tin than nhan                          |");
            Console.SetCursorPosition(25, 7); Console.WriteLine("|----------------------------------------------------------------------------|");
            Console.SetCursorPosition(25, 15); Console.WriteLine("-----------------------------------------------------------------------------");
            List<Thannhan> list = TN.GetAllThannhan();
            string Maxoa;
            Console.SetCursorPosition(27, 17); Console.Write("Nhap ma than nhan can xoa:");
            Maxoa = Console.ReadLine();
            int i;
            for (i = 0; i < list.Count; ++i)
                if (list[i].maTN == Maxoa) break;
            if (i < list.Count)
            {
                Console.SetCursorPosition(27, 17); Console.Write("Xoa thanh cong.....");
                TN.XoaThannhan(Maxoa);
                Console.ReadKey();
            }
            else
            {
                Console.SetCursorPosition(27, 17); Console.Write("Khong ton tai ma than nhan nay!");
                Console.ReadKey();
            }
        }
        public void Tim()
        {
            Console.Clear();
            Console.SetCursorPosition(9, 5); Console.WriteLine("--------------------------------------------------------------------------------------------------------");
            Console.SetCursorPosition(9, 6); Console.WriteLine("|                                Tim kiem thong tin than nhan                                           |");
            Console.SetCursorPosition(9, 7); Console.WriteLine("|-------------------------------------------------------------------------------------------------------|");
            IThannhanBLL sp = new ThannhanBLL();
            List<Thannhan> list = sp.TimThannhan(new Thannhan());
            string makhach;
            Console.SetCursorPosition(27, 17); Console.Write("Nhap ma than nhan can tim:");
            makhach = Console.ReadLine();
            int i;
            for (i = 0; i < list.Count; ++i)
                if (makhach == list[i].maTN) break;
            if (i < list.Count)
            {
                Console.SetCursorPosition(9, 9); Console.WriteLine("|                                     Thong tin than nhan                    |");
                Console.SetCursorPosition(9, 7); Console.WriteLine("|----------------------|-------------------------------|--------------------|");
                Console.SetCursorPosition(9, 8); Console.WriteLine("| Ma than nhan         |    Ten than nhan              |       Gioi tinh    |");
                Console.SetCursorPosition(9, 9); Console.WriteLine("|----------------------|-------------------------------|--------------------|");
                Console.SetCursorPosition(9, 12); Console.WriteLine("----------------------------------------------------------------------------");
                Console.SetCursorPosition(9, 13); Console.WriteLine("| " + list[i].maTN + "\t |   " + list[i].TenTN + "|  \t" + list[i].Gioitinh + "\t |");
                Console.SetCursorPosition(9, 14); Console.WriteLine("-----------------------------------------------------------------------------------");
                Console.SetCursorPosition(9, 15); Console.Write(" Nhap phim bat ki de tiep tuc");
                Console.ReadKey();
            }
            else
            {
                Console.SetCursorPosition(9, 11); Console.Write("  Khong ton tai ma than nhan nay....");
                Console.SetCursorPosition(9, 15); Console.WriteLine("---------------------------------------------------------------------------------------------------------------");
                Console.SetCursorPosition(47, 11);
                Console.ReadKey();
            }
        }
        public void Menutn()
        {
            do
            {
                Console.Clear();
                Console.SetCursorPosition(20, 5); Console.Write("-----------------------------------------------------------------------------");
                Console.SetCursorPosition(20, 6); Console.Write("|                              Quan Li Nhan Su                              |");
                Console.SetCursorPosition(20, 7); Console.Write("|---------------------------------------------------------------------------|");
                Console.SetCursorPosition(20, 8); Console.Write("|                          QUAN LI THONG TIN THAN NHAN                      |");
                Console.SetCursorPosition(20, 9); Console.Write("|---------------------------------------------------------------------------|");
                Console.SetCursorPosition(20, 10); Console.Write("|     1    |            Them thong tin than nhan                           |");
                Console.SetCursorPosition(20, 11); Console.Write("|----------|--------------------------------------------------------------- |");
                Console.SetCursorPosition(20, 12); Console.Write("|     2    |           Sua thong tin than nhan                              |");
                Console.SetCursorPosition(20, 13); Console.Write("|----------|----------------------------------------------------------------|");
                Console.SetCursorPosition(20, 14); Console.Write("|     3    |            Xoa thong tin than nhan                             |");
                Console.SetCursorPosition(20, 15); Console.Write("|----------|----------------------------------------------------------------|");
                Console.SetCursorPosition(20, 16); Console.Write("|     4    |           Hien thong tin than nhan                             |");
                Console.SetCursorPosition(20, 17); Console.Write("|----------|----------------------------------------------------------------|");
                Console.SetCursorPosition(20, 18); Console.Write("|     5    |            Tim kiem thong tin than nhan                        |");
                Console.SetCursorPosition(20, 19); Console.Write("|----------|----------------------------------------------------------------|");
                Console.SetCursorPosition(20, 20); Console.Write("|     6    |             Quay lai                                           |");
                Console.SetCursorPosition(20, 21); Console.Write("|----------|----------------------------------------------------------------|");
                Console.SetCursorPosition(20, 22); Console.Write("|  Moi ban chon lai chuc nang :                                             |");
                Console.SetCursorPosition(20, 23); Console.Write("|---------------------------------------------------------------------------|");
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

