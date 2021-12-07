using Quanlyphonggym.View.ServiceInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Quanlyphonggym.View
{
    class Menu : IMenu
    {
        public int MenuNV()
        {
            int n = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("\t\t\t\t\t\t╔═══════════════════════════════════════╗");
                Console.WriteLine("\t\t\t\t\t\t║          Quản lý nhân viên            ║");
                Console.WriteLine("\t\t\t\t\t\t║═══════════════════════════════════════║");
                Console.WriteLine("\t\t\t\t\t\t║     1. Thêm nhân viên                 ║");
                Console.WriteLine("\t\t\t\t\t\t║═══════════════════════════════════════║");
                Console.WriteLine("\t\t\t\t\t\t║     2. Hiện tất cả các nhân viên      ║");
                Console.WriteLine("\t\t\t\t\t\t║═══════════════════════════════════════║");
                Console.WriteLine("\t\t\t\t\t\t║     3. Sửa thông tin nhân viên        ║");
                Console.WriteLine("\t\t\t\t\t\t║═══════════════════════════════════════║");
                Console.WriteLine("\t\t\t\t\t\t║     4. Xóa nhân viên                  ║");
                Console.WriteLine("\t\t\t\t\t\t║═══════════════════════════════════════║");
                Console.WriteLine("\t\t\t\t\t\t║     5. Tìm nhân viên                  ║");
                Console.WriteLine("\t\t\t\t\t\t║═══════════════════════════════════════║");
                Console.WriteLine("\t\t\t\t\t\t║     6. Quay lại                       ║");
                Console.WriteLine("\t\t\t\t\t\t║═══════════════════════════════════════║");
                Console.WriteLine("\t\t\t\t\t\t║     Chọn:                             ║");
                Console.WriteLine("\t\t\t\t\t\t╚═══════════════════════════════════════╝");
                Console.SetCursorPosition(60, 15);
                try
                {
                    n = int.Parse(Console.ReadLine());//nhập n
                }
                catch
                {

                }
            } while (n < 1 || n > 6);//nếu n <1 hoặc lớn hơn 7 thì lặp lại
            return n;
        }

        public int MenuPTH()
        {
            int n = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("\t\t\t\t\t\t╔═══════════════════════════════════════╗");
                Console.WriteLine("\t\t\t\t\t\t║          Quản lý phiếu tập            ║");
                Console.WriteLine("\t\t\t\t\t\t║═══════════════════════════════════════║");
                Console.WriteLine("\t\t\t\t\t\t║     1. Thêm phiếu tập                 ║");
                Console.WriteLine("\t\t\t\t\t\t║═══════════════════════════════════════║");
                Console.WriteLine("\t\t\t\t\t\t║     2. Hiện tất cả các phiếu tập      ║");
                Console.WriteLine("\t\t\t\t\t\t║═══════════════════════════════════════║");
                Console.WriteLine("\t\t\t\t\t\t║     3. Xóa phiếu tập                  ║");
                Console.WriteLine("\t\t\t\t\t\t║═══════════════════════════════════════║");
                Console.WriteLine("\t\t\t\t\t\t║     4. Tìm phiếu tập                  ║");
                Console.WriteLine("\t\t\t\t\t\t║═══════════════════════════════════════║");
                Console.WriteLine("\t\t\t\t\t\t║     5. Quay lại                       ║");
                Console.WriteLine("\t\t\t\t\t\t║═══════════════════════════════════════║");
                Console.WriteLine("\t\t\t\t\t\t║     Chọn:                             ║");
                Console.WriteLine("\t\t\t\t\t\t╚═══════════════════════════════════════╝");
                Console.SetCursorPosition(60, 13);
                try
                {
                    n = int.Parse(Console.ReadLine());//nhập n
                }
                catch
                {

                }
            } while (n < 1 || n > 5);//nếu n <1 hoặc lớn hơn 7 thì lặp lại
            return n;
        }

        public int MenuKH()
        {
            int n = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("\t\t\t\t\t\t╔═══════════════════════════════════════╗");
                Console.WriteLine("\t\t\t\t\t\t║          Quản lý khách hàng           ║");
                Console.WriteLine("\t\t\t\t\t\t║═══════════════════════════════════════║");
                Console.WriteLine("\t\t\t\t\t\t║     1. Thêm khách hàng                ║");
                Console.WriteLine("\t\t\t\t\t\t║═══════════════════════════════════════║");
                Console.WriteLine("\t\t\t\t\t\t║     2. Hiện tất cả khách hàng         ║");
                Console.WriteLine("\t\t\t\t\t\t║═══════════════════════════════════════║");
                Console.WriteLine("\t\t\t\t\t\t║     3. Sửa khách hàng                 ║");
                Console.WriteLine("\t\t\t\t\t\t║═══════════════════════════════════════║");
                Console.WriteLine("\t\t\t\t\t\t║     4. Xóa khách hàng                 ║");
                Console.WriteLine("\t\t\t\t\t\t║═══════════════════════════════════════║");
                Console.WriteLine("\t\t\t\t\t\t║     5. Tìm khách hàng                 ║");
                Console.WriteLine("\t\t\t\t\t\t║═══════════════════════════════════════║");
                Console.WriteLine("\t\t\t\t\t\t║     6. Quay lại                       ║");
                Console.WriteLine("\t\t\t\t\t\t║═══════════════════════════════════════║");
                Console.WriteLine("\t\t\t\t\t\t║     Chọn:                             ║");
                Console.WriteLine("\t\t\t\t\t\t╚═══════════════════════════════════════╝");
                Console.SetCursorPosition(60, 15);
                try
                {
                    n = int.Parse(Console.ReadLine());//nhập n
                }
                catch
                {

                }
            } while (n < 1 || n > 6);//nếu n <1 hoặc lớn hơn 7 thì lặp lại
            return n;
        }

        public int MenuTB()
        {
            int n = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("\t\t\t\t\t\t╔═══════════════════════════════════════╗");
                Console.WriteLine("\t\t\t\t\t\t║          Quản lý thiết bị             ║");
                Console.WriteLine("\t\t\t\t\t\t║═══════════════════════════════════════║");
                Console.WriteLine("\t\t\t\t\t\t║     1. Thêm thiết bị                  ║");
                Console.WriteLine("\t\t\t\t\t\t║═══════════════════════════════════════║");
                Console.WriteLine("\t\t\t\t\t\t║     2. Hiện tất cả thiết bị           ║");
                Console.WriteLine("\t\t\t\t\t\t║═══════════════════════════════════════║");
                Console.WriteLine("\t\t\t\t\t\t║     3. Sửa thông tin thiết bị         ║");
                Console.WriteLine("\t\t\t\t\t\t║═══════════════════════════════════════║");
                Console.WriteLine("\t\t\t\t\t\t║     4. Xóa thiết bị                   ║");
                Console.WriteLine("\t\t\t\t\t\t║═══════════════════════════════════════║");
                Console.WriteLine("\t\t\t\t\t\t║     5. Tìm thiết bị                   ║");
                Console.WriteLine("\t\t\t\t\t\t║═══════════════════════════════════════║");
                Console.WriteLine("\t\t\t\t\t\t║     6. Quay lại                       ║");
                Console.WriteLine("\t\t\t\t\t\t║═══════════════════════════════════════║");
                Console.WriteLine("\t\t\t\t\t\t║     Chọn:                             ║");
                Console.WriteLine("\t\t\t\t\t\t╚═══════════════════════════════════════╝");
                Console.SetCursorPosition(60, 15);
                try
                {
                    n = int.Parse(Console.ReadLine());//nhập n
                }
                catch
                {

                }
            } while (n < 1 || n > 6);//nếu n <1 hoặc lớn hơn 7 thì lặp lại
            return n;
        }
    }
}
