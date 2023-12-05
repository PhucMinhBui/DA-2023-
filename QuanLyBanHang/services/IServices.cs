using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyBanHang.models;


namespace QuanLyBanHang.services
{
    public interface IServices<T>
    {
        List<T> getALL();
        T getByID(string id);
        void btnThem(T entity);
        void btnSua(T entity);
        void btnXoa(T Ma);
        void setAll(List<T> list);
    }
}
