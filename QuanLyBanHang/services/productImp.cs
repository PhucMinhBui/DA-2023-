using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyBanHang.models;
using QuanLyBanHang.services;

namespace QuanLyBanHang
{
    class productImp : IServices<CProduct>
    {

        List<CProduct> productslmp = new List<CProduct>();
        public void btnThem(CProduct entity)
        {
            productslmp.Add(entity);
        }

        public void btnXoa(CProduct id)
        {
            productslmp.Remove(id);
        }

        public List<CProduct> getALL()
        {
            return productslmp;
        }

        public CProduct getByID(string id)
        {
            throw new NotImplementedException();
        }

        public void btnSua(CProduct entity)
        {
            throw new NotImplementedException();
        }
        public void setAll(List<CProduct> list)
        {
            productslmp = list;
        }
    }
}
