using Quanlyphonggym.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Quanlyphonggym.DataAccess.ServiceInterface
{
     interface IquanlynhanvienDAO
    {
        void GhiThongTin(List<NhanVien> phieuTaps);
        List<NhanVien> LayDS();
    }
}
