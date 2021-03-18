using System;
using System.Collections.Generic;
using System.Text;

namespace PhuongThao.Common.Class
{
    public class ResultSet
    {
        /// <summary>
        /// Lỗi thông báo ra
        /// </summary>
        public List<ErrMsg> error { get; set; }

        /// <summary>
        /// Kiểm tra dữ liệu
        /// </summary>
        public Boolean Sucess { set; get; }

        /// <summary>
        /// Dữ liệu trả về
        /// </summary>
        public object data { set; get; }
    }
}
