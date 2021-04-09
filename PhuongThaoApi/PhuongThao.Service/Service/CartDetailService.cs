using PhuongThao.Service.interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using PhuongThao.DataLayer.DataLayer;
namespace PhuongThao.Service.Service
{
    public class CartDetailService : ICartDetailService
    {
        CartDetailConnect _cartdetail = new CartDetailConnect();

        /// <summary>
        /// Xóa dữ liệu sản phẩm từ giỏ hàng
        /// </summary>
        /// <param name="cart_id">ID giỏ hàng</param>
        /// <param name="product_id">ID sản phẩm</param>
        /// <returns>Số bản ghi thực thi</returns>
        public int DeleteProduct(int cart_id, int product_id)
        {
            return _cartdetail.DeleteProduct(cart_id, product_id);
        }

        /// <summary>
        /// Lấy toàn bộ danh sách trong giỏ hàng
        /// </summary>
        /// <param name="id">ID giỏ hàng</param>
        /// <returns></returns>
        public IEnumerable<object> GetAllProduct(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Thêm mới sản phẩm
        /// </summary>
        /// <param name="cart_id">ID giỏ hàng</param>
        /// <param name="product_id">ID sản phẩm</param>
        /// <returns></returns>
        public int InsertCart(int cart_id, int product_id)
        {
            return _cartdetail.InsertCart(cart_id, product_id);
        }

        /// <summary>
        /// Chỉnh sửa số lượng sản phẩm
        /// </summary>
        /// <param name="amount">Số lượng sản phẩm</param>
        /// <param name="cart_id">ID giỏ hàng</param>
        /// <param name="product_id">ID sản phẩm</param>
        /// <returns>Số lượng bản ghi thực thi</returns>
        public int UpdateProduct(int amount, int cart_id, int product_id)
        {
            return _cartdetail.UpdateProduct(amount, cart_id, product_id);
        }

        /// <summary>
        /// Kiểm tra sản phẩm đã tồn tại trong giỏ hàng hay chưa
        /// </summary>
        /// <param name="product_id">ID sản phẩm</param>
        /// <param name="user_id">ID người dùng</param>
        /// <returns>Đúng sai</returns>
        public bool CheckProduct(int product_id, int user_id)
        {
            return _cartdetail.CheckProduct(product_id, user_id);
        }

        /// <summary>
        /// Cập nhật số lượng của một sản phẩm trong giỏ hàng
        /// </summary>
        /// <param name="amount">Số lượng truyền vào</param>
        /// <param name="cart_id">ID giỏ hàng</param>
        /// <param name="product_id">ID sản phẩm</param>
        /// <returns></returns>
        public int UpdateProductDetail(int amount, int cart_id, int product_id)
        {
            return _cartdetail.UpdateProductDetail(amount, cart_id, product_id);
        }

        /// <summary>
        /// Cập nhật chi tiết giỏ hàng khi giảm
        /// </summary>
        /// <param name="amount">Số lượng truyền vào</param>
        /// <param name="cart_id">ID giỏ hàng</param>
        /// <param name="product_id">ID sản phẩm</param>
        /// <returns>Số bản ghi thực thi truy vấn</returns>
        public int UpdateProductReduction(int amount, int cart_id, int product_id)
        {
            return this._cartdetail.UpdateProductReduction(amount, cart_id, product_id);
        }

    }
}
