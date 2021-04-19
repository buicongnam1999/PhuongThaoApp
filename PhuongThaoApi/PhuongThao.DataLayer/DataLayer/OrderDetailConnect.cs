using Dapper;
using PhuongThao.Common.Class;
using PhuongThao.DataLayer.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhuongThao.DataLayer.DataLayer
{
    public class OrderDetailConnect : DBConnect<OrderDetail>, IOrderDetailConnect
    {
        public int Delete(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Lấy toàn bộ danh sách thanh toán
        /// </summary>
        /// <returns>Danh sách thanh toán</returns>
        public IEnumerable<object> GetAllOrder()
        {
            throw new NotImplementedException();
        }


        public IEnumerable<object> GetOrderByUser(int id)
        {
            throw new NotImplementedException();
        }

        public int GetOrderByUserId(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Thêm mới thanh toán
        /// </summary>
        /// <param name="order_id">Mã thanh toán</param>
        /// <param name="food_id">Mã sản phẩm</param>
        /// <param name="quality">Số lượng</param>
        /// <returns>Số lượng bản ghi thực thi</returns>
        public int InsertOrder(int order_id , int food_id, int quality)
        {
            String sql = "INSERT INTO tblorderdetail(order_id,food_id,quality) VALUES(" + order_id + "," + food_id + ","+quality+")";
            _dbConnect.Open();
            var res = _dbConnect.Execute(sql);
            _dbConnect.Close();
            return res;
        }

        public int UpdateOrder(Order u)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Xóa toàn bộ sản phẩm trong thanh toán
        /// </summary>
        /// <param name="order_id">ID thanh toán</param>
        /// <returns></returns>
        public int DeleteOrderDetail(int order_id)
        {
            String sql = "DELETE FROM tblorder WHERE order_id = " + order_id;
            _dbConnect.Open();
            var res = _dbConnect.Execute(sql);
            _dbConnect.Close();
            return res;
        }


    }
}
