using System;
using System.Collections.Generic;
using System.Text;

namespace PhuongThao.Common.Class
{
    public class Cart
    {
        /// <summary>
        /// Khóa chính
        /// </summary>
        public int cart_id { get; set; }

        /// <summary>
        /// Khóa phụ
        /// </summary>
        public int u_id { get; set; }

        /// <summary>
        /// Ngày tạo
        /// </summary>
        public DateTime? cart_date { get; set; }

        /// <summary>
        /// Ghi chú
        /// </summary>
        public String? cart_note { get; set; }
    }
}
