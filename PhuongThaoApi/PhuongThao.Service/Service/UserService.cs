using PhuongThao.DataLayer.DataLayer;
using PhuongThao.Service.interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace PhuongThao.Service.Service
{
    public class UserService<User> : IUserService<User>
    {
        DBConnect<User> _dbConnection;

        public UserService()
        {
            _dbConnection = new DBConnect<User>();
        }

        /// <summary>
        /// Hàm lấy toàn bộ dữ liệu người dùng
        /// </summary>
        /// <returns>Danh sách người dùng</returns>
        /// Create By: NamBC (08/03/21)
        public IEnumerable<User> GetAllUser()
        {
            _dbConnection = new DBConnect<User>();
            return _dbConnection.getAllData();

        }

        /// <summary>
        /// Hàm lấy dự liệu theo tên
        /// </summary>
        /// <param name="name">Tên được truyền vào</param>
        /// <param name="cmd">Kiểu thực thi truy vấn</param>
        /// <returns>Danh sách tên tìm kiếm</returns>
        public Task<IEnumerable<User>> GetUserByName(string name, CommandType cmd = CommandType.Text)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Hàm thêm mới người dùng
        /// </summary>
        /// <param name="entity">Người dùng được truyền vào</param>
        /// <param name="cmd">Kiểu thực thi truy vấn</param>
        /// <returns>Kiểu đúng hoặc sai</returns>
        /// Create By: NamBC (08/03/21)
        public Task<int> InsertUser(User entity, CommandType cmd = CommandType.Text)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Hàm sửa thông tin người dùng
        /// </summary>
        /// <param name="entity">Người dùng được truyền vào</param>
        /// <param name="cmd">Kiểu thực thi</param>
        /// <returns>Kiểu số nguyên</returns>
        /// Create By: NamBC (08/03/21)
        public Task<int> UpdateUser(User entity, CommandType cmd = CommandType.Text)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Hàm xóa thông tin người dùng
        /// </summary>
        /// <param name="id">ID được truyền vào</param>
        /// <param name="cmd">Kiểu thực thi</param>
        /// <returns>Kiểu số nguyên</returns>
        /// Create By: NamBC (08/03/21)
        public Task<int> DeleteUser(int id, CommandType cmd = CommandType.Text)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Hàm lấy người dùng theo số điện thoại
        /// </summary>
        /// <param name="phone">Số điện thoại được truyền vào</param>
        /// <param name="cmd">Kiểu thực thi</param>
        /// <returns>Đúng hoặc sai</returns>
        public Task<bool> GetUserByPhone(string phone, CommandType cmd = CommandType.Text)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Hàm lấy người dùng theo email
        /// </summary>
        /// <param name="email">Email được truyền vào</param>
        /// <param name="cmd">Kiểu thực thi</param>
        /// <returns>Đúng hoặc sai</returns>
        /// Create By: NamBC (08/03/21)
        public Task<bool> GetUserByEmail(string email, CommandType cmd = CommandType.Text)
        {
            throw new NotImplementedException();
        }
    }
}
