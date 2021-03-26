using Dapper;
using PhuongThao.Common.Class;
using PhuongThao.DataLayer.interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace PhuongThao.DataLayer.DataLayer
{
    public class CartConnect : DBConnect<Cart>, ICartConnect
    {
        public bool CheckCart(string email)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Xóa toàn bộ giỏ hàng
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int Delete(int id)
        {
            this._dbConnect = new SqlConnection(this._stringConnect);
            String sql = "DELETE FROM tblcart where cart_id=" + id;
            _dbConnect.Open();
            var a = _dbConnect.Execute(sql);
            _dbConnect.Close();
            return a;
        }

        /// <summary>
        /// Lấy toàn bộ giỏ hàng
        /// </summary>
        /// <returns>Danh sách giỏ hàng</returns>
        public IEnumerable<object> GetAllCart()
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Lấy toàn bộ giỏ hàng theo người dùng
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IEnumerable<object> GetCartByUser(int id)
        {
            String sql = "SELECT * FROM tblcart LEFT JOIN tbluser ON tblcart.u_id = tbluser.u_id LEFT JOIN tblcartdetail ON tblcart.cart_id = tblcartdetail.cart_id INNER JOIN tblfood ON tblcartdetail.food_id = tblfood.food_id  WHERE tblcart.u_id ="+id;
            this._dbConnect = new SqlConnection(this._stringConnect);
            _dbConnect.Open();
            var a = _dbConnect.Query(sql);
            _dbConnect.Close();
            return a;
        }

        /// <summary>
        /// Thêm giỏ hàng mới
        /// </summary>
        /// <param name="ncart"></param>
        /// <returns>Số lượng thực thi</returns>
        public int InsertCart(Cart ncart)
        {
            this._dbConnect = new SqlConnection(_stringConnect);
            SqlCommand cmd = new SqlCommand("Insert_Cart", this._dbConnect);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@u_id", ncart.u_id);
            cmd.Parameters.AddWithValue("@cart_note", ncart.cart_note);
            this._dbConnect.Open();
            int result = cmd.ExecuteNonQuery();
            this._dbConnect.Close();
            return result;
        }


        /// <summary>
        /// Chỉnh sửa giỏ hàng
        /// </summary>
        /// <param name="u"></param>
        /// <returns>Số lượng bản ghi đã chỉnh sửa</returns>
        public int UpdateCart(Cart u)
        {
            this._dbConnect = new SqlConnection(_stringConnect);
            SqlCommand cmd = new SqlCommand("Update_Cart", this._dbConnect);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cart_id", u.cart_id);
            cmd.Parameters.AddWithValue("@u_id", u.u_id);
            cmd.Parameters.AddWithValue("@cart_note", u.cart_note);
            this._dbConnect.Open();
            int result = cmd.ExecuteNonQuery();
            this._dbConnect.Close();
            return result;
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

        /// <summary>
        /// Đếm số lượng sản phẩm của sản phẩm hiện tại
        /// </summary>
        /// <param name="user_id">ID người dùng</param>
        /// <returns>Số lượng sản phẩm trong giỏ hàng</returns>
        public int CountProduct(int user_id)
        {
            String sql = "SELECT COUNT(food_id) FROM tblcart INNER JOIN tblcartdetail ON tblcart.cart_id = tblcartdetail.cart_id" +
                " INNER JOIN tbluser ON tblcart.u_id = tbluser.u_id WHERE tbluser.u_id =" + user_id;
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
