using System;
using System.Collections.Generic;
using System.Text;

namespace PhuongThao.Common.Class
{
    public class Supplier
    {
        /// <summary>
        /// Khóa chính
        /// </summary>
        public int sup_id { get; set; }

        /// <summary>
        /// Tên nhà cung cấp
        /// </summary>
        public String sup_name { get; set; }

        /// <summary>
        /// Địa chỉ email
        /// </summary>
        public String sup_email { get; set; }

        /// <summary>
        /// Số điện thoại
        /// </summary>
        public String sup_phone { get; set; }

        /// <summary>
        /// Địa chỉ
        /// </summary>
        public String sup_address { get; set; }
    }
}
