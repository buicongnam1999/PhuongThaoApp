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
    public class UserConnect : IUserConnect
    {
        #region DECLARE
        public String _stringConnect = @"Data Source=DESKTOP-1BICBR5\SQLEXPRESS;Initial Catalog=PhuongThaoShop;Integrated Security=True";
        SqlConnection _dbConnect;
        #endregion

        #region 
        public UserConnect()
        {
            _dbConnect = new SqlConnection(_stringConnect);
        }

        /// <summary>
        /// Kiểm tra email người dùng
        /// </summary>
        /// <param name="email">Email truyền vào</param>
        /// <returns></returns>
        public bool CheckUserEmail(string email)
        {
            _dbConnect = new SqlConnection(_stringConnect);
            String sql = "SELECT user_email FROM tbluser WHERE user_email ='" +email+"'";
            _dbConnect.Open();
            var e = _dbConnect.Query<object>(sql, commandType: CommandType.Text);
            _dbConnect.Close();
            if(e.Count() > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        /// <summary>
        /// Kiểm tra tài khoản người dùng
        /// </summary>
        /// <param name="name">Tài khoản</param>
        /// <returns>Đúng sai</returns>
        public bool CheckUserName(string name)
        {
            _dbConnect = new SqlConnection(_stringConnect);
            String sql = "SELECT u_name FROM tbluser WHERE u_name ='" + name + "'";
            _dbConnect.Open();
            var u = _dbConnect.Query<object>(sql, commandType: CommandType.Text);
            _dbConnect.Close();
            if (u.Count() > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        #endregion

        #region Method
        /// <summary>
        /// Xóa người dùng
        /// </summary>
        /// <param name="id">Mã người dùng</param>
        /// <returns>Số lượng bản ghi thực thi</returns>
        public int Delete(int id)
        {
            _dbConnect = new SqlConnection(_stringConnect);
            String sql = "DELETE FROM tbluser WHERE u_id =" + id;
            /*SqlCommand cmd = new SqlCommand(sql, _dbConnect);
            cmd.Parameters.AddWithValue("@u_id", id);*/
            _dbConnect.Open();
            int a = _dbConnect.Execute(sql,commandType: CommandType.Text);
            _dbConnect.Close();

            return a;
        }

        /// <summary>
        /// Lấy toàn bộ danh sách khách hàng
        /// </summary>
        /// <returns>Lấy toàn bộ danh sách khách hàng</returns>
        public IEnumerable<object> getAllCustomer()
        {
            _dbConnect = new SqlConnection(_stringConnect);
            String sql = "SELECT * FROM tbluser WHERE user_type = 1";
            _dbConnect.Open();
            var a = _dbConnect.Query(sql);
            _dbConnect.Close();
            return a;
        }

        /// <summary>
        /// Lấy toàn bộ danh sách người dùng
        /// </summary>
        /// <returns>Danh sách người dùng</returns>
        public IEnumerable<object> getAllEmployee()
        {
            _dbConnect = new SqlConnection(_stringConnect);
            String sql = "SELECT * FROM tbluser WHERE user_type = 2";
            _dbConnect.Open();
            var a = _dbConnect.Query(sql);
            _dbConnect.Close();
            return a;
        }


        /// <summary>
        /// Lấy toàn bộ danh sách người dùng
        /// </summary>
        /// <returns>Danh sách người dùng</returns>
        public IEnumerable<object> GetAllUser()
        {
            _dbConnect = new SqlConnection(_stringConnect);
            String sql = "SELECT * FROM tbluser";
            _dbConnect.Open();
            var a = _dbConnect.Query(sql);
            _dbConnect.Close();
            return a;
        }


        /// <summary>
        /// Thêm mới người dùng
        /// </summary>
        /// <param name="nuser">Người dùng</param>
        /// <returns>Số lượng bản ghi thực thi</returns>
        public int InsertUser(User nuser)
        {
            _dbConnect = new SqlConnection(_stringConnect);
            SqlCommand cmd = new SqlCommand("Insert_User", _dbConnect);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@user_fullname",nuser.user_fullname);
            cmd.Parameters.AddWithValue("@user_gender", nuser.user_gender);
            cmd.Parameters.AddWithValue("@user_phone", nuser.user_phone);
            cmd.Parameters.AddWithValue("@user_email", nuser.user_email);
            cmd.Parameters.AddWithValue("@user_address", nuser.user_address);
            cmd.Parameters.AddWithValue("@u_name", nuser.u_name);
            cmd.Parameters.AddWithValue("@user_pass", nuser.user_pass);
            cmd.Parameters.AddWithValue("@user_type", nuser.user_type);
            cmd.Parameters.AddWithValue("@user_status", nuser.user_status);
            cmd.Parameters.AddWithValue("@user_img", nuser.user_img);

            _dbConnect.Open();
            int result = cmd.ExecuteNonQuery();
            _dbConnect.Close();
            return result;
        }

        /// <summary>
        /// Sửa dữ liệu người dùng
        /// </summary>
        /// <param name="u"></param>
        /// <returns>Kiểu dữ liệu nguyên thủy</returns>
        /// Create By: NamBC (17/03/21)
        public int UpdateUser(User u)
        {
            _dbConnect = new SqlConnection(_stringConnect);
            SqlCommand cmd = new SqlCommand("Update_User", _dbConnect);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@user_fullname", u.user_fullname);
            cmd.Parameters.AddWithValue("@user_gender", u.user_gender);
            cmd.Parameters.AddWithValue("@user_phone", u.user_phone);
            cmd.Parameters.AddWithValue("@user_email", u.user_email);
            cmd.Parameters.AddWithValue("@user_address", u.user_address);
            cmd.Parameters.AddWithValue("@u_name", u.u_name);
            cmd.Parameters.AddWithValue("@user_pass", u.user_pass);
            cmd.Parameters.AddWithValue("@user_type", u.user_type);
            cmd.Parameters.AddWithValue("@user_img", u.user_img);
            cmd.Parameters.AddWithValue("@u_id",u.u_id);
            _dbConnect.Open();
            int result = cmd.ExecuteNonQuery();
            _dbConnect.Close();
            return result;
        }

        /// <summary>
        /// Lấy người dùng theo ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IEnumerable<Object> GetUserById(int id)
        {
            _dbConnect = new SqlConnection(_stringConnect);
            String sql = "SELECT * FROM tbluser WHERE u_id ="+id;
            _dbConnect.Open();
            var a = _dbConnect.Query(sql);
            _dbConnect.Close();
            return a;
        }

        /// <summary>
        /// Kiểm tra thông tin đăng nhập
        /// </summary>
        /// <param name="name">Tài khoản</param>
        /// <param name="pass">Mật khẩu</param>
        /// <returns>Đúng hoặc sai</returns>
        public IEnumerable<object> CheckLoginUser(String name, String pass)
        {
            _dbConnect = new SqlConnection(_stringConnect);
            String sql = "SELECT * FROM tbluser WHERE u_name = '" + name + "' AND user_pass = '" + pass + "' AND user_type = 2";
            _dbConnect.Open();
            var user = _dbConnect.Query(sql);
            _dbConnect.Close();
            return user;
        }
        #endregion

    }
}
