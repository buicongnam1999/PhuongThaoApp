using PhuongThao.Common.Class;
using PhuongThao.DataLayer.DataLayer;
using PhuongThao.Service.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhuongThao.Service.Service
{
    public class OrderService : IOrderService
    {
        OrderConnect _orderConnect = new OrderConnect();

        /// <summary>
        /// Xóa thanh toán theo ID
        /// </summary>
        /// <param name="id">ID thanh toán</param>
        /// <returns>Số bản ghi thực thi</returns>
        public int DeleteOrder(int id)
        {
            return _orderConnect.DeleteOrder(id);
        }


        /// <summary>
        /// Thêm mới thanh toán
        /// </summary>
        /// <param name="norder">Thanh toán</param>
        /// <returns>Số lượng bản ghi thực thi</returns>
        public int InsertOrder(Order norder)
        {
            return _orderConnect.InsertOrder(norder);
        }


        /// <summary>
        /// Chỉnh sửa bản ghi
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public int UpdateOrder(Order c)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Lấy toàn bộ thanh toán theo người dùng
        /// </summary>
        /// <param name="id">ID người dùng</param>
        /// <returns>Danh sách thanh toán</returns>
        public IEnumerable<object> GetOrderByUser(int id)
        {
            return _orderConnect.GetOrderByUser(id);
        }

        /// <summary>
        /// Lấy ID thanh toán vừa thêm
        /// </summary>
        /// <param name="id"></param>
        /// <returns>ID thanh toán vừa thêm</returns>
        public int GetUserOrder(int id)
        {
            return this._orderConnect.GetUserOrder(id);
        }

        /// <summary>
        /// Lấy toàn bộ danh sách sản phẩm theo người dùng
        /// </summary>
        /// <param name="user_id">ID người dùng</param>
        /// <returns>Danh sách sản phẩm trong giỏ hàng</returns>
        public List<CartDetail> GetProductsCart(int user_id)
        {
            return this._orderConnect.GetProductsCart(user_id);
        }

        /// <summary>
        /// Thêm chi tiết vào thanh toán
        /// </summary>
        /// <param name="cd">Danh sách sản phẩm</param>
        /// <param name="order_id">ID thanh toán</param>
        /// <returns>Danh sách số lượng sản phẩm đã thêm</returns>
        public int InsertOrderDetail(List<CartDetail> cd, int order_id)
        {
            return this._orderConnect.InsertOrderDetail(cd, order_id);
        }

        /// <summary>
        /// Đếm số lượng sản phẩm có trong giỏ hàng
        /// </summary>
        /// <param name="user_id">ID người dùng</param>
        /// <returns>Số lượng sản phẩm trong giỏ</returns>
        public int CountProductCart(int user_id)
        {
            return this._orderConnect.CountProductCart(user_id);
        }

        /// <summary>
        /// Cập nhật thông tin sản phẩm khi thanh toán
        /// </summary>
        /// <param name="food_id">ID sản phẩm</param>
        /// <param name="amount">Số lượng sản phẩm</param>
        /// <returns>Số lượng sản phẩm cập nhật</returns>
        public int UpdateFood(int food_id, int amount)
        {
            return this._orderConnect.UpdateFood(food_id, amount);
        }

        /// <summary>
        /// Xóa dữ liệu sản phẩm giỏ hàng
        /// </summary>
        /// <param name="cart_id"></param>
        /// <param name="food_id"></param>
        /// <returns>Số lượng sản phẩm xóa</returns>
        public int DeleteFoodCart(int cart_id, int food_id)
        {
            return this._orderConnect.DeleteFoodCart(cart_id, food_id);
        }


        /// <summary>
        /// Xóa giỏ hàng khi thanh toán
        /// </summary>
        /// <param name="cart_id">ID giỏ hàng</param>
        /// <returns>Số lượng bản ghi thực thi</returns>
        public int DeleteCart(int cart_id)
        {
            return this._orderConnect.DeleteCart(cart_id);
        }

        /// <summary>
        /// Lấy giỏ hàng theo người dùng
        /// </summary>
        /// <param name="id">ID người dùng</param>
        /// <returns>ID giỏ hàng người dùng</returns>
        public int GetCartByUserId(int id)
        {
            return this._orderConnect.GetCartByUserId(id);
        }

        /// <summary>
        /// Lấy toàn bộ danh sách thanh toán
        /// </summary>
        /// <returns>Danh sách thanh toán</returns>
        public IEnumerable<object> GetAllOder()
        {
            return this._orderConnect.GetAllOder();
        }
    }
}
