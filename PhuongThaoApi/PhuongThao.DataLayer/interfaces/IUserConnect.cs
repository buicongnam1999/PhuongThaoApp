using PhuongThao.Common.Class;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace PhuongThao.DataLayer.interfaces
{
    public interface IUserConnect
    {
        #region DECLARE
        
        #endregion
        #region Method

        /// <summary>
        /// Lấy toàn bộ danh sách người dùng
        /// </summary>
        /// <returns>Danh sách người dùng</returns>
        /// Create By: NamBC (17/03/21)
        public IEnumerable<object> GetAllUser();

        /// <summary>
        /// Thêm mới người dùng
        /// </summary>
        /// <param name="nuser">Người dùng mới</param>
        /// <returns>Kiểu số nguyên thủy</returns>
        /// Create By: NamBC (08/03/21)
        public int InsertUser(User nuser);

        /// <summary>
        /// Sửa thông tin người dùng
        /// </summary>
        /// <param name="u">Người dùng</param>
        /// <returns>Kiểu số tự nhiên</returns>
        /// Create By: NamBC (08/03/21)
        public int UpdateUser(User u);

        /// <summary>
        /// Xóa người dùng
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns>Kiểu số tự nhiên</returns>
        public int Delete(int id);

        public Boolean CheckUserName(String name);

        public Boolean CheckUserEmail(String email);

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

        #endregion
    }
}
