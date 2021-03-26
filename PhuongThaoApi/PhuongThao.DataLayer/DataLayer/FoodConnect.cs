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
    public class FoodConnect :DBConnect<User>, IFoodConnect
    {

        #region DECLARE
        
        #endregion

        #region Constructor

        #endregion


        #region Method
        /// <summary>
        /// Lấy toàn bộ danh sách sản phẩm
        /// </summary>
        /// <returns>Danh sách sản phẩm</returns>
        /// Create By: NamBC (17/03/21)
        public IEnumerable<object> GetAllProduct()
        {
            this._dbConnect = new SqlConnection(this._stringConnect);
            String sql = "SELECT * FROM tblfood INNER JOIN tblcoupons ON tblfood.cou_id = tblcoupons.cou_id";
            return this._dbConnect.Query<object>(sql, commandType: CommandType.Text);
        }

        /// <summary>
        /// Thêm mới sản phẩm
        /// </summary>
        /// <param name="nf">Sản phẩm mới</param>
        /// <returns>Số lượng thực thi sản phẩm</returns>
        public int InsertFood(Food nf)
        {
            this._dbConnect = new SqlConnection(this._stringConnect);
            SqlCommand cmd = new SqlCommand("Insert_Food", this._dbConnect);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@food_code", nf.food_code);
            cmd.Parameters.AddWithValue("@sup_id", nf.sup_id);
            cmd.Parameters.AddWithValue("@food_name", nf.food_name);
            cmd.Parameters.AddWithValue("@food_img", nf.food_img);
            cmd.Parameters.AddWithValue("@food_money", nf.food_money);
            cmd.Parameters.AddWithValue("@food_quality", nf.food_quality);
            cmd.Parameters.AddWithValue("@food_type", nf.food_type);
            cmd.Parameters.AddWithValue("@cou_id", nf.cou_id);
            cmd.Parameters.AddWithValue("@food_status", nf.food_status);
            cmd.Parameters.AddWithValue("@food_count_order", nf.food_count_order);
            cmd.Parameters.AddWithValue("@food_description", nf. food_description);

            _dbConnect.Open();
            int result = cmd.ExecuteNonQuery();
            _dbConnect.Close();
            return result;
        }


        /// <summary>
        /// Chỉnh sửa thông tin sản phẩm
        /// </summary>
        /// <param name="f">Sản phẩm</param>
        /// <returns>Số lượng thực thi</returns>
        public int UpdateFood(Food f)
        {
            this._dbConnect = new SqlConnection(this._stringConnect);
            SqlCommand cmd = new SqlCommand("Insert_Food", this._dbConnect);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@food_code", f.food_code);
            cmd.Parameters.AddWithValue("@sup_id", f.sup_id);
            cmd.Parameters.AddWithValue("@food_name", f.food_name);
            cmd.Parameters.AddWithValue("@food_img", f.food_img);
            cmd.Parameters.AddWithValue("@food_money", f.food_money);
            cmd.Parameters.AddWithValue("@food_quality", f.food_quality);
            cmd.Parameters.AddWithValue("@food_type", f.food_type);
            cmd.Parameters.AddWithValue("@cou_id", f.cou_id);
            cmd.Parameters.AddWithValue("@food_status", f.food_status);
            cmd.Parameters.AddWithValue("@food_count_order", f.food_count_order);
            cmd.Parameters.AddWithValue("@food_id", f.food_id);

            _dbConnect.Open();
            int result = cmd.ExecuteNonQuery();
            _dbConnect.Close();
            return result;
        }


        /// <summary>
        /// Xóa sản phẩm theo mã sản phẩm
        /// </summary>
        /// <param name="id">ID ssanr phẩm</param>
        /// <returns></returns>
        public int DeleteFood(int id)
        {
            String sql = "DELETE FROM tblfood WHERE food_id = " + id;
            this._dbConnect = new SqlConnection(this._stringConnect);
            _dbConnect.Open();
            var result = _dbConnect.Execute(sql);
            _dbConnect.Close();
            return result;

        }

        /// <summary>
        /// Kiểm tra mã sản phẩm
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public Boolean CheckFoodCode(String code)
        {
            this._dbConnect = new SqlConnection(_stringConnect);
            String sql = "SELECT food_code FROM tblfood WHERE food_code = '" + code + "'";
            _dbConnect.Open();
            var result = _dbConnect.Execute(sql);
            _dbConnect.Close();
            if(result > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Lấy sản phẩm theo ID
        /// </summary>
        /// <param name="id">ID sản phẩm</param>
        /// <returns>Đối tượng sản phẩm cần tìm</returns>
        public object GetFoodById(int id)
        {
            this._dbConnect = new SqlConnection(this._stringConnect);
            String sql = "SELECT * FROM tblfood WHERE food_id = "+id;
            var res = this._dbConnect.Query<object>(sql, commandType: CommandType.Text);
            return res;
        }
        #endregion


    }
}
