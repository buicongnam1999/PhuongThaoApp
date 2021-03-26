using PhuongThao.Common.Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhuongThao.Service.interfaces
{
    public interface IOrderDetailService
    {
        /// <summary>
        /// Thêm mới sản phẩm
        /// </summary>
        /// <param name="norder"></param>
        /// <returns></returns>
        public int InsertOrder(int order_id, int food_id, int quality);

        public int DeleteOrderDetail(int order_id);
    }
}
