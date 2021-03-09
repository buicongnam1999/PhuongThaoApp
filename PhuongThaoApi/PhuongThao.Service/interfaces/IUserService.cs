using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace PhuongThao.Service.interfaces
{
    public interface IUserService<T>
    {
        /// <summary>
        /// Hàm lấy toàn bộ danh sách người dùng
        /// </summary>
        /// <returns>Danh sách người dùng</returns>
        /// Create By: NamBC (08/03/21)
        public IEnumerable<T> GetAllUser();

        /// <summary>
        /// Hàm thêm mới người dùng
        /// </summary>
        /// <param name="entity">Người dùng được truyền vào</param>
        /// <param name="cmd">Kiểu thực thi</param>
        /// <returns>Số tự nhiên</returns>
        /// Create By: NamBC (08/03/21)
        public Task<int> InsertUser(T entity, CommandType cmd = CommandType.Text);

        /// <summary>
        /// Hàm sửa thông tin người dùng
        /// </summary>
        /// <param name="entity">Người dùng được truyền vào</param>
        /// <param name="cmd">Kiểu thực thi</param>
        /// <returns>Số tự nhiên</returns>
        /// Create By: NamBC (08/03/21)
        public Task<int> UpdateUser(T entity, CommandType cmd = CommandType.Text);

        /// <summary>
        /// Hàm xóa thông tin người dùng
        /// </summary>
        /// <param name="id">ID được truyền vào</param>
        /// <param name="cmd">Kiểu thực thi</param>
        /// <returns>Số tự nhiên</returns>
        /// Create By: NamBC (08/03/21)
        public Task<int> DeleteUser(int id, CommandType cmd = CommandType.Text);

        /// <summary>
        /// Hàm tìm kiếm theo tên
        /// </summary>
        /// <param name="name">Tên được truyền vào</param>
        /// <param name="cmd">Kiểu thực thi</param>
        /// <returns>Số tự nhiên</returns>
        /// Create By: NamBc (08/03/21)
        public Task<IEnumerable<T>> GetUserByName(String name, CommandType cmd = CommandType.Text);

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
    }
}
