
using Quanlyphonggym.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Quanlyphonggym.BusinessLayer.ServiceInterface
{
    interface IquanlythietbiBLL
    {
        void Nhap(ref List<ThietBi> thietBis);
        void Hien(List<ThietBi> thietBis);
        void Hien1(ThietBi tb);
        void HienTimKiem(ThietBi tb);
        ThietBi TimKiem(List<ThietBi> thietBis, string ma);
        void Xoa(ref List<ThietBi> thietBis, ThietBi tb);
        void Sua(ref List<ThietBi> thietBis, string ma);

    }
}
