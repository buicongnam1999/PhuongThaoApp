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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IEnumerable<Object> GetUserById(int id)
        {
            return _dbConnection.GetUserById(id);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Object> GetAllData()
        {
            _dbConnection = new UserConnect();
            return _dbConnection.GetAllUser();
        }

        /// <summary>
        /// Kiểm tra tài khoản và mật khẩu
        /// </summary>
        /// <param name="name">Tài khoản được truyền vào</param>
        /// <param name="pass">Mật khẩu được truyền vào</param>
        /// <returns>Người dùng</returns>
        /// Create By: NamBC (21/03/21)
        public IEnumerable<object> CheckLoginUser(String name, String pass)
        {
            _dbConnection = new UserConnect();
            return _dbConnection.CheckLoginUser(name, pass);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public int InsertObject(User entity)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public int UpdateObject(User entity)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public int DeleteObject(int entity)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Xuất dữ liệu ra excel
        /// </summary>
        /// <returns>Dữ liệu</returns>
        public DataTable ExportExcelEmployees()
        {
            _dbConnection = new UserConnect();
            return _dbConnection.ExportExcelEmployees();
        }


        public IEnumerable<User> ExportExcem()
        {
            _dbConnection = new UserConnect();
            return _dbConnection.ExportExcel();
        }
    }
}