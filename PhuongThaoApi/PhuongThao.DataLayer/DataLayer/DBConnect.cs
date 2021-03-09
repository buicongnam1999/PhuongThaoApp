﻿using Dapper;
using MySqlConnector;
using PhuongThao.DataLayer.interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace PhuongThao.DataLayer.DataLayer
{
    public class DBConnect<T> : IDBConnect<T>
    {

        public String _stringConnect = @"Data Source=DESKTOP-1BICBR5\SQLEXPRESS;Initial Catalog=PhuongThaoShop;Integrated Security=True";
        IDbConnection _dbConnect;
        public DBConnect()
        {
            _dbConnect = new SqlConnection(_stringConnect);
        }

        /// <summary>
        /// Hàm lấy toàn bộ danh sách dữ liệu
        /// </summary>
        /// <returns>Danh sách đối tượng cần lấy</returns>
        /// Create By: NamBC (07/03/21)
        public IEnumerable<T> getAllData()
        {
            _dbConnect.Open();
            String className = "tbl" + typeof(T).Name.ToLower();
            String sql = "SELECT * FROM " + className;
            /*_dbConnect.Close();*/
            var list =  _dbConnect.Query<T>(sql, commandType: CommandType.Text);
            _dbConnect.Close();
            return list;
        }

        /// <summary>
        /// Hàm thêm mới đối tượng
        /// </summary>
        /// <param name="entity">Đối tượng truyền vào</param>
        /// <param name="cmd">Kiểu thực thi</param>
        /// <returns>Kiểu số nguyên</returns>
        /// Create By: NamBC (07/03/21)
        public Task<int> InsertObject(T entity, CommandType cmd = CommandType.Text)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Hàm sửa thông tin đối tượng
        /// </summary>
        /// <param name="entity">Đối tượng truyền vào</param>
        /// <param name="cmd">Kiểu thực thi</param>
        /// <returns>Kiểu số nguyên</returns>
        /// Create By: NamBC (07/03/21)
        public Task<int> UpdateObject(T entity, CommandType cmd = CommandType.Text)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Hàm xóa thông tin đối tượng
        /// </summary>
        /// <param name="id">ID truyền vào</param>
        /// <param name="cmd">Kiểu thực thi</param>
        /// <returns>Kiểu số nguyên</returns>
        /// Create By: NamBC (07/02/21)
        public Task<int> DeleteObjcet(int id, CommandType cmd = CommandType.Text)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Hàm tìm kiếm đối tượng theo ID
        /// </summary>
        /// <param name="id">ID được truyền vào</param>
        /// <param name="cmd">Kiểu thực thi truy vấn</param>
        /// <returns>Đối tượng cần tìm</returns>
        /// Create By: NamBC (07/03/21)
        public Task<T> GetObject(int id, CommandType cmd = CommandType.Text)
        {
            throw new NotImplementedException();
        }
    }
}
