using Dapper;
using PhuongThao.Common.Class;
using PhuongThao.DataLayer.interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace PhuongThao.DataLayer.DataLayer
{
    public class CartDetailConnect :DBConnect<Cart>, ICartDetailConnect<CartDetail>
    {

        /// <summary>
        /// Xóa sản phẩm theo sản phẩm và giỏ hàng
        /// </summary>
        /// <param name="id">ID hàng</param>
        /// <param name="product_id">ID sản phẩm</param>
        /// <returns>Số bản ghi bị xóa</returns>
        public int DeleteProduct(int id ,int product_id)
        {
            // Khởi tạo kết nối
            this._dbConnect = new SqlConnection(this._stringConnect);
            // Sql thực hiện
            String sql = "DELETE FROM tblcartdetail WHERE cart_id = " + id + " AND food_id ="+product_id;
            // Mở kết nối
            _dbConnect.Open();
            // Thực thi truy vấn
            var res = _dbConnect.Execute(sql);
            // Đóng kết nối
            _dbConnect.Close();
            return res;
        }

        /// <summary>
        /// Lấy toàn bộ sản phẩm
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IEnumerable<object> GetAllProduct(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Thêm một sản phẩm vào giỏ hàng
        /// </summary>
        /// <param name="cart_id">Mã giỏ hàng</param>
        /// <param name="product_id">Mã sản phẩm</param>
        /// <returns>Số lượng thực thi</returns>
        /// Create By: NamBC (18/03/21)
        public int InsertCart(int cart_id, int product_id)
        {
            // Câu truy vấn
            String sql = "INSERT INTO tblcartdetail(cart_id,food_id,quality,cart_status) VALUES("+cart_id+","+product_id+",1,1)";
            // Mở kết nối
            _dbConnect.Open();
            // Thực thi truy vấn
            var res = _dbConnect.Execute(sql);
            // Đóng kết nối
            _dbConnect.Close();
            return res;
        }

        /// <summary>
        /// Update số lượng theo số lượng, mã giỏ hàng, mã sản phẩm
        /// </summary>
        /// <param name="amount">Số lượng</param>
        /// <param name="cart_id">Mã giỏ hàng</param>
        /// <param name="product_id">Mã sản phẩm</param>
        /// <returns>Số bản ghi thực thi</returns>
        public int UpdateProduct(int amount , int cart_id, int product_id)
        {
            // Viết câu truy vấn
            String sql = "UPDATE tblcartdetail SET quality = "+amount+" WHERE food_id ="+product_id+" AND cart_id = "+cart_id;
            // Mở kết nối
            _dbConnect.Open();
            // Thực thi truy vấn
            var res = _dbConnect.Execute(sql);
            // Đóng kết nối
            _dbConnect.Close();
            return res;
        }

        /// <summary>
        /// Kiểm tra sản phẩm theo người dùng và sản phẩm
        /// </summary>
        /// <param name="product_id">ID sản phẩm</param>
        /// <param name="user_id">ID người dùng</param>
        /// <returns>Đúng sai</returns>
        public bool CheckProduct(int product_id, int user_id)
        {
            // Câu lệnh sql
            String sql = "SELECT * FROM tblcart INNER JOIN tblcartdetail ON tblcart.cart_id = tblcartdetail.cart_id " +
                "INNER JOIN tbluser ON tblcart.u_id = tbluser.u_id WHERE tbluser.u_id = "+ user_id+ " AND tblcartdetail.food_id = "+product_id;

            _dbConnect.Open();
            var res = _dbConnect.Query(sql);
            _dbConnect.Close();
            if(res.FirstOrDefault() == null)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Cập nhật chi tiết giỏ hàng khi tăng
        /// </summary>
        /// <param name="amount">Số lượng sản phẩm</param>
        /// <param name="cart_id">ID giỏ hàng</param>
        /// <param name="product_id">ID sản phẩm</param>
        /// <returns>Số lượng sản phẩm thực thi</returns>
        public int UpdateProductDetail(int amount, int cart_id, int product_id)
        {
            String sql = "UPDATE tblcartdetail SET quality = " + amount + " + quality WHERE food_id =" + product_id + " AND cart_id = " + cart_id;
            _dbConnect.Open();
            var res = _dbConnect.Execute(sql);
            _dbConnect.Close();
            return res;
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
            String sql = "UPDATE tblcartdetail SET quality = quality -" + amount + "  WHERE food_id =" + product_id + " AND cart_id = " + cart_id;
            _dbConnect.Open();
            var res = _dbConnect.Execute(sql);
            _dbConnect.Close();
            return res;
        }

        /// <summary>
        /// Kiểm tra số lượng xem có bằng 1 không
        /// </summary>
        /// <param name="cart_id">ID giỏ hàng</param>
        /// <param name="product_id">ID sản phẩm</param>
        /// <returns></returns>
        /*public int CheckAmountProduct(int cart_id, int product_id)
        {
            // Khởi tạo kết nối
            this._dbConnect = new SqlConnection(this._stringConnect);
            // Câu lệnh thực thi
            String sql = "SELECT "
        }*/

    }
}
