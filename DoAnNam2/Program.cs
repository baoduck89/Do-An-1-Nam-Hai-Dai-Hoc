﻿using System;
using DoAnNam2.Presenation;
namespace DoAnNam2
{
    public class Program
    {
        public static void Menu1()
        {
            do
            {
                Console.Clear();
                Console.WriteLine(" F1.Quan ly nhan vien: ");               
                Console.WriteLine(" F5.Ket thuc ");
                ConsoleKeyInfo kt = Console.ReadKey();
                switch (kt.Key)
                {
                    case ConsoleKey.F1:
                        frmNhanvien frm = new frmNhanvien();
                        frm.Menu();
                        break;
                    case ConsoleKey.F5:
                        Environment.Exit(0);
                        break;
                }
            } while (true);
        }

        static void Main(string[] args)
        {
            Menu1();
        }
    }
}