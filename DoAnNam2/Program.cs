using System;
using DoAnNam2.Presenation;
namespace DoAnNam2

{
    public class Program
    {
        public static void Menu()
        {
            do
            {
                Console.Clear();
                Console.WriteLine(" F1.Quan ly nhan vien: ");
                Console.WriteLine("F2.Quan ly don vi:");
                Console.WriteLine("F3.Quan ly than nhan:");
                Console.WriteLine(" F5.Ket thuc ");
                ConsoleKeyInfo kt = Console.ReadKey();
                switch (kt.Key)
                {
                    case ConsoleKey.F1:
                        frmNhanvien frm = new frmNhanvien();
                        frm.Menu();
                        break;
                    case ConsoleKey.F2:
                        frmDonvi fra = new frmDonvi();
                        fra.Menu1();
                        break;
                    case ConsoleKey.F3:
                        frm frq = new frmDonvi();
                        frq.Menu2();
                        break;
                    case ConsoleKey.F5:
                        Environment.Exit(0);
                        break;
                }
            } while (true);
        }

        static void Main(string[] args)
        {
            Menu();
        }
    }
}