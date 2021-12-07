using Quanlyphonggym.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Quanlyphonggym.DataAccess.ServiceInterface
{
    interface IquanlykhachhangDAO
    {
        void GhiThongTin(List<KhachHang> sinhViens);
        List<KhachHang> LayDS();
    }
}
