using System;
using System.Collections.Generic;
using System.Text;

namespace PhuongThao.Service.interfaces
{
    public interface IBaseService<T>
    {

        public IEnumerable<Object> GetAllData();

        public int InsertObject(T entity);

        public int UpdateObject(T entity);


        public int DeleteObject(int id);
    }
}
