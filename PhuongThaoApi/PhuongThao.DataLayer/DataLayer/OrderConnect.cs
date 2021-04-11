using Dapper;
using PhuongThao.Common.Class;
using PhuongThao.DataLayer.interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace PhuongThao.DataLayer.DataLayer
{
    public class OrderConnect : DBConnect<Order>, IOrderConnect
    {

        /// <summary>
        /// Xóa sản thanh toán
        /// </summary>
        /// <param name="entity">Thanh toán cần xóa</param>
        /// <returns>Số lượng bản ghi thực thi</returns>
        public int DeleteOrder(int id)
        {
            String sql = "DELETE FROM tblorder WHERE order_id = "+id;
            this._dbConnect = new SqlConnection(this._stringConnect);
            this._dbConnect.Open();
            var res = this._dbConnect.Execute(sql);
            this._dbConnect.Close();
            return res;
        }

        /// <summary>
        /// Lấy toàn bộ danh sách thanh toán
        /// </summary>
        /// <returns>Danh sách thanh toán</returns>
        public IEnumerable<object> GetAllOder()
        {
            String sql = "SELECT * FROM tblorder LEFT JOIN tbluser ON tblorder.u_id = tbluser.u_id LEFT JOIN tblorderdetail ON tblorder.order_id = tblorderdetail.order_id INNER JOIN tblfood ON tblorderdetail.food_id = tblfood.food_id";
            this._dbConnect = new SqlConnection(this._stringConnect);
            _dbConnect.Open();
            var a = _dbConnect.Query(sql);
            _dbConnect.Close();
            return a;
        }

        /// <summary>
        /// Lấy danh sách thanh toán theo người dùng
        /// </summary>
        /// <param name="id">ID người dùng</param>
        /// <returns>Danh sách thanh toán theo người dùng</returns>
        public IEnumerable<object> GetOrderByUser(int id)
        {
            String sql = "SELECT * FROM tblorder LEFT JOIN tbluser ON tblorder.u_id = tbluser.u_id LEFT JOIN tblorderdetail ON tblorder.order_id = tblorderdetail.order_id INNER JOIN tblfood ON tblorderdetail.food_id = tblfood.food_id  WHERE tblorder.u_id =" + id;
            this._dbConnect = new SqlConnection(this._stringConnect);
            _dbConnect.Open();
            var a = _dbConnect.Query(sql);
            _dbConnect.Close();

            return a;
        }

        /// <summary>
        /// Thêm mới thanh toán
        /// </summary>
        /// <param name="norder">Thanh toán</param>
        /// <returns>Danh sách thực thi</returns>
        public int InsertOrder(Order norder)
        {
            this._dbConnect = new SqlConnection(_stringConnect);
            SqlCommand cmd = new SqlCommand("Insert_Order", this._dbConnect);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@u_id", norder.u_id);
            cmd.Parameters.AddWithValue("@order_date", norder.order_date);
            cmd.Parameters.AddWithValue("@order_note", norder.order_note);
            cmd.Parameters.AddWithValue("@order_status", norder.order_status);
            this._dbConnect.Open();
            int result = cmd.ExecuteNonQuery();
            this._dbConnect.Close();
            return result;
        }

        /// <summary>
        /// Sửa thông tin thanh toán
        /// </summary>
        /// <param name="entity">Thanh toán</param>
        /// <returns>Số lượng bản ghi chỉnh sửa</returns>
        public int UpdateOrder(Order entity)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Lấy thanh toán theo người dùng
        /// </summary>
        /// <param name="id">ID người dùng</param>
        /// <returns>Số thanh toán</returns>
        public int GetUserOrder(int id)
        {
            String sql = "SELECT MAX(order_id) FROM tblorder INNER JOIN tbluser ON tblorder.u_id = tbluser.u_id WHERE tbluser.u_id = "+id;
            SqlCommand cmd = new SqlCommand(sql, this._dbConnect);
            int a = 0;
            _dbConnect.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                a = rd.GetInt32(0);
            }
            _dbConnect.Close();
            return a;
        }

        /// <summary>
        /// Lấy danh sách sản phẩm trong giỏ hàng
        /// </summary>
        /// <param name="user_id">ID người dùng</param>
        /// <returns>Danh sách cần thêm vào thanh toán</returns>
        public List<CartDetail> GetProductsCart(int user_id)
        {
            String sql = "SELECT * FROM tblcart INNER JOIN tblcartdetail ON tblcart.cart_id = tblcartdetail.cart_id" +
                " INNER JOIN tbluser ON tbluser.u_id = tblcart.u_id WHERE tbluser.u_id = "+user_id;
            _dbConnect.Open();
            var res =_dbConnect.Query<CartDetail>(sql).ToList();
            _dbConnect.Close();
            return res;
        }

        /// <summary>
        /// Thêm mới sản phẩm vào thanh toán
        /// </summary>
        /// <param name="cd">Danh sách sản phẩm thanh toán</param>
        /// <param name="order_id">ID thanh toán</param>
        /// <returns>Số lượng sản phẩm đã thêm</returns>
        public int InsertOrderDetail(List<CartDetail> cd, int order_id)
        {
            int i = 0;
            foreach(CartDetail c in cd)
            {
                String sql = "INSERT INTO tblorderdetail(order_id,food_id,quality,order_status) " +
                    "VALUES(" + order_id + "," + c.food_id + "," + c.quality + "," + 1 + ")";
                _dbConnect.Open();
                var a = _dbConnect.Execute(sql);
                _dbConnect.Close();
                if(a > 0)
                {
                    i++;
                }
            }
            return i;
        }

        /// <summary>
        /// Đếm số sản phẩm có trong giỏ hàng
        /// </summary>
        /// <param name="user_id">ID người dùng</param>
        /// <returns>Số lượng sản phẩm trong giỏ hàng</returns>
        public int CountProductCart(int user_id)
        {
            String sql = "SELECT COUNT(food_id) FROM tblcart INNER JOIN tblcartdetail " +
            "ON tblcart.cart_id = tblcartdetail.cart_id INNER JOIN tbluser ON tblcart.u_id = tbluser.u_id WHERE tbluser.u_id = " + user_id;
            SqlCommand cmd = new SqlCommand(sql, this._dbConnect);
            int count = 0;
            _dbConnect.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                count = rd.GetInt32(0);
            }
            _dbConnect.Close();
            return count;
        }

        /// <summary>
        /// Cập nhật lại danh sách số lượng sản phẩm sau khi thanh toán
        /// </summary>
        /// <param name="food_id">ID sản phẩm</param>
        /// <param name="amount">Số lượng sản phẩm</param>
        /// <returns>Số lượng bản ghi thực thi</returns>
        public int UpdateFood(int food_id, int amount)
        {
            String sql = "UPDATE tblfood SET food_quality = food_quality - " + amount + " WHERE food_id = " + food_id;
            _dbConnect.Open();
            var res = _dbConnect.Execute(sql);
            _dbConnect.Close();
            return res;
        }

        /// <summary>
        /// Xóa sản phẩm trong giỏ hàng
        /// </summary>
        /// <param name="food_id">ID sản phẩm</param>
        /// <param name="cart_id">ID giỏ hàng</param>
        /// <returns>Số lượng bản ghi thực thi</returns>
        public int DeleteFoodCart(int cart_id ,int food_id)
        {
            this._dbConnect = new SqlConnection(this._stringConnect);
            String sql = "DELETE FROM tblcartdetail WHERE cart_id = " + cart_id + " AND food_id =" + food_id;
            _dbConnect.Open();
            var res = _dbConnect.Execute(sql);
            _dbConnect.Close();
            return res;
        }

        /// <summary>
        /// Xóa giỏ hàng
        /// </summary>
        /// <param name="cart_id"></param>
        /// <returns></returns>
        public int DeleteCart(int cart_id)
        {
            this._dbConnect = new SqlConnection(this._stringConnect);
            String sql = "DELETE FROM tblcart where cart_id=" + cart_id;
            _dbConnect.Open();
            var a = _dbConnect.Execute(sql);
            _dbConnect.Close();
            return a;
        }

        /// <summary>
        /// Lấy giỏ hàng theo người dùng
        /// </summary>
        /// <param name="id">ID người dùng</param>
        /// <returns>ID giỏ hàng người dùng</returns>
        public int GetCartByUserId(int id)
        {
            String sql = "SELECT cart_id FROM tblcart LEFT JOIN tbluser ON tblcart.u_id = tbluser.u_id WHERE tblcart.u_id =" + id;
            this._dbConnect = new SqlConnection(this._stringConnect);
            SqlCommand cmd = new SqlCommand(sql, this._dbConnect);
            int a = 0;
            _dbConnect.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                a = rd.GetInt32(0);
            }
            _dbConnect.Close();
            return a;
        }
    }
}
