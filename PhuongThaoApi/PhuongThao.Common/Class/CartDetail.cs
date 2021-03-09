using System;
using System.Collections.Generic;
using System.Text;

namespace PhuongThao.Common.Class
{
    public class CartDetail
    {
        /// <summary>
        /// Khóa chính
        /// </summary>
        public int cart_id { get; set; }

        /// <summary>
        /// Khóa phụ
        /// </summary>
        public int food_id { get; set; }

        /// <summary>
        /// Số lượng
        /// </summary>
        public int quality { get; set; }

        /// <summary>
        /// Trạng thái
        /// </summary>
        public int cart_status { get; set; }
    }
}

