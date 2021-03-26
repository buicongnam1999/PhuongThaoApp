using PhuongThao.Common.Class;
using PhuongThao.DataLayer.DataLayer;
using PhuongThao.Service.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhuongThao.Service.Service
{
    public class CartService : ICartService<Cart>
    {
        CartConnect _cartService = new CartConnect();

        /// <summary>
        /// Xóa giỏ hàng hiện tại
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int DeleteCart(int id)
        {
            return _cartService.Delete(id);
        }


        /// <summary>
        /// Thêm giỏ hàng mới
        /// </summary>
        /// <param name="ncart">Giỏ hàng mới</param>
        /// <returns>Số lượng bản ghi thực thi</returns>
        public int InsertCart(Cart ncart)
        {
            return _cartService.InsertCart(ncart);
        }


        /// <summary>
        /// Chỉnh sửa giỏ hàng
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public int UpdateCart(Cart c)
        {
            return _cartService.UpdateCart(c);
        }

        /// <summary>
        /// Lấy giỏ hàng theo người dùng
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IEnumerable<object> GetCartByUser(int id)
        {
            return _cartService.GetCartByUser(id);
        }

        /// <summary>
        /// Lấy giỏ hàng theo ID người dùng
        /// </summary>
        /// <param name="id">ID người dùng</param>
        /// <returns></returns>
        public int GetCartByUserId(int id)
        {
            return _cartService.GetCartByUserId(id);
        }

        /// <summary>
        /// Đếm số lượng sản phẩm có trong giỏ hàng
        /// </summary>
        /// <param name="user_id">ID người dùng</param>
        /// <returns>Số lượng sản phẩm</returns>
        public int CountProduct(int user_id)
        {
            return _cartService.CountProduct(user_id);
        }
    }
}
