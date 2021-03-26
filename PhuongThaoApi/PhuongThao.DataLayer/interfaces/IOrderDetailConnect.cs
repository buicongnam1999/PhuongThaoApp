using PhuongThao.Common.Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhuongThao.DataLayer.interfaces
{
    public interface IOrderDetailConnect
    {
        /// <summary>
        /// Lấy toàn bộ danh sách
        /// </summary>
        /// <returns>Danh sách người dùng</returns>
        /// Create By: NamBC (17/03/21)
        public IEnumerable<object> GetAllOrder();

        /// <summary>
        /// Thêm mới người dùng
        /// </summary>
        /// <param name="nOrder">Người dùng mới</param>
        /// <returns>Kiểu số nguyên thủy</returns>
        /// Create By: NamBC (08/03/21)
        public int InsertOrder(int order_id, int food_id, int quality);

        /// <summary>
        /// Sửa thông tin người dùng
        /// </summary>
        /// <param name="u">Người dùng</param>
        /// <returns>Kiểu số tự nhiên</returns>
        /// Create By: NamBC (08/03/21)
        public int UpdateOrder(Order u);

        /// <summary>
        /// Xóa người dùng
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns>Kiểu số tự nhiên</returns>
        public int Delete(int id);

        /// <summary>
        /// Lấy thanh toán theo người dùng
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Danh sách thanh toán</returns>
        public IEnumerable<object> GetOrderByUser(int id);

        /// <summary>
        /// Lấy thanh toán theo người dùng
        /// </summary>
        /// <param name="id">ID người dùng</param>
        /// <returns>Số ID thanh toán</returns>
        public int GetOrderByUserId(int id);
    }
}
