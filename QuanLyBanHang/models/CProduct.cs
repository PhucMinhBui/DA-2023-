using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyBanHang.models;

namespace QuanLyBanHang.models
{
    [Serializable]
     class CProduct:Common 
    {
        private string m_ma;
        

        public string Ma { get => m_ma; set => m_ma = value; }
      

        public CProduct(string ma, string ten, string loai, string soluongnhap,string soluongxuat, string gianhap, string giaxuat, string ghichu)
        {
            Ma = ma;
            Ten = ten;
            Loai = loai;
            Soluongnhap = soluongnhap;
            Soluongxuat = soluongxuat;
            Gianhap = gianhap;
            Giaxuat = giaxuat;
            Ghichu = ghichu;
        }
        public CProduct() { }
    }

    
}
