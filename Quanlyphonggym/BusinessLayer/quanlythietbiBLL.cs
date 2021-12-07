using Quanlyphonggym.BusinessLayer.ServiceInterface;
using Quanlyphonggym.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Quanlyphonggym.BusinessLayer
{
    class quanlythietbiBLL : IquanlythietbiBLL
    {
        
        public void Nhap(ref List<ThietBi> thietBis)
        {
            Console.Clear();
            ThietBi tb = new ThietBi();

            Console.WriteLine("\t\t╔═════════════════════════════════════════╗");
            Console.WriteLine("\t\t║        Nhập thông tin thiết bị          ║");
            Console.WriteLine("\t\t║═════════════════════════════════════════║");
            Console.WriteLine("\t\t║    Nhập mã thiết bị:                    ║");
            Console.WriteLine("\t\t║═════════════════════════════════════════║");
            Console.WriteLine("\t\t║    Nhập tên thiết bị:                   ║");
            Console.WriteLine("\t\t║═════════════════════════════════════════║");
            Console.WriteLine("\t\t║    Nhập tình trạng:                     ║");
            Console.WriteLine("\t\t║═════════════════════════════════════════║");
            Console.WriteLine("\t\t║    Nhập số Lượng:                       ║");
            Console.WriteLine("\t\t╚═════════════════════════════════════════╝");
            do
            {
                bool kt = true;
                Console.SetCursorPosition(40, 3);
                tb.MaTB = Console.ReadLine();
                foreach (ThietBi kh in thietBis)
                {
                    if (tb.MaTB.ToUpper().Equals(kh.MaTB.ToUpper()))
                    {
                        kt = false;
                    }
                }
                if (tb.MaTB.Trim() != "" && kt)
                {
                    break;
                }
            } while (true);
            do
            {
                Console.SetCursorPosition(40, 5);
                tb.TenTB = Console.ReadLine();
            } while (tb.TenTB.Trim() == "");
            do
            {
                Console.SetCursorPosition(38, 7);
                tb.TinhTrang = Console.ReadLine();
            } while (tb.TinhTrang.Trim() == "");
            do
            {
                Console.SetCursorPosition(36, 9);
                tb.SoLuong = int.Parse(Console.ReadLine());
            } while (tb.SoLuong < 0);
            thietBis.Add(tb);

        }
        public void Hien(List<ThietBi> thietBis)
        {
            Console.Clear();
            Console.WriteLine("╔══════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                               Hiện thông tin thiết bị                        ║");
            Console.WriteLine("║══════════════════════════════════════════════════════════════════════════════║");
            Console.WriteLine("║{0,-15}║{1,-25}║{2,-20}║{3,-15}║", "Mã TB", "Tên TB", "Tình Trạng", "Số lượng");

            foreach (ThietBi tb in thietBis)
            {
                Hien1(tb);
            }
            Console.WriteLine("╚══════════════════════════════════════════════════════════════════════════════╝");

        }

        public void Hien1(ThietBi tb)
        {
            Console.WriteLine("║{0,-15}║{1,-25}║{2,-20}║{3,-15}║", tb.MaTB, tb.TenTB, tb.TinhTrang, tb.SoLuong);

        }
        public void HienTimKiem(ThietBi tb)
        {
            if (tb != null)
            {
                Console.Clear();
                Console.WriteLine("╔══════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("║                               Hiện thông tin thiết bị                        ║");
                Console.WriteLine("║══════════════════════════════════════════════════════════════════════════════║");
                Console.WriteLine("║{0,-15}║{1,-25}║{2,-20}║{3,-15}║", "Mã TB", "Tên TB", "Tình Trạng", "Số lượng");
                Console.WriteLine("║{0,-15}║{1,-25}║{2,-20}║{3,-15}║", tb.MaTB, tb.TenTB, tb.TinhTrang, tb.SoLuong);
                Console.WriteLine("╚══════════════════════════════════════════════════════════════════════════════╝");
            }
        }
       
        public void Xoa(ref List<ThietBi> thietBis, ThietBi tb)
        {
            thietBis.Remove(tb);
        }
        public void Sua(ref List<ThietBi> thietBis, string ma)
        {
            Console.Clear();
            foreach (ThietBi tb in thietBis)
            {
                if (ma.ToUpper().Equals(tb.MaTB.ToUpper()))
                {
                    Console.WriteLine("\t\t╔═════════════════════════════════════════╗");
                    Console.WriteLine("\t\t║        Nhập thông tin thiết bị          ║");
                    Console.WriteLine("\t\t║═════════════════════════════════════════║");
                    Console.WriteLine("\t\t║    Mã thiết bị: {0,-8}                ║", tb.MaTB);
                    Console.WriteLine("\t\t║═════════════════════════════════════════║");
                    Console.WriteLine("\t\t║    Sửa tên thiết bị:                    ║");
                    Console.WriteLine("\t\t║═════════════════════════════════════════║");
                    Console.WriteLine("\t\t║    Sửa tình trạng:                      ║");
                    Console.WriteLine("\t\t║═════════════════════════════════════════║");
                    Console.WriteLine("\t\t║    Sửa số Lượng:                        ║");
                    Console.WriteLine("\t\t╚═════════════════════════════════════════╝");
                    Console.SetCursorPosition(39, 5);
                    tb.TenTB = Console.ReadLine();
                    Console.SetCursorPosition(37, 7);
                    tb.TinhTrang = Console.ReadLine();
                    Console.SetCursorPosition(35, 9);
                    tb.SoLuong = int.Parse(Console.ReadLine());
                }
            }
        }
        
        public ThietBi TimKiem(List<ThietBi> thietBis, string ma)
        {
            Console.Clear();
            foreach (ThietBi tb in thietBis)
            {
                if (tb.MaTB.ToUpper().Equals(ma.ToUpper()))
                {
                    return tb;
                }
            }
            return null;
        }
    }
}
