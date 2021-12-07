using Quanlyphonggym.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Quanlyphonggym.DataAccess.ServiceInterface
{
    interface IquanlythietbiDAO
    {
        void GhiThongTin(List<ThietBi> thietBis);
        List<ThietBi> LayDS();
    }
}
