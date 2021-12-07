using Quanlyphonggym.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Quanlyphonggym.BusinessLayer.ServiceInterface
{
    interface IquanlynhanvienBLL
    {
        void Nhap(ref List<NhanVien> nhanViens);
        void Hien(List<NhanVien> nhanViens);
        void Hien1(NhanVien nv);
        void HienTimKiem(NhanVien nv);
        NhanVien TimKiem(List<NhanVien> nhanViens, string ma);
        void Xoa(ref List<NhanVien> nhanViens, NhanVien nv);
        void Sua(ref List<NhanVien> nhanViens, string ma);
    }
}
