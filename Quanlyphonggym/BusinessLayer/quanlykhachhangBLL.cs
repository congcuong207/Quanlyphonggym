using Quanlyphonggym.BusinessLayer.ServiceInterface;
using Quanlyphonggym.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Quanlyphonggym.BusinessLayer
{
    class quanlykhachhangBLL:IquanlykhachhangBLL
    {
        public void Nhap(ref List<KhachHang> khachangs)
        {
            Console.Clear();
            KhachHang nm = new KhachHang();
            Console.WriteLine("\t\t╔═════════════════════════════════════════════════╗");
            Console.WriteLine("\t\t║              Nhập thông tin khách hàng          ║");
            Console.WriteLine("\t\t║═════════════════════════════════════════════════║");
            Console.WriteLine("\t\t║    Nhập mã khách hàng:                          ║");
            Console.WriteLine("\t\t║═════════════════════════════════════════════════║");
            Console.WriteLine("\t\t║    Nhập họ tên khách hàng:                      ║");
            Console.WriteLine("\t\t║═════════════════════════════════════════════════║");
            Console.WriteLine("\t\t║    Nhập ngày sinh:                              ║");
            Console.WriteLine("\t\t║═════════════════════════════════════════════════║");
            Console.WriteLine("\t\t║    Nhập số điện thoại:                          ║");
            Console.WriteLine("\t\t║═════════════════════════════════════════════════║");
            Console.WriteLine("\t\t║    Nhập địa chỉ:                                ║");
            Console.WriteLine("\t\t╚═════════════════════════════════════════════════╝");
            do
            {
                bool kt = true;
                Console.SetCursorPosition(40, 3);
                nm.MaKH = Console.ReadLine();
                foreach(KhachHang kh in khachangs)
                {
                    if (nm.MaKH.ToUpper().Equals(kh.MaKH.ToUpper()))
                    {
                        kt = false;
                    }
                }
                if (nm.MaKH!=""&&kt)
                {
                    break;
                }
            } while (true);
            do
            {
                Console.SetCursorPosition(44, 5);
                nm.HoTen = Console.ReadLine();
            } while (nm.HoTen == "");
            do
            {
                Console.SetCursorPosition(40, 7);
                nm.NgaySinh = Console.ReadLine();
            } while (nm.NgaySinh == "");
            do
            {
                Console.SetCursorPosition(35, 9);
                nm.SoDT = Console.ReadLine();
            } while (nm.SoDT == "");
            do
            {
                Console.SetCursorPosition(30, 11);
                nm.DiaChi = Console.ReadLine();
            } while (nm.DiaChi == "");
            khachangs.Add(nm);

        }
        public void Hien(List<KhachHang> khachangs)
        {
            Console.Clear();
            Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                                            Hiện thông tin khách hàng                                   ║");
            Console.WriteLine("║════════════════════════════════════════════════════════════════════════════════════════════════════════║");
            Console.WriteLine("║{0,-15}║{1,-25}║{2,-20}║{3,-20}║{4,-20}║", "Mã SV", "Họ tên","Ngày sinh", "Số DT","Địa chỉ");
            foreach (KhachHang sv in khachangs)
            {
                Hien1(sv);
            }
            Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════╝");


        }

        public void Hien1(KhachHang kh)
        {
            Console.WriteLine("║{0,-15}║{1,-25}║{2,-20}║{3,-20}║{4,-20}║", kh.MaKH, kh.HoTen,kh.NgaySinh, kh.SoDT, kh.DiaChi);
        }
        public void HienTimKiem(KhachHang kh)
        {
            if (kh != null) {
                Console.Clear();
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("║                                            Hiện thông tin khách hàng                                   ║");
                Console.WriteLine("║════════════════════════════════════════════════════════════════════════════════════════════════════════║");
                Console.WriteLine("║{0,-15}║{1,-25}║{2,-20}║{3,-20}║{4,-20}║", "Mã SV", "Họ tên", "Ngày sinh", "Số ĐT", "Địa chỉ");
                Console.WriteLine("║{0,-15}║{1,-25}║{2,-20}║{3,-20}║{4,-20}║", kh.MaKH, kh.HoTen, kh.NgaySinh, kh.SoDT, kh.DiaChi);
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
            }
        }
        public KhachHang TimKiem(List<KhachHang> khachangs, string ma)
        {
            Console.Clear();
            foreach (KhachHang kh in khachangs)
            {
                if (kh.MaKH.ToUpper().Equals(ma.ToUpper()))
                {
                    return kh;
                }
            }
            return null;
        }
        public void Xoa(ref List<KhachHang> khachangs, KhachHang kh)
        {
            khachangs.Remove(kh);
        }
        public void Sua(ref List<KhachHang> khachangs, string ma)
        {
            Console.Clear();
            foreach (KhachHang nm in khachangs)
            {
                if (ma.ToUpper().Equals(nm.MaKH.ToUpper()))
                {
                    Console.WriteLine("\t\t╔═════════════════════════════════════════════════╗");
                    Console.WriteLine("\t\t║              Nhập thông tin khách hàng          ║");
                    Console.WriteLine("\t\t║═════════════════════════════════════════════════║");
                    Console.WriteLine("\t\t║    Nhập mã khách hàng:                          ║");
                    Console.WriteLine("\t\t║═════════════════════════════════════════════════║");
                    Console.WriteLine("\t\t║    Nhập họ tên khách hàng:                      ║");
                    Console.WriteLine("\t\t║═════════════════════════════════════════════════║");
                    Console.WriteLine("\t\t║    Nhập ngày sinh:                              ║");
                    Console.WriteLine("\t\t║═════════════════════════════════════════════════║");
                    Console.WriteLine("\t\t║    Nhập số điện thoại:                          ║");
                    Console.WriteLine("\t\t║═════════════════════════════════════════════════║");
                    Console.WriteLine("\t\t║    Nhập địa chỉ:                                ║");
                    Console.WriteLine("\t\t╚═════════════════════════════════════════════════╝");
                    Console.SetCursorPosition(40, 3);
                    nm.MaKH = Console.ReadLine();
                    Console.SetCursorPosition(44, 5);
                    nm.HoTen = Console.ReadLine();
                    Console.SetCursorPosition(40, 7);
                    nm.NgaySinh = Console.ReadLine();
                    Console.SetCursorPosition(35, 9);
                    nm.SoDT = Console.ReadLine();
                    Console.SetCursorPosition(30, 11);
                    nm.DiaChi = Console.ReadLine();
                }
            }
        }
           }
}
