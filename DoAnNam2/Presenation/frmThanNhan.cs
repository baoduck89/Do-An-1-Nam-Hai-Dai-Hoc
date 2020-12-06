using System;
using System.Collections.Generic;
using System.Text;
using DoAnNam2.BussinessLayer;
using DoAnNam2.DataAccessLayer;
using DoAnNam2.Entities;


namespace DoAnNam2.Presenation
{
    class frmThanNhan
    {
        public class frmThannhan
        {
            private IThannhanBLL TN = new ThannhanBLL();
            public void Nhap()
            {
                Console.Clear();
                Console.WriteLine("NHAP THONG TIN THAN NHAN");
                Thannhan tn = new Thannhan();
                Console.Write("Nhap ma than nhan:"); tn.manv = Console.ReadLine();
                Console.Write("Nhap ten than nhan:"); tn.ten = Console.ReadLine();
                Console.Write("Nhap ngay sinh:"); tn.ngaysinh = DateTime.Parse(Console.ReadLine());
                Console.Write("Nhap gioi tinh:"); tn.gioitinh = Console.ReadLine();
                TN.ThemThannhan(tn);
            }
            public void Hien()
            {
                Console.Clear();
                Console.WriteLine("HIEN THI THONG TIN NHAN VIEN");
                List<Thannhan> list = tnDLL.GetAllThannhan();
                foreach (var tn in list)
                    Console.WriteLine(tn.Matn + "\t" + tn.Tentn + "\t" + tn.Ngaysinh + "\t" + tn.Gioitinh + "\t" + tn.Luong);
            }
            public void Sua()
            {
                Console.Clear();
                Console.WriteLine("SUA THONG TIN THAN NHAN  ");
                List<Thannhan> list = tnDLL.GetAllThannhan();
                string Tensua;
                Console.Write("NHAP TEN THAN NHAN CAN SUA:");
                Tensua = Console.ReadLine();
                int i = 0;
                for (i = 0; i < list.Count; ++i)
                {
                    if (list[i].TenTN == Tensua)
                    {
                        if (i < list.Count)
                        {
                            Thannhan tn = new Thannhan(list[i]);
                            Console.Write("Nhap ten moi :");
                            string ten = Console.ReadLine();
                            if (!string.IsNullOrEmpty(ten)) tn.Tentn = ten;
                            Console.Write("Nhap ma nhan vien moi:");
                            string ma = Console.ReadLine();
                            if (!string.IsNullOrEmpty(ten)) tn.Matn = ma;
                            Console.Write("Nhap ngay sinh:");
                            DateTime ngay = DateTime.Parse(Console.ReadLine());

                        }
                    }
                    else
                    {
                        Console.WriteLine("khong ton tai ten than nhan nay");
                    }
                }
            }
            public void Xoa()
            {
                Console.Clear();
                Console.WriteLine("Xoa thong tin nhan vien");
                List<Thannhan> list = tnDLL.GetAllThannhan();
                string Maxoa;
                Console.Write("Nhap ma nhan vien can xoa:");
                Maxoa = Console.ReadLine();
                int i;
                for (i = 0; i < list.Count; ++i)
                    if (list[i].Matn == Maxoa) break;
                if (i < list.Count)
                {
                    Console.Write("Xoa thanh cong.....");
                    tnDLL.XoaThannhan(Maxoa);
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
                List<Thannhan> list = Thannhan.TimThannhan(new Thannhan());
                string makhach;
                Console.Write("Nhap ma nhan vien can tim:");
                makhach = Console.ReadLine();
                for (int i = 0; i < list.Count; ++i)
                {
                    if (makhach == list[i].Matn)
                        Console.WriteLine(list[i].Matn + "\t" + list[i].Tentn + "\t" + list[i].Gioitinh + "\t" + list[i].Ngaysinh);
                }
            }
            public void Menu2()
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("QUAN LY THONG TIN NHAN VIEN");
                    Console.WriteLine(" F1.Nhap than nhan   ");
                    Console.WriteLine(" F2.Sua than nhan ");
                    Console.WriteLine(" F3.Xoa than nhan");
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
    }
}



