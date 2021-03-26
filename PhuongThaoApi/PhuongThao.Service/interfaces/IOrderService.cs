using PhuongThao.Common.Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhuongThao.Service.interfaces
{
    public interface IOrderService
    {
        public int InsertOrder(Order norder);

        public int UpdateOrder(Order c);

        public int DeleteOrder(int id);
    }
}
