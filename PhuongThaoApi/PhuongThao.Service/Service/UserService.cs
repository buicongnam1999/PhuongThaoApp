using PhuongThao.Common.Class;
using PhuongThao.DataLayer.DataLayer;
using PhuongThao.Service.interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace PhuongThao.Service.Service
{
    public class UserService : IBaseService<User>
    {
        UserConnect _dbConnection;

        public UserService()
        {
            _dbConnection = new UserConnect();
        }

        /// <summary>
        /// Hàm lấy toàn bộ dữ liệu người dùng
        /// </summary>
        /// <returns>Danh sách người dùng</returns>
        /// Create By: NamBC (08/03/21)
        public IEnumerable GetAllUser()
        {
            _dbConnection = new UserConnect();
            return _dbConnection.GetAllUser();

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
        public int InsertUser(User entity)
        {
            _dbConnection = new UserConnect();
            return  _dbConnection.InsertUser(entity);
        }

        /// <summary>
        /// Hàm sửa thông tin người dùng
        /// </summary>
        /// <param name="entity">Người dùng được truyền vào</param>
        /// <param name="cmd">Kiểu thực thi</param>
        /// <returns>Kiểu số nguyên</returns>
        /// Create By: NamBC (08/03/21)
        public int UpdateUser(User entity, CommandType cmd = CommandType.Text)
        {
            _dbConnection = new UserConnect();
            return _dbConnection.UpdateUser(entity);
        }

        /// <summary>
        /// Hàm xóa thông tin người dùng
        /// </summary>
        /// <param name="id">ID được truyền vào</param>
        /// <param name="cmd">Kiểu thực thi</param>
        /// <returns>Kiểu số nguyên</returns>
        /// Create By: NamBC (08/03/21)
        public int DeleteUser(int id, CommandType cmd = CommandType.Text)
        {
            _dbConnection = new UserConnect();
            return _dbConnection.Delete(id);
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

        /// <summary>
        /// Kiểm tra tồn tại tài khoản chưa
        /// </summary>
        /// <param name="name">Tài khoản</param>
        /// <returns>Kiểu Boolean</returns>
        /// Create By: NamBC (17/03/21)
        public bool CheckUserName(string name)
        {
            return _dbConnection.CheckUserName(name);
        }

        /// <summary>
        /// Kiểm tra email đã tồn tại chưa
        /// </summary>
        /// <param name="email">Email</param>
        /// <returns>Kiểu Boolean</returns>
        /// Create By: NamBC (17/03/21)
        public bool CheckUserEmail(string email)
        {
            return _dbConnection.CheckUserEmail(email);
        }


        /// <summary>
        /// Lấy toàn bộ danh sách nhân viên
        /// </summary>
        /// <returns>Danh sách nhân viên</returns>
        /// Create By: NamBC (17/03/21)
        public IEnumerable<object> getAllEmployee()
        {
            return _dbConnection.getAllEmployee();
        }

        /// <summary>
        /// Lấy toàn bộ danh sách khách hàng
        /// </summary>
        /// <returns>Danh sách khách hàng</returns>
        /// Create By: NamBC (17/03/21)
        public IEnumerable<object> getAllCustomer()
        {
            return _dbConnection.getAllCustomer();
        }

        public IEnumerable<Object> GetAllData()
        {
            _dbConnection = new UserConnect();
            return _dbConnection.GetAllUser();
        }

        public int InsertObject(User entity)
        {
            throw new NotImplementedException();
        }

        public int UpdateObject(User entity)
        {
            throw new NotImplementedException();
        }

        public int DeleteObject(int entity)
        {
            throw new NotImplementedException();
        }
    }
}