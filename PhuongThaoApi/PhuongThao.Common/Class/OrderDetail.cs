using System;
using System.Collections.Generic;
using System.Text;

namespace PhuongThao.Common.Class
{
    public class OrderDetail
    {
        /// <summary>
        /// Khóa chính
        /// </summary>
        public int order_id { get; set; }

        /// <summary>
        /// Khóa phụ Mã sản phẩm
        /// </summary>
        public int food_id { get; set; }

        /// <summary>
        /// Số lượng
        /// </summary>
        public int quality { get; set; }

        /// <summary>
        /// Trạng thái
        /// </summary>
        public int order_status { get; set; }
    }
}
