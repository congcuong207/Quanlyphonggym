using Quanlyphonggym.DataAccess.ServiceInterface;
using Quanlyphonggym.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Quanlyphonggym
{
    class quanlyphieutapDAO : IquanlyphieutapDAO
    {
        public void GhiThongTin(List<PhieuTap> phieuTaps)
        {
            StreamWriter writer = new StreamWriter("PhieuTap.txt");
            foreach (PhieuTap pt in phieuTaps)
            {
                writer.WriteLine(pt.MaTheKhachHang + "#" + pt.MaHocVien + "#" + pt.NgayDky + "#" + pt.NgayHethan + "#" + pt.MaNhanvien);
            }
            writer.Close();
        }


        public List<PhieuTap> LayDS()
        {
            List<PhieuTap> phieuTaps = new List<PhieuTap>();
            StreamReader sr = new StreamReader("PhieuTap.txt");
            string s;
            while ((s = sr.ReadLine()) != null)
            {
                if (string.IsNullOrEmpty(s))
                    continue;
                string[] tmp = s.Split('#');
                phieuTaps.Add(new PhieuTap(tmp[0], tmp[1], tmp[2], tmp[3], tmp[4]));

            }
            sr.Close();
            return phieuTaps;

        }
    }
}
