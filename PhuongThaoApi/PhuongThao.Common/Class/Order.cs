using System;
using System.Collections.Generic;
using System.Text;

namespace PhuongThao.Common.Class
{
    public class Order
    {
        /// <summary>
        /// Khóa chính
        /// </summary>
        public int order_id { get; set; }

        /// <summary>
        /// Ngày tháng thanh toán
        /// </summary>
        public DateTime order_date { get; set; }

        /// <summary>
        /// Ghi chú
        /// </summary>
        public String order_note { get; set; }

        /// <summary>
        /// Khóa phụ người dùng
        /// </summary>
        public int u_id { get; set; }

        /// <summary>
        /// Trạng thái thanh toán
        /// </summary>
        public int order_status { get; set; }
    }
}
