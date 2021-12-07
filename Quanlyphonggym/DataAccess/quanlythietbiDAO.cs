using Quanlyphonggym.DataAccess.ServiceInterface;
using Quanlyphonggym.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Quanlyphonggym
{
    class quanlythietbiDAO:IquanlythietbiDAO
    {
    
        public void GhiThongTin(List<ThietBi> thietBis)
        {
            StreamWriter writer = new StreamWriter("ThietBi.txt");
            foreach (ThietBi tb in thietBis)
            {
                writer.WriteLine(tb.MaTB + "#" + tb.TenTB + "#" + tb.TinhTrang+"#"+tb.SoLuong);
            }
            writer.Close();
        }
        public List<ThietBi> LayDS()
        {
            List<ThietBi> thietBis = new List<ThietBi>();
            StreamReader sr = new StreamReader("ThietBi.txt");
            string s;
            while ((s = sr.ReadLine()) != null)
            {
                if (string.IsNullOrEmpty(s))
                    continue;
                string[] tmp = s.Split('#');
                thietBis.Add(new ThietBi(tmp[0], tmp[1], tmp[2],int.Parse(tmp[3])));

            }
            sr.Close();
            return thietBis;

        }
    }
}
