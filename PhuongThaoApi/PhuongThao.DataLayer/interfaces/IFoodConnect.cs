using PhuongThao.Common.Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhuongThao.DataLayer.interfaces
{
    public interface IFoodConnect
    {

        /// <summary>
        /// Lấy toàn bộ danh sách sản phẩm
        /// </summary>
        /// <returns></returns>
        public IEnumerable<object> GetAllProduct();

        /// <summary>
        /// Thêm mới sản phẩm
        /// </summary>
        /// <param name="nf">Sản phẩm mới được truyền vào</param>
        /// <returns>Kiểu số nguyên thủy</returns>
        /// Create By: NamBC (17/03/21)
        public int InsertFood(Food nf);

        /// <summary>
        /// Sửa thông tin sản phẩm
        /// </summary>
        /// <param name="f">Sản phẩm</param>
        /// <returns></returns>
        public int UpdateFood(Food f);

        /// <summary>
        /// Xóa dữ liệu sản phẩm
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns>Kiểu số nguyên</returns>
        /// Create By: NamBC (17/03/21)
        public int DeleteFood(int id);

        /// <summary>
        /// Kiểm tra mã sản phẩm đã tồn tại chưa
        /// </summary>
        /// <param name="code"></param>
        /// <returns>Trả về Boolean</returns>
        /// Create By: NamBC (17/03/21)
        public Boolean CheckFoodCode(String code);

    }
}
