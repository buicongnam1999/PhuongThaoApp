using PhuongThao.Common.Class;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace PhuongThao.Service.interfaces
{
    public interface IUserService
    {
        /// <summary>
        /// Hàm lấy toàn bộ danh sách người dùng
        /// </summary>
        /// <returns>Danh sách người dùng</returns>
        /// Create By: NamBC (08/03/21)
        public IEnumerable GetAllUser();

        /// <summary>
        /// Hàm thêm mới người dùng
        /// </summary>
        /// <param name="entity">Người dùng được truyền vào</param>
        /// <param name="cmd">Kiểu thực thi</param>
        /// <returns>Số tự nhiên</returns>
        /// Create By: NamBC (08/03/21)
        public int InsertUser(User entity);

        /// <summary>
        /// Hàm sửa thông tin người dùng
        /// </summary>
        /// <param name="entity">Người dùng được truyền vào</param>
        /// <param name="cmd">Kiểu thực thi</param>
        /// <returns>Số tự nhiên</returns>
        /// Create By: NamBC (08/03/21)
        public int UpdateUser(User entity, CommandType cmd = CommandType.Text);

        /// <summary>
        /// Hàm xóa thông tin người dùng
        /// </summary>
        /// <param name="id">ID được truyền vào</param>
        /// <param name="cmd">Kiểu thực thi</param>
        /// <returns>Số tự nhiên</returns>
        /// Create By: NamBC (08/03/21)
        public int DeleteUser(int id, CommandType cmd = CommandType.Text);

        /// <summary>
        /// Hàm tìm kiếm theo tên
        /// </summary>
        /// <param name="name">Tên được truyền vào</param>
        /// <param name="cmd">Kiểu thực thi</param>
        /// <returns>Số tự nhiên</returns>
        /// Create By: NamBc (08/03/21)
        public Task<IEnumerable<User>> GetUserByName(String name, CommandType cmd = CommandType.Text);

        /// <summary>
        /// Hàm tìm kiếm theo số điện thoại
        /// </summary>
        /// <param name="phone">Số điện thoại được truyền vào</param>
        /// <param name="cmd">Kiểu thực thi truy vấn</param>
        /// <returns>Đúng hoặc sai</returns>
        /// Create By: NamBC (08/03/21)
        public Task<Boolean> GetUserByPhone(String phone, CommandType cmd = CommandType.Text);

        /// <summary>
        /// Hàm tìm kiếm theo email
        /// </summary>
        /// <param name="email">Email được truyền vào</param>
        /// <param name="cmd">JKiểu thực thi truy vấn</param>
        /// <returns>Đúng hoặc sai</returns>
        /// Create By: NamBC (08/03/21)
        public Task<Boolean> GetUserByEmail(String email, CommandType cmd = CommandType.Text);

        /// <summary>
        /// Kiểm tra tài khoản đã tồn tại hay chưa
        /// </summary>
        /// <param name="name">Tài khoản</param>
        /// <returns>Kiểu Boolean</returns>
        /// Create By: NamBC(17/03/21)
        public Boolean CheckUserName(string name);

        /// <summary>
        /// Kiểm tra địa chỉ email đã tồn tại chưa
        /// </summary>
        /// <param name="email">Email</param>
        /// <returns>Kiểu Boolean</returns>
        /// Create By: NamBc(17/03/21)
        public bool CheckUserEmail(string email);

        /// <summary>
        /// Lấy toàn bộ danh sách nhân viên
        /// </summary>
        /// <returns>Danh sách nhân viên</returns>
        /// Create By: NamBC(17/03/21)
        public IEnumerable<object> getAllEmployee();


        /// <summary>
        /// Lấy toàn bộ danh sách khách hàng
        /// </summary>
        /// <returns>Danh sách khách hàng</returns>
        /// Create By: NamBC(17/03/21)
        public IEnumerable<object> getAllCustomer();


        public IEnumerable<object> CheckLoginUser(String name, String pass);
    }
}
