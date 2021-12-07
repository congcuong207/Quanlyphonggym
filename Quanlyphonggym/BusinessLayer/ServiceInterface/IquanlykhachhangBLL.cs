
using Quanlyphonggym.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Quanlyphonggym.BusinessLayer.ServiceInterface
{
    interface IquanlykhachhangBLL
    {
        void Nhap(ref List<KhachHang> sinhViens);
        void Hien(List<KhachHang> sinhViens);
        void Hien1(KhachHang sv);
        void HienTimKiem(KhachHang sv);
        KhachHang TimKiem(List<KhachHang> sinhViens, string ma);
        void Xoa(ref List<KhachHang> sinhViens, KhachHang sv);
        void Sua(ref List<KhachHang> sinhViens, string ma);

    }
}
