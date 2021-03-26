using PhuongThao.Common.Class;
using PhuongThao.DataLayer.DataLayer;
using PhuongThao.Service.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhuongThao.Service.Service
{
    public class FoodService : IBaseService<Food>
    {
        #region DECLARE
        FoodConnect _foodConnect;
        #endregion

        #region Constructor
        public FoodService()
        {
            this._foodConnect = new FoodConnect();
        }
        #endregion

        #region Method


        #endregion
        /// <summary>
        /// Xóa sản phẩm theo ID
        /// </summary>
        /// <param name="id">ID truyền vào</param>
        /// <returns>Số lượng bản ghi thực thi</returns>
        public int DeleteObject(int id)
        {
            _foodConnect = new FoodConnect();
            return this._foodConnect.DeleteFood(id);
        }

        /// <summary>
        /// Lấy toàn bộ danh sách sản phẩm
        /// </summary>
        /// <returns>Danh sách sản phẩm</returns>
        public IEnumerable<object> GetAllData()
        {
            _foodConnect = new FoodConnect();
            return this._foodConnect.GetAllProduct();
        }

        /// <summary>
        /// Thêm mới sản phẩm
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Số lượng bản ghi đã thực thi</returns>
        public int InsertObject(Food entity)
        {
            _foodConnect = new FoodConnect();
            return this._foodConnect.InsertFood(entity);
        }

        /// <summary>
        /// Chỉnh sửa thông tin sản phẩm
        /// </summary>
        /// <param name="entity">Sản phẩm cần sửa</param>
        /// <returns>Số lượng bản ghi thực thi</returns>
        public int UpdateObject(Food entity)
        {
            _foodConnect = new FoodConnect();
            return this._foodConnect.UpdateFood(entity);
        }

        /// <summary>
        /// Kiểm tra mã sản phẩm
        /// </summary>
        /// <param name="code">Mã sản phẩm</param>
        /// <returns>Đúng sai</returns>
        public Boolean CheckFoodCode(String code)
        {
            return this._foodConnect.CheckFoodCode(code);
        }
    }
}
