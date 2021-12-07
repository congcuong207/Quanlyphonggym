using Quanlyphonggym.DataAccess.ServiceInterface;
using Quanlyphonggym.Entities;

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Quanlyphonggym.ChucNang
{
    class quanlykhachhangDAO:IquanlykhachhangDAO
    {
        
        public void GhiThongTin(List<KhachHang> KhachHangs)
        {
            StreamWriter writer = new StreamWriter("KhachHang.txt");
            foreach (KhachHang kh in KhachHangs)
            {
                writer.WriteLine(kh.MaKH + "#" + kh.HoTen + "#" + kh.NgaySinh+"#"+ kh.DiaChi+"#"+ kh.SoDT);
            }
            writer.Close();
        }
        public List<KhachHang> LayDS()
        {
            List<KhachHang> KhachHangs = new List<KhachHang>();
            StreamReader sr = new StreamReader("KhachHang.txt");
            string s;
            while ((s = sr.ReadLine()) != null)
            {
                if (string.IsNullOrEmpty(s))
                    continue;
                string[] tmp = s.Split('#');
                KhachHangs.Add(new KhachHang(tmp[0], tmp[1],tmp[2],tmp[3],tmp[4]));

            }
            sr.Close();
            return KhachHangs;

        }
    }
}
