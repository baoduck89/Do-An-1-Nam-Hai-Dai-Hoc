using System;
using System.Collections.Generic;
using System.Text;

namespace DoAnNam2.Presenation
{
    public class Menu
    {
        public void frm()
        {
            do
            {
                Console.Clear();
                Console.SetCursorPosition(20, 5); Console.Write("|--------------------------------------------------------------------------|");
                Console.SetCursorPosition(20, 6); Console.Write("|                             Quan Li Nhan Su                              |");
                Console.SetCursorPosition(20, 7); Console.Write("|--------------------------------------------------------------------------|");
                Console.SetCursorPosition(20, 8); Console.Write("|     1    |                    Quan Li Nhan vien                          |");
                Console.SetCursorPosition(20, 9); Console.Write("|----------|-------------------------------------------------------------- |");
                Console.SetCursorPosition(20, 10); Console.Write("|     2    |                   Quan Li Don vi                              |");
                Console.SetCursorPosition(20, 11); Console.Write("|----------|---------------------------------------------------------------|");
                Console.SetCursorPosition(20, 12); Console.Write("|     3    |                  Quan Li Than Nhan                            |");
                Console.SetCursorPosition(20, 13); Console.Write("|----------|---------------------------------------------------------------|");
                Console.SetCursorPosition(20, 14); Console.Write("|     4    |                         Ket Thuc                              |");
                Console.SetCursorPosition(20, 15); Console.Write("|--------------------------------------------------------------------------|");
                ConsoleKeyInfo kt = Console.ReadKey();
                switch (kt.KeyChar)
                {
                    case '1':
                        frmNhanvien frm = new frmNhanvien();
                        frm.Menunv();
                        Console.ReadKey();
                        break;
                    case '2':
                        FrmDonvi frd = new FrmDonvi();
                        frd.Menudv();
                        Console.ReadKey();
                        break;
                    case '3':
                        FrmThannhan frn = new FrmThannhan();
                        frn.Menutn();
                        Console.ReadKey();
                        break;
                    case '4':
                        Environment.Exit(0);
                        break;
                }
            } while (true);
        }
    }
}

