using Quanlyphonggym;
using Quanlyphonggym.BusinessLayer;
using Quanlyphonggym.BusinessLayer.ServiceInterface;
using Quanlyphonggym.ChucNang;
using Quanlyphonggym.DataAccess;
using Quanlyphonggym.DataAccess.ServiceInterface;
using Quanlyphonggym.Entities;
using Quanlyphonggym.View;
using Quanlyphonggym.View.ServiceInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Quanlyphonggym
{
    class Run
    {
        public static List<KhachHang> khachHangs;
        public static List<ThietBi> thietBis;
        public static List<PhieuTap> phieuTaps;
        public static List<NhanVien> nhanViens;
        public static int MenuRun()
        {
            int n = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("\t\t\t\t\t\t╔═══════════════════════════════════════════════════╗");
                Console.WriteLine("\t\t\t\t\t\t║          CHƯƠNG TRÌNH QUẢN LÝ PHÒNG GYM           ║");
                Console.WriteLine("\t\t\t\t\t\t║═══════════════════════════════════════════════════║");
                Console.WriteLine("\t\t\t\t\t\t║     1. Quản lý khách hàng                         ║");
                Console.WriteLine("\t\t\t\t\t\t║═══════════════════════════════════════════════════║");
                Console.WriteLine("\t\t\t\t\t\t║     2. Quản lý thiết bị                           ║");
                Console.WriteLine("\t\t\t\t\t\t║═══════════════════════════════════════════════════║");
                Console.WriteLine("\t\t\t\t\t\t║     3. Quản lý phiếu tập                          ║");
                Console.WriteLine("\t\t\t\t\t\t║═══════════════════════════════════════════════════║");
                Console.WriteLine("\t\t\t\t\t\t║     4. Quản lý nhân viên                          ║");
                Console.WriteLine("\t\t\t\t\t\t║═══════════════════════════════════════════════════║");
                Console.WriteLine("\t\t\t\t\t\t║     5. Quay lại                                   ║");
                Console.WriteLine("\t\t\t\t\t\t║═══════════════════════════════════════════════════║");
                Console.WriteLine("\t\t\t\t\t\t║     Chọn:                                         ║");
                Console.WriteLine("\t\t\t\t\t\t╚═══════════════════════════════════════════════════╝");
                Console.SetCursorPosition(60, 13);
                try
                {
                    n = int.Parse(Console.ReadLine());//nhập n
                }
                catch
                {

                }
            } while (n < 1 || n > 5);//nếu n <1 hoặc lớn hơn 5 thì lặp lại
            return n;
        }
        public static void Main()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            IquanlykhachhangBLL qlkhBLL = new quanlykhachhangBLL();
            IquanlykhachhangDAO qlkh = new quanlykhachhangDAO();
            IquanlythietbiBLL qltbBLL = new quanlythietbiBLL();
            IquanlythietbiDAO qltb = new quanlythietbiDAO();
            IquanlyphieutapBLL qlptBLL = new quanlyphieutapBLL();
            IquanlyphieutapDAO qlpt = new quanlyphieutapDAO();
            IquanlynhanvienBLL qlnvBLL=new  quanlynhanvienBLL();
            IquanlynhanvienDAO qlnv=new quanlynhanvienDAO();
            khachHangs = new List<KhachHang>();
            khachHangs = qlkh.LayDS();
            nhanViens = new List<NhanVien>();
            nhanViens = qlnv.LayDS();
            IMenu menu = new Menu();
            
                      
            
            
            while (true)
            {
                int chon = MenuRun();
                switch (chon)
                {
                    case 1:
                        
                        do
                        {
                            khachHangs = new List<KhachHang>();
                            khachHangs = qlkh.LayDS();
                            chon = menu.MenuKH();
                            switch (chon)
                            {
                                case 1:
                                    qlkhBLL.Nhap(ref khachHangs);
                                    qlkh.GhiThongTin(khachHangs);
                                    break;
                                case 2:
                                    qlkhBLL.Hien(khachHangs);
                                    Console.ReadLine();
                                    break;
                                case 3:
                                    Console.Write("Nhập mã KH cần sửa: ");
                                    qlkhBLL.Sua(ref khachHangs, Console.ReadLine());
                                    qlkh.GhiThongTin(khachHangs);
                                    break;
                                case 4:
                                    Console.Write("Nhập mã KH cần xóa: ");
                                    qlkhBLL.Xoa(ref khachHangs, qlkhBLL.TimKiem(khachHangs, Console.ReadLine()));
                                    qlkh.GhiThongTin(khachHangs);
                                    break;
                                case 5:
                                    Console.Write("Nhập mã KH cần tìm: ");
                                    qlkhBLL.HienTimKiem(qlkhBLL.TimKiem(khachHangs, Console.ReadLine()));
                                    Console.ReadLine();
                                    break;
                            }
                        } while (chon != 6);
                        break;
                    case 2:
                        
                        do
                        {
                            thietBis = new List<ThietBi>();
                            thietBis = qltb.LayDS();
                            chon = menu.MenuTB();
                            switch (chon)
                            {
                                case 1:
                                    qltbBLL.Nhap(ref thietBis);
                                    qltb.GhiThongTin(thietBis);
                                    break;
                                case 2:
                                    qltbBLL.Hien(thietBis);
                                    Console.ReadLine();
                                    break;
                                case 3:
                                    Console.Write("Nhập mã TB cần sửa: ");
                                    qltbBLL.Sua(ref thietBis, Console.ReadLine());
                                    qltb.GhiThongTin(thietBis);
                                    break;
                                case 4:
                                    Console.Write("Nhập mã TB cần xóa: ");
                                    qltbBLL.Xoa(ref thietBis, qltbBLL.TimKiem(thietBis, Console.ReadLine()));
                                    qltb.GhiThongTin(thietBis);
                                    break;
                                case 5:
                                    Console.Write("Nhập mã TB cần tìm: ");
                                    qltbBLL.HienTimKiem(qltbBLL.TimKiem(thietBis, Console.ReadLine()));
                                    Console.ReadLine();
                                    break;
                            }
                        } while (chon != 6);
                        break;
                    case 3:
                        
                        do
                        {
                            phieuTaps = new List<PhieuTap>();
                            phieuTaps = qlpt.LayDS();
                            chon = menu.MenuPTH();
                            switch (chon)
                            {
                                case 1:
                                    qlptBLL.Nhap(ref phieuTaps,nhanViens,khachHangs);
                                    qlpt.GhiThongTin(phieuTaps);
                                    break;
                                case 2:
                                    qlptBLL.Hien(phieuTaps);
                                    Console.ReadLine();
                                    break;
                                case 3:
                                    Console.Write("Nhập mã phiếu tập cần xóa: ");
                                    qlptBLL.Xoa(ref phieuTaps, qlptBLL.TimKiem(phieuTaps, Console.ReadLine()));
                                    qlpt.GhiThongTin(phieuTaps);
                                    break;
                                case 4:
                                    Console.Write("Nhập mã phiếu tập cần tìm: ");
                                    qlptBLL.HienTimKiem(qlptBLL.TimKiem(phieuTaps, Console.ReadLine()));
                                    Console.ReadLine();
                                    break;
                            }
                        } while (chon != 6);
                        break;
                    case 4:

                        do
                        {
                            nhanViens = new List<NhanVien>();
                            nhanViens = qlnv.LayDS();
                            chon = menu.MenuNV();
                            switch (chon)
                            {
                                case 1:
                                    qlnvBLL.Nhap(ref nhanViens);
                                    qlnv.GhiThongTin(nhanViens);
                                    break;
                                case 2:
                                    qlnvBLL.Hien(nhanViens);
                                    Console.ReadLine();
                                    break;
                                case 3:
                                    Console.Write("Nhập mã nhân viên cần sửa: ");
                                    qlnvBLL.Sua(ref nhanViens, Console.ReadLine());
                                    qlnv.GhiThongTin(nhanViens);
                                    break;
                                case 4:
                                    Console.Write("Nhập mã nhân viên cần xóa: ");
                                    qlnvBLL.Xoa(ref nhanViens, qlnvBLL.TimKiem(nhanViens, Console.ReadLine()));
                                    qlnv.GhiThongTin(nhanViens);
                                    break;
                                case 5:
                                    Console.Write("Nhập mã nhân viên cần tìm: ");
                                    qlnvBLL.HienTimKiem(qlnvBLL.TimKiem(nhanViens, Console.ReadLine()));
                                    Console.ReadLine();
                                    break;
                            }
                        } while (chon != 6);
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                }
            }
            
        }
    }

}
