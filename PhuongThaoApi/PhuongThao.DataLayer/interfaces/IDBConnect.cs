using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace PhuongThao.DataLayer.interfaces
{
    public interface IDBConnect<T>
    {
        /// <summary>
        /// Hàm lấy toàn bộ dữ liệu
        /// </summary>
        /// <returns>Danh sách đối tượng muốn lấy</returns>
        /// Create By: NamBC (07/03/21)
        public IEnumerable<T> getAllData();

        /// <summary>
        /// Hàm thêm mới đối tượng
        /// </summary>
        /// <param name="entity">Đói tượng truyền vào</param>
        /// /// <param name="cmd">Kiểu thực thi truy vấn</param>
        /// <returns>Kiểu số tự nhiên</returns>
        /// Create By: NamBC(07/03/21)
        public int InsertObject(T entity, CommandType cmd = CommandType.Text,string query = null);

        /// <summary>
        /// Hàm sửa đổi dữ liệu
        /// </summary>
        /// <param name="entity">Đối tượng truyền vào</param>
        /// <param name="cmd">Kiểu thực thi truy vấn</param>
        /// <returns>Kiểu số tự nhiên</returns>
        /// Create By: NamBC (07/03/21)
        public Task<int> UpdateObject(T entity, CommandType cmd = CommandType.Text);

        /// <summary>
        /// Hàm xóa dữ liệu đối tượng
        /// </summary>
        /// <param name="id">ID truyền vào</param>
        /// <param name="cmd">Kiểu thực thi</param>
        /// <returns>Kiểu số tự nhiên</returns>
        /// Create By: NamBC (07/03/21)
        public Task<int> DeleteObjcet(int id, CommandType cmd = CommandType.Text);

        /// <summary>
        /// Hàm tìm kiếm  đối tượng cần  tìm theo ID
        /// </summary>
        /// <param name="id">ID được truyền vào</param>
        /// <param name="cmd">Kiểu thực thi truy vấn</param>
        /// <returns>Đối tượng cần tìm</returns>
        /// Create By: NamBC (07/03/21)
        public Task<T> GetObject(int id, CommandType cmd = CommandType.Text);

        

    }
}
