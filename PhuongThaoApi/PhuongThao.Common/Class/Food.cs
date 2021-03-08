using System;
using System.Collections.Generic;
using System.Text;

namespace PhuongThao.Common.Class
{
    public class Food
    {
        /// <summary>
        /// Khóa chính
        /// </summary>
        public int food_id { get; set; }

        /// <summary>
        /// Khóa phụ tên nhãn hàng
        /// </summary>
        public int sup_id { get; set; }

        /// <summary>
        /// Mã sản phẩm
        /// </summary>
        public String food_code { get; set; }

        /// <summary>
        /// Tên sản phẩm
        /// </summary>
        public String food_name { get; set; }

        /// <summary>
        /// Hình ảnh sản phẩm
        /// </summary>
        public String food_img { get; set; }

        /// <summary>
        /// Tiền sản phẩm
        /// </summary>
        public float food_money { get; set; }

        /// <summary>
        /// Số lượng trong kho
        /// </summary>
        public int food_quality { get; set; }

        /// <summary>
        /// Mã giảm giá
        /// </summary>
        public int cou_id { get; set; }

        /// <summary>
        /// Trạng thái
        /// </summary>
        public int food_status { get; set; }

        /// <summary>
        /// Kiểu đồ ăn
        /// </summary>
        public int food_type { get; set; }

        /// <summary>
        /// Số lượng đặt
        /// </summary>
        public int food_count_order { get; set; }

        /// <summary>
        /// Miêu tả
        /// </summary>
        public String food_description { get; set; }
    }
}
