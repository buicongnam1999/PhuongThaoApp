using PhuongThao.Common.Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhuongThao.DataLayer.interfaces
{
    public interface IOrderConnect
    {
        public IEnumerable<object> GetAllOder();

        public IEnumerable<object> GetOrderByUser(int id);

        public int InsertOrder(Order entity);

        public int UpdateOrder(Order entity);

        public int DeleteOrder(int id);
    }
}
