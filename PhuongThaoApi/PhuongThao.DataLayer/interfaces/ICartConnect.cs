using PhuongThao.Common.Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhuongThao.DataLayer.interfaces
{
    public interface ICartConnect
    {
        /// <summary>
        /// Lấy toàn bộ danh sách
        /// </summary>
        /// <returns>Danh sách người dùng</returns>
        /// Create By: NamBC (17/03/21)
        public IEnumerable<object> GetAllCart();

        /// <summary>
        /// Thêm mới người dùng
        /// </summary>
        /// <param name="nCart">Người dùng mới</param>
        /// <returns>Kiểu số nguyên thủy</returns>
        /// Create By: NamBC (08/03/21)
        public int InsertCart(Cart ncart);

        /// <summary>
        /// Sửa thông tin người dùng
        /// </summary>
        /// <param name="u">Người dùng</param>
        /// <returns>Kiểu số tự nhiên</returns>
        /// Create By: NamBC (08/03/21)
        public int UpdateCart(Cart u);

        /// <summary>
        /// Xóa người dùng
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns>Kiểu số tự nhiên</returns>
        public int Delete(int id);

        public IEnumerable<object> GetCartByUser(int id);

        public int GetCartByUserId(int id);

    }
}
