using Quanlyphonggym.DataAccess.ServiceInterface;
using Quanlyphonggym.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Quanlyphonggym.DataAccess
{
    class quanlynhanvienDAO : IquanlynhanvienDAO
    {
        public void GhiThongTin(List<NhanVien> nhanViens)
        {
            StreamWriter writer = new StreamWriter("NhanVien.txt");
            foreach (NhanVien pt in nhanViens)
            {
                writer.WriteLine(pt.MaNV + "#" + pt.TenNV + "#" + pt.SoDT + "#" + pt.NgaySinh + "#" + pt.DiaChi);
            }
            writer.Close();
        }

        public List<NhanVien> LayDS()
        {
            List<NhanVien> nhanViens = new List<NhanVien>();
            StreamReader sr = new StreamReader("NhanVien.txt");
            string s;
            while ((s = sr.ReadLine()) != null)
            {
                if (string.IsNullOrEmpty(s))
                    continue;
                string[] tmp = s.Split('#');
                nhanViens.Add(new NhanVien(tmp[0], tmp[1], tmp[2], tmp[3], tmp[4]));

            }
            sr.Close();
            return nhanViens;
        }
    }
}
