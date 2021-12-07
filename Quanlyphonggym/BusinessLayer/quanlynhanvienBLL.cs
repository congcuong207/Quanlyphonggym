using Quanlyphonggym.BusinessLayer.ServiceInterface;
using Quanlyphonggym.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Quanlyphonggym.BusinessLayer
{
    class quanlynhanvienBLL : IquanlynhanvienBLL
    {
       
        public void Nhap(ref List<NhanVien> nhanviens)
        {
            Console.Clear();
            NhanVien nm = new NhanVien();
            Console.WriteLine("\t\t╔═════════════════════════════════════════════════╗");
            Console.WriteLine("\t\t║              Nhập thông tin nhân viên           ║");
            Console.WriteLine("\t\t║═════════════════════════════════════════════════║");
            Console.WriteLine("\t\t║    Nhập mã nhân viên:                           ║");
            Console.WriteLine("\t\t║═════════════════════════════════════════════════║");
            Console.WriteLine("\t\t║    Nhập họ tên nhân viên:                       ║");
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
                nm.MaNV = Console.ReadLine();
                foreach (NhanVien nv in nhanviens)
                {
                    if (nm.MaNV.ToUpper().Equals(nv.MaNV.ToUpper()))
                    {
                        kt = false;
                    }
                }
                if (nm.MaNV != "" && kt)
                {
                    break;
                }
            } while (true);
            do
            {
                Console.SetCursorPosition(44, 5);
                nm.TenNV = Console.ReadLine();
            } while (nm.TenNV == "");
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
            nhanviens.Add(nm);

        }
        public void Hien(List<NhanVien> nhanviens)
        {
            Console.Clear();
            Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                                             Hiện thông tin nhân viên                                   ║");
            Console.WriteLine("║════════════════════════════════════════════════════════════════════════════════════════════════════════║");
            Console.WriteLine("║{0,-15}║{1,-25}║{2,-20}║{3,-20}║{4,-20}║", "Mã SV", "Họ tên", "Ngày sinh", "Số DT", "Địa chỉ");
            foreach (NhanVien sv in nhanviens)
            {
                Hien1(sv);
            }
            Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════╝");


        }

        public void Hien1(NhanVien kh)
        {
            Console.WriteLine("║{0,-15}║{1,-25}║{2,-20}║{3,-20}║{4,-20}║", kh.MaNV, kh.TenNV, kh.NgaySinh, kh.SoDT, kh.DiaChi);
        }
        public void HienTimKiem(NhanVien kh)
        {
            if (kh != null)
            {
                Console.Clear();
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("║                                             Hiện thông tin nhân viên                                   ║");
                Console.WriteLine("║════════════════════════════════════════════════════════════════════════════════════════════════════════║");
                Console.WriteLine("║{0,-15}║{1,-25}║{2,-20}║{3,-20}║{4,-20}║", "Mã SV", "Họ tên", "Ngày sinh", "Số ĐT", "Địa chỉ");
                Console.WriteLine("║{0,-15}║{1,-25}║{2,-20}║{3,-20}║{4,-20}║", kh.MaNV, kh.TenNV, kh.NgaySinh, kh.SoDT, kh.DiaChi);
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
            }
        }
        public NhanVien TimKiem(List<NhanVien> nhanviens, string ma)
        {
            Console.Clear();
            foreach (NhanVien kh in nhanviens)
            {
                if (kh.MaNV.ToUpper().Equals(ma.ToUpper()))
                {
                    return kh;
                }
            }
            return null;
        }
        public void Xoa(ref List<NhanVien> nhanviens, NhanVien kh)
        {
            nhanviens.Remove(kh);
        }
        public void Sua(ref List<NhanVien> nhanviens, string ma)
        {
            Console.Clear();
            foreach (NhanVien nm in nhanviens)
            {
                if (ma.ToUpper().Equals(nm.MaNV.ToUpper()))
                {
                    Console.WriteLine("\t\t╔═════════════════════════════════════════════════╗");
                    Console.WriteLine("\t\t║              Nhập thông tin nhân viên           ║");
                    Console.WriteLine("\t\t║═════════════════════════════════════════════════║");
                    Console.WriteLine("\t\t║    Nhập mã nhân viên:                           ║");
                    Console.WriteLine("\t\t║═════════════════════════════════════════════════║");
                    Console.WriteLine("\t\t║    Nhập họ tên nhân viên:                       ║");
                    Console.WriteLine("\t\t║═════════════════════════════════════════════════║");
                    Console.WriteLine("\t\t║    Nhập ngày sinh:                              ║");
                    Console.WriteLine("\t\t║═════════════════════════════════════════════════║");
                    Console.WriteLine("\t\t║    Nhập số điện thoại:                          ║");
                    Console.WriteLine("\t\t║═════════════════════════════════════════════════║");
                    Console.WriteLine("\t\t║    Nhập địa chỉ:                                ║");
                    Console.WriteLine("\t\t╚═════════════════════════════════════════════════╝");
                    Console.SetCursorPosition(40, 3);
                    nm.MaNV = Console.ReadLine();
                    Console.SetCursorPosition(44, 5);
                    nm.TenNV = Console.ReadLine();
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
