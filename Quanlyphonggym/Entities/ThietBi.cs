using System;
using System.Collections.Generic;
using System.Text;

namespace Quanlyphonggym.Entities
{
    class ThietBi
    {
        private string maTB;
        private string tenTB;
        private string tinhTrang;
        private int soLuong;
        
        public string MaTB { get => maTB; set => maTB = value; }
        public string TenTB { get => tenTB; set => tenTB = value; }
        public string TinhTrang { get => tinhTrang; set => tinhTrang = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
       
        public ThietBi(string maTB,string tenTB,string tinhTrang,int soLuong)
        {
            this.maTB = maTB;
            this.tenTB = tenTB;
            this.tinhTrang = tinhTrang;
            this.soLuong = soLuong;
        }

        public ThietBi()
        {
        }
    }
}
