using Quanlyphonggym.BusinessLayer.ServiceInterface;
using Quanlyphonggym.DataAccess.ServiceInterface;
using Quanlyphonggym.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Quanlyphonggym.BusinessLayer
{
    internal class quanlyphieutapBLL : IquanlyphieutapBLL
    {
       
        public void Nhap(ref List<PhieuTap> phieuTaps,List<NhanVien> nhanViens,List<KhachHang>khachHangs)
        {
            Console.Clear();
            PhieuTap tb = new PhieuTap();

            Console.WriteLine("\t\t╔══════════════════════════════════════════════╗");
            Console.WriteLine("\t\t║            Nhập thông tin phiếu tập          ║");
            Console.WriteLine("\t\t║══════════════════════════════════════════════║");
            Console.WriteLine("\t\t║    Nhập mã phiếu tập:                        ║");
            Console.WriteLine("\t\t║══════════════════════════════════════════════║");
            Console.WriteLine("\t\t║    Nhập mã học viên:                         ║");
            Console.WriteLine("\t\t║══════════════════════════════════════════════║");
            Console.WriteLine("\t\t║    Nhập ngày hết hạn:                        ║");
            Console.WriteLine("\t\t║══════════════════════════════════════════════║");
            Console.WriteLine("\t\t║    Nhập mã nhân viên:                        ║");
            Console.WriteLine("\t\t╚══════════════════════════════════════════════╝");
            do
            {
                bool kt = true;
                Console.SetCursorPosition(40, 3);
                tb.MaTheKhachHang = Console.ReadLine();
                foreach (PhieuTap kh in phieuTaps)
                {
                    if (tb.MaTheKhachHang.ToUpper().Equals(kh.MaTheKhachHang.ToUpper()))
                    {
                        kt = false;
                    }
                }
                if (tb.MaTheKhachHang.Trim() != "" && kt)
                {
                    break;
                }
            } while (true);
            do
            {
                bool kt = false;
                Console.SetCursorPosition(40, 5);
                tb.MaHocVien = Console.ReadLine();
                foreach(KhachHang kh in khachHangs)
                {
                    if (kh.MaKH.ToUpper().Equals(tb.MaHocVien.ToUpper()))
                    {
                        kt = true;
                    }
                }
                if (kt&& tb.MaHocVien != "")
                {
                    break;
                }
            } while (true);
            do
            {
                Console.SetCursorPosition(38, 7);
                tb.NgayHethan = Console.ReadLine();
            } while (tb.NgayHethan == "");
            do
            {
                Console.SetCursorPosition(36, 9);
                tb.MaNhanvien = Console.ReadLine();
                bool kt = false;
                foreach (NhanVien nv in nhanViens)
                {
                    if (nv.MaNV.ToUpper().Equals(tb.MaNhanvien.ToUpper()))
                    {
                        kt = true;
                    }
                }
                if (kt && tb.MaNhanvien != "")
                {
                    break;
                }
                    
            } while (true);
            phieuTaps.Add(tb);

        }
        public void Hien(List<PhieuTap> phieuTaps)
        {
            Console.Clear();
            Console.WriteLine("╔══════════════════════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                                  Hiện thông tin phiếu tập                                    ║");
            Console.WriteLine("║══════════════════════════════════════════════════════════════════════════════════════════════║");
            Console.WriteLine("║{0,-15}║{1,-25}║{2,-20}║{3,-15}║{4,-15}║", "Mã Phiếu", "Mã Học Viên", "Ngày Đky", "Ngày hết hạn","Mã NV");

            foreach (PhieuTap tb in phieuTaps)
            {
                Hien1(tb);
            }
            Console.WriteLine("╚══════════════════════════════════════════════════════════════════════════════════════════════╝");

        }

        public void Hien1(PhieuTap tb)
        {
            Console.WriteLine("║{0,-15}║{1,-25}║{2,-20}║{3,-15}║{4,-15}║", tb.MaTheKhachHang, tb.MaHocVien, tb.NgayDky, tb.NgayHethan,tb.MaNhanvien);

        }
        public void HienTimKiem(PhieuTap tb)
        {
            if (tb != null)
            {
                Console.Clear();
                Console.WriteLine("╔══════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("║                                  Hiện thông tin phiếu tập                                    ║");
                Console.WriteLine("║══════════════════════════════════════════════════════════════════════════════════════════════║");
                Console.WriteLine("║{0,-15}║{1,-25}║{2,-20}║{3,-15}║{4,-15}║", "Mã Phiếu", "Mã Học Viên", "Ngày Đky", "Ngày hết hạn", "Mã NV");
                Console.WriteLine("║{0,-15}║{1,-25}║{2,-20}║{3,-15}║{4,-15}║", tb.MaTheKhachHang, tb.MaHocVien, tb.NgayDky, tb.NgayHethan, tb.MaNhanvien);
                Console.WriteLine("╚══════════════════════════════════════════════════════════════════════════════════════════════╝");
            }
        }
        public PhieuTap TimKiem(List<PhieuTap> phieuTaps, string ma)
        {
            Console.Clear();
            foreach (PhieuTap tb in phieuTaps)
            {
                if (tb.MaHocVien.ToUpper().Equals(ma.ToUpper()))
                {
                    return tb;
                }
            }
            return null;
        }
        public void Xoa(ref List<PhieuTap> phieuTaps, PhieuTap tb)
        {
            phieuTaps.Remove(tb);
        }
        
    }
}
