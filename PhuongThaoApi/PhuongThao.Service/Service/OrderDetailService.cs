using PhuongThao.DataLayer.DataLayer;
using PhuongThao.Service.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhuongThao.Service.Service
{
    public class OrderDetailService :IOrderDetailService
    {
        OrderDetailConnect _orderDetailConnect = new OrderDetailConnect();
        /// <summary>
        /// Xóa toàn bộ danh sách sản phẩm trong thanh toán
        /// </summary>
        /// <param name="order_id">ID thanh toán</param>
        /// <returns>Số lượng bản ghi thực thi</returns>
        public int DeleteOrderDetail(int order_id)
        {
            return _orderDetailConnect.DeleteOrderDetail(order_id);
        }

        /// <summary>
        /// Thêm mới sản phẩm vào thanh toán
        /// </summary>
        /// <param name="order_id">ID thanh toán</param>
        /// <param name="food_id">ID sản phẩm</param>
        /// <param name="quality">Số lượng</param>
        /// <returns>Số lượng bản ghi đã thực thi</returns>
        public int InsertOrder(int order_id, int food_id, int quality)
        {
            return _orderDetailConnect.InsertOrder(order_id, food_id, quality);
        }

    }
}
