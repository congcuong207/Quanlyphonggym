using System;
using System.Collections.Generic;
using System.Text;

namespace Quanlyphonggym.Entities
{
    class NhanVien
    {
        private string maNV;
        private string tenNV;
        private string soDT;
        private string ngaySinh;
        private string diaChi;

        public NhanVien()
        {
        }

        public NhanVien(string maNV, string tenNV, string soDT, string ngaySinh, string diaChi)
        {
            this.maNV = maNV;
            this.tenNV = tenNV;
            this.soDT = soDT;
            this.ngaySinh = ngaySinh;
            this.diaChi = diaChi;
        }

        public string MaNV { get => maNV; set => maNV = value; }
        public string TenNV { get => tenNV; set => tenNV = value; }
        public string SoDT { get => soDT; set => soDT = value; }
        public string NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
    }
}
