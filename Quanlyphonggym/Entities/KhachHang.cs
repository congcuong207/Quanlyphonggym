using System;
using System.Collections.Generic;
using System.Text;

namespace Quanlyphonggym.Entities
{
    class KhachHang
    {
        private string maKH;
        private string hoTen;
        private string ngaySinh;
        private string diaChi;
        private string soDT;

        

        public KhachHang()
        {
        }

        public KhachHang(string maKH, string hoTen, string ngaySinh, string diaChi, string soDT)
        {
            this.maKH = maKH;
            this.hoTen = hoTen;
            this.ngaySinh = ngaySinh;
            this.diaChi = diaChi;
            this.soDT = soDT;
        }

        public string MaKH { get => maKH; set => maKH = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string SoDT { get => soDT; set => soDT = value; }
    }
}
