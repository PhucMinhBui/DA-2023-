using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.models
{
    [Serializable]
    class Common
    {
  
        private string m_ten;
        private string m_loai;
        private string m_soluongnhap;
        private string m_soluongxuat;
        private string m_gianhap;
        private string m_giaxuat;
        private string m_ghichu;
        
        public string Ten { get => m_ten; set => m_ten = value; }
        public string Loai { get => m_loai; set => m_loai = value; }
        public string Soluongnhap { get => m_soluongnhap; set => m_soluongnhap = value; }
        public string Soluongxuat { get => m_soluongxuat; set => m_soluongxuat = value; }
        public string Gianhap { get => m_gianhap; set => m_gianhap = value; }
        public string Giaxuat { get => m_giaxuat; set => m_giaxuat = value; }
        public string Ghichu { get => m_ghichu; set => m_ghichu = value; }


        
    }
}
