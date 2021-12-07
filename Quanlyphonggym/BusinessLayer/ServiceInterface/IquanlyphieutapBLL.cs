
using Quanlyphonggym.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Quanlyphonggym.BusinessLayer.ServiceInterface
{
    interface IquanlyphieutapBLL
    {
        void Nhap(ref List<PhieuTap> phieuTaps,List<NhanVien>nhanViens,List<KhachHang> khachHangs);
        void Hien(List<PhieuTap> phieuTaps);
        void Hien1(PhieuTap pt);
        void HienTimKiem(PhieuTap pt);
        PhieuTap TimKiem(List<PhieuTap> phieuTaps, string ma);
        void Xoa(ref List<PhieuTap> phieuTaps, PhieuTap sv);

    }
}
