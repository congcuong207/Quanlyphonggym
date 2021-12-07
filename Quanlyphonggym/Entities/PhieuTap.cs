using System;
using System.Collections.Generic;
using System.Text;

namespace Quanlyphonggym.Entities
{
    class PhieuTap
    {
        //DateTime.Now.ToString("dd/MM/yyyy")
        private string maTheKhachHang;
        private string maHocVien;
        private string ngayDky;
        private string ngayHethan;
        private string maNhanvien;
        public PhieuTap()
        {
            this.ngayDky = DateTime.Now.ToString("dd/MM/yyyy");
         
        }

        public PhieuTap(string maTheKhachHang, string maHocVien, string ngayDky, string ngayHethan, string maNhanvien)
        {
            this.maTheKhachHang = maTheKhachHang;
            this.maHocVien = maHocVien;
            this.ngayDky = ngayDky;
            this.ngayHethan = ngayHethan;
            this.maNhanvien = maNhanvien;
        }

        public string MaHocVien { get => maHocVien; set => maHocVien = value; }
        public string NgayDky { get => ngayDky; set => ngayDky = value; }
        public string NgayHethan { get => ngayHethan; set => ngayHethan = value; }
        public string MaTheKhachHang { get => maTheKhachHang; set => maTheKhachHang = value; }
        public string MaNhanvien { get => maNhanvien; set => maNhanvien = value; }
    }
}
